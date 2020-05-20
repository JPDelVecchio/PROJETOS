using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WSInsereOcorrencia
{
    

    public partial class formDado : Form
    {
        private string _link;
        private string _usuario;
        private string _senha;
        private string _contexto;
        private string _dataservername;
        private DataSet _dsDataServer;
             

        public formDado()
        {
            InitializeComponent();
        }

        public DataSet Execute(DataSet ds, string link, string usuario, string senha, string contexto, string dataserver)
        {
            _dsDataServer = ds;            
            _link = link;
            _usuario = usuario;
            _senha = senha;
            _contexto = contexto;
            _dataservername = dataserver;

            for (int i = 0; i < _dsDataServer.Tables.Count - 1; i++)
            {
                tabControl.TabPages.Add(_dsDataServer.Tables[i].TableName);
                DataGridView dg = new DataGridView();
                dg.Dock = DockStyle.Fill;
                dg.DataSource = _dsDataServer;
                dg.DataMember = _dsDataServer.Tables[i].TableName;
                dg.Parent = tabControl.TabPages[i];
            }


            this.ShowDialog();

            return _dsDataServer;
        }
        private void butSalvar_Click(object sender, EventArgs e)
        {

            string xml = getXML();
            //executa webservice para salvar registro
            wsDataServer ws = new wsDataServer();
            ws.Url = _link;
            string retorno = ws.SaveRecordAuth(_dataservername, xml, _contexto, _usuario, _senha);
            
            
            MessageBox.Show(retorno);
            Close();
        }

        private string getXML()
        {
            //transforma dataset em XML
            MemoryStream ms = new MemoryStream();
            _dsDataServer.WriteXml(ms, XmlWriteMode.WriteSchema);
            ms.Position = 0;
            byte[] buffer = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(buffer);
        }

        private void butFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formXML form = new formXML();
            form.execute(getXML());
        }
    }
}
