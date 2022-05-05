namespace SistemaBalcao
{
    partial class NP_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefoneBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.LogradouroBox = new System.Windows.Forms.TextBox();
            this.BairroBox = new System.Windows.Forms.TextBox();
            this.CidadeBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TipoPedidoBox1 = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logradouro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade:";
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.Location = new System.Drawing.Point(12, 33);
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(157, 23);
            this.TelefoneBox.TabIndex = 5;
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(12, 79);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(346, 23);
            this.NomeBox.TabIndex = 6;
            // 
            // LogradouroBox
            // 
            this.LogradouroBox.Location = new System.Drawing.Point(12, 126);
            this.LogradouroBox.Name = "LogradouroBox";
            this.LogradouroBox.Size = new System.Drawing.Size(346, 23);
            this.LogradouroBox.TabIndex = 7;
            // 
            // BairroBox
            // 
            this.BairroBox.Location = new System.Drawing.Point(12, 173);
            this.BairroBox.Name = "BairroBox";
            this.BairroBox.Size = new System.Drawing.Size(157, 23);
            this.BairroBox.TabIndex = 8;
            // 
            // CidadeBox
            // 
            this.CidadeBox.Location = new System.Drawing.Point(187, 173);
            this.CidadeBox.Name = "CidadeBox";
            this.CidadeBox.Size = new System.Drawing.Size(171, 23);
            this.CidadeBox.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(187, 33);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // TipoPedidoBox1
            // 
            this.TipoPedidoBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPedidoBox1.FormattingEnabled = true;
            this.TipoPedidoBox1.Items.AddRange(new object[] {
            "Balcão",
            "Tele-Entrega"});
            this.TipoPedidoBox1.Location = new System.Drawing.Point(12, 226);
            this.TipoPedidoBox1.Name = "TipoPedidoBox1";
            this.TipoPedidoBox1.Size = new System.Drawing.Size(157, 23);
            this.TipoPedidoBox1.TabIndex = 11;
            // 
            // OkButton
            // 
            this.OkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkButton.Location = new System.Drawing.Point(187, 210);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 42);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Próximo";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelaButton
            // 
            this.CancelaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelaButton.Location = new System.Drawing.Point(283, 210);
            this.CancelaButton.Name = "CancelaButton";
            this.CancelaButton.Size = new System.Drawing.Size(75, 42);
            this.CancelaButton.TabIndex = 13;
            this.CancelaButton.Text = "Cancelar";
            this.CancelaButton.UseVisualStyleBackColor = true;
            this.CancelaButton.Click += new System.EventHandler(this.CancelaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Pedido:";
            // 
            // NP_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelaButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TipoPedidoBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CidadeBox);
            this.Controls.Add(this.BairroBox);
            this.Controls.Add(this.LogradouroBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NP_Cliente";
            this.Text = "Novo Pedido - Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefoneBox;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox LogradouroBox;
        private System.Windows.Forms.TextBox BairroBox;
        private System.Windows.Forms.TextBox CidadeBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox TipoPedidoBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelaButton;
        private System.Windows.Forms.Label label6;
    }
}