using System;
using System.Windows.Forms;

namespace FlowerShop.UI.Admin
{
    public partial class fmAddInStock : Form
    {
        public int quantity = 1;

        public fmAddInStock()
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
            if (quantity > 999)
            {
                MessageBox.Show("Недопустимое значение!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            quantity--;
            txtQuantity.Text = quantity.ToString();
            if (quantity < 1)
            {
                MessageBox.Show("Недопустимое значение!");
            }
        }
    }
}
