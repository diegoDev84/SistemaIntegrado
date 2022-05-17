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
    public partial class BalcaoDia : Form
    {
        public BalcaoDia()
        {
            InitializeComponent();
            BuscarBalcaoDia();
        }

        private void FechaButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarBalcaoDia()
        {
            BalcaoDiaList.Items.Clear();
            double Total = 0;
            var pedidos = PedidoRequest.pedidos();
            foreach (Pedido p in pedidos)
            {
                if (p.TipoPedido == "Balcão" && p.DataPedido.Date == DateTime.Today)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        p.DataPedido.ToString(),
                        p.TipoPedido,
                        p.ValorTotal.ToString("C")
                    }); ;

                    Total = +p.ValorTotal;
                    TotalBox.Text = Total.ToString("C");
                    BalcaoDiaList.Items.Add(item);
                }
            }
        }


    }
}