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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmpedidos pedidos = new frmpedidos();
            pedidos.ShowDialog();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmclientes clientes = new frmclientes();
            clientes.ShowDialog();
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            frmpizzas pizzas = new frmpizzas();
             pizzas.ShowDialog();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            dtgpesquisas.DataSource = pedidoTableAdapter1.retornarpedidos();
            verificarpedido();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (cbentregue.Checked == true)
            {
                dtgpesquisas.DataSource = pedidoTableAdapter1.retornarentregue();
            }
            else
            {
                if (cbespera.Checked == true)
                {
                    dtgpesquisas.DataSource = pedidoTableAdapter1.retornarespera();
                }
                else
                {
                    if (txtnomecliente.Text == "")
                    {
                        dtgpesquisas.DataSource = pedidoTableAdapter1.retornarpedidos();
                    }
                    else
                    {
                        dtgpesquisas.DataSource = pedidoTableAdapter1.retornarcliente(txtnomecliente.Text);
                    }
                }
            }
            verificarpedido();
        }

        private void cbentregue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbentregue.Checked == true) // virifica se a caixa esta marcada 
            {
                cbespera.Enabled = false;
                txtnomecliente.Enabled = false;
            }
            else
            {
                cbespera.Enabled = true;
                txtnomecliente.Enabled = true;
            }
        }

        private void cbespera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbespera.Checked == true) // virifica se a caixa esta marcada 
            {
                cbentregue.Enabled = false;
                txtnomecliente.Enabled = false;
            }
            else
            {
                cbentregue.Enabled = true;
                txtnomecliente.Enabled = true;
            }
        }

        private void verificarpedido()
        {
            int linhas = dtgpesquisas.Rows.Count;

            if (linhas > 0)
            {
                for (int i = 0; i < linhas; i++)
                {
                  if (Convert.ToBoolean(dtgpesquisas.Rows[i].Cells["ENTREGUE"].Value) == true)
                    {
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Value = "ENTREGUE";
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.ForestGreen;
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }

                  else
                    {
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Value = "A Espera";
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.Firebrick;
                        dtgpesquisas.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
