using System;
using System.Windows.Forms;

namespace FlowerShop.UI.Main
{
    public partial class fmQuantity : Form
    {
        public int quantity = 1;

        public fmQuantity()
        {
            InitializeComponent();
            txtQuantity.Text = quantity.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string txtquantity = txtQuantity.Text;
            quantity = Convert.ToInt32(txtquantity);
            Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            txtQuantity.Text = quantity.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            quantity--;
            txtQuantity.Text = quantity.ToString();
            if (quantity <= 0)
            {
                MessageBox.Show("Значение не может быть меньше 1!");
                quantity = 1;
            }
        }
    }
}
