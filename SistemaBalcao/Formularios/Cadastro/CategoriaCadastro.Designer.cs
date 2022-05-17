namespace SistemaBalcao.Formularios.Cadastro
{
    partial class CategoriaCadastro
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
            this.CategoriasLista = new System.Windows.Forms.ListView();
            this.CategoriaColum = new System.Windows.Forms.ColumnHeader();
            this.SalvaButton = new System.Windows.Forms.Button();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaButton = new System.Windows.Forms.Button();
            this.LimpaButton = new System.Windows.Forms.Button();
            this.ExcluiButton = new System.Windows.Forms.Button();
            this.AdicionaButton = new System.Windows.Forms.Button();
            IdColuna = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // IdColuna
            // 
            IdColuna.Text = "Id";
            IdColuna.Width = 0;
            // 
            // CategoriasLista
            // 
            this.CategoriasLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoriaColum,
            IdColuna});
            this.CategoriasLista.HideSelection = false;
            this.CategoriasLista.Location = new System.Drawing.Point(12, 61);
            this.CategoriasLista.Name = "CategoriasLista";
            this.CategoriasLista.Size = new System.Drawing.Size(359, 310);
            this.CategoriasLista.TabIndex = 42;
            this.CategoriasLista.UseCompatibleStateImageBehavior = false;
            this.CategoriasLista.View = System.Windows.Forms.View.Details;
            this.CategoriasLista.SelectedIndexChanged += new System.EventHandler(this.CategoriasLista_SelectedIndexChanged);
            // 
            // CategoriaColum
            // 
            this.CategoriaColum.Text = "Categoria";
            this.CategoriaColum.Width = 350;
            // 
            // SalvaButton
            // 
            this.SalvaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalvaButton.Location = new System.Drawing.Point(85, 377);
            this.SalvaButton.Name = "SalvaButton";
            this.SalvaButton.Size = new System.Drawing.Size(67, 23);
            this.SalvaButton.TabIndex = 37;
            this.SalvaButton.TabStop = false;
            this.SalvaButton.Text = "Salvar";
            this.SalvaButton.UseVisualStyleBackColor = true;
            this.SalvaButton.Click += new System.EventHandler(this.SalvaButton_Click);
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(12, 29);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(359, 23);
            this.NomeBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome:";
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(304, 377);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(67, 23);
            this.FechaButton.TabIndex = 40;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // LimpaButton
            // 
            this.LimpaButton.Location = new System.Drawing.Point(231, 377);
            this.LimpaButton.Name = "LimpaButton";
            this.LimpaButton.Size = new System.Drawing.Size(67, 23);
            this.LimpaButton.TabIndex = 39;
            this.LimpaButton.Text = "Limpar";
            this.LimpaButton.UseVisualStyleBackColor = true;
            this.LimpaButton.Click += new System.EventHandler(this.LimpaButton_Click);
            // 
            // ExcluiButton
            // 
            this.ExcluiButton.Location = new System.Drawing.Point(158, 377);
            this.ExcluiButton.Name = "ExcluiButton";
            this.ExcluiButton.Size = new System.Drawing.Size(67, 23);
            this.ExcluiButton.TabIndex = 38;
            this.ExcluiButton.Text = "Excluir";
            this.ExcluiButton.UseVisualStyleBackColor = true;
            this.ExcluiButton.Click += new System.EventHandler(this.ExcluiButton_Click);
            // 
            // AdicionaButton
            // 
            this.AdicionaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdicionaButton.Location = new System.Drawing.Point(12, 377);
            this.AdicionaButton.Name = "AdicionaButton";
            this.AdicionaButton.Size = new System.Drawing.Size(67, 23);
            this.AdicionaButton.TabIndex = 36;
            this.AdicionaButton.Text = "Adicionar";
            this.AdicionaButton.UseVisualStyleBackColor = true;
            this.AdicionaButton.Click += new System.EventHandler(this.AdicionaButton_Click);
            // 
            // CategoriaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 412);
            this.Controls.Add(this.CategoriasLista);
            this.Controls.Add(this.SalvaButton);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaButton);
            this.Controls.Add(this.LimpaButton);
            this.Controls.Add(this.ExcluiButton);
            this.Controls.Add(this.AdicionaButton);
            this.Name = "CategoriaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CategoriasLista;
        private System.Windows.Forms.ColumnHeader CategoriaColum;
        private System.Windows.Forms.Button SalvaButton;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.Button LimpaButton;
        private System.Windows.Forms.Button ExcluiButton;
        private System.Windows.Forms.Button AdicionaButton;
    }
}