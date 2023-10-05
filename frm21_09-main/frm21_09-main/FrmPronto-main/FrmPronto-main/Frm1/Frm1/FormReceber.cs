using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm1
{
    public partial class FormReceber : Form
    {
        public FormReceber()
        {
            InitializeComponent();
        }

       
       

        private void FormReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tb_contasreceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasreceberTableAdapter.Fill(this.database1DataSet.tb_contasreceber);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
