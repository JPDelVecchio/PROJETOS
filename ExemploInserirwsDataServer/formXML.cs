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
    public partial class formXML : Form
    {
        public formXML()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void execute(string texto)
        {
            textXml.Text = texto;
            ShowDialog();
        }


    }
}
