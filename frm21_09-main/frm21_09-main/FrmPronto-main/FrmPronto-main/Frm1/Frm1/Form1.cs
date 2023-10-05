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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.ShowDialog();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedor fu = new FormFornecedor ();
            fu.ShowDialog();
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCliente fu = new FormCliente();
            fu.ShowDialog();
        }

        private void ContasÀPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagar fu = new FormPagar();
            fu.ShowDialog();
        }

        private void ContasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReceber fu = new FormReceber();
            fu.ShowDialog();
        }
    }
}
