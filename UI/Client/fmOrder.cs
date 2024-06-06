using FlowerShop.CLasses;
using FlowerShop.UI.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FlowerShop.UI.Main
{
    public partial class fmOrder : Form
    {
        public static List<Order> showOrder;

        public fmOrder(List<Order> order)
        {
            InitializeComponent();
            showOrder = order;
            ShowName();
            LoadOrder();
            GetFinallySum();
            lstOrder.HorizontalScrollbar = true;
            lstOrder.ClearSelected();
            //lstOrder.Items.Clear();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            var count =
                    from order in showOrder
                    group order by order.ProductId into productId
                    select new
                    {
                        ProductId = productId.Key,
                        Count = productId.Count(),
                    };
            DateTime now = DateTime.Now;
            int id;

            string Adress = "Ул. " + txtStreet.Text + ", д." + txtHouse.Text + ", кв." + txtFlat.Text;

            if (txtFlat.Text == string.Empty || txtHouse.Text == string.Empty || txtStreet.Text == string.Empty)
            {
                MessageBox.Show($"Введите корректный адрес!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mTxtTime.MaskCompleted)
            {
                Order.OrderDate = now;
                Order.OrderAdress = Adress;
                if (MessageBox.Show("Вы точно уверены в своём выборе? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                        {
                            connection.Open();
                            foreach (var items in count)
                            {
                                SqlCommand command1 = new SqlCommand();
                                command1.CommandType = CommandType.StoredProcedure;
                                command1.CommandText = "GetProductCount";
                                command1.Connection = connection;
                                command1.Parameters.AddWithValue("@count", items.Count);
                                command1.Parameters.AddWithValue("@productId", items.ProductId);
                                command1.ExecuteNonQuery();

                                DateTime date = DateTime.Parse(dtpDate.Text);
                                DateTime time = DateTime.Parse(mTxtTime.Text);
                                DateTime cmbDateTime = date.Date + time.TimeOfDay;
                                string cmbDateTimeString = cmbDateTime.ToString();
                                SqlCommand command2 = new SqlCommand();
                                command2.CommandType = CommandType.StoredProcedure;
                                command2.CommandText = "InsertOrder";
                                command2.Connection = connection;
                                if (User.UserRoleId == 4)
                                {
                                    command2.Parameters.AddWithValue("@OrderClient", DBNull.Value);
                                }
                                else
                                {
                                    command2.Parameters.AddWithValue("@OrderClient", User.UserId);
                                }
                                command2.Parameters.AddWithValue("@OrderDate", now);
                                command2.Parameters.AddWithValue("@OrderDeliveryDate", cmbDateTimeString);
                                command2.Parameters.AddWithValue("@OrderCost", Convert.ToDecimal(lblCostWithDiscount.Text));
                                command2.Parameters.AddWithValue("@OrderAdress", Adress);
                                command2.Parameters.AddWithValue("@OrderDiscount", Convert.ToInt32(lblCostDiscounts.Text));
                                id = (int)command2.ExecuteScalar();

                                SqlCommand command3 = new SqlCommand();
                                command3.CommandType = CommandType.StoredProcedure;
                                command3.CommandText = "InsertOrderProduct";
                                command3.Connection = connection;
                                command3.Parameters.AddWithValue("@OrderId", id);
                                command3.Parameters.AddWithValue("@ProductId", items.ProductId);
                                command3.Parameters.AddWithValue("@Quantity", items.Count);
                                command3.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                        MessageBox.Show($"Ваш заказ принят!\nМожете получить свой чек.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCheck.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOrder.SelectedItem != null)
                {
                    Order selectedOrder = (Order)lstOrder.SelectedItem;
                    string photoPath = selectedOrder.ProductPhoto;
                    picProduct.ImageLocation = photoPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить изображение!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowName()
        {
            if (User.UserRoleId == 4)
            {
                lblFullName.Text = " Вы находитесь в гостевом режиме!";
            }
            else
            {
                lblFullName.Text = $"Учетная запись: \n{User.UserSurname} {User.UserName} {User.UserPatronymic}!";
            }
        }

        private void GetFinallySum()
        {
            decimal sumWithDiscount = 0;
            int sumDiscount = 0;
            int productCount = 0;

            foreach (Order order in showOrder)
            {
                sumWithDiscount += Convert.ToDecimal(order.ProductCostWithDiscount);

                sumDiscount += Convert.ToInt32(order.ProductDiscount);
                productCount++;
            }
            int avgDiscount = sumDiscount / productCount;
            lblCostWithDiscount.Text = $"{sumWithDiscount}";
            lblCostDiscounts.Text = $"{avgDiscount}";
        }

        private void LoadOrder()
        {
            try
            {
                lstOrder.DataSource = showOrder
                    .GroupBy(o => new { o.ProductId, o.ProductName, o.ProductCost, o.ProductManufacturer, o.ProductCategory, o.ProductDiscount, o.ProductDescription, o.ProductCostWithDiscount, o.ProductPhoto })
                    .Select(group => new Order
                    {
                        ProductId = group.Key.ProductId,
                        ProductName = group.Key.ProductName,
                        ProductCost = group.Key.ProductCost,
                        ProductManufacturer = group.Key.ProductManufacturer,
                        ProductCategory = group.Key.ProductCategory,
                        ProductDiscount = group.Key.ProductDiscount,
                        ProductDescription = group.Key.ProductDescription,
                        ProductCostWithDiscount = group.Key.ProductCostWithDiscount,
                        ProductPhoto = group.Key.ProductPhoto,
                        Count = group.Count() 
                    })
                    .ToList();
                lstOrder.DisplayMember = "Values";
                GetFinallySum();

                if (lstOrder.Items.Count == 0)
                {
                    btnMakeOrder.Enabled = false;
                }
                else
                {
                    btnMakeOrder.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить товары!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstOrder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lstOrder.SelectedIndex = lstOrder.IndexFromPoint(e.Location);
                if (lstOrder.SelectedIndex != -1)
                {
                    cmsDeleteProduct.Show(lstOrder, e.Location); ;
                }
            }
        }

        private void DeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count != -1)
            {
                int selectedIndex = lstOrder.SelectedIndex;
                showOrder.RemoveAt(selectedIndex);
            }
            lstOrder.DataSource = null;
            LoadOrder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value < DateTime.Now)
            {
                dtpDate.MinDate = DateTime.Now;
                MessageBox.Show("Выберите корректную дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            fmCheck fmcheck = new fmCheck(showOrder);
            Close();
            fmcheck.ShowDialog();
            Show();
        }
    }
}
