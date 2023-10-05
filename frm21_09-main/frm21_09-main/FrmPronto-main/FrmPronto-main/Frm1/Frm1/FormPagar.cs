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
    public partial class FormPagar : Form
    {
        public FormPagar()
        {
            InitializeComponent();
        }

  

        private void FormPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tb_contaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaspagarTableAdapter.Fill(this.database1DataSet.tb_contaspagar);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
