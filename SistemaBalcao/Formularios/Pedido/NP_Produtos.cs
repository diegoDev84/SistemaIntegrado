using System;
using System.Windows.Forms;

namespace SistemaBalcao.Forms.Pedido
{
    public partial class NP_Produtos : Form
    {
        public NP_Produtos()
        {
            InitializeComponent();
        }

        private void CancelaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
