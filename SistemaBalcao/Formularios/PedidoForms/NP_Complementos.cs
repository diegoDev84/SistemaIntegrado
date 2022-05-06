using SistemaBalcao.Forms.PedidoForms;
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

namespace SistemaBalcao.Formularios.PedidoForms
{
    public partial class NP_Complementos : Form
    {
        int x = 50;
        int y = 50;
        public NP_Complementos()
        {
            InitializeComponent();
            var complementos = ComplementoRequest.Complementos();

            foreach (Complemento c in complementos)
            {
                CriarBotao(c.Nome, c.Preco);
                x += 119;
                if (x > 800)
                {
                    y += 86;
                    x = 50;
                }
            }
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ObservacoesBox.Text))
            {
                NP_Produtos.ListaItens.Items.Add("     Obs: " + ObservacoesBox.Text);
            }
            this.Close();
        }
        private void CriarBotao(string nome, double preco)
        {
            Button ProdutoBtn = new Button();
            ProdutoBtn.Name = nome;
            ProdutoBtn.Location = new Point(x, y);
            ProdutoBtn.Size = new Size(110, 80);
            ProdutoBtn.Text = nome;
            Controls.Add(ProdutoBtn);
            ProdutoBtn.Click += delegate
            {
                NP_Produtos.ListaItens.Items.Add(".....1x " + nome + "   " + preco.ToString("C"));
                NP_Produtos._totalPedido += preco;
                NP_Produtos.TotalPedidoBox.Text = NP_Produtos._totalPedido.ToString("C");
            };
        }
    }
}
