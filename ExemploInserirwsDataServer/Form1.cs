using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WSInsereOcorrencia
{
	public partial class formAtendimento : Form
	{

		public formAtendimento()
		{
			InitializeComponent();
		}

  
		private void btnGetEstruct_Click(object sender, EventArgs e)
		{
            //busca estrutura de dados
            wsDataServer ws = new wsDataServer();
            ws.Url = textLink.Text;
            string xml = ws.GetSchemaAuth(textDataServer.Text, textContext.Text, textUsuario.Text, textSenha.Text);
            formXML form = new formXML();
            form.execute(xml);
		}

		private void readrecord_Click(object sender, EventArgs e)
		{
            //Ler registro do dataserver
            wsDataServer ws = new wsDataServer();
            ws.Url = textLink.Text;
            string xml = ws.ReadRecordAuth(textDataServer.Text, textPrimaryKey.Text, textContext.Text, textUsuario.Text, textSenha.Text);
            textXml.Text = xml;

            //transforma xml em dataset
            byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(xml);
            MemoryStream streamxml = new System.IO.MemoryStream(buf);
            DataSet _ds = new DataSet();
            _ds.ReadXml(streamxml);

            //abre tela com a edição dos dados
            formDado formdado1 = new formDado();
            dataSet1 = formdado1.Execute(_ds, textLink.Text, textUsuario.Text, textSenha.Text, textContext.Text, textDataServer.Text);
		}

        private void button2_Click(object sender, EventArgs e)
        {            
            //executa webservice para salvar registro
            wsDataServer ws = new wsDataServer();
            ws.Url = textLink.Text;

            string retorno = ws.SaveRecordAuth(textDataServer.Text, textXml.Text, textContext.Text, textUsuario.Text, textSenha.Text);
            MessageBox.Show(retorno);
        }



	}
}
