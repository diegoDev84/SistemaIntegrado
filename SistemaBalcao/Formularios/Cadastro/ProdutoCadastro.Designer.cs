namespace SistemaBalcao.Forms.Cadastro
{
    partial class ProdutoCadastro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader ComplementosColuna;
            System.Windows.Forms.ColumnHeader IdColuna;
            System.Windows.Forms.ColumnHeader CustoColuna;
            System.Windows.Forms.ColumnHeader LucroColuna;
            System.Windows.Forms.ColumnHeader MargemColuna;
            this.AdicionaButton = new System.Windows.Forms.Button();
            this.ExcluiButton = new System.Windows.Forms.Button();
            this.LimpaButton = new System.Windows.Forms.Button();
            this.FechaButton = new System.Windows.Forms.Button();
            this.ComplementoCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.PrecoBox = new System.Windows.Forms.TextBox();
            this.CategoriaBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalvaButton = new System.Windows.Forms.Button();
            this.ProdutosLista = new System.Windows.Forms.ListView();
            this.ProdutoColuna = new System.Windows.Forms.ColumnHeader();
            this.CategoriaColuna = new System.Windows.Forms.ColumnHeader();
            this.PrecoColuna = new System.Windows.Forms.ColumnHeader();
            this.LucroLabel = new System.Windows.Forms.Label();
            this.MargemLabel = new System.Windows.Forms.Label();
            ComplementosColuna = new System.Windows.Forms.ColumnHeader();
            IdColuna = new System.Windows.Forms.ColumnHeader();
            CustoColuna = new System.Windows.Forms.ColumnHeader();
            LucroColuna = new System.Windows.Forms.ColumnHeader();
            MargemColuna = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComplementosColuna
            // 
            ComplementosColuna.Text = "Complementos";
            ComplementosColuna.Width = 0;
            // 
            // IdColuna
            // 
            IdColuna.Text = "Id";
            IdColuna.Width = 0;
            // 
            // CustoColuna
            // 
            CustoColuna.Text = "Custo";
            CustoColuna.Width = 0;
            // 
            // LucroColuna
            // 
            LucroColuna.Text = "Lucro";
            LucroColuna.Width = 0;
            // 
            // MargemColuna
            // 
            MargemColuna.Text = "Margem";
            MargemColuna.Width = 0;
            // 
            // AdicionaButton
            // 
            this.AdicionaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdicionaButton.Location = new System.Drawing.Point(102, 448);
            this.AdicionaButton.Name = "AdicionaButton";
            this.AdicionaButton.Size = new System.Drawing.Size(75, 23);
            this.AdicionaButton.TabIndex = 9;
            this.AdicionaButton.Text = "Adicionar";
            this.AdicionaButton.UseVisualStyleBackColor = true;
            this.AdicionaButton.Click += new System.EventHandler(this.AdicionaButton_Click);
            // 
            // ExcluiButton
            // 
            this.ExcluiButton.Location = new System.Drawing.Point(262, 448);
            this.ExcluiButton.Name = "ExcluiButton";
            this.ExcluiButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluiButton.TabIndex = 11;
            this.ExcluiButton.Text = "Excluir";
            this.ExcluiButton.UseVisualStyleBackColor = true;
            this.ExcluiButton.Click += new System.EventHandler(this.ExcluiButton_Click);
            // 
            // LimpaButton
            // 
            this.LimpaButton.Location = new System.Drawing.Point(343, 448);
            this.LimpaButton.Name = "LimpaButton";
            this.LimpaButton.Size = new System.Drawing.Size(75, 23);
            this.LimpaButton.TabIndex = 12;
            this.LimpaButton.Text = "Limpar";
            this.LimpaButton.UseVisualStyleBackColor = true;
            this.LimpaButton.Click += new System.EventHandler(this.LimpaButton_Click);
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(424, 448);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(75, 23);
            this.FechaButton.TabIndex = 13;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // ComplementoCheck
            // 
            this.ComplementoCheck.AutoSize = true;
            this.ComplementoCheck.Location = new System.Drawing.Point(457, 38);
            this.ComplementoCheck.Name = "ComplementoCheck";
            this.ComplementoCheck.Size = new System.Drawing.Size(142, 19);
            this.ComplementoCheck.TabIndex = 2;
            this.ComplementoCheck.Text = "Aceita complementos";
            this.ComplementoCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Preço (venda):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Categoria:";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(16, 35);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(323, 23);
            this.NomeBox.TabIndex = 0;
            // 
            // PrecoBox
            // 
            this.PrecoBox.Location = new System.Drawing.Point(345, 35);
            this.PrecoBox.Name = "PrecoBox";
            this.PrecoBox.Size = new System.Drawing.Size(100, 23);
            this.PrecoBox.TabIndex = 1;
            // 
            // CategoriaBox
            // 
            this.CategoriaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaBox.FormattingEnabled = true;
            this.CategoriaBox.ItemHeight = 15;
            this.CategoriaBox.Location = new System.Drawing.Point(16, 84);
            this.CategoriaBox.Name = "CategoriaBox";
            this.CategoriaBox.Size = new System.Drawing.Size(250, 23);
            this.CategoriaBox.TabIndex = 4;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(SistemaBalcao.Modelos.Categoria);
            // 
            // CustoBox
            // 
            this.CustoBox.Location = new System.Drawing.Point(272, 84);
            this.CustoBox.Name = "CustoBox";
            this.CustoBox.Size = new System.Drawing.Size(109, 23);
            this.CustoBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Custo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Margem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lucro Bruto:";
            // 
            // SalvaButton
            // 
            this.SalvaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalvaButton.Location = new System.Drawing.Point(183, 448);
            this.SalvaButton.Name = "SalvaButton";
            this.SalvaButton.Size = new System.Drawing.Size(75, 23);
            this.SalvaButton.TabIndex = 10;
            this.SalvaButton.TabStop = false;
            this.SalvaButton.Text = "Salvar";
            this.SalvaButton.UseVisualStyleBackColor = true;
            this.SalvaButton.Click += new System.EventHandler(this.SalvaButton_Click);
            // 
            // ProdutosLista
            // 
            this.ProdutosLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdutoColuna,
            this.CategoriaColuna,
            this.PrecoColuna,
            ComplementosColuna,
            IdColuna,
            CustoColuna,
            LucroColuna,
            MargemColuna});
            this.ProdutosLista.HideSelection = false;
            this.ProdutosLista.Location = new System.Drawing.Point(16, 122);
            this.ProdutosLista.Name = "ProdutosLista";
            this.ProdutosLista.Size = new System.Drawing.Size(577, 310);
            this.ProdutosLista.TabIndex = 34;
            this.ProdutosLista.UseCompatibleStateImageBehavior = false;
            this.ProdutosLista.View = System.Windows.Forms.View.Details;
            this.ProdutosLista.SelectedIndexChanged += new System.EventHandler(this.ProdutosLista_SelectedIndexChanged);
            // 
            // ProdutoColuna
            // 
            this.ProdutoColuna.Text = "Produto";
            this.ProdutoColuna.Width = 270;
            // 
            // CategoriaColuna
            // 
            this.CategoriaColuna.Text = "Categoria";
            this.CategoriaColuna.Width = 200;
            // 
            // PrecoColuna
            // 
            this.PrecoColuna.Text = "Preço";
            this.PrecoColuna.Width = 100;
            // 
            // LucroLabel
            // 
            this.LucroLabel.AutoSize = true;
            this.LucroLabel.Location = new System.Drawing.Point(388, 88);
            this.LucroLabel.Name = "LucroLabel";
            this.LucroLabel.Size = new System.Drawing.Size(0, 15);
            this.LucroLabel.TabIndex = 35;
            // 
            // MargemLabel
            // 
            this.MargemLabel.AutoSize = true;
            this.MargemLabel.Location = new System.Drawing.Point(493, 89);
            this.MargemLabel.Name = "MargemLabel";
            this.MargemLabel.Size = new System.Drawing.Size(0, 15);
            this.MargemLabel.TabIndex = 36;
            // 
            // ProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 484);
            this.Controls.Add(this.MargemLabel);
            this.Controls.Add(this.LucroLabel);
            this.Controls.Add(this.ProdutosLista);
            this.Controls.Add(this.SalvaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriaBox);
            this.Controls.Add(this.PrecoBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComplementoCheck);
            this.Controls.Add(this.FechaButton);
            this.Controls.Add(this.LimpaButton);
            this.Controls.Add(this.ExcluiButton);
            this.Controls.Add(this.AdicionaButton);
            this.Name = "ProdutoCadastro";
            this.Text = "Cadastro Produto";
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdicionaButton;
        private System.Windows.Forms.Button ExcluiButton;
        private System.Windows.Forms.Button LimpaButton;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.CheckBox ComplementoCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox PrecoBox;
        private System.Windows.Forms.ComboBox CategoriaBox;
        private System.Windows.Forms.TextBox CustoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SalvaButton;
        private System.Windows.Forms.ListView ProdutosLista;
        private System.Windows.Forms.ColumnHeader ProdutoColuna;
        private System.Windows.Forms.ColumnHeader CategoriaColuna;
        private System.Windows.Forms.ColumnHeader PrecoColuna;
        private System.Windows.Forms.Label LucroLabel;
        private System.Windows.Forms.Label MargemLabel;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}