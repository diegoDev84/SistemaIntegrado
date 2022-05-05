using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBalcao.Forms.PedidoForms
{
    public partial class NP_Produtos : Form
    {
        string _bairro { get; set; }
        string _cidade { get; set; }
        int x = 50;
        int y = 96;
        double _totalPedido = 0;

        public NP_Produtos(string nome, string endereco, string bairro, string cidade, string telefone, string tipo)
        {
            InitializeComponent();
            NomePedidoBox.Text = nome;
            EnderecoPedidoBox.Text = endereco;
            _bairro = bairro;
            _cidade = cidade;
            TelefonePedidoBox.Text= telefone;
            TipoPedidoBox.Text = tipo;

            var produtos = ProdutoRequest.Produtos();
            
            foreach (Produto p in produtos)
            {
                CriarBotao(p.Nome, p.Preco, p.Complementos);
                x += 119;
                if(x > 800)
                {
                    y += 86;
                    x = 50;
                }
            }
        }
        private void CancelaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriarBotao(string nome, double preco, bool complemento)
        {
            Button ProdutoBtn = new Button();
            ProdutoBtn.Name = nome;
            ProdutoBtn.Location = new Point(x, y);
            ProdutoBtn.Size = new Size(110, 80);
            ProdutoBtn.Text = nome;
            Controls.Add(ProdutoBtn);
            ProdutoBtn.Click += delegate
            {
                ListaItens.Items.Add("1x " + nome + "   " + preco.ToString("C"));
                _totalPedido += preco;
                TotalPedidoBox.Text = _totalPedido.ToString("C");
            };
        }

        private async void ConfirmaButton_Click(object sender, EventArgs e)
        {
            if(DescontoBox.Text == "Financeiro" && !String.IsNullOrEmpty(DescontoBox2.Text))
            {
                _totalPedido -= Convert.ToDouble(DescontoBox2.Text);
                TotalPedidoBox.Text = _totalPedido.ToString("C");
            }
            var NovoPedido = new Pedido()
            {
                Nome = NomePedidoBox.Text,
                Telefone = TelefonePedidoBox.Text,
                Bairro = _bairro,
                Cidade = _cidade,
                Logradouro = EnderecoPedidoBox.Text,
                TipoPedido = TipoPedidoBox.Text,
                ValorTotal = _totalPedido
            };

            await PedidoRequest.NovoPedido(NovoPedido);
            this.Close();

        }
    }
}
