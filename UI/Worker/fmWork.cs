﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.UI.Main
{
    public partial class fmWork : Form
    {
        public fmWork()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowOrders()
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
                            command.CommandText = "GetOrders";
                            break;
                        case 1:
                            command.CommandText = "GetOrdersDiscountLessTen";
                            break;
                        case 2:
                            command.CommandText = "GetOrdersDiscountMoreTen";
                            break;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    datatable.Load(reader);
                    dgvOrders.DataSource = datatable;
                    dgvOrders.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connectionString.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateOrder";
                    command.Connection = connectionString;
                    command.Parameters.AddWithValue("@OrderStatus", cmbStatus.SelectedItem);
                    command.Parameters.AddWithValue("@OrderId", dgvOrders.CurrentRow.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    connectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSortingPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSortingPrice.SelectedIndex == 0)
                {
                    dgvOrders.Sort(dgvOrders.Columns[7], ListSortDirection.Ascending);
                }
                else
                {
                    dgvOrders.Sort(dgvOrders.Columns[7], ListSortDirection.Descending);
                }
            }
            catch
            {
                MessageBox.Show("Для начала выберите диапозон скидок!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSortingDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void dgvOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentRow = e.RowIndex;

            if (e.Button == MouseButtons.Left)
            {
                if (currentRow >= 0)
                {
                    dgvOrders.Rows[currentRow].Selected = true;
                    cmbStatus.Text = dgvOrders.CurrentRow.Cells[6].Value.ToString().Trim();
                }
            }
        }

        private void fmWork_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmAuthorization fmauthorization = new fmAuthorization();
            fmauthorization.Show();
        }

        private void fmWork_Load(object sender, EventArgs e)
        {
            cmbSortingDiscount.SelectedIndex = 0;
            ShowOrders();
        }
    }
}
