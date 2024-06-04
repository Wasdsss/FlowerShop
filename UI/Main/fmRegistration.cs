using FlowerShop.CLasses;
using System;
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
    public partial class fmRegistration : Form
    {
        public fmRegistration()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fmAuthorization fmauth = new fmAuthorization();
            Close();
            fmauth.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty || txtPassword.Text == string.Empty || txtSurname.Text == string.Empty || txtName.Text == string.Empty || txtPatronymic.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (User.UserRoleId == 3)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "RegistrationWorker";
                        sqlCommand.Connection = connection;
                        sqlCommand.Parameters.AddWithValue("@UserLogin", txtLogin.Text);
                        sqlCommand.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                        sqlCommand.Parameters.AddWithValue("@UserSurname", txtSurname.Text);
                        sqlCommand.Parameters.AddWithValue("@UserName", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@UserPatronymic", txtPatronymic.Text);

                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show($"Регистрация сотрудника успешна!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                    fmMenu fmmenu = new fmMenu();
                    fmmenu.Show();
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "Registration";
                        sqlCommand.Connection = connection;
                        sqlCommand.Parameters.AddWithValue("@UserLogin", txtLogin.Text);
                        sqlCommand.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                        sqlCommand.Parameters.AddWithValue("@UserSurname", txtSurname.Text);
                        sqlCommand.Parameters.AddWithValue("@UserName", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@UserPatronymic", txtPatronymic.Text);

                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show($"Регистрация успешна!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fmAuthorization fmauth = new fmAuthorization();
                    Close();
                    fmauth.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void fmRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmAuthorization fmauthorization = new fmAuthorization();
            fmauthorization.Show();
        }
    }
}
