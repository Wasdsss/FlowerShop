namespace FlowerShop.UI.Main
{
    partial class fmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRegWorker = new System.Windows.Forms.Button();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.cmbSortingDiscount = new System.Windows.Forms.ComboBox();
            this.cmbSortingPrice = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnAddInStock = new System.Windows.Forms.Button();
            this.pnlPhotoProduct = new System.Windows.Forms.Panel();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.pnlLogoName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.lblDiscountSize = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblCostWithDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblProductManufacturer = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPhotoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.pnlLogoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDiscount.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(943, 95);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTop.Controls.Add(this.btnReports);
            this.pnlTop.Controls.Add(this.btnRegWorker);
            this.pnlTop.Controls.Add(this.lblQuantityInStock);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.lblFullName);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSorting);
            this.pnlTop.Controls.Add(this.cmbSortingDiscount);
            this.pnlTop.Controls.Add(this.cmbSortingPrice);
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1049, 105);
            this.pnlTop.TabIndex = 3;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightCoral;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReports.Location = new System.Drawing.Point(854, 67);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(188, 31);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Посмотреть отчеты";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnRegWorker
            // 
            this.btnRegWorker.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegWorker.Location = new System.Drawing.Point(647, 67);
            this.btnRegWorker.Name = "btnRegWorker";
            this.btnRegWorker.Size = new System.Drawing.Size(201, 31);
            this.btnRegWorker.TabIndex = 7;
            this.btnRegWorker.Text = "Добавить доставщика";
            this.btnRegWorker.UseVisualStyleBackColor = false;
            this.btnRegWorker.Visible = false;
            this.btnRegWorker.Click += new System.EventHandler(this.btnRegWorker_Click);
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantityInStock.Location = new System.Drawing.Point(22, 73);
            this.lblQuantityInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(233, 18);
            this.lblQuantityInStock.TabIndex = 6;
            this.lblQuantityInStock.Text = "Наличие товаров на складе:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(35, 15);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 18);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Поиск товара";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(677, 26);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(103, 18);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Полное имя";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(25, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSorting.Location = new System.Drawing.Point(440, 16);
            this.lblSorting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(193, 18);
            this.lblSorting.TabIndex = 4;
            this.lblSorting.Text = "Отсортировать по цене";
            // 
            // cmbSortingDiscount
            // 
            this.cmbSortingDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSortingDiscount.FormattingEnabled = true;
            this.cmbSortingDiscount.Items.AddRange(new object[] {
            "Все товары",
            "Менее 10%",
            "Более 10%"});
            this.cmbSortingDiscount.Location = new System.Drawing.Point(193, 38);
            this.cmbSortingDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortingDiscount.Name = "cmbSortingDiscount";
            this.cmbSortingDiscount.Size = new System.Drawing.Size(213, 26);
            this.cmbSortingDiscount.TabIndex = 1;
            this.cmbSortingDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbSortingDiscount_SelectedIndexChanged);
            // 
            // cmbSortingPrice
            // 
            this.cmbSortingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSortingPrice.FormattingEnabled = true;
            this.cmbSortingPrice.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.cmbSortingPrice.Location = new System.Drawing.Point(439, 38);
            this.cmbSortingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortingPrice.Name = "cmbSortingPrice";
            this.cmbSortingPrice.Size = new System.Drawing.Size(194, 26);
            this.cmbSortingPrice.TabIndex = 2;
            this.cmbSortingPrice.SelectedIndexChanged += new System.EventHandler(this.cmbSortingPrice_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilter.Location = new System.Drawing.Point(190, 15);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(217, 18);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Отфильтровать по скидке";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.MistyRose;
            this.pnlBottom.Controls.Add(this.btnAddInStock);
            this.pnlBottom.Controls.Add(this.pnlPhotoProduct);
            this.pnlBottom.Controls.Add(this.pnlLogoName);
            this.pnlBottom.Controls.Add(this.pnlDiscount);
            this.pnlBottom.Controls.Add(this.pnlProduct);
            this.pnlBottom.Controls.Add(this.btnWork);
            this.pnlBottom.Controls.Add(this.btnCheckOrder);
            this.pnlBottom.Controls.Add(this.btnBack);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlBottom.Location = new System.Drawing.Point(0, 492);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1049, 130);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnAddInStock
            // 
            this.btnAddInStock.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddInStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddInStock.Location = new System.Drawing.Point(874, 60);
            this.btnAddInStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddInStock.Name = "btnAddInStock";
            this.btnAddInStock.Size = new System.Drawing.Size(172, 32);
            this.btnAddInStock.TabIndex = 17;
            this.btnAddInStock.Text = "Добавить на склад";
            this.btnAddInStock.UseVisualStyleBackColor = false;
            this.btnAddInStock.Visible = false;
            this.btnAddInStock.Click += new System.EventHandler(this.btnAddInStock_Click);
            // 
            // pnlPhotoProduct
            // 
            this.pnlPhotoProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhotoProduct.Controls.Add(this.pictureProduct);
            this.pnlPhotoProduct.Location = new System.Drawing.Point(193, 3);
            this.pnlPhotoProduct.Name = "pnlPhotoProduct";
            this.pnlPhotoProduct.Size = new System.Drawing.Size(170, 125);
            this.pnlPhotoProduct.TabIndex = 16;
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(3, 2);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(160, 118);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 13;
            this.pictureProduct.TabStop = false;
            // 
            // pnlLogoName
            // 
            this.pnlLogoName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogoName.Controls.Add(this.lblName);
            this.pnlLogoName.Controls.Add(this.picLogo);
            this.pnlLogoName.Location = new System.Drawing.Point(3, 2);
            this.pnlLogoName.Name = "pnlLogoName";
            this.pnlLogoName.Size = new System.Drawing.Size(183, 125);
            this.pnlLogoName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(4, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 22);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Магазин цветов";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = global::FlowerShop.Properties.Resources.logo;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(-1, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(182, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDiscount.Controls.Add(this.lblDiscountSize);
            this.pnlDiscount.Controls.Add(this.lblDiscount);
            this.pnlDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlDiscount.Location = new System.Drawing.Point(747, 2);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(300, 54);
            this.pnlDiscount.TabIndex = 14;
            // 
            // lblDiscountSize
            // 
            this.lblDiscountSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountSize.Location = new System.Drawing.Point(6, 0);
            this.lblDiscountSize.Name = "lblDiscountSize";
            this.lblDiscountSize.Size = new System.Drawing.Size(287, 22);
            this.lblDiscountSize.TabIndex = 8;
            this.lblDiscountSize.Text = "Размер скидки: ";
            this.lblDiscountSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.Location = new System.Drawing.Point(3, 22);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(287, 22);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Скидка";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProduct.Controls.Add(this.lblCostWithDiscount);
            this.pnlProduct.Controls.Add(this.lblCost);
            this.pnlProduct.Controls.Add(this.lblProductManufacturer);
            this.pnlProduct.Controls.Add(this.lblProductDescription);
            this.pnlProduct.Controls.Add(this.lblProductName);
            this.pnlProduct.Location = new System.Drawing.Point(369, 4);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(370, 125);
            this.pnlProduct.TabIndex = 13;
            // 
            // lblCostWithDiscount
            // 
            this.lblCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostWithDiscount.Location = new System.Drawing.Point(248, 100);
            this.lblCostWithDiscount.Name = "lblCostWithDiscount";
            this.lblCostWithDiscount.Size = new System.Drawing.Size(115, 22);
            this.lblCostWithDiscount.TabIndex = 12;
            this.lblCostWithDiscount.Text = "Цена со";
            this.lblCostWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCost.Location = new System.Drawing.Point(147, 101);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(115, 20);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Цена без скидки:  ";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductManufacturer
            // 
            this.lblProductManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductManufacturer.Location = new System.Drawing.Point(3, 99);
            this.lblProductManufacturer.Name = "lblProductManufacturer";
            this.lblProductManufacturer.Size = new System.Drawing.Size(162, 22);
            this.lblProductManufacturer.TabIndex = 9;
            this.lblProductManufacturer.Text = "Производитель: ";
            this.lblProductManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductDescription.Location = new System.Drawing.Point(3, 27);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(360, 74);
            this.lblProductDescription.TabIndex = 8;
            this.lblProductDescription.Text = "Описание товара: ";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(3, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(360, 23);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Наименование товара: ";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.LightCoral;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWork.Location = new System.Drawing.Point(747, 60);
            this.btnWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(124, 32);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Заказы";
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Visible = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheckOrder.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnCheckOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckOrder.Location = new System.Drawing.Point(747, 95);
            this.btnCheckOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(192, 32);
            this.btnCheckOrder.TabIndex = 1;
            this.btnCheckOrder.Text = "Посмотреть заказ";
            this.btnCheckOrder.UseVisualStyleBackColor = false;
            this.btnCheckOrder.Visible = false;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(25, 105);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1000, 387);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            this.dgvProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseClick);
            // 
            // cmsProducts
            // 
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateOrderToolStripMenuItem,
            this.AddProductToolStripMenuItem,
            this.DeleteProductToolStripMenuItem,
            this.ChangeDiscountToolStripMenuItem});
            this.cmsProducts.Name = "cmsProducts";
            this.cmsProducts.Size = new System.Drawing.Size(173, 92);
            // 
            // UpdateOrderToolStripMenuItem
            // 
            this.UpdateOrderToolStripMenuItem.Name = "UpdateOrderToolStripMenuItem";
            this.UpdateOrderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.UpdateOrderToolStripMenuItem.Text = "Добавить к заказу";
            this.UpdateOrderToolStripMenuItem.Visible = false;
            this.UpdateOrderToolStripMenuItem.Click += new System.EventHandler(this.UpdateOrderToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.AddProductToolStripMenuItem.Text = "Добавить товар";
            this.AddProductToolStripMenuItem.Visible = false;
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // DeleteProductToolStripMenuItem
            // 
            this.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem";
            this.DeleteProductToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.DeleteProductToolStripMenuItem.Text = "Удалить товар";
            this.DeleteProductToolStripMenuItem.Visible = false;
            this.DeleteProductToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolStripMenuItem_Click);
            // 
            // ChangeDiscountToolStripMenuItem
            // 
            this.ChangeDiscountToolStripMenuItem.Name = "ChangeDiscountToolStripMenuItem";
            this.ChangeDiscountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ChangeDiscountToolStripMenuItem.Text = "Изменить скидку";
            this.ChangeDiscountToolStripMenuItem.Visible = false;
            this.ChangeDiscountToolStripMenuItem.Click += new System.EventHandler(this.ChangeDiscountToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1025, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 387);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 387);
            this.panel2.TabIndex = 6;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMenu_FormClosed);
            this.Load += new System.EventHandler(this.fmMenu_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlPhotoProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.pnlLogoName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbSortingPrice;
        private System.Windows.Forms.ComboBox cmbSortingDiscount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblCostWithDiscount;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblProductManufacturer;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Label lblDiscountSize;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ContextMenuStrip cmsProducts;
        private System.Windows.Forms.ToolStripMenuItem UpdateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteProductToolStripMenuItem;
        private System.Windows.Forms.Button btnRegWorker;
        private System.Windows.Forms.Panel pnlLogoName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlPhotoProduct;
        private System.Windows.Forms.ToolStripMenuItem ChangeDiscountToolStripMenuItem;
        private System.Windows.Forms.Button btnAddInStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.PictureBox pictureProduct;
    }
}