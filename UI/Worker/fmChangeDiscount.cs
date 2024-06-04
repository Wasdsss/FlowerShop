using FlowerShop.UI.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.UI.Worker
{
    public partial class fmChangeDiscount : Form
    {
        public int discount = 0;

        public fmChangeDiscount()
        {
            InitializeComponent();
            txtDiscount.Text = discount.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string txtdiscount = txtDiscount.Text;
            discount = Convert.ToInt32(txtdiscount);
            Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            discount++;
            txtDiscount.Text = discount.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            discount--;
            txtDiscount.Text = discount.ToString();
            if (discount < 0 && discount > 100)
            {
                MessageBox.Show("Недопустимое значение!");
            }
        }
    }
}
