namespace SistemaBalcao.Formularios.Relatorios
{
    partial class VendasDia
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
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.FechaButton = new System.Windows.Forms.Button();
            this.PgtoBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BuscaButton = new System.Windows.Forms.Button();
            this.VendasDiaList = new System.Windows.Forms.ListView();
            this.DataPedido = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.TipoPedido = new System.Windows.Forms.ColumnHeader();
            this.FormaPgto = new System.Windows.Forms.ColumnHeader();
            this.ValorTotal = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(478, 370);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(97, 23);
            this.TotalBox.TabIndex = 27;
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(257, 391);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(75, 34);
            this.FechaButton.TabIndex = 25;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // PgtoBox
            // 
            this.PgtoBox.FormattingEnabled = true;
            this.PgtoBox.Items.AddRange(new object[] {
            "Todos",
            "Cartão",
            "Dinheiro",
            "Pix",
            "Voucher"});
            this.PgtoBox.Location = new System.Drawing.Point(142, 12);
            this.PgtoBox.Name = "PgtoBox";
            this.PgtoBox.Size = new System.Drawing.Size(117, 23);
            this.PgtoBox.TabIndex = 32;
            this.PgtoBox.Text = "Todos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Forma de Pagamento:";
            // 
            // BuscaButton
            // 
            this.BuscaButton.Location = new System.Drawing.Point(265, 12);
            this.BuscaButton.Name = "BuscaButton";
            this.BuscaButton.Size = new System.Drawing.Size(75, 23);
            this.BuscaButton.TabIndex = 33;
            this.BuscaButton.Text = "Buscar";
            this.BuscaButton.UseVisualStyleBackColor = true;
            this.BuscaButton.Click += new System.EventHandler(this.BuscaButton_Click);
            // 
            // VendasDiaList
            // 
            this.VendasDiaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataPedido,
            this.Nome,
            this.TipoPedido,
            this.FormaPgto,
            this.ValorTotal});
            this.VendasDiaList.HideSelection = false;
            this.VendasDiaList.Location = new System.Drawing.Point(12, 41);
            this.VendasDiaList.Name = "VendasDiaList";
            this.VendasDiaList.Size = new System.Drawing.Size(563, 323);
            this.VendasDiaList.TabIndex = 36;
            this.VendasDiaList.UseCompatibleStateImageBehavior = false;
            this.VendasDiaList.View = System.Windows.Forms.View.Details;
            // 
            // DataPedido
            // 
            this.DataPedido.Text = "Data Pedido";
            this.DataPedido.Width = 100;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // TipoPedido
            // 
            this.TipoPedido.Text = "Tipo Pedido";
            this.TipoPedido.Width = 120;
            // 
            // FormaPgto
            // 
            this.FormaPgto.Text = "Forma de Pagamento";
            this.FormaPgto.Width = 130;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor Total";
            this.ValorTotal.Width = 120;
            // 
            // VendasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 427);
            this.Controls.Add(this.VendasDiaList);
            this.Controls.Add(this.BuscaButton);
            this.Controls.Add(this.PgtoBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.FechaButton);
            this.Name = "VendasDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendasDia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.ComboBox PgtoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BuscaButton;
        private System.Windows.Forms.ListView VendasDiaList;
        private System.Windows.Forms.ColumnHeader DataPedido;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader TipoPedido;
        private System.Windows.Forms.ColumnHeader FormaPgto;
        private System.Windows.Forms.ColumnHeader ValorTotal;
    }
}