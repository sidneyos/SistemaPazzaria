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
    public partial class frmpizzas : Form
    {
        public frmpizzas()
        {
            InitializeComponent();
        }

        public void listarsabores()
        {
            dtgsabores.DataSource = saborTableAdapter1.retornarsabores();
        }
        public void Limpar()
        {
            // metodo de limpar os nomes
            txtcodigo.Text = "0";
            txtnome.Clear();
            txtingredientes.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            saborTableAdapter1.salvar(txtnome.Text, txtingredientes.Text);
            MessageBox.Show("salvo com sucesso!");
            listarsabores();
            Limpar();
        }

        private void frmpizzas_Load(object sender, EventArgs e)
        {
            listarsabores();
            
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgsabores_DoubleClick(object sender, EventArgs e)
        {
            txtcodigo.Text = dtgsabores.Rows[dtgsabores.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
            txtnome.Text = dtgsabores.Rows[dtgsabores.CurrentRow.Index].Cells["NOME"].Value.ToString();
            txtingredientes.Text = dtgsabores.Rows[dtgsabores.CurrentRow.Index].Cells["INGREDIENTES"].Value.ToString();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "0")
            {
                MessageBox.Show("impossivel Excluir");
            }
            else
            {
                saborTableAdapter1.excluir(Convert.ToInt32(txtcodigo.Text));
                MessageBox.Show("registro excluido com sucesso!");
                listarsabores();
                Limpar();

            }
        }

        private void btnsalvartamanho_Click(object sender, EventArgs e)
        {
            if(txtcodigotamanho.Text == "0")
            {
                tamanhoTableAdapter1.salvartamanho(txtnometamanho.Text, Convert.ToDecimal(txtvalor.Text));
                Limpar();
                
                MessageBox.Show("cadastro realizado com sucesso!");
            }
            else
            {
               tamanhoTableAdapter1.alterartamanho(txtnometamanho.Text, Convert.ToDecimal(txtvalor.Text), Convert.ToInt32(txtcodigotamanho.Text));
                Limpar();
                
                MessageBox.Show("alteração realizada com sucesso!");
            }
        }

        private void btnexcluirtamanho_Click(object sender, EventArgs e)
        {
            if (txtcodigotamanho.Text == "0")
            {
                MessageBox.Show("impossivel excluir!");
            }
            else
            {
                tamanhoTableAdapter1.excluirtamanho(Convert.ToInt32(txtcodigotamanho.Text));
                MessageBox.Show("excluido com sucesso!");
                
                Limpar();
            }
        }

        private void dtgtamanho_DoubleClick(object sender, EventArgs e)
        {
            txtcodigotamanho.Text = dtgtamanho.Rows[dtgtamanho.CurrentRow.Index].Cells["CODIGO_TAMANHO"].Value.ToString();
            txtnometamanho.Text = dtgtamanho.Rows[dtgtamanho.CurrentRow.Index].Cells["NOME_TAMANHO"].Value.ToString();
            txtvalor.Text = dtgtamanho.Rows[dtgtamanho.CurrentRow.Index].Cells["VALOR"].Value.ToString();
        }
    }
}
