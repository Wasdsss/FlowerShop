namespace FlowerShop.UI.Client
{
    partial class fmCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCheck));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lstCheck = new System.Windows.Forms.ListBox();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.MistyRose;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.btnFeedback);
            this.pnlBottom.Controls.Add(this.pnlCheck);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 320);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(325, 247);
            this.pnlBottom.TabIndex = 19;
            // 
            // pnlCheck
            // 
            this.pnlCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCheck.Controls.Add(this.lblInfo);
            this.pnlCheck.Controls.Add(this.lblAdress);
            this.pnlCheck.Controls.Add(this.lblDiscount);
            this.pnlCheck.Controls.Add(this.lblCost);
            this.pnlCheck.Controls.Add(this.lblOrderDate);
            this.pnlCheck.Location = new System.Drawing.Point(3, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(315, 187);
            this.pnlCheck.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(49, 5);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(201, 25);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Информация о заказе:";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdress.Location = new System.Drawing.Point(6, 124);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(292, 60);
            this.lblAdress.TabIndex = 23;
            this.lblAdress.Text = "Адрес доставки: ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.Location = new System.Drawing.Point(5, 98);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(292, 22);
            this.lblDiscount.TabIndex = 22;
            this.lblDiscount.Text = "Общая скидка: ";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCost.Location = new System.Drawing.Point(5, 71);
            this.lblCost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(292, 22);
            this.lblCost.TabIndex = 21;
            this.lblCost.Text = "Сумма заказа: ";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(5, 45);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(293, 22);
            this.lblOrderDate.TabIndex = 20;
            this.lblOrderDate.Text = "Дата заказа:";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Controls.Add(this.lblShopName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(325, 118);
            this.pnlTop.TabIndex = 20;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = global::FlowerShop.Properties.Resources.logo;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(117, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopName.Location = new System.Drawing.Point(126, 50);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(145, 20);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Магазин цветов";
            // 
            // lstCheck
            // 
            this.lstCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstCheck.FormattingEnabled = true;
            this.lstCheck.ItemHeight = 16;
            this.lstCheck.Location = new System.Drawing.Point(0, 118);
            this.lstCheck.Name = "lstCheck";
            this.lstCheck.Size = new System.Drawing.Size(325, 202);
            this.lstCheck.TabIndex = 21;
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.LightCoral;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFeedback.Location = new System.Drawing.Point(42, 201);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(239, 32);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "Оставить отзыв";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // fmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 567);
            this.Controls.Add(this.lstCheck);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmCheck";
            this.Text = "Чек";
            this.pnlBottom.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.ListBox lstCheck;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Button btnFeedback;
    }
}