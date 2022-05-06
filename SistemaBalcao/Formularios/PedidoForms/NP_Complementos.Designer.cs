namespace SistemaBalcao.Formularios.PedidoForms
{
    partial class NP_Complementos
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
            this.FechaButton = new System.Windows.Forms.Button();
            this.ObservacoesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaButton
            // 
            this.FechaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FechaButton.Location = new System.Drawing.Point(321, 392);
            this.FechaButton.Name = "FechaButton";
            this.FechaButton.Size = new System.Drawing.Size(154, 46);
            this.FechaButton.TabIndex = 0;
            this.FechaButton.Text = "Fechar";
            this.FechaButton.UseVisualStyleBackColor = true;
            this.FechaButton.Click += new System.EventHandler(this.FechaButton_Click);
            // 
            // ObservacoesBox
            // 
            this.ObservacoesBox.Location = new System.Drawing.Point(12, 354);
            this.ObservacoesBox.Name = "ObservacoesBox";
            this.ObservacoesBox.Size = new System.Drawing.Size(463, 23);
            this.ObservacoesBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "OBSERVAÇÕES:";
            // 
            // NP_Complementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObservacoesBox);
            this.Controls.Add(this.FechaButton);
            this.Name = "NP_Complementos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NP_Complementos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FechaButton;
        private System.Windows.Forms.TextBox ObservacoesBox;
        private System.Windows.Forms.Label label1;
    }
}