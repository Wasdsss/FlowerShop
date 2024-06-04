namespace FlowerShop
{
    partial class fmAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAuthorization));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.linklblRegistration = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(81, 5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.LightCoral;
            this.btnGuest.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuest.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuest.Location = new System.Drawing.Point(49, 44);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(222, 35);
            this.btnGuest.TabIndex = 1;
            this.btnGuest.Text = "Войти как гость";
            this.toolTip1.SetToolTip(this.btnGuest, "У вас не будет доступа к скидкам");
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Controls.Add(this.lblShopName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(318, 125);
            this.pnlTop.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = global::FlowerShop.Properties.Resources.logo;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(4, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(122, 117);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopName.Location = new System.Drawing.Point(135, 53);
            this.lblShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(145, 20);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Магазин цветов";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.MistyRose;
            this.pnlBottom.Controls.Add(this.btnLogin);
            this.pnlBottom.Controls.Add(this.btnGuest);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 342);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(318, 84);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(136, 143);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 18);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(49, 165);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(231, 24);
            this.txtLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(49, 231);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(132, 209);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Пароль";
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkShow.Location = new System.Drawing.Point(49, 263);
            this.chkShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(139, 20);
            this.chkShow.TabIndex = 8;
            this.chkShow.Text = "Показать пароль";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSave.Location = new System.Drawing.Point(49, 291);
            this.chkSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(133, 20);
            this.chkSave.TabIndex = 9;
            this.chkSave.Text = "Запомнить меня";
            this.chkSave.UseVisualStyleBackColor = true;
            this.chkSave.CheckedChanged += new System.EventHandler(this.chkSave_CheckedChanged);
            // 
            // linklblRegistration
            // 
            this.linklblRegistration.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linklblRegistration.AutoSize = true;
            this.linklblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linklblRegistration.LinkColor = System.Drawing.Color.Crimson;
            this.linklblRegistration.Location = new System.Drawing.Point(58, 316);
            this.linklblRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblRegistration.Name = "linklblRegistration";
            this.linklblRegistration.Size = new System.Drawing.Size(222, 18);
            this.linklblRegistration.TabIndex = 10;
            this.linklblRegistration.TabStop = true;
            this.linklblRegistration.Text = "Еще не зарегистрированы?";
            this.linklblRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegistration_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // fmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 426);
            this.Controls.Add(this.linklblRegistration);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fmAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.LinkLabel linklblRegistration;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

