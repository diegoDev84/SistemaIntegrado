using SistemaBalcao.Forms.Cadastro;
using SistemaBalcao.Formularios.Cadastro;
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
        public TeleInicial()
        {
            InitializeComponent();
            var empresa = DadosDaEmpresaRequest.Empresa();
            NomeFantasiaBox.Text = empresa.NomeFantasia;

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
    }
}
