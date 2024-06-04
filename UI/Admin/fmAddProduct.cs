using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowerShop.UI.Main
{
    public partial class fmAddProduct : Form
    {
        public fmAddProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fmMenu fmmenu = new fmMenu();
            Close();
            fmmenu.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtCost.Text == string.Empty || txtMaxDiscount.Text == string.Empty || txtSupplier.Text == string.Empty || txtCategory.Text == string.Empty
                || txtDiscount.Text == string.Empty || txtQuantity.Text == string.Empty || txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddProduct";
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@ProductName", txtName.Text.ToString());
                    command.Parameters.AddWithValue("@ProductUnitOfMeasurement", txtUnit.Text.ToString());
                    command.Parameters.AddWithValue("@ProductCost", Convert.ToDecimal(txtCost.Text.ToString()));
                    command.Parameters.AddWithValue("@ProductMaxDiscount", Convert.ToInt32(txtMaxDiscount.Text.ToString()));
                    command.Parameters.AddWithValue("@ProductSupplier", txtSupplier.Text.ToString());
                    command.Parameters.AddWithValue("@ProductCategory", txtCategory.Text.ToString());
                    command.Parameters.AddWithValue("@ProductDiscount", Convert.ToInt32(txtDiscount.Text.ToString()));
                    command.Parameters.AddWithValue("@ProductQuantityInStock", Convert.ToInt32(txtQuantity.Text.ToString()));
                    command.Parameters.AddWithValue("@ProductDescription", txtDescription.Text.ToString());
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show($"Товар был успешно добавление!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoadPhoto.Visible = true;
                btnSavePhoto.Visible = true;
            }
            catch
            {
                MessageBox.Show($"Ошибка добавления товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                ofd.FilterIndex = 2;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picProduct.Image = Image.FromFile(ofd.FileName);
                    lblPath.Text = ofd.SafeFileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления фото!{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePhoto_Click(object sender, EventArgs e)
        {
            if (picProduct.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                picProduct.Image.Save(memoryStream, picProduct.Image.RawFormat);
                byte[] a = memoryStream.GetBuffer();
                memoryStream.Close();
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddPhoto";
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@ProductPhoto", lblPath.Text);
                    command.Parameters.AddWithValue("@ProductName", txtName.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    lblPath.Text = "";
                    picProduct.Image = null;
                    Clear();
                }
                MessageBox.Show($"Фото товара успешно добавлено!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear()
        {
            txtName.Clear();
            txtCost.Clear();
            txtDescription.Clear();
            txtCategory.Clear();
            txtDiscount.Clear();
            txtMaxDiscount.Clear();
            txtSupplier.Clear();
            txtQuantity.Clear();
        }

        private void fmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmAuthorization fmauth = new fmAuthorization();
            fmauth.Show();
        }
    }
}
