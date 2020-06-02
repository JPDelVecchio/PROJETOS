using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  int codColigada = 1;
  int idRelatorio = 554;
  string userName = "mestre";
  string password = "totvs";

  protected void Page_Load(object sender, EventArgs e)
  {

  }

  protected override void OnPreRender(EventArgs e)
  {
    base.OnPreRender(e);

    byte[] rpt = GenerateSync();

    Response.Clear();
    Response.ContentType = "application/pdf";
    //Response.AddHeader("content-length", size.ToString());
    Response.BinaryWrite(rpt);
    Response.Flush();
  }

  private byte[] GenerateSync()
  {
    ServiceReference1.IwsReportClient client = new ServiceReference1.IwsReportClient();
    client.ClientCredentials.UserName.UserName = userName;
    client.ClientCredentials.UserName.Password = password;

    using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
    {
      OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
        CreateBasicAuthorizationMessageProperty(userName, password);

      string teste = client.GetReportMetaData(codColigada, idRelatorio);

      // recupera xml de filtros e parâmetros
      string[] FiltersAndParams = client.GetReportInfo(codColigada, idRelatorio);

      string guid = client.GenerateReport(codColigada, idRelatorio, FiltersAndParams[0], FiltersAndParams[1], "Relteste.pdf");
      //string guid = client.GenerateReport(codColigada, idRelatorio, FiltersAndParams[0].Replace("00001", "00005"), FiltersAndParams[1], "Relteste.pdf");

      long size = client.GetGeneratedReportSize(guid);
      int offset = 0;
      string rptstr = "";
      int pack = 65000;
      while (offset < size)
      {
        int temp = pack;
        if ((offset + temp) > size)
          temp = (int)size - offset;

        rptstr += client.GetFileChunk(guid, offset, temp);

        offset = offset + pack;
      }

      byte[] rpt = Convert.FromBase64String(rptstr);
      return rpt;
    }
  }

  private byte[] GenerateAsync()
  {
    ServiceReference1.IwsReportClient client = new ServiceReference1.IwsReportClient();
    client.ClientCredentials.UserName.UserName = userName;
    client.ClientCredentials.UserName.Password = password;

    using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
    {
      OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
        CreateBasicAuthorizationMessageProperty(userName, password);

      // recupera xml de filtros e parâmetros
      string[] FiltersAndParams = client.GetReportInfo(codColigada, idRelatorio);

      string guid = client.GenerateReportAsynchronous(codColigada, idRelatorio, FiltersAndParams[0], FiltersAndParams[1], "Relteste.pdf");

      string[] status = client.GetGeneratedReportStatus(guid).Split(';');

      while (status[0] == "0")
      {
        status = client.GetGeneratedReportStatus(guid).Split(';');
      }

      if (status[0] == "1")
      {
        guid = status[1];

        long size = client.GetGeneratedReportSize(guid);
        int offset = 0;
        string rptstr = "";
        int pack = 65000;
        while (offset < size)
        {
          int temp = pack;
          if ((offset + temp) > size)
            temp = (int)size - offset;

          rptstr += client.GetFileChunk(guid, offset, temp);

          offset = offset + pack;
        }

        byte[] rpt = Convert.FromBase64String(rptstr);
        return rpt;
      }
      else
        throw new Exception(status[1]);
    }
  }

  public static HttpRequestMessageProperty CreateBasicAuthorizationMessageProperty(string username, string password)
  {
    Encoding encoding = Encoding.GetEncoding("iso-8859-1");
    string credential = String.Format("{0}:{1}", username, password);

    var httpRequestProperty = new HttpRequestMessageProperty();
    httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] =
      "Basic " + Convert.ToBase64String(encoding.GetBytes(credential));

    return httpRequestProperty;
  }
}