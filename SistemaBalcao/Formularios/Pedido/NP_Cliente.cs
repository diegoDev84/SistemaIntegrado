﻿using SistemaBalcao.Forms.Cadastro;
using SistemaBalcao.Forms.Pedido;
using SistemaBalcao.Modelos;
using SistemaBalcao.Requests;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaBalcao
{
    public partial class NP_Cliente : Form
    {
        public NP_Cliente()
        {
            InitializeComponent();
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NomeBox.Text))
            {
                MessageBox.Show("O campo NOME é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(TipoPedidoBox1.Text)) 
            { 
                MessageBox.Show("O campo TIPO DO PEDIDO é obrigatório");
                return;
            }

            var NovoProdutos = new NP_Produtos();
            var NovoPedido = new Pedido();
            NovoPedido.Nome = NomeBox.Text;
            NovoPedido.Telefone = TelefoneBox.Text;
            NovoPedido.Bairro = BairroBox.Text;
            NovoPedido.Logradouro = LogradouroBox.Text;
            NovoPedido.Cidade = CidadeBox.Text;

           if(TipoPedidoBox1.Text == "Balcão")
            {
                NovoPedido.TeleEntrega = false;
            }
           else NovoPedido.TeleEntrega=true;

            await PedidoRequest.NovoPedido(NovoPedido);

            NovoProdutos.Show();
            this.Close();
        }

        private void CancelaButton_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        public void BuscarCliente()
        {
            var clientes = ClienteRequest.Clientes();
            foreach (Cliente c in clientes)
            {
                if (c.Telefone == TelefoneBox.Text)
                {
                    NomeBox.Text = c.Nome;
                    LogradouroBox.Text = c.Logradouro;
                    BairroBox.Text = c.Bairro;
                    CidadeBox.Text = c.Cidade;
                    break;
                }
            }
            if (string.IsNullOrEmpty(NomeBox.Text))
            {
                if (MessageBox.Show("Cliente não encontrado! Deseja cadastrar o cliente?", "Não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var cadastroCliente = new ClienteCadastro();
                    cadastroCliente.Show();
                }
            }
        }
    }
}
