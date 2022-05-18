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
    public partial class PedidosPeriodo : Form
    {
        public PedidosPeriodo()
        {
            InitializeComponent();
            DataInicio.Format = DateTimePickerFormat.Custom;
            DataInicio.CustomFormat = "dd-MM-yyyy";
            DataFim.Format = DateTimePickerFormat.Custom;
            DataFim.CustomFormat = "dd-MM-yyyy";
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscaButton_Click(object sender, EventArgs e)
        {
            TotalBox.Text = "";
            BuscarPedidos();
            MessageBox.Show("Busca concluída!");
        }

        public void BuscarPedidos()
        {
            PedidosPeriodoList.Items.Clear();
            double Total = 0;
            var pedidos = PedidoRequest.pedidos();
            foreach(Pedido p in pedidos)
            {
                if (p.DataPedido >= DataInicio.Value &&
                    p.DataPedido <= DataFim.Value.AddDays(1))
                {
                    if (PgtoBox.Text == p.FormaPagamento)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                        p.DataPedido.ToString(),
                        p.Nome,
                        p.TipoPedido,
                        p.FormaPagamento,
                        p.ValorTotal.ToString("C")
                        }); ;
                        Total = +p.ValorTotal;
                        TotalBox.Text = Total.ToString("C");
                        PedidosPeriodoList.Items.Add(item);
                    }
                    if (PgtoBox.Text == "Todos")
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                        p.DataPedido.ToString(),
                        p.Nome,
                        p.TipoPedido,
                        p.FormaPagamento,
                        p.ValorTotal.ToString("C")
                        }); ;
                        Total = +p.ValorTotal;
                        TotalBox.Text = Total.ToString("C");
                        PedidosPeriodoList.Items.Add(item);
                    }
                }
            }
        }
    }
}
