using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemapizaria
{
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemapizariaDataSet);

        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemapizariaDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.sistemapizariaDataSet.CLIENTE);

        }

        private void cLIENTEBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cIDADETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void retornarnomeclienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTETableAdapter.retornarnomecliente(this.sistemapizariaDataSet.CLIENTE, nomeclienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void retornarcpfToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTETableAdapter.retornarcpf(this.sistemapizariaDataSet.CLIENTE, cpfToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
