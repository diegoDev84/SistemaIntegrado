namespace SistemaBalcao.Forms.Cadastro
{
    partial class ClienteCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader UfCliente;
            System.Windows.Forms.ColumnHeader CepCliente;
            this.TelefoneBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaButton = new System.Windows.Forms.Button();
            this.CancelaButton = new System.Windows.Forms.Button();
            this.ExcluiButton = new System.Windows.Forms.Button();
            this.SalvaButton = new System.Windows.Forms.Button();
            this.LogradouroBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComplementoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CidadeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UfBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CepBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClientesLista = new System.Windows.Forms.ListView();
            this.IdCliente = new System.Windows.Forms.ColumnHeader();
            this.NomeCliente = new System.Windows.Forms.ColumnHeader();
            this.TelefoneCliente = new System.Windows.Forms.ColumnHeader();
            this.LogradouroCliente = new System.Windows.Forms.ColumnHeader();
            this.NumeroCliente = new System.Windows.Forms.ColumnHeader();
            this.ComplementoCliente = new System.Windows.Forms.ColumnHeader();
            this.BairroCliente = new System.Windows.Forms.ColumnHeader();
            this.CidadeCliente = new System.Windows.Forms.ColumnHeader();
            this.EmailCliente = new System.Windows.Forms.ColumnHeader();
            this.BairroBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AtualizaButton = new System.Windows.Forms.Button();
            UfCliente = new System.Windows.Forms.ColumnHeader();
            CepCliente = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // UfCliente
            // 
            UfCliente.Text = "UF";
            UfCliente.Width = 0;
            // 
            // CepCliente
            // 
            CepCliente.Text = "CEP";
            CepCliente.Width = 0;
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.Location = new System.Drawing.Point(316, 22);
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(165, 23);
            this.TelefoneBox.TabIndex = 19;
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(12, 22);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(298, 23);
            this.NomeBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome:";
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(572, 507);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(75, 23);
            this.FechaButton.TabIndex = 32;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // CancelaButton
            // 
            this.CancelaButton.Location = new System.Drawing.Point(491, 507);
            this.CancelaButton.Name = "CancelaButton";
            this.CancelaButton.Size = new System.Drawing.Size(75, 23);
            this.CancelaButton.TabIndex = 31;
            this.CancelaButton.Text = "Limpar";
            this.CancelaButton.UseVisualStyleBackColor = true;
            this.CancelaButton.Click += new System.EventHandler(this.CancelaButton_Click);
            // 
            // ExcluiButton
            // 
            this.ExcluiButton.Location = new System.Drawing.Point(410, 507);
            this.ExcluiButton.Name = "ExcluiButton";
            this.ExcluiButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluiButton.TabIndex = 30;
            this.ExcluiButton.Text = "Excluir";
            this.ExcluiButton.UseVisualStyleBackColor = true;
            this.ExcluiButton.Click += new System.EventHandler(this.ExcluiButton_Click);
            // 
            // SalvaButton
            // 
            this.SalvaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalvaButton.Location = new System.Drawing.Point(248, 507);
            this.SalvaButton.Name = "SalvaButton";
            this.SalvaButton.Size = new System.Drawing.Size(75, 23);
            this.SalvaButton.TabIndex = 28;
            this.SalvaButton.Text = "Adicionar";
            this.SalvaButton.UseVisualStyleBackColor = true;
            this.SalvaButton.Click += new System.EventHandler(this.SalvaButton_Click);
            // 
            // LogradouroBox
            // 
            this.LogradouroBox.Location = new System.Drawing.Point(12, 66);
            this.LogradouroBox.Name = "LogradouroBox";
            this.LogradouroBox.Size = new System.Drawing.Size(298, 23);
            this.LogradouroBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rua/Avenida:";
            // 
            // NumeroBox
            // 
            this.NumeroBox.Location = new System.Drawing.Point(316, 66);
            this.NumeroBox.Name = "NumeroBox";
            this.NumeroBox.Size = new System.Drawing.Size(54, 23);
            this.NumeroBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número:";
            // 
            // ComplementoBox
            // 
            this.ComplementoBox.Location = new System.Drawing.Point(376, 66);
            this.ComplementoBox.Name = "ComplementoBox";
            this.ComplementoBox.Size = new System.Drawing.Size(105, 23);
            this.ComplementoBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Complemento:";
            // 
            // CidadeBox
            // 
            this.CidadeBox.Location = new System.Drawing.Point(597, 66);
            this.CidadeBox.Name = "CidadeBox";
            this.CidadeBox.Size = new System.Drawing.Size(178, 23);
            this.CidadeBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cidade:";
            // 
            // UfBox
            // 
            this.UfBox.Location = new System.Drawing.Point(781, 66);
            this.UfBox.Name = "UfBox";
            this.UfBox.Size = new System.Drawing.Size(54, 23);
            this.UfBox.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "UF:";
            // 
            // CepBox
            // 
            this.CepBox.Location = new System.Drawing.Point(841, 66);
            this.CepBox.Name = "CepBox";
            this.CepBox.Size = new System.Drawing.Size(105, 23);
            this.CepBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(841, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "CEP:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(487, 22);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(288, 23);
            this.EmailBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "E-mail:";
            // 
            // ClientesLista
            // 
            this.ClientesLista.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ClientesLista.AllowColumnReorder = true;
            this.ClientesLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCliente,
            this.NomeCliente,
            this.TelefoneCliente,
            this.LogradouroCliente,
            this.NumeroCliente,
            this.ComplementoCliente,
            this.BairroCliente,
            this.CidadeCliente,
            UfCliente,
            CepCliente,
            this.EmailCliente});
            this.ClientesLista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientesLista.HideSelection = false;
            this.ClientesLista.Location = new System.Drawing.Point(12, 110);
            this.ClientesLista.Name = "ClientesLista";
            this.ClientesLista.Size = new System.Drawing.Size(934, 376);
            this.ClientesLista.TabIndex = 35;
            this.ClientesLista.UseCompatibleStateImageBehavior = false;
            this.ClientesLista.View = System.Windows.Forms.View.Details;
            this.ClientesLista.SelectedIndexChanged += new System.EventHandler(this.ClientesLista_SelectedIndexChanged);
            // 
            // IdCliente
            // 
            this.IdCliente.Text = "ID";
            this.IdCliente.Width = 0;
            // 
            // NomeCliente
            // 
            this.NomeCliente.Text = "Nome";
            this.NomeCliente.Width = 175;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.Text = "Telefone";
            this.TelefoneCliente.Width = 100;
            // 
            // LogradouroCliente
            // 
            this.LogradouroCliente.Text = "Logradouro";
            this.LogradouroCliente.Width = 200;
            // 
            // NumeroCliente
            // 
            this.NumeroCliente.Text = "Numero";
            // 
            // ComplementoCliente
            // 
            this.ComplementoCliente.Text = "Complemento";
            this.ComplementoCliente.Width = 120;
            // 
            // BairroCliente
            // 
            this.BairroCliente.Text = "Bairro";
            this.BairroCliente.Width = 125;
            // 
            // CidadeCliente
            // 
            this.CidadeCliente.Text = "Cidade";
            this.CidadeCliente.Width = 150;
            // 
            // EmailCliente
            // 
            this.EmailCliente.Text = "E-mail";
            this.EmailCliente.Width = 0;
            // 
            // BairroBox
            // 
            this.BairroBox.Location = new System.Drawing.Point(487, 66);
            this.BairroBox.Name = "BairroBox";
            this.BairroBox.Size = new System.Drawing.Size(105, 23);
            this.BairroBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Bairro:";
            // 
            // AtualizaButton
            // 
            this.AtualizaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AtualizaButton.Location = new System.Drawing.Point(329, 507);
            this.AtualizaButton.Name = "AtualizaButton";
            this.AtualizaButton.Size = new System.Drawing.Size(75, 23);
            this.AtualizaButton.TabIndex = 29;
            this.AtualizaButton.Text = "Salvar";
            this.AtualizaButton.UseVisualStyleBackColor = true;
            this.AtualizaButton.Click += new System.EventHandler(this.AtualizaButton_Click);
            // 
            // ClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 546);
            this.Controls.Add(this.AtualizaButton);
            this.Controls.Add(this.BairroBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ClientesLista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.CepBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UfBox);
            this.Controls.Add(this.CidadeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComplementoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumeroBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogradouroBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaButton);
            this.Controls.Add(this.CancelaButton);
            this.Controls.Add(this.ExcluiButton);
            this.Controls.Add(this.SalvaButton);
            this.Name = "ClienteCadastro";
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TelefoneBox;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.Button CancelaButton;
        private System.Windows.Forms.Button ExcluiButton;
        private System.Windows.Forms.Button SalvaButton;
        private System.Windows.Forms.TextBox LogradouroBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ComplementoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CidadeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UfBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CepBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView ClientesLista;
        private System.Windows.Forms.ColumnHeader NomeCliente;
        private System.Windows.Forms.ColumnHeader TelefoneCliente;
        private System.Windows.Forms.ColumnHeader LogradouroCliente;
        private System.Windows.Forms.ColumnHeader NumeroCliente;
        private System.Windows.Forms.ColumnHeader ComplementoCliente;
        private System.Windows.Forms.ColumnHeader BairroCliente;
        private System.Windows.Forms.ColumnHeader CidadeCliente;
        private System.Windows.Forms.TextBox BairroBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader IdCliente;
        private System.Windows.Forms.Button AtualizaButton;
        private System.Windows.Forms.ColumnHeader EmailCliente;
    }
}