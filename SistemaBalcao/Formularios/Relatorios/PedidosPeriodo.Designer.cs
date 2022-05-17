namespace SistemaBalcao.Formularios.Relatorios
{
    partial class PedidosPeriodo
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
            this.PedidosPeriodoList = new System.Windows.Forms.ListView();
            this.DataPedido = new System.Windows.Forms.ColumnHeader();
            this.TipoPedido = new System.Windows.Forms.ColumnHeader();
            this.ValorTotal = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BuscaButton = new System.Windows.Forms.Button();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(283, 378);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(97, 23);
            this.TotalBox.TabIndex = 14;
            // 
            // PedidosPeriodoList
            // 
            this.PedidosPeriodoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataPedido,
            this.TipoPedido,
            this.ValorTotal});
            this.PedidosPeriodoList.HideSelection = false;
            this.PedidosPeriodoList.Location = new System.Drawing.Point(14, 63);
            this.PedidosPeriodoList.Name = "PedidosPeriodoList";
            this.PedidosPeriodoList.Size = new System.Drawing.Size(366, 309);
            this.PedidosPeriodoList.TabIndex = 13;
            this.PedidosPeriodoList.UseCompatibleStateImageBehavior = false;
            this.PedidosPeriodoList.View = System.Windows.Forms.View.Details;
            // 
            // DataPedido
            // 
            this.DataPedido.Text = "Data Pedido";
            this.DataPedido.Width = 120;
            // 
            // TipoPedido
            // 
            this.TipoPedido.Text = "Tipo Pedido";
            this.TipoPedido.Width = 120;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor Total";
            this.ValorTotal.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "De:";
            // 
            // FechaButton
            // 
            this.FechaButton.Location = new System.Drawing.Point(201, 411);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(75, 23);
            this.FechaButton.TabIndex = 10;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImprimirButton.Location = new System.Drawing.Point(120, 411);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirButton.TabIndex = 9;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // BuscaButton
            // 
            this.BuscaButton.Location = new System.Drawing.Point(283, 32);
            this.BuscaButton.Name = "BuscaButton";
            this.BuscaButton.Size = new System.Drawing.Size(97, 23);
            this.BuscaButton.TabIndex = 8;
            this.BuscaButton.Text = "Buscar";
            this.BuscaButton.UseVisualStyleBackColor = true;
            this.BuscaButton.Click += new System.EventHandler(this.BuscaButton_Click);
            // 
            // DataInicio
            // 
            this.DataInicio.Location = new System.Drawing.Point(14, 32);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(116, 23);
            this.DataInicio.TabIndex = 16;
            this.DataInicio.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // DataFim
            // 
            this.DataFim.Location = new System.Drawing.Point(153, 32);
            this.DataFim.Margin = new System.Windows.Forms.Padding(2);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(117, 23);
            this.DataFim.TabIndex = 18;
            this.DataFim.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Até";
            // 
            // PedidosPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.PedidosPeriodoList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscaButton);
            this.Name = "PedidosPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.ListView PedidosPeriodoList;
        private System.Windows.Forms.ColumnHeader TipoPedido;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button BuscaButton;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader DataPedido;
    }
}