namespace SistemaBalcao.Formularios.Relatorios
{
    partial class PedidosCliente
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
            this.BuscaButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.FechaButton = new System.Windows.Forms.Button();
            this.TelefoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PedidosClienteList = new System.Windows.Forms.ListView();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.TipoPedido = new System.Windows.Forms.ColumnHeader();
            this.ValorTotal = new System.Windows.Forms.ColumnHeader();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuscaButton
            // 
            this.BuscaButton.Location = new System.Drawing.Point(341, 27);
            this.BuscaButton.Name = "BuscaButton";
            this.BuscaButton.Size = new System.Drawing.Size(75, 23);
            this.BuscaButton.TabIndex = 0;
            this.BuscaButton.Text = "Buscar";
            this.BuscaButton.UseVisualStyleBackColor = true;
            this.BuscaButton.Click += new System.EventHandler(this.BuscaButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImprimirButton.Location = new System.Drawing.Point(137, 404);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirButton.TabIndex = 1;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(218, 404);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(75, 23);
            this.FechaButton.TabIndex = 2;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.Location = new System.Drawing.Point(12, 27);
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(323, 23);
            this.TelefoneBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o Telefone do cliente";
            // 
            // PedidosClienteList
            // 
            this.PedidosClienteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Nome,
            this.TipoPedido,
            this.ValorTotal});
            this.PedidosClienteList.HideSelection = false;
            this.PedidosClienteList.Location = new System.Drawing.Point(12, 56);
            this.PedidosClienteList.Name = "PedidosClienteList";
            this.PedidosClienteList.Size = new System.Drawing.Size(404, 309);
            this.PedidosClienteList.TabIndex = 5;
            this.PedidosClienteList.UseCompatibleStateImageBehavior = false;
            this.PedidosClienteList.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 130;
            // 
            // TipoPedido
            // 
            this.TipoPedido.Text = "Tipo Pedido";
            this.TipoPedido.Width = 100;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor Total";
            this.ValorTotal.Width = 90;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(319, 371);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(97, 23);
            this.TotalBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total";
            // 
            // PedidosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.PedidosClienteList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.FechaButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscaButton);
            this.Name = "PedidosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscaButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.TextBox TelefoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView PedidosClienteList;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader TipoPedido;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Data;
    }
}