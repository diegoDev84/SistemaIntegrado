using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Windows.Forms;

namespace SistemaBalcao.Forms.Cadastro
{
    public partial class ProdutoCadastro : Form
    {
        public ProdutoCadastro()
        {
            InitializeComponent();
            ProdutosLista.View = View.Details;
            ProdutosLista.FullRowSelect = true;
            ListarProdutos();
            ListarCategorias();
        }
        private async void AdicionaButton_Click(object sender, EventArgs e)
        {
            if (PrecoBox.Text.Contains(".") || CustoBox.Text.Contains("."))
            {
                MessageBox.Show("Caractere inválido. Utilize VÍRGULA ao invés de PONTO nos decimais");
                return;
            }
            if (String.IsNullOrEmpty(PrecoBox.Text) || String.IsNullOrEmpty(NomeBox.Text))
            {
                MessageBox.Show("Obrigatório informar os campos NOME e PREÇO.");
                return;
            }

            await ProdutoRequest.AdicionarProduto(CriaProduto());
            ListarProdutos();
            LimparBox();
        }

        private async void SalvaButton_Click(object sender, EventArgs e)
        {
            if (ProdutosLista.SelectedItems.Count > 0)
            {
                if (PrecoBox.Text.Contains(".") || CustoBox.Text.Contains("."))
                {
                    MessageBox.Show("Caractere inválido. Utilize VÍRGULA ao invés de PONTO nos decimais");
                    return;
                }
                if (String.IsNullOrEmpty(PrecoBox.Text) || String.IsNullOrEmpty(NomeBox.Text))
                {
                    MessageBox.Show("Obrigatório informar os campos NOME e PREÇO.");
                    return;
                }
                else
                {
                    Produto produto = new Produto
                    {
                        Id = Convert.ToInt32(ProdutosLista.SelectedItems[0].SubItems[7].Text),
                        Nome = NomeBox.Text,
                        Preco = Convert.ToDouble(PrecoBox.Text),
                        Categoria = CategoriaBox.Text,
                        Complementos = Convert.ToBoolean(ComplementoCheck.CheckState)
                    };

                    if (!String.IsNullOrEmpty(CustoBox.Text))
                    {
                        produto.Custo = Convert.ToDouble(CustoBox.Text);
                        produto.Lucro = Math.Round(produto.Preco - produto.Custo, 2);
                        produto.Margem = Math.Round((produto.Lucro / produto.Preco) * 100, 2);
                    }
                    await ProdutoRequest.AtualizarProduto(produto);
                    ListarProdutos();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um produto na lista.");
            }
        }

        private async void ExcluiButton_Click(object sender, EventArgs e)
        {
            if (ProdutosLista.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("ATENÇÃO: Tem certeza que deseja excluir o produto selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var produto = new Produto
                    {
                        Id = Convert.ToInt32(ProdutosLista.SelectedItems[0].SubItems[7].Text)
                };
                    await ProdutoRequest.DeletarProduto(produto);
                    ListarProdutos();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um produto na lista.");
            }
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpaButton_Click(object sender, EventArgs e)
        {
            LimparBox();
        }

        private void ProdutosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionaProduto();
        }


        //MÉTODOS

        private void ListarProdutos()
        {
            ProdutosLista.Items.Clear();
            var produtos = ProdutoRequest.Produtos();
            foreach (Produto p in produtos)
            {
            ListViewItem item = new ListViewItem(new[]
            {
                p.Nome,
                p.Categoria,
                p.Preco.ToString(),
                p.Complementos.ToString(),
                p.Lucro.ToString(),
                p.Margem.ToString(),
                p.Custo.ToString(),
                p.Id.ToString(),
            });
                ProdutosLista.Items.Add(item);
            }
        }

        private void ListarCategorias()
        {
            var categorias = CategoriaRequest.Categorias();
            foreach (Categoria c in categorias)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                c.Nome
                });
                CategoriaBox.Items.Add(item.Text);
            }
        }
        private void LimparBox()
        {
            NomeBox.Clear();
            PrecoBox.Clear();
            ComplementoCheck.Checked = false;
            CategoriaBox.ResetText();
            CustoBox.Clear();
            LucroLabel.Text = "";
            MargemLabel.Text = "";
        }

        private void SelecionaProduto()
        {
            if (ProdutosLista.SelectedItems.Count > 0)
            {
                NomeBox.Text = ProdutosLista.SelectedItems[0].SubItems[0].Text;
                CategoriaBox.Text = ProdutosLista.SelectedItems[0].SubItems[1].Text;
                PrecoBox.Text = ProdutosLista.SelectedItems[0].SubItems[2].Text;
                ComplementoCheck.Checked = Convert.ToBoolean(ProdutosLista.SelectedItems[0].SubItems[3].Text);
                LucroLabel.Text = "R$"+ProdutosLista.SelectedItems[0].SubItems[4].Text;
                MargemLabel.Text = ProdutosLista.SelectedItems[0].SubItems[5].Text + "%";
                CustoBox.Text = ProdutosLista.SelectedItems[0].SubItems[6].Text;
            }
            else
            {
                return;
            }
        }

        private Produto CriaProduto()
        {
            Produto produto = new Produto
            {
                Nome = NomeBox.Text,
                Preco = Convert.ToDouble(PrecoBox.Text),
                Categoria = CategoriaBox.Text,
                Complementos = Convert.ToBoolean(ComplementoCheck.CheckState)
            };

            if (!String.IsNullOrEmpty(CustoBox.Text))
            {
                produto.Custo = Convert.ToDouble(CustoBox.Text);
                produto.Lucro = Math.Round(produto.Preco - produto.Custo, 2);
                produto.Margem = Math.Round((produto.Lucro / produto.Preco) * 100, 2);
            }
            return produto;
        }

    }
}
