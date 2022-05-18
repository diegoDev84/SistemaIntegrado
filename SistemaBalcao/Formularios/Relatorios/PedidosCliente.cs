using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBalcao.Formularios.Relatorios
{
    public partial class PedidosCliente : Form
    {
        public int _clienteID { get; set; }
        public string _clienteNome;
        
        public PedidosCliente()
        {
            InitializeComponent();
            PedidosClienteList.View = View.Details;
            PedidosClienteList.FullRowSelect = true;
        }
        
        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscaButton_Click(object sender, EventArgs e)
        {
            PedidosClienteList.Items.Clear();
            TotalBox.Text = "";
            BuscarCliente();
            BuscarPedidos();
        }

        public void BuscarCliente()
        {
            var clientes = ClienteRequest.Clientes();
            foreach (Cliente c in clientes)
            {
                if (TelefoneBox.Text == c.Telefone)
                {
                    _clienteID = c.Id;
                    _clienteNome = c.Nome;
                    break;
                }
            }
        }

        public void BuscarPedidos()
        {
            double Total = 0;
            var pedidos = ClienteRequest.ClientePedidos(_clienteID);
            if(pedidos != null)
            {
                foreach (Pedido p in pedidos)
                {
                    if (PgtoBox.Text == p.FormaPagamento)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            p.DataPedido.ToString(),
                            _clienteNome,
                            p.TipoPedido,
                            p.FormaPagamento,
                            p.ValorTotal.ToString("C")
                        });;
                        Total = +p.ValorTotal;
                        TotalBox.Text = Total.ToString("C");
                        PedidosClienteList.Items.Add(item);
                    }
                    else if (PgtoBox.Text == "Todos")
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            p.DataPedido.ToString(),
                            _clienteNome,
                            p.TipoPedido,
                            p.FormaPagamento,
                            p.ValorTotal.ToString("C")
                        });;
                        Total = +p.ValorTotal;
                        TotalBox.Text = Total.ToString("C");
                        PedidosClienteList.Items.Add(item);
                    }
                }
                MessageBox.Show("Busca concluída!");
            }
        }
    }
}
