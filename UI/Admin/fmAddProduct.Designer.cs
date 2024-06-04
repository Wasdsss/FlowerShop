namespace FlowerShop.UI.Main
{
    partial class fmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAddProduct));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPhotoProduct = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSavePhoto = new System.Windows.Forms.Button();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlShop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblShopName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtMaxDiscount = new System.Windows.Forms.TextBox();
            this.lblMaxDiscount = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.pnlPhotoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnlWork.SuspendLayout();
            this.pnlShop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(270, 85);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.MistyRose;
            this.pnlBottom.Controls.Add(this.pnlPhotoProduct);
            this.pnlBottom.Controls.Add(this.pnlWork);
            this.pnlBottom.Controls.Add(this.pnlShop);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 294);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(770, 138);
            this.pnlBottom.TabIndex = 18;
            // 
            // pnlPhotoProduct
            // 
            this.pnlPhotoProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhotoProduct.Controls.Add(this.picProduct);
            this.pnlPhotoProduct.Location = new System.Drawing.Point(192, 4);
            this.pnlPhotoProduct.Name = "pnlPhotoProduct";
            this.pnlPhotoProduct.Size = new System.Drawing.Size(162, 129);
            this.pnlPhotoProduct.TabIndex = 19;
            // 
            // picProduct
            // 
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.ErrorImage = null;
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.InitialImage = null;
            this.picProduct.Location = new System.Drawing.Point(0, 0);
            this.picProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(158, 125);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 19;
            this.picProduct.TabStop = false;
            // 
            // pnlWork
            // 
            this.pnlWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWork.Controls.Add(this.lblPath);
            this.pnlWork.Controls.Add(this.btnSavePhoto);
            this.pnlWork.Controls.Add(this.btnLoadPhoto);
            this.pnlWork.Controls.Add(this.btnBack);
            this.pnlWork.Controls.Add(this.btnAddProduct);
            this.pnlWork.Location = new System.Drawing.Point(360, 4);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(406, 129);
            this.pnlWork.TabIndex = 18;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.Location = new System.Drawing.Point(7, 54);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 18);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Имя";
            // 
            // btnSavePhoto
            // 
            this.btnSavePhoto.BackColor = System.Drawing.Color.LightCoral;
            this.btnSavePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePhoto.Location = new System.Drawing.Point(208, 9);
            this.btnSavePhoto.Name = "btnSavePhoto";
            this.btnSavePhoto.Size = new System.Drawing.Size(188, 33);
            this.btnSavePhoto.TabIndex = 2;
            this.btnSavePhoto.Text = "Сохранить фото";
            this.btnSavePhoto.UseVisualStyleBackColor = false;
            this.btnSavePhoto.Visible = false;
            this.btnSavePhoto.Click += new System.EventHandler(this.btnSavePhoto_Click);
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadPhoto.Location = new System.Drawing.Point(10, 9);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(192, 33);
            this.btnLoadPhoto.TabIndex = 1;
            this.btnLoadPhoto.Text = "Загрузить фото";
            this.btnLoadPhoto.UseVisualStyleBackColor = false;
            this.btnLoadPhoto.Visible = false;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.Location = new System.Drawing.Point(10, 85);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(252, 33);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlShop
            // 
            this.pnlShop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShop.Controls.Add(this.panel3);
            this.pnlShop.Controls.Add(this.label3);
            this.pnlShop.Controls.Add(this.pictureBox3);
            this.pnlShop.Location = new System.Drawing.Point(3, 3);
            this.pnlShop.Name = "pnlShop";
            this.pnlShop.Size = new System.Drawing.Size(184, 131);
            this.pnlShop.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblShopName);
            this.panel3.Controls.Add(this.picLogo);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 131);
            this.panel3.TabIndex = 17;
            // 
            // lblShopName
            // 
            this.lblShopName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopName.Location = new System.Drawing.Point(4, 106);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(170, 23);
            this.lblShopName.TabIndex = 10;
            this.lblShopName.Text = "Магазин цветов";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(180, 106);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Магазин цветов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTop.Controls.Add(this.lblFullName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(770, 51);
            this.pnlTop.TabIndex = 19;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(57, 18);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(103, 18);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Полное имя";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(398, 143);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(182, 132);
            this.txtDescription.TabIndex = 45;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(586, 146);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 18);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Описание";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.Location = new System.Drawing.Point(398, 104);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(182, 24);
            this.txtQuantity.TabIndex = 43;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(586, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(148, 18);
            this.lblQuantity.TabIndex = 42;
            this.lblQuantity.Text = "Кол-во на складе";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscount.Location = new System.Drawing.Point(398, 68);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(182, 24);
            this.txtDiscount.TabIndex = 41;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(586, 71);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(130, 18);
            this.lblDiscountAmount.TabIndex = 40;
            this.lblDiscountAmount.Text = "Действ. скидка";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCategory.Location = new System.Drawing.Point(20, 248);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(182, 24);
            this.txtCategory.TabIndex = 37;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategory.Location = new System.Drawing.Point(208, 251);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 18);
            this.lblCategory.TabIndex = 36;
            this.lblCategory.Text = "Категория";
            // 
            // txtMaxDiscount
            // 
            this.txtMaxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaxDiscount.Location = new System.Drawing.Point(20, 176);
            this.txtMaxDiscount.Name = "txtMaxDiscount";
            this.txtMaxDiscount.Size = new System.Drawing.Size(182, 24);
            this.txtMaxDiscount.TabIndex = 33;
            this.txtMaxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxDiscount
            // 
            this.lblMaxDiscount.AutoSize = true;
            this.lblMaxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxDiscount.Location = new System.Drawing.Point(208, 179);
            this.lblMaxDiscount.Name = "lblMaxDiscount";
            this.lblMaxDiscount.Size = new System.Drawing.Size(176, 18);
            this.lblMaxDiscount.TabIndex = 32;
            this.lblMaxDiscount.Text = "Макс. размер скидки";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCost.Location = new System.Drawing.Point(20, 140);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(182, 24);
            this.txtCost.TabIndex = 31;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCost.Location = new System.Drawing.Point(208, 143);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(154, 18);
            this.lblCost.TabIndex = 30;
            this.lblCost.Text = "Стоимость товара";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUnit.Location = new System.Drawing.Point(20, 104);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(182, 24);
            this.txtUnit.TabIndex = 29;
            this.txtUnit.Text = "шт.";
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ед. измерения";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(20, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 24);
            this.txtName.TabIndex = 27;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(208, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 18);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Наименование";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplier.Location = new System.Drawing.Point(208, 215);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(95, 18);
            this.lblSupplier.TabIndex = 34;
            this.lblSupplier.Text = "Поставщик";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSupplier.Location = new System.Drawing.Point(20, 212);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(182, 24);
            this.txtSupplier.TabIndex = 35;
            this.txtSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 432);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtMaxDiscount);
            this.Controls.Add(this.lblMaxDiscount);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmAddProduct_FormClosed);
            this.pnlBottom.ResumeLayout(false);
            this.pnlPhotoProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnlWork.ResumeLayout(false);
            this.pnlWork.PerformLayout();
            this.pnlShop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlShop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnSavePhoto;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Panel pnlPhotoProduct;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtMaxDiscount;
        private System.Windows.Forms.Label lblMaxDiscount;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblPath;
    }
}