using FlowerShop.CLasses;
using FlowerShop.UI.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.UI.Main
{
    public partial class fmMenu : Form
    {
        public static List<Order> showOrder;

        public fmMenu()
        {
            InitializeComponent();
            ShowFunctionality();
            showOrder = new List<Order>();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowFunctionality()
        {
            switch (User.UserRoleId)
            {
                case 1:
                    lblFullName.Text = $" Учетная запись:\n{User.UserSurname} {User.UserName} {User.UserPatronymic}";
                    UpdateOrderToolStripMenuItem.Visible = true;
                    break;
                case 2:
                    lblFullName.Text = $" Учетная запись:\n{User.UserSurname} {User.UserName} {User.UserPatronymic}";
                    btnWork.Visible = true;
                    ChangeDiscountToolStripMenuItem.Visible = true;
                    break;
                case 3:
                    lblFullName.Text = $" Учетная запись: Администратор";
                    btnRegWorker.Visible = true;
                    DeleteProductToolStripMenuItem.Visible = true;
                    AddProductToolStripMenuItem.Visible = true;
                    break;
                case 4:
                    lblFullName.Text = $" Вы находитесь в гостевом режиме";
                    break;
            }
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            btnCheckOrder.Visible = false;

            using (var fmorder = new fmOrder(showOrder))
            {
                Hide();
                fmorder.ShowDialog();
                Show();
            }
        }

        private void ShowProducts()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    int selectedDiscount = cmbSortingDiscount.SelectedIndex;
                    DataTable datatable = new DataTable();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    connection.Open();

                    switch (selectedDiscount)
                    {
                        case 0:
                            command.CommandText = "GetProducts";
                            break;
                        case 1:
                            command.CommandText = "GetDiscountLessTen";
                            break;
                        case 2:
                            command.CommandText = "GetDiscountMoreTen";
                            break;
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    datatable.Load(reader);
                    dgvProducts.DataSource = datatable;
                    dgvProducts.Columns[0].Visible = false;
                    lblQuantityInStock.Text = $"Наличие товаров на складе: {dgvProducts.RowCount} из {datatable.Rows.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка!{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingsource = new BindingSource()
            {
                DataSource = dgvProducts.DataSource,
                Filter = "Название like '%" + txtSearch.Text + "%'"
            };
            dgvProducts.DataSource = bindingsource;
            lblQuantityInStock.Text = $"Количество товаров на складе: {dgvProducts.RowCount} из {dgvProducts.RowCount}";
        }

        private void cmbSortingPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSortingPrice.SelectedIndex == 0)
                {
                    dgvProducts.Sort(dgvProducts.Columns[3], ListSortDirection.Ascending);
                }
                else
                {
                    dgvProducts.Sort(dgvProducts.Columns[3], ListSortDirection.Descending);
                }
            }
            catch
            {
                MessageBox.Show("Для начала выберите диапозон скидок!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSortingDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                lblProductDescription.Text = dgvProducts.CurrentRow.Cells[9].Value.ToString();
                lblProductManufacturer.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                lblCost.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                lblCostWithDiscount.Text = dgvProducts.CurrentRow.Cells[10].Value.ToString();

                decimal cost = decimal.Parse(lblCost.Text);
                decimal costWithDiscoud = decimal.Parse(lblCostWithDiscount.Text);

                if (cost != costWithDiscoud)
                {
                    lblCost.Font = new Font(lblCost.Font, FontStyle.Strikeout);
                }
                else
                {
                    lblCost.Font = new Font(lblCost.Font, FontStyle.Regular);
                }

                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string productPhoto = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                string photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\Products\\{productPhoto}.jpg");

                if (File.Exists(photoPath))
                {
                    picProduct.ImageLocation = Path.Combine(projectDirectory, $"Resources\\Images\\Products\\{productPhoto}.jpg");
                }
                else
                {
                    picProduct.ImageLocation = Path.Combine(projectDirectory, $"Resources\\Images\\Icons and Logos\\picture.png");
                }
                lblDiscount.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvProducts.CurrentRow != null)
            {
                int currentRow = e.RowIndex;

                if (e.Button == MouseButtons.Right)
                {
                    if (currentRow >= 0)
                    {
                        dgvProducts.Rows[currentRow].Selected = true;
                        Point point = dgvProducts.PointToClient(Cursor.Position);
                        cmsProducts.Show(dgvProducts, point);
                    }
                }      
            }
            else
            {
                MessageBox.Show("Выберите товар!");
            }
        }

        private void UpdateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string quantityInStock = dgvProducts.CurrentRow.Cells[8].Value.ToString();
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string productPhoto = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            string photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\Products\\{productPhoto}.jpg");

            fmQuantity fmquantity = new fmQuantity();
            fmquantity.Show();

            if (quantityInStock != "0")
            {
                btnCheckOrder.Visible = true;
                try
                {
                    for (int i = 0; i < fmquantity.quantity; i++)
                    {
                        if (!File.Exists(photoPath))
                        {
                            photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\Icons and Logos\\picture.png");
                        }

                        Order order = new Order
                        {
                            ProductId = dgvProducts.CurrentRow.Cells[0].Value.ToString(),
                            ProductName = dgvProducts.CurrentRow.Cells[1].Value.ToString(),
                            ProductCost = dgvProducts.CurrentRow.Cells[3].Value.ToString(),
                            ProductManufacturer = dgvProducts.CurrentRow.Cells[5].Value.ToString(),
                            ProductCategory = dgvProducts.CurrentRow.Cells[6].Value.ToString(),
                            ProductDiscount = dgvProducts.CurrentRow.Cells[7].Value.ToString(),
                            ProductDescription = dgvProducts.CurrentRow.Cells[9].Value.ToString(),
                            ProductCostWithDiscount = dgvProducts.CurrentRow.Cells[10].Value.ToString(),
                            ProductPhoto = photoPath
                        };

                        if (showOrder == null)
                        {
                            showOrder = new List<Order>();
                        }

                        showOrder.Add(order);
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Товара нет в наличии!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            fmWork fmwork = new fmWork();
            Hide();
            fmwork.Show();
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAddProduct fmadd = new fmAddProduct();
            Hide();
            fmadd.Show();
        }

        private void DeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить данный товар? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "DeleteProduct";
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@ProductId", dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show($"Товар был успешно удалён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegWorker_Click(object sender, EventArgs e)
        {
            fmRegistration fmreg = new fmRegistration();
            Hide();
            fmreg.Show();
        }

        private void ChangeDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmChangeDiscount fmchangediscount = new fmChangeDiscount();
            if (fmchangediscount.ShowDialog() == DialogResult.OK)
            {
                int newDiscount = fmchangediscount.discount;
                try
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "UpdateDiscount";
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@ProductId", dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@NewDiscount", newDiscount);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show($"Скидка успешно изменена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка изменения скидки!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmAuthorization fmauth = new fmAuthorization();
            fmauth.Show();
        }

        private void fmMenu_Load(object sender, EventArgs e)
        {
            cmbSortingDiscount.SelectedIndex = 0;
            ShowProducts();
        }

        private void btnAddInStock_Click(object sender, EventArgs e)
        {
            int currentQuantity = Convert.ToInt32(dgvProducts.CurrentRow.Cells[2].Value);

            fmChangeDiscount fmchangediscount = new fmChangeDiscount();
            if (fmchangediscount.ShowDialog() == DialogResult.OK)
            {
                int newDiscount = fmchangediscount.discount;
                try
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "UpdateQuantityInStock";
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@ProductId", dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@Quantity", newDiscount);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show($"Скидка успешно изменена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка изменения скидки!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}