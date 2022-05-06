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

namespace SistemaBalcao.Formularios.Cadastro
{
    public partial class EmpresaCadastro : Form
    {
        public EmpresaCadastro()
        {
            InitializeComponent();
            var empresa = DadosDaEmpresaRequest.Empresa();
            cnpjBox.Text = empresa.CNPJ;
            razaoSocialBox.Text = empresa.RazaoSocial;
            nomeFantasiaBox.Text = empresa.NomeFantasia;
            enderecoBox.Text = empresa.Endereco;
            bairroBox.Text = empresa.Bairro;
            cidadeBox.Text = empresa.Cidade;
            ufBox.Text = empresa.UF;
            cepBox.Text = empresa.CEP;
            telefoneBox.Text = empresa.Telefone;
            emailBox.Text = empresa.Email;
        }

        private void FechaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SalvaButton_Click(object sender, EventArgs e)
        {
            var empresa = new DadosDaEmpresa()
            {
                CNPJ = cnpjBox.Text,
                RazaoSocial = razaoSocialBox.Text,
                NomeFantasia = nomeFantasiaBox.Text,
                Endereco = enderecoBox.Text,
                Bairro = bairroBox.Text,
                Cidade = cidadeBox.Text,
                UF = ufBox.Text,
                CEP = cepBox.Text,
                Telefone = telefoneBox.Text,
                Email = emailBox.Text,
            };
            await DadosDaEmpresaRequest.AtualizarEmpresa(empresa);
            MessageBox.Show("Dados salvos com sucesso!");

        }
    }
}
