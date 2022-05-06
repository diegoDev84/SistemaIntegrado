using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Windows.Forms;

namespace SistemaBalcao.Formularios.Cadastro
{
    public partial class ComplementoCadastro : Form
    {
        public ComplementoCadastro()
        {
            InitializeComponent();
            ComplementoLista.View = View.Details;
            ComplementoLista.FullRowSelect = true;
            ListarComplementos();
        }
        private async void AdicionaComplemento_Click_1(object sender, EventArgs e)
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

            await ComplementoRequest.AdicionarComplemento(CriaComplemento());
            ListarComplementos();
            LimparBox();
        }

        private async void SalvaComplemento_Click_1(object sender, EventArgs e)
        {
            if (ComplementoLista.SelectedItems.Count > 0)
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
                    Complemento complemento = new Complemento
                    {
                        Id = Convert.ToInt32(ComplementoLista.SelectedItems[0].SubItems[5].Text),
                        Nome = NomeBox.Text,
                        Preco = Convert.ToDouble(PrecoBox.Text),
                    };

                    if (!String.IsNullOrEmpty(CustoBox.Text))
                    {
                        complemento.Custo = Convert.ToDouble(CustoBox.Text);
                        complemento.Lucro = Math.Round(complemento.Preco - complemento.Custo, 2);
                        complemento.Margem = Math.Round((complemento.Lucro / complemento.Preco) * 100, 2);
                    }
                    await ComplementoRequest.AtualizarComplemento(complemento);
                    MessageBox.Show("Salvo com sucesso!");
                    ListarComplementos();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um complemento na lista.");
            }
        }

        private async void ExcluiComplemento_Click_1(object sender, EventArgs e)
        {
            if (ComplementoLista.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("ATENÇÃO: Tem certeza que deseja excluir o complemento selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var complemento = new Complemento
                    {
                        Id = Convert.ToInt32(ComplementoLista.SelectedItems[0].SubItems[5].Text)
                    };
                    await ComplementoRequest.DeletarComplemento(complemento);
                    MessageBox.Show("Excluído com sucesso!");
                    ListarComplementos();
                    LimparBox();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um complemento na lista.");
            }
        }

        private void FechaComplemento_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpaComplemento_Click_1(object sender, EventArgs e)
        {
            LimparBox();
        }

        private void ComplementoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionaComplemento();
        }


        //MÉTODOS

        private void ListarComplementos()
        {
            ComplementoLista.Items.Clear();
            var complementos = ComplementoRequest.Complementos();
            foreach (Complemento c in complementos)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                c.Nome,
                c.Preco.ToString(),
                c.Lucro.ToString(),
                c.Margem.ToString(),
                c.Custo.ToString(),
                c.Id.ToString(),
            });
                ComplementoLista.Items.Add(item);
            }
        }

        private void LimparBox()
        {
            NomeBox.Clear();
            PrecoBox.Clear();
            CustoBox.Clear();
            LucroLabel.Text = "";
            MargemLabel.Text = "";
        }

        private void SelecionaComplemento()
        {
            if (ComplementoLista.SelectedItems.Count > 0)
            {
                NomeBox.Text = ComplementoLista.SelectedItems[0].SubItems[0].Text;
                PrecoBox.Text = ComplementoLista.SelectedItems[0].SubItems[1].Text;
                LucroLabel.Text = "R$" + ComplementoLista.SelectedItems[0].SubItems[2].Text;
                MargemLabel.Text = ComplementoLista.SelectedItems[0].SubItems[3].Text + "%";
                CustoBox.Text = ComplementoLista.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                return;
            }
        }

        private Complemento CriaComplemento()
        {
            Complemento complemento = new Complemento
            {
                Nome = NomeBox.Text,
                Preco = Convert.ToDouble(PrecoBox.Text),
            };

            if (!String.IsNullOrEmpty(CustoBox.Text))
            {
                complemento.Custo = Convert.ToDouble(CustoBox.Text);
                complemento.Lucro = Math.Round(complemento.Preco - complemento.Custo, 2);
                complemento.Margem = Math.Round((complemento.Lucro / complemento.Preco) * 100, 2);
            }
            return complemento;
        }


    }
}