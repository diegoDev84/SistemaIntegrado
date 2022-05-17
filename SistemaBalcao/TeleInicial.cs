using SistemaBalcao.Forms.Cadastro;
using SistemaBalcao.Formularios.Cadastro;
using SistemaBalcao.Formularios.Relatorios;
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

namespace SistemaBalcao
{
    public partial class TeleInicial : Form
    {
        public static string _nomeFantasia { get; set; }
        public static string _telefone { get; set; }
        public TeleInicial()
        {
            InitializeComponent();
            var empresa = DadosDaEmpresaRequest.Empresa();
            _nomeFantasia = empresa.NomeFantasia;
            _telefone = empresa.Telefone;

            NomeFantasiaLabel.Text = _nomeFantasia;
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NovoPedido = new NP_Cliente();
            NovoPedido.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroProduto = new ProdutoCadastro();
            cadastroProduto.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cadastroCliente = new ClienteCadastro();
            cadastroCliente.Show();
        }

        private void complementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroComplemento = new ComplementoCadastro();
            cadastroComplemento.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroCategorias = new CategoriaCadastro();
            cadastroCategorias.Show();
        }

        private void dadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroEmpresa = new EmpresaCadastro();
            cadastroEmpresa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pedidosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PedidosCliente = new PedidosCliente();
            PedidosCliente.Show();
        }

        private void pedidosPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PedidosPeriodo = new PedidosPeriodo();
            PedidosPeriodo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NovoPedido = new NP_Cliente();
            NovoPedido.Show();
        }

        private void NovoClientBtn_Click(object sender, EventArgs e)
        {
            var NovoCliente = new ClienteCadastro();
            NovoCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var DeliveryDia = new DeliveryDia();
            DeliveryDia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var BalcaoDia = new BalcaoDia();
            BalcaoDia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var VendasDia = new VendasDia();
            VendasDia.Show();
        }
    }
}
