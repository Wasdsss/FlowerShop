using FlowerShop.CLasses;
using FlowerShop.UI.Main;
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

namespace FlowerShop
{
    public partial class fmAuthorization : Form
    {
        private int incorrectAnswer = 0;

        public fmAuthorization()
        {
            InitializeComponent();
            GetSettings();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void GetSettings()
        {
            txtLogin.Text = Properties.Settings.Default.login;
            txtPassword.Text = Properties.Settings.Default.password;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.login = txtLogin.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            User.UserRoleId = 4;
            fmMenu fmmenu = new fmMenu();
            this.Hide();
            fmmenu.Show();

            Greeting greeting = new Greeting();
            string welcomeMessage = greeting.Welcome();
            string message = $"{welcomeMessage} Гость!";
            MessageBox.Show(message, "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Authorization";
                    sqlCommand.Parameters.AddWithValue("@UserLogin", txtLogin.Text);
                    sqlCommand.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                    sqlCommand.Connection = connection;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            User.InitializeUser(reader);

                            fmMenu fmmenu = new fmMenu();
                            this.Hide();
                            fmmenu.Show();

                            Greeting greeting = new Greeting();
                            string welcomeMessage = greeting.Welcome();
                            string message = $"{welcomeMessage} {User.UserSurname} {User.UserName} {User.UserPatronymic}!";
                            MessageBox.Show(message, "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Неверное имя пользователя или пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        incorrectAnswer++;

                        if (incorrectAnswer > 4)
                        {
                            MessageBox.Show($"Блокировка возможности входа на 30 секунд.\n" + $"Пожалуйста, подождите!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnLogin.Enabled = false;
                            await Task.Delay(10000);
                            btnLogin.Enabled = true;
                        }
                        //reader.Close();
                    }
                    //connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void chkSave_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            GetSettings();
        }

        private void linklblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmRegistration fmreg = new fmRegistration();
            this.Hide();
            fmreg.Show();
        }
    }
}
