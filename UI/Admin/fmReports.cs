using FlowerShop.UI.Main;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlowerShop.UI.Admin
{
    public partial class fmReports : Form
    {
        public fmReports()
        {
            InitializeComponent();
        }

        private void fmReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmAuthorization fmauth = new fmAuthorization();
            fmauth.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fmMenu fmmenu = new fmMenu();
            Close();
            fmmenu.Show();
        }

        private void ShowHistory()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    connection.Open();
                    int selectedHistory = cmbReports.SelectedIndex;
                    DataTable datatable = new DataTable();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    DateTime dtpfrom = dtpFrom.Value;
                    DateTime dtpbefore = dtpBefore.Value;

                    switch (selectedHistory)
                    {
                        case 0:
                            command.CommandText = "GetCurrentOrders";
                            command.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dtpfrom;
                            command.Parameters.Add("@DateBefore", SqlDbType.DateTime).Value = dtpbefore;
                            break;
                        case 1:
                            command.CommandText = "GetCompletedOrders";
                            command.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dtpfrom;
                            command.Parameters.Add("@DateBefore", SqlDbType.DateTime).Value = dtpbefore;
                            break;
                        case 2:
                            command.CommandText = "GetHistory";
                            command.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dtpfrom;
                            command.Parameters.Add("@DateBefore", SqlDbType.DateTime).Value = dtpbefore;
                            break;
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    datatable.Load(reader);
                    dgvReports.DataSource = datatable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка!{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHistory();
        }

        private void fmReports_Load(object sender, EventArgs e)
        {
            cmbReports.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddDays(-10);
            dtpBefore.MaxDate = DateTime.Now;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }
    }
}
