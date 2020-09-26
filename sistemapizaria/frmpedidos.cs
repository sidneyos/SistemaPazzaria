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
    public partial class frmpedidos : Form
    {
        public frmpedidos()
        {
            InitializeComponent();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemapizariaDataSet);

        }

        private void cLIENTEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemapizariaDataSet);

        }

        private void frmpedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemapizariaDataSet.SABOR'. Você pode movê-la ou removê-la conforme necessário.
            this.sABORTableAdapter.Fill(this.sistemapizariaDataSet.SABOR);
            // TODO: esta linha de código carrega dados na tabela 'sistemapizariaDataSet.TAMANHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tamanhoTableAdapter.Fill(this.sistemapizariaDataSet.TAMANHO);
            // TODO: esta linha de código carrega dados na tabela 'sistemapizariaDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.sistemapizariaDataSet.CLIENTE);

        }

        private void vALORTextBox_TextChanged(object sender, EventArgs e)
        {
            totaltextbox.Text = vALORTextBox.Text;
        }
    }
}
