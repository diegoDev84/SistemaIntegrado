using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Windows.Forms;

namespace SistemaBalcao.Formularios.Cadastro
{
    public partial class CategoriaCadastro : Form
    {
        public CategoriaCadastro()
        {
            InitializeComponent();
            CategoriasLista.View = View.Details;
            CategoriasLista.FullRowSelect = true;
            ListarCategorias();
        }

        private async void AdicionaButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomeBox.Text))
            {
                MessageBox.Show("Obrigatório informar o campo NOME.");
                return;
            }
            await CategoriaRequest.AdicionarCategoria(CriaCategoria());
            MessageBox.Show("Adicionado com sucesso!");
            ListarCategorias();
            LimparBox();
        }


        private async void SalvaButton_Click(object sender, EventArgs e)
        {
            if (CategoriasLista.SelectedItems.Count > 0)
            {
                if (String.IsNullOrEmpty(NomeBox.Text))
                {
                    MessageBox.Show("Obrigatório informar os campos NOME.");
                    return;
                }
                else
                {
                    Categoria categoria = new Categoria
                    {
                        Id = Convert.ToInt32(CategoriasLista.SelectedItems[0].SubItems[1].Text),
                        Nome = NomeBox.Text,
                    };
                    await CategoriaRequest.AtualizarCategoria(categoria);
                    MessageBox.Show("Salvo com sucesso!");
                    ListarCategorias();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar uma categoria na lista.");
            }
        }

        private async void ExcluiButton_Click(object sender, EventArgs e)
        {
            if (CategoriasLista.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("ATENÇÃO: Tem certeza que deseja excluir a categoria selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var categoria = new Categoria
                    {
                        Id = Convert.ToInt32(CategoriasLista.SelectedItems[0].SubItems[1].Text)
                    };
                    await CategoriaRequest.DeletarCategoria(categoria);
                    MessageBox.Show("Excluído com sucesso!");
                    ListarCategorias();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar uma categoria na lista.");
            }
        }

        private void LimpaButton_Click(object sender, EventArgs e)
        {
            NomeBox.Clear();
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoriasLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionaCategoria();
        }

        //MÉTODOS
        private void ListarCategorias()
        {
            CategoriasLista.Items.Clear();
            var categorias = CategoriaRequest.Categorias();
            foreach (Categoria c in categorias)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                c.Nome,
                c.Id.ToString(),
                });
                CategoriasLista.Items.Add(item);
            }
        }

        private void LimparBox()
        {
            NomeBox.Clear();
        }

        private Categoria CriaCategoria()
        {
            Categoria categoria = new Categoria
            {
                Nome = NomeBox.Text,
            };
            return categoria;
        }

        private void SelecionaCategoria()
        {
            if (CategoriasLista.SelectedItems.Count > 0)
            {
                NomeBox.Text = CategoriasLista.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                return;
            }
        }
    }
}
