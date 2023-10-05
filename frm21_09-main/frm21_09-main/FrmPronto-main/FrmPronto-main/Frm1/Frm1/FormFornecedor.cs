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
    public partial class FormFornecedor : Form
    {
        private void HabilitaEdicao()
        {
            nm_fornecedorTextBox.Enabled = true;
            CNPJ.Enabled = true;
            IE.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            estado.Enabled = true;
            CEP.Enabled = true;
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
            nm_fornecedorTextBox.Enabled = false;
            CNPJ.Enabled = false;
            IE.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            estado.Enabled = false;
            CEP.Enabled = false;
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
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfornecedorTableAdapter.Fill(this.database1DataSet.tbfornecedor);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MovePrevious();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.RemoveCurrent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Validate();
            tbfornecedorBindingSource.EndEdit();
            DesabilitaEdicao();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MoveNext();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MovePrevious();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tbfornecedorBindingSource.EndEdit();
            tbfornecedorTableAdapter.Update(database1DataSet.tbfornecedor);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tbfornecedorBindingSource.CancelEdit();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
            tbfornecedorBindingSource.AddNew();
        }

        private void BtnPequisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.RemoveCurrent();
            tbfornecedorTableAdapter.Update(database1DataSet.tbfornecedor);
        }
    }
}
