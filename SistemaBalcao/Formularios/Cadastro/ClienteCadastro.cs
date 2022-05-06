using SistemaBalcao.Requests;
using System;
using System.Windows.Forms;

namespace SistemaBalcao.Forms.Cadastro
{
    public partial class ClienteCadastro : Form
    {
        public ClienteCadastro()
        {
            InitializeComponent();
            ClientesLista.View = View.Details;
            ClientesLista.FullRowSelect = true;
            ListarClientes();
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SalvaButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente {
                Nome = NomeBox.Text,
                Telefone = TelefoneBox.Text,
                Logradouro = LogradouroBox.Text,
                Numero = NumeroBox.Text,
                Complemento = ComplementoBox.Text,
                Bairro = BairroBox.Text,
                Cidade = CidadeBox.Text,
                UF = UfBox.Text,
                CEP = CepBox.Text,
                Email = EmailBox.Text
                };

            await ClienteRequest.AdicionarCliente(cliente);
            MessageBox.Show("Adicionado com sucesso!");
            ListarClientes();
            LimparBox();
        }

        private async void AtualizaButton_Click(object sender, EventArgs e)
        {
            if (ClientesLista.SelectedItems.Count > 0)
            {
                var cliente = new Cliente
                {
                    Id = ClientesLista.SelectedItems[0].SubItems[0].Text,
                    Nome = NomeBox.Text,
                    Telefone = TelefoneBox.Text,
                    Logradouro = LogradouroBox.Text,
                    Numero = NumeroBox.Text,
                    Complemento = ComplementoBox.Text,
                    Bairro = BairroBox.Text,
                    Cidade = CidadeBox.Text,
                    UF = UfBox.Text,
                    CEP = CepBox.Text,
                    Email = EmailBox.Text
                };
                await ClienteRequest.AtualizarCliente(cliente);
                MessageBox.Show("Salvo com sucesso!");
                ListarClientes();
                LimparBox();
            }

            else
            {
                MessageBox.Show("Você deve selecionar um cliente na lista.");
            }
        }
        
        private void CancelaButton_Click(object sender, EventArgs e)
        {
            LimparBox();
        }

        private async void ExcluiButton_Click(object sender, EventArgs e)
        {
            if (ClientesLista.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("ATENÇÃO: Tem certeza que deseja excluir o cliente selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var cliente = new Cliente
                    {
                        Id = ClientesLista.SelectedItems[0].SubItems[0].Text,
                    };
                    await ClienteRequest.DeletarCliente(cliente);
                    MessageBox.Show("Excluído com sucesso!");
                    ListarClientes();
                    LimparBox();
                }
            }

            else
            {
                MessageBox.Show("Você deve selecionar um cliente na lista.");
            }

        }

        private void ClientesLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionaCliente();
        }

                

        //---------MÉTODOS-----------

        public void ListarClientes()
        {
            ClientesLista.Items.Clear();
            var clientes = ClienteRequest.Clientes();
            foreach (Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem(new[]
                    {
                    c.Id,
                    c.Nome,
                    c.Telefone,
                    c.Logradouro,
                    c.Numero,
                    c.Complemento,
                    c.Bairro,
                    c.Cidade,
                    c.UF,
                    c.CEP,
                    c.Email
                });
                ClientesLista.Items.Add(item);
             }
        }

        private void SelecionaCliente()
        {
            if (ClientesLista.SelectedItems.Count > 0)
            {
                NomeBox.Text = ClientesLista.SelectedItems[0].SubItems[1].Text;
                TelefoneBox.Text = ClientesLista.SelectedItems[0].SubItems[2].Text;
                LogradouroBox.Text = ClientesLista.SelectedItems[0].SubItems[3].Text;
                NumeroBox.Text = ClientesLista.SelectedItems[0].SubItems[4].Text;
                ComplementoBox.Text = ClientesLista.SelectedItems[0].SubItems[5].Text;
                BairroBox.Text = ClientesLista.SelectedItems[0].SubItems[6].Text;
                CidadeBox.Text = ClientesLista.SelectedItems[0].SubItems[7].Text;
                UfBox.Text = ClientesLista.SelectedItems[0].SubItems[8].Text;
                CepBox.Text = ClientesLista.SelectedItems[0].SubItems[9].Text;
                EmailBox.Text = ClientesLista.SelectedItems[0].SubItems[10].Text;
            }
            else
            {
                return;
            }
        }
        private void LimparBox()
        {
            NomeBox.Clear();
            TelefoneBox.Clear();
            LogradouroBox.Clear();
            NumeroBox.Clear();
            ComplementoBox.Clear();
            BairroBox.Clear();
            CidadeBox.Clear();
            UfBox.Clear();
            CepBox.Clear();
            EmailBox.Clear();
        }
    }
}
