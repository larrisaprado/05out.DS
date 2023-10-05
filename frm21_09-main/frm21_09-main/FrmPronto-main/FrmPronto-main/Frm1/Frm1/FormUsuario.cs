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
    public partial class FormUsuario : Form
    {
        private void HabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPequisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPequisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.database1DataSet.Tbusuario);

        }

        private void Cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MovePrevious();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Validate();
            tbusuarioBindingSource.EndEdit();
            tbusuarioTableAdapter.Update(database1DataSet.Tbusuario);
            DesabilitaEdicao();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnPequisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            int cod = fpu.getCodigo();
            if (cod > 0)
            {
                int reg = tbusuarioBindingSource.Find("cd_usuario", cod);
                tbusuarioBindingSource.Position = reg;
            }
        }

        private void Sg_nivelTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Nm_loginTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Cd_senhaTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Cd_senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Nm_usuarioTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Sg_nivelTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }
    }
}
