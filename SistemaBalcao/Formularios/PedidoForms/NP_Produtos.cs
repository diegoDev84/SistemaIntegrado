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

        Pedido NovoPedido = new Pedido();

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

            NovoPedido.Nome = NomePedidoBox.Text;
            NovoPedido.Telefone = TelefonePedidoBox.Text;
            NovoPedido.Bairro = _bairro;
            NovoPedido.Cidade = _cidade;
            NovoPedido.Logradouro = EnderecoPedidoBox.Text;
            NovoPedido.TipoPedido = TipoPedidoBox.Text;
            NovoPedido.ValorTotal = _totalPedido;

            await PedidoRequest.NovoPedido(NovoPedido);
            impressora.Print();
            this.Close();
        }

        private void impressora_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int tamanhoDaLinha = 25;
            int espacamento = 25;
            void Escrever(string texto)
            {
                Font tipoFonte = new Font("Segoe UI", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                SolidBrush cor = new SolidBrush(Color.Black);
                Point local = new Point(15, tamanhoDaLinha);
                e.Graphics.DrawString(texto, tipoFonte, cor, local);
                tamanhoDaLinha += espacamento;
            }

            void EscreverNegrito(string texto)
            {
                Font tipoFonte = new Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel);
                SolidBrush cor = new SolidBrush(Color.Black);
                Point local = new Point(15, tamanhoDaLinha);
                e.Graphics.DrawString(texto, tipoFonte, cor, local);
                tamanhoDaLinha += espacamento;
            }

            EscreverNegrito("     .::"+TeleInicial._nomeFantasia+"::.");
            EscreverNegrito(             "Fone: "+TeleInicial._telefone);
            tamanhoDaLinha += espacamento;
            Escrever("Pedido: " + Program.NumeroPedido + "      " + DateTime.Now);
            Program.NumeroPedido++;
            tamanhoDaLinha += espacamento;
            Escrever("Ítens do pedido:");
            if (ListaItens.Items.Count > 0)
            {
                foreach (var item in ListaItens.Items)
                {
                    Escrever(item.ToString());
                }
            }

            tamanhoDaLinha += espacamento;

            EscreverNegrito("Total do pedido...................................." + _totalPedido.ToString("C"));
            tamanhoDaLinha += espacamento;
            Escrever("Forma de pagamento: " + PgtoBox.Text);
            if (PgtoBox.Text == "Dinheiro")
            {
                Escrever("Levar troco para.....................R$" + Convert.ToDouble(TrocoBox.Text));
                double valorDoTroco = Convert.ToDouble(TrocoBox.Text) - _totalPedido;
                Escrever("Valor do troco........................." + valorDoTroco.ToString("C"));
            }

            tamanhoDaLinha += espacamento;

            Escrever("Tipo de pedido: " + TipoPedidoBox.Text);
            Escrever("Cliente: " + NomePedidoBox.Text);
            Escrever("Telefone: " + TelefonePedidoBox.Text);

            if (TipoPedidoBox.Text == "Tele-Entrega")
            {
                Escrever("Endereço: " + EnderecoPedidoBox.Text);
                Escrever("Bairro: " + _bairro);
                Escrever("Cidade: " + _cidade);
            }
            tamanhoDaLinha += espacamento;
            Escrever("Agradecemos a preferência!");



        }
    }
}
