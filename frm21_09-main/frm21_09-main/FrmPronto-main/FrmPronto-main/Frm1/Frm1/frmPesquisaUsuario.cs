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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void TbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.database1DataSet.Tbusuario);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (lblNome.Text == "")
            {
                this.tbusuarioTableAdapter.Fill(this.database1DataSet.Tbusuario);
            }
            else
            {
                this.tbusuarioTableAdapter.FillByNome(this.database1DataSet.Tbusuario,"%"+lblNome.Text+"%");
            }
        }

        private void TbusuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbusuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbusuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
