namespace SistemaBalcao.Formularios.Cadastro
{
    partial class ComplementoCadastro
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
            System.Windows.Forms.ColumnHeader IdColuna;
            System.Windows.Forms.ColumnHeader CustoColuna;
            System.Windows.Forms.ColumnHeader LucroColuna;
            System.Windows.Forms.ColumnHeader MargemColuna;
            this.MargemLabel = new System.Windows.Forms.Label();
            this.LucroLabel = new System.Windows.Forms.Label();
            this.ComplementoLista = new System.Windows.Forms.ListView();
            this.ComplementoColuna = new System.Windows.Forms.ColumnHeader();
            this.PrecoColuna = new System.Windows.Forms.ColumnHeader();
            this.SalvaComplemento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecoBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaComplemento = new System.Windows.Forms.Button();
            this.LimpaComplemento = new System.Windows.Forms.Button();
            this.ExcluiComplemento = new System.Windows.Forms.Button();
            this.AdicionaComplemento = new System.Windows.Forms.Button();
            IdColuna = new System.Windows.Forms.ColumnHeader();
            CustoColuna = new System.Windows.Forms.ColumnHeader();
            LucroColuna = new System.Windows.Forms.ColumnHeader();
            MargemColuna = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
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
            // MargemLabel
            // 
            this.MargemLabel.AutoSize = true;
            this.MargemLabel.Location = new System.Drawing.Point(233, 82);
            this.MargemLabel.Name = "MargemLabel";
            this.MargemLabel.Size = new System.Drawing.Size(0, 15);
            this.MargemLabel.TabIndex = 55;
            // 
            // LucroLabel
            // 
            this.LucroLabel.AutoSize = true;
            this.LucroLabel.Location = new System.Drawing.Point(128, 81);
            this.LucroLabel.Name = "LucroLabel";
            this.LucroLabel.Size = new System.Drawing.Size(0, 15);
            this.LucroLabel.TabIndex = 54;
            // 
            // ComplementoLista
            // 
            this.ComplementoLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComplementoColuna,
            this.PrecoColuna,
            IdColuna,
            CustoColuna,
            LucroColuna,
            MargemColuna});
            this.ComplementoLista.HideSelection = false;
            this.ComplementoLista.Location = new System.Drawing.Point(12, 115);
            this.ComplementoLista.Name = "ComplementoLista";
            this.ComplementoLista.Size = new System.Drawing.Size(429, 310);
            this.ComplementoLista.TabIndex = 53;
            this.ComplementoLista.UseCompatibleStateImageBehavior = false;
            this.ComplementoLista.View = System.Windows.Forms.View.Details;
            this.ComplementoLista.SelectedIndexChanged += new System.EventHandler(this.ComplementoLista_SelectedIndexChanged);
            // 
            // ComplementoColuna
            // 
            this.ComplementoColuna.Text = "Complemento";
            this.ComplementoColuna.Width = 320;
            // 
            // PrecoColuna
            // 
            this.PrecoColuna.Text = "Preço";
            this.PrecoColuna.Width = 100;
            // 
            // SalvaComplemento
            // 
            this.SalvaComplemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalvaComplemento.Location = new System.Drawing.Point(109, 439);
            this.SalvaComplemento.Name = "SalvaComplemento";
            this.SalvaComplemento.Size = new System.Drawing.Size(75, 23);
            this.SalvaComplemento.TabIndex = 43;
            this.SalvaComplemento.TabStop = false;
            this.SalvaComplemento.Text = "Salvar";
            this.SalvaComplemento.UseVisualStyleBackColor = true;
            this.SalvaComplemento.Click += new System.EventHandler(this.SalvaComplemento_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Lucro Bruto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Margem:";
            // 
            // CustoBox
            // 
            this.CustoBox.Location = new System.Drawing.Point(12, 77);
            this.CustoBox.Name = "CustoBox";
            this.CustoBox.Size = new System.Drawing.Size(109, 23);
            this.CustoBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Custo:";
            // 
            // PrecoBox
            // 
            this.PrecoBox.Location = new System.Drawing.Point(341, 28);
            this.PrecoBox.Name = "PrecoBox";
            this.PrecoBox.Size = new System.Drawing.Size(100, 23);
            this.PrecoBox.TabIndex = 38;
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(12, 28);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(323, 23);
            this.NomeBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Preço (venda):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nome:";
            // 
            // FechaComplemento
            // 
            this.FechaComplemento.Location = new System.Drawing.Point(350, 439);
            this.FechaComplemento.Name = "FechaComplemento";
            this.FechaComplemento.Size = new System.Drawing.Size(75, 23);
            this.FechaComplemento.TabIndex = 46;
            this.FechaComplemento.Text = "Fechar";
            this.FechaComplemento.UseVisualStyleBackColor = true;
            this.FechaComplemento.Click += new System.EventHandler(this.FechaComplemento_Click_1);
            // 
            // LimpaComplemento
            // 
            this.LimpaComplemento.Location = new System.Drawing.Point(269, 439);
            this.LimpaComplemento.Name = "LimpaComplemento";
            this.LimpaComplemento.Size = new System.Drawing.Size(75, 23);
            this.LimpaComplemento.TabIndex = 45;
            this.LimpaComplemento.Text = "Limpar";
            this.LimpaComplemento.UseVisualStyleBackColor = true;
            this.LimpaComplemento.Click += new System.EventHandler(this.LimpaComplemento_Click_1);
            // 
            // ExcluiComplemento
            // 
            this.ExcluiComplemento.Location = new System.Drawing.Point(189, 439);
            this.ExcluiComplemento.Name = "ExcluiComplemento";
            this.ExcluiComplemento.Size = new System.Drawing.Size(75, 23);
            this.ExcluiComplemento.TabIndex = 44;
            this.ExcluiComplemento.Text = "Excluir";
            this.ExcluiComplemento.UseVisualStyleBackColor = true;
            this.ExcluiComplemento.Click += new System.EventHandler(this.ExcluiComplemento_Click_1);
            // 
            // AdicionaComplemento
            // 
            this.AdicionaComplemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdicionaComplemento.Location = new System.Drawing.Point(28, 439);
            this.AdicionaComplemento.Name = "AdicionaComplemento";
            this.AdicionaComplemento.Size = new System.Drawing.Size(75, 23);
            this.AdicionaComplemento.TabIndex = 42;
            this.AdicionaComplemento.Text = "Adicionar";
            this.AdicionaComplemento.UseVisualStyleBackColor = true;
            this.AdicionaComplemento.Click += new System.EventHandler(this.AdicionaComplemento_Click_1);
            // 
            // ComplementoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 475);
            this.Controls.Add(this.MargemLabel);
            this.Controls.Add(this.LucroLabel);
            this.Controls.Add(this.ComplementoLista);
            this.Controls.Add(this.SalvaComplemento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecoBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaComplemento);
            this.Controls.Add(this.LimpaComplemento);
            this.Controls.Add(this.ExcluiComplemento);
            this.Controls.Add(this.AdicionaComplemento);
            this.Name = "ComplementoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Complemento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MargemLabel;
        private System.Windows.Forms.Label LucroLabel;
        private System.Windows.Forms.ListView ComplementoLista;
        private System.Windows.Forms.ColumnHeader ComplementoColuna;
        private System.Windows.Forms.ColumnHeader PrecoColuna;
        private System.Windows.Forms.Button SalvaComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecoBox;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FechaComplemento;
        private System.Windows.Forms.Button LimpaComplemento;
        private System.Windows.Forms.Button ExcluiComplemento;
        private System.Windows.Forms.Button AdicionaComplemento;
    }
}