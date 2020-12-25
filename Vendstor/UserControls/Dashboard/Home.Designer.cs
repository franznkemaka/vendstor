using System;

namespace Vendstor.UserControls.Dashboard
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.cardRevenue = new Bunifu.Framework.UI.BunifuCards();
            this.picRevenuePtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRevenuePtg = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.text_TotalRevenue_Card = new System.Windows.Forms.Label();
            this.imgpnlRevenue = new System.Windows.Forms.Panel();
            this.imgbtnTotalRevenue = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardProducts = new Bunifu.Framework.UI.BunifuCards();
            this.picProductsPtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProductsPtg = new System.Windows.Forms.Label();
            this.imgpnlProducts = new System.Windows.Forms.Panel();
            this.imgbtnProducts = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnTotalProducts = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_TotalProducts = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.text_Products_Card = new System.Windows.Forms.Label();
            this.cardSales = new Bunifu.Framework.UI.BunifuCards();
            this.picSalesCountPtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSalesCountPtg = new System.Windows.Forms.Label();
            this.imgpnlSales = new System.Windows.Forms.Panel();
            this.imgbtnSales = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnSalesDate = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_WeeklySales = new System.Windows.Forms.Label();
            this.lblSalesCount = new System.Windows.Forms.Label();
            this.text_Sales_Card = new System.Windows.Forms.Label();
            this.cardCustomers = new Bunifu.Framework.UI.BunifuCards();
            this.picCustomersCountPtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCustomersCountPtg = new System.Windows.Forms.Label();
            this.imgpnlCustomers = new System.Windows.Forms.Panel();
            this.imgbtnCustomers = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnTotalCustomers = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_TotalCustomers = new System.Windows.Forms.Label();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.text_Customers_Card = new System.Windows.Forms.Label();
            this.cardTopSoldProducts = new Bunifu.Framework.UI.BunifuCards();
            this.TopSoldProductsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.imgVectorEmptyProducts = new Bunifu.Framework.UI.BunifuImageButton();
            this.text_TopSoldProducts = new System.Windows.Forms.Label();
            this.cardStatistics = new Bunifu.Framework.UI.BunifuCards();
            this.tbtnMonthlySalesPtg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cpgbSalesPtg_XS = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.text_ThisMonth = new System.Windows.Forms.Label();
            this.lblMonthlySalesAmount = new System.Windows.Forms.Label();
            this.card = new Bunifu.Framework.UI.BunifuCards();
            this.cardReview = new Bunifu.Framework.UI.BunifuCards();
            this.text_WeeklyCustomerSales_R = new System.Windows.Forms.Label();
            this.text_AverageWeeklyProfit_R = new System.Windows.Forms.Label();
            this.lblAmtTotalProfit_R = new System.Windows.Forms.Label();
            this.text_TotalProfit_R = new System.Windows.Forms.Label();
            this.sep1_R = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblAmtMemberProfit_R = new System.Windows.Forms.Label();
            this.text_MemberProfit_R = new System.Windows.Forms.Label();
            this.cardDailyRevenue = new Bunifu.Framework.UI.BunifuCards();
            this.pnlChartDailyRevenure = new System.Windows.Forms.Panel();
            this.chartDailyRevenueHost = new System.Windows.Forms.Integration.ElementHost();
            this.chartDailyRevenue = new LiveCharts.Wpf.CartesianChart();
            this.text_UpdateTimeago_DR = new System.Windows.Forms.Label();
            this.picTimeAgo_DR = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDailyRevenueComment = new System.Windows.Forms.Label();
            this.picDailyRevenurePtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDailyRevenurePtg = new System.Windows.Forms.Label();
            this.Seperator_DR = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_DailyRevenue = new System.Windows.Forms.Label();
            this.cardDailySales = new Bunifu.Framework.UI.BunifuCards();
            this.pnlChartDailySales = new System.Windows.Forms.Panel();
            this.chartDailySalesHost = new System.Windows.Forms.Integration.ElementHost();
            this.chartDailySales = new LiveCharts.Wpf.CartesianChart();
            this.text_UpdateTimeago_DS = new System.Windows.Forms.Label();
            this.picTimeAgo_DS = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDailySalesComment = new System.Windows.Forms.Label();
            this.picDailySalesPtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblDailySalesPtg = new System.Windows.Forms.Label();
            this.Seperator_DS = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_DailySales = new System.Windows.Forms.Label();
            this.cardWeeklyCustomers = new Bunifu.Framework.UI.BunifuCards();
            this.pnlChartWeeklyCustomers = new System.Windows.Forms.Panel();
            this.chartWeeklyCustomersHost = new System.Windows.Forms.Integration.ElementHost();
            this.chartWeeklyCustomers = new LiveCharts.Wpf.CartesianChart();
            this.text_UpdateTimeago_WC = new System.Windows.Forms.Label();
            this.picTimeAgo_WC = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblWeeklyCustomersComment = new System.Windows.Forms.Label();
            this.picWeeklyCustomersPtg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblWeeklyCustomersPtg = new System.Windows.Forms.Label();
            this.Seperator_WC = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_WeeklyCustomers = new System.Windows.Forms.Label();
            this.pgbLoading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.cardRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenuePtg)).BeginInit();
            this.imgpnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalRevenue)).BeginInit();
            this.cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductsPtg)).BeginInit();
            this.imgpnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalProducts)).BeginInit();
            this.cardSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalesCountPtg)).BeginInit();
            this.imgpnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSalesDate)).BeginInit();
            this.cardCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomersCountPtg)).BeginInit();
            this.imgpnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalCustomers)).BeginInit();
            this.cardTopSoldProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorEmptyProducts)).BeginInit();
            this.cardStatistics.SuspendLayout();
            this.cardReview.SuspendLayout();
            this.cardDailyRevenue.SuspendLayout();
            this.pnlChartDailyRevenure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_DR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDailyRevenurePtg)).BeginInit();
            this.cardDailySales.SuspendLayout();
            this.pnlChartDailySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDailySalesPtg)).BeginInit();
            this.cardWeeklyCustomers.SuspendLayout();
            this.pnlChartWeeklyCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_WC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeeklyCustomersPtg)).BeginInit();
            this.pnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardRevenue
            // 
            this.cardRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardRevenue.BackColor = System.Drawing.Color.White;
            this.cardRevenue.BorderRadius = 10;
            this.cardRevenue.BottomSahddow = true;
            this.cardRevenue.color = System.Drawing.Color.Transparent;
            this.cardRevenue.Controls.Add(this.picRevenuePtg);
            this.cardRevenue.Controls.Add(this.lblRevenuePtg);
            this.cardRevenue.Controls.Add(this.lblTotalRevenue);
            this.cardRevenue.Controls.Add(this.text_TotalRevenue_Card);
            this.cardRevenue.Controls.Add(this.imgpnlRevenue);
            this.cardRevenue.LeftSahddow = false;
            this.cardRevenue.Location = new System.Drawing.Point(17, 12);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.RightSahddow = true;
            this.cardRevenue.ShadowDepth = 10;
            this.cardRevenue.Size = new System.Drawing.Size(324, 131);
            this.cardRevenue.TabIndex = 0;
            // 
            // picRevenuePtg
            // 
            this.picRevenuePtg.BackColor = System.Drawing.Color.Transparent;
            this.picRevenuePtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picRevenuePtg.ImageActive = null;
            this.picRevenuePtg.Location = new System.Drawing.Point(149, 33);
            this.picRevenuePtg.Name = "picRevenuePtg";
            this.picRevenuePtg.Size = new System.Drawing.Size(15, 15);
            this.picRevenuePtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRevenuePtg.TabIndex = 7;
            this.picRevenuePtg.TabStop = false;
            this.picRevenuePtg.Zoom = 10;
            // 
            // lblRevenuePtg
            // 
            this.lblRevenuePtg.AutoSize = true;
            this.lblRevenuePtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblRevenuePtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblRevenuePtg.Location = new System.Drawing.Point(131, 53);
            this.lblRevenuePtg.Name = "lblRevenuePtg";
            this.lblRevenuePtg.Size = new System.Drawing.Size(33, 25);
            this.lblRevenuePtg.TabIndex = 6;
            this.lblRevenuePtg.Text = "- %";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(168, 46);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(130, 48);
            this.lblTotalRevenue.TabIndex = 2;
            this.lblTotalRevenue.Text = "$65,650";
            // 
            // text_TotalRevenue_Card
            // 
            this.text_TotalRevenue_Card.AutoSize = true;
            this.text_TotalRevenue_Card.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TotalRevenue_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_TotalRevenue_Card.Location = new System.Drawing.Point(182, 18);
            this.text_TotalRevenue_Card.Name = "text_TotalRevenue_Card";
            this.text_TotalRevenue_Card.Size = new System.Drawing.Size(125, 28);
            this.text_TotalRevenue_Card.TabIndex = 1;
            this.text_TotalRevenue_Card.Text = "Total Revenue";
            // 
            // imgpnlRevenue
            // 
            this.imgpnlRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlRevenue.Controls.Add(this.imgbtnTotalRevenue);
            this.imgpnlRevenue.Location = new System.Drawing.Point(23, 18);
            this.imgpnlRevenue.Name = "imgpnlRevenue";
            this.imgpnlRevenue.Size = new System.Drawing.Size(49, 47);
            this.imgpnlRevenue.TabIndex = 8;
            // 
            // imgbtnTotalRevenue
            // 
            this.imgbtnTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTotalRevenue.Image = global::Vendstor.Properties.Resources.money_d_w;
            this.imgbtnTotalRevenue.ImageActive = null;
            this.imgbtnTotalRevenue.Location = new System.Drawing.Point(7, 6);
            this.imgbtnTotalRevenue.Name = "imgbtnTotalRevenue";
            this.imgbtnTotalRevenue.Size = new System.Drawing.Size(35, 35);
            this.imgbtnTotalRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTotalRevenue.TabIndex = 3;
            this.imgbtnTotalRevenue.TabStop = false;
            this.imgbtnTotalRevenue.Zoom = 10;
            // 
            // cardProducts
            // 
            this.cardProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardProducts.BackColor = System.Drawing.Color.White;
            this.cardProducts.BorderRadius = 10;
            this.cardProducts.BottomSahddow = true;
            this.cardProducts.color = System.Drawing.Color.Transparent;
            this.cardProducts.Controls.Add(this.picProductsPtg);
            this.cardProducts.Controls.Add(this.lblProductsPtg);
            this.cardProducts.Controls.Add(this.imgpnlProducts);
            this.cardProducts.Controls.Add(this.imgbtnTotalProducts);
            this.cardProducts.Controls.Add(this.text_TotalProducts);
            this.cardProducts.Controls.Add(this.lblProductsCount);
            this.cardProducts.Controls.Add(this.text_Products_Card);
            this.cardProducts.LeftSahddow = false;
            this.cardProducts.Location = new System.Drawing.Point(347, 12);
            this.cardProducts.Name = "cardProducts";
            this.cardProducts.RightSahddow = true;
            this.cardProducts.ShadowDepth = 10;
            this.cardProducts.Size = new System.Drawing.Size(324, 131);
            this.cardProducts.TabIndex = 3;
            // 
            // picProductsPtg
            // 
            this.picProductsPtg.BackColor = System.Drawing.Color.Transparent;
            this.picProductsPtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picProductsPtg.ImageActive = null;
            this.picProductsPtg.Location = new System.Drawing.Point(186, 33);
            this.picProductsPtg.Name = "picProductsPtg";
            this.picProductsPtg.Size = new System.Drawing.Size(15, 15);
            this.picProductsPtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductsPtg.TabIndex = 10;
            this.picProductsPtg.TabStop = false;
            this.picProductsPtg.Zoom = 10;
            // 
            // lblProductsPtg
            // 
            this.lblProductsPtg.AutoSize = true;
            this.lblProductsPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblProductsPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblProductsPtg.Location = new System.Drawing.Point(168, 53);
            this.lblProductsPtg.Name = "lblProductsPtg";
            this.lblProductsPtg.Size = new System.Drawing.Size(33, 25);
            this.lblProductsPtg.TabIndex = 9;
            this.lblProductsPtg.Text = "- %";
            // 
            // imgpnlProducts
            // 
            this.imgpnlProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.imgpnlProducts.Controls.Add(this.imgbtnProducts);
            this.imgpnlProducts.Location = new System.Drawing.Point(21, 18);
            this.imgpnlProducts.Name = "imgpnlProducts";
            this.imgpnlProducts.Size = new System.Drawing.Size(49, 47);
            this.imgpnlProducts.TabIndex = 9;
            // 
            // imgbtnProducts
            // 
            this.imgbtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnProducts.Image = global::Vendstor.Properties.Resources.products_dashboard_w;
            this.imgbtnProducts.ImageActive = null;
            this.imgbtnProducts.Location = new System.Drawing.Point(7, 6);
            this.imgbtnProducts.Name = "imgbtnProducts";
            this.imgbtnProducts.Size = new System.Drawing.Size(35, 35);
            this.imgbtnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnProducts.TabIndex = 3;
            this.imgbtnProducts.TabStop = false;
            this.imgbtnProducts.Zoom = 10;
            // 
            // imgbtnTotalProducts
            // 
            this.imgbtnTotalProducts.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTotalProducts.Image = global::Vendstor.Properties.Resources.total_w;
            this.imgbtnTotalProducts.ImageActive = null;
            this.imgbtnTotalProducts.Location = new System.Drawing.Point(21, 96);
            this.imgbtnTotalProducts.Name = "imgbtnTotalProducts";
            this.imgbtnTotalProducts.Size = new System.Drawing.Size(15, 15);
            this.imgbtnTotalProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTotalProducts.TabIndex = 7;
            this.imgbtnTotalProducts.TabStop = false;
            this.imgbtnTotalProducts.Zoom = 10;
            // 
            // text_TotalProducts
            // 
            this.text_TotalProducts.AutoSize = true;
            this.text_TotalProducts.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_TotalProducts.ForeColor = System.Drawing.Color.DarkGray;
            this.text_TotalProducts.Location = new System.Drawing.Point(42, 94);
            this.text_TotalProducts.Name = "text_TotalProducts";
            this.text_TotalProducts.Size = new System.Drawing.Size(110, 25);
            this.text_TotalProducts.TabIndex = 6;
            this.text_TotalProducts.Text = "Total Products";
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblProductsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductsCount.Location = new System.Drawing.Point(218, 46);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(80, 48);
            this.lblProductsCount.TabIndex = 2;
            this.lblProductsCount.Text = "1254";
            // 
            // text_Products_Card
            // 
            this.text_Products_Card.AutoSize = true;
            this.text_Products_Card.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Products_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Products_Card.Location = new System.Drawing.Point(216, 18);
            this.text_Products_Card.Name = "text_Products_Card";
            this.text_Products_Card.Size = new System.Drawing.Size(82, 28);
            this.text_Products_Card.TabIndex = 1;
            this.text_Products_Card.Text = "Products";
            // 
            // cardSales
            // 
            this.cardSales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardSales.BackColor = System.Drawing.Color.White;
            this.cardSales.BorderRadius = 10;
            this.cardSales.BottomSahddow = true;
            this.cardSales.color = System.Drawing.Color.Transparent;
            this.cardSales.Controls.Add(this.picSalesCountPtg);
            this.cardSales.Controls.Add(this.lblSalesCountPtg);
            this.cardSales.Controls.Add(this.imgpnlSales);
            this.cardSales.Controls.Add(this.imgbtnSalesDate);
            this.cardSales.Controls.Add(this.text_WeeklySales);
            this.cardSales.Controls.Add(this.lblSalesCount);
            this.cardSales.Controls.Add(this.text_Sales_Card);
            this.cardSales.LeftSahddow = false;
            this.cardSales.Location = new System.Drawing.Point(677, 12);
            this.cardSales.Name = "cardSales";
            this.cardSales.RightSahddow = true;
            this.cardSales.ShadowDepth = 10;
            this.cardSales.Size = new System.Drawing.Size(324, 131);
            this.cardSales.TabIndex = 3;
            // 
            // picSalesCountPtg
            // 
            this.picSalesCountPtg.BackColor = System.Drawing.Color.Transparent;
            this.picSalesCountPtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picSalesCountPtg.ImageActive = null;
            this.picSalesCountPtg.Location = new System.Drawing.Point(189, 33);
            this.picSalesCountPtg.Name = "picSalesCountPtg";
            this.picSalesCountPtg.Size = new System.Drawing.Size(15, 15);
            this.picSalesCountPtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalesCountPtg.TabIndex = 12;
            this.picSalesCountPtg.TabStop = false;
            this.picSalesCountPtg.Zoom = 10;
            // 
            // lblSalesCountPtg
            // 
            this.lblSalesCountPtg.AutoSize = true;
            this.lblSalesCountPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblSalesCountPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblSalesCountPtg.Location = new System.Drawing.Point(171, 53);
            this.lblSalesCountPtg.Name = "lblSalesCountPtg";
            this.lblSalesCountPtg.Size = new System.Drawing.Size(33, 25);
            this.lblSalesCountPtg.TabIndex = 11;
            this.lblSalesCountPtg.Text = "- %";
            // 
            // imgpnlSales
            // 
            this.imgpnlSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlSales.Controls.Add(this.imgbtnSales);
            this.imgpnlSales.Location = new System.Drawing.Point(19, 18);
            this.imgpnlSales.Name = "imgpnlSales";
            this.imgpnlSales.Size = new System.Drawing.Size(49, 47);
            this.imgpnlSales.TabIndex = 9;
            // 
            // imgbtnSales
            // 
            this.imgbtnSales.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSales.Image = global::Vendstor.Properties.Resources.sales_d_w;
            this.imgbtnSales.ImageActive = null;
            this.imgbtnSales.Location = new System.Drawing.Point(7, 6);
            this.imgbtnSales.Name = "imgbtnSales";
            this.imgbtnSales.Size = new System.Drawing.Size(35, 35);
            this.imgbtnSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSales.TabIndex = 3;
            this.imgbtnSales.TabStop = false;
            this.imgbtnSales.Zoom = 10;
            // 
            // imgbtnSalesDate
            // 
            this.imgbtnSalesDate.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnSalesDate.Image = global::Vendstor.Properties.Resources.calendar_f_w;
            this.imgbtnSalesDate.ImageActive = null;
            this.imgbtnSalesDate.Location = new System.Drawing.Point(19, 96);
            this.imgbtnSalesDate.Name = "imgbtnSalesDate";
            this.imgbtnSalesDate.Size = new System.Drawing.Size(15, 15);
            this.imgbtnSalesDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnSalesDate.TabIndex = 7;
            this.imgbtnSalesDate.TabStop = false;
            this.imgbtnSalesDate.Zoom = 10;
            // 
            // text_WeeklySales
            // 
            this.text_WeeklySales.AutoSize = true;
            this.text_WeeklySales.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_WeeklySales.ForeColor = System.Drawing.Color.DarkGray;
            this.text_WeeklySales.Location = new System.Drawing.Point(40, 94);
            this.text_WeeklySales.Name = "text_WeeklySales";
            this.text_WeeklySales.Size = new System.Drawing.Size(101, 25);
            this.text_WeeklySales.TabIndex = 6;
            this.text_WeeklySales.Text = "Weekly Sales";
            // 
            // lblSalesCount
            // 
            this.lblSalesCount.AutoSize = true;
            this.lblSalesCount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblSalesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSalesCount.Location = new System.Drawing.Point(211, 46);
            this.lblSalesCount.Name = "lblSalesCount";
            this.lblSalesCount.Size = new System.Drawing.Size(86, 48);
            this.lblSalesCount.TabIndex = 2;
            this.lblSalesCount.Text = "5678";
            // 
            // text_Sales_Card
            // 
            this.text_Sales_Card.AutoSize = true;
            this.text_Sales_Card.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Sales_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Sales_Card.Location = new System.Drawing.Point(243, 18);
            this.text_Sales_Card.Name = "text_Sales_Card";
            this.text_Sales_Card.Size = new System.Drawing.Size(54, 28);
            this.text_Sales_Card.TabIndex = 1;
            this.text_Sales_Card.Text = "Sales";
            // 
            // cardCustomers
            // 
            this.cardCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardCustomers.BackColor = System.Drawing.Color.White;
            this.cardCustomers.BorderRadius = 10;
            this.cardCustomers.BottomSahddow = true;
            this.cardCustomers.color = System.Drawing.Color.Transparent;
            this.cardCustomers.Controls.Add(this.picCustomersCountPtg);
            this.cardCustomers.Controls.Add(this.lblCustomersCountPtg);
            this.cardCustomers.Controls.Add(this.imgpnlCustomers);
            this.cardCustomers.Controls.Add(this.imgbtnTotalCustomers);
            this.cardCustomers.Controls.Add(this.text_TotalCustomers);
            this.cardCustomers.Controls.Add(this.lblCustomersCount);
            this.cardCustomers.Controls.Add(this.text_Customers_Card);
            this.cardCustomers.LeftSahddow = false;
            this.cardCustomers.Location = new System.Drawing.Point(1007, 12);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.RightSahddow = true;
            this.cardCustomers.ShadowDepth = 10;
            this.cardCustomers.Size = new System.Drawing.Size(324, 131);
            this.cardCustomers.TabIndex = 4;
            // 
            // picCustomersCountPtg
            // 
            this.picCustomersCountPtg.BackColor = System.Drawing.Color.Transparent;
            this.picCustomersCountPtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picCustomersCountPtg.ImageActive = null;
            this.picCustomersCountPtg.Location = new System.Drawing.Point(179, 33);
            this.picCustomersCountPtg.Name = "picCustomersCountPtg";
            this.picCustomersCountPtg.Size = new System.Drawing.Size(15, 15);
            this.picCustomersCountPtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomersCountPtg.TabIndex = 14;
            this.picCustomersCountPtg.TabStop = false;
            this.picCustomersCountPtg.Zoom = 10;
            // 
            // lblCustomersCountPtg
            // 
            this.lblCustomersCountPtg.AutoSize = true;
            this.lblCustomersCountPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblCustomersCountPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblCustomersCountPtg.Location = new System.Drawing.Point(161, 53);
            this.lblCustomersCountPtg.Name = "lblCustomersCountPtg";
            this.lblCustomersCountPtg.Size = new System.Drawing.Size(33, 25);
            this.lblCustomersCountPtg.TabIndex = 13;
            this.lblCustomersCountPtg.Text = "- %";
            // 
            // imgpnlCustomers
            // 
            this.imgpnlCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(98)))), ((int)(((byte)(224)))));
            this.imgpnlCustomers.Controls.Add(this.imgbtnCustomers);
            this.imgpnlCustomers.Location = new System.Drawing.Point(24, 18);
            this.imgpnlCustomers.Name = "imgpnlCustomers";
            this.imgpnlCustomers.Size = new System.Drawing.Size(49, 47);
            this.imgpnlCustomers.TabIndex = 9;
            // 
            // imgbtnCustomers
            // 
            this.imgbtnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnCustomers.Image = global::Vendstor.Properties.Resources.users_d_w;
            this.imgbtnCustomers.ImageActive = null;
            this.imgbtnCustomers.Location = new System.Drawing.Point(7, 6);
            this.imgbtnCustomers.Name = "imgbtnCustomers";
            this.imgbtnCustomers.Size = new System.Drawing.Size(35, 35);
            this.imgbtnCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCustomers.TabIndex = 3;
            this.imgbtnCustomers.TabStop = false;
            this.imgbtnCustomers.Zoom = 10;
            // 
            // imgbtnTotalCustomers
            // 
            this.imgbtnTotalCustomers.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTotalCustomers.Image = global::Vendstor.Properties.Resources.total_w;
            this.imgbtnTotalCustomers.ImageActive = null;
            this.imgbtnTotalCustomers.Location = new System.Drawing.Point(24, 96);
            this.imgbtnTotalCustomers.Name = "imgbtnTotalCustomers";
            this.imgbtnTotalCustomers.Size = new System.Drawing.Size(15, 15);
            this.imgbtnTotalCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTotalCustomers.TabIndex = 5;
            this.imgbtnTotalCustomers.TabStop = false;
            this.imgbtnTotalCustomers.Zoom = 10;
            // 
            // text_TotalCustomers
            // 
            this.text_TotalCustomers.AutoSize = true;
            this.text_TotalCustomers.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_TotalCustomers.ForeColor = System.Drawing.Color.DarkGray;
            this.text_TotalCustomers.Location = new System.Drawing.Point(45, 94);
            this.text_TotalCustomers.Name = "text_TotalCustomers";
            this.text_TotalCustomers.Size = new System.Drawing.Size(125, 25);
            this.text_TotalCustomers.TabIndex = 3;
            this.text_TotalCustomers.Text = "Total Customers";
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCustomersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomersCount.Location = new System.Drawing.Point(211, 46);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(86, 48);
            this.lblCustomersCount.TabIndex = 2;
            this.lblCustomersCount.Text = "5678";
            // 
            // text_Customers_Card
            // 
            this.text_Customers_Card.AutoSize = true;
            this.text_Customers_Card.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Customers_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Customers_Card.Location = new System.Drawing.Point(199, 18);
            this.text_Customers_Card.Name = "text_Customers_Card";
            this.text_Customers_Card.Size = new System.Drawing.Size(98, 28);
            this.text_Customers_Card.TabIndex = 1;
            this.text_Customers_Card.Text = "Customers";
            // 
            // cardTopSoldProducts
            // 
            this.cardTopSoldProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardTopSoldProducts.BackColor = System.Drawing.Color.White;
            this.cardTopSoldProducts.BorderRadius = 10;
            this.cardTopSoldProducts.BottomSahddow = true;
            this.cardTopSoldProducts.color = System.Drawing.Color.Transparent;
            this.cardTopSoldProducts.Controls.Add(this.TopSoldProductsGrid);
            this.cardTopSoldProducts.Controls.Add(this.imgVectorEmptyProducts);
            this.cardTopSoldProducts.Controls.Add(this.text_TopSoldProducts);
            this.cardTopSoldProducts.LeftSahddow = false;
            this.cardTopSoldProducts.Location = new System.Drawing.Point(16, 516);
            this.cardTopSoldProducts.Name = "cardTopSoldProducts";
            this.cardTopSoldProducts.RightSahddow = true;
            this.cardTopSoldProducts.ShadowDepth = 10;
            this.cardTopSoldProducts.Size = new System.Drawing.Size(435, 353);
            this.cardTopSoldProducts.TabIndex = 9;
            // 
            // TopSoldProductsGrid
            // 
            this.TopSoldProductsGrid.Location = new System.Drawing.Point(3, 53);
            this.TopSoldProductsGrid.Name = "TopSoldProductsGrid";
            this.TopSoldProductsGrid.Size = new System.Drawing.Size(417, 282);
            this.TopSoldProductsGrid.TabIndex = 3;
            // 
            // imgVectorEmptyProducts
            // 
            this.imgVectorEmptyProducts.BackColor = System.Drawing.Color.Transparent;
            this.imgVectorEmptyProducts.Image = global::Vendstor.Properties.Resources.vector_empty_colored;
            this.imgVectorEmptyProducts.ImageActive = null;
            this.imgVectorEmptyProducts.Location = new System.Drawing.Point(107, 92);
            this.imgVectorEmptyProducts.Name = "imgVectorEmptyProducts";
            this.imgVectorEmptyProducts.Size = new System.Drawing.Size(220, 168);
            this.imgVectorEmptyProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVectorEmptyProducts.TabIndex = 183;
            this.imgVectorEmptyProducts.TabStop = false;
            this.imgVectorEmptyProducts.Zoom = 10;
            // 
            // text_TopSoldProducts
            // 
            this.text_TopSoldProducts.AutoSize = true;
            this.text_TopSoldProducts.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_TopSoldProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_TopSoldProducts.Location = new System.Drawing.Point(19, 15);
            this.text_TopSoldProducts.Name = "text_TopSoldProducts";
            this.text_TopSoldProducts.Size = new System.Drawing.Size(212, 35);
            this.text_TopSoldProducts.TabIndex = 2;
            this.text_TopSoldProducts.Text = "Top 3 Sold Products";
            // 
            // cardStatistics
            // 
            this.cardStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.cardStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardStatistics.BorderRadius = 10;
            this.cardStatistics.BottomSahddow = true;
            this.cardStatistics.color = System.Drawing.Color.Transparent;
            this.cardStatistics.Controls.Add(this.tbtnMonthlySalesPtg);
            this.cardStatistics.Controls.Add(this.cpgbSalesPtg_XS);
            this.cardStatistics.Controls.Add(this.text_ThisMonth);
            this.cardStatistics.Controls.Add(this.lblMonthlySalesAmount);
            this.cardStatistics.LeftSahddow = false;
            this.cardStatistics.Location = new System.Drawing.Point(457, 516);
            this.cardStatistics.Name = "cardStatistics";
            this.cardStatistics.RightSahddow = true;
            this.cardStatistics.ShadowDepth = 10;
            this.cardStatistics.Size = new System.Drawing.Size(435, 172);
            this.cardStatistics.TabIndex = 10;
            // 
            // tbtnMonthlySalesPtg
            // 
            this.tbtnMonthlySalesPtg.ActiveBorderThickness = 1;
            this.tbtnMonthlySalesPtg.ActiveCornerRadius = 20;
            this.tbtnMonthlySalesPtg.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.tbtnMonthlySalesPtg.ActiveForecolor = System.Drawing.Color.White;
            this.tbtnMonthlySalesPtg.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.tbtnMonthlySalesPtg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.tbtnMonthlySalesPtg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbtnMonthlySalesPtg.BackgroundImage")));
            this.tbtnMonthlySalesPtg.ButtonText = "- %";
            this.tbtnMonthlySalesPtg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnMonthlySalesPtg.Font = new System.Drawing.Font("Poppins", 15F);
            this.tbtnMonthlySalesPtg.ForeColor = System.Drawing.Color.White;
            this.tbtnMonthlySalesPtg.IdleBorderThickness = 1;
            this.tbtnMonthlySalesPtg.IdleCornerRadius = 25;
            this.tbtnMonthlySalesPtg.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.tbtnMonthlySalesPtg.IdleForecolor = System.Drawing.Color.White;
            this.tbtnMonthlySalesPtg.IdleLineColor = System.Drawing.Color.White;
            this.tbtnMonthlySalesPtg.Location = new System.Drawing.Point(24, 112);
            this.tbtnMonthlySalesPtg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbtnMonthlySalesPtg.Name = "tbtnMonthlySalesPtg";
            this.tbtnMonthlySalesPtg.Size = new System.Drawing.Size(89, 55);
            this.tbtnMonthlySalesPtg.TabIndex = 6;
            this.tbtnMonthlySalesPtg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpgbSalesPtg_XS
            // 
            this.cpgbSalesPtg_XS.animated = true;
            this.cpgbSalesPtg_XS.animationIterval = 5;
            this.cpgbSalesPtg_XS.animationSpeed = 1;
            this.cpgbSalesPtg_XS.BackColor = System.Drawing.Color.Transparent;
            this.cpgbSalesPtg_XS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgbSalesPtg_XS.BackgroundImage")));
            this.cpgbSalesPtg_XS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgbSalesPtg_XS.ForeColor = System.Drawing.Color.White;
            this.cpgbSalesPtg_XS.LabelVisible = false;
            this.cpgbSalesPtg_XS.LineProgressThickness = 8;
            this.cpgbSalesPtg_XS.LineThickness = 5;
            this.cpgbSalesPtg_XS.Location = new System.Drawing.Point(270, 25);
            this.cpgbSalesPtg_XS.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgbSalesPtg_XS.MaxValue = 100;
            this.cpgbSalesPtg_XS.Name = "cpgbSalesPtg_XS";
            this.cpgbSalesPtg_XS.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpgbSalesPtg_XS.ProgressColor = System.Drawing.Color.White;
            this.cpgbSalesPtg_XS.Size = new System.Drawing.Size(116, 116);
            this.cpgbSalesPtg_XS.TabIndex = 5;
            this.cpgbSalesPtg_XS.Value = 18;
            // 
            // text_ThisMonth
            // 
            this.text_ThisMonth.AutoSize = true;
            this.text_ThisMonth.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ThisMonth.ForeColor = System.Drawing.Color.White;
            this.text_ThisMonth.Location = new System.Drawing.Point(28, 86);
            this.text_ThisMonth.Name = "text_ThisMonth";
            this.text_ThisMonth.Size = new System.Drawing.Size(97, 28);
            this.text_ThisMonth.TabIndex = 4;
            this.text_ThisMonth.Text = "This Month";
            // 
            // lblMonthlySalesAmount
            // 
            this.lblMonthlySalesAmount.AutoSize = true;
            this.lblMonthlySalesAmount.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblMonthlySalesAmount.ForeColor = System.Drawing.Color.White;
            this.lblMonthlySalesAmount.Location = new System.Drawing.Point(25, 38);
            this.lblMonthlySalesAmount.Name = "lblMonthlySalesAmount";
            this.lblMonthlySalesAmount.Size = new System.Drawing.Size(123, 48);
            this.lblMonthlySalesAmount.TabIndex = 3;
            this.lblMonthlySalesAmount.Text = "€ 00,00";
            // 
            // card
            // 
            this.card.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.card.BackColor = System.Drawing.Color.White;
            this.card.BorderRadius = 10;
            this.card.BottomSahddow = true;
            this.card.color = System.Drawing.Color.Transparent;
            this.card.LeftSahddow = false;
            this.card.Location = new System.Drawing.Point(898, 516);
            this.card.Name = "card";
            this.card.RightSahddow = true;
            this.card.ShadowDepth = 10;
            this.card.Size = new System.Drawing.Size(435, 353);
            this.card.TabIndex = 10;
            // 
            // cardReview
            // 
            this.cardReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardReview.BackColor = System.Drawing.Color.White;
            this.cardReview.BorderRadius = 10;
            this.cardReview.BottomSahddow = true;
            this.cardReview.color = System.Drawing.Color.Transparent;
            this.cardReview.Controls.Add(this.text_WeeklyCustomerSales_R);
            this.cardReview.Controls.Add(this.text_AverageWeeklyProfit_R);
            this.cardReview.Controls.Add(this.lblAmtTotalProfit_R);
            this.cardReview.Controls.Add(this.text_TotalProfit_R);
            this.cardReview.Controls.Add(this.sep1_R);
            this.cardReview.Controls.Add(this.lblAmtMemberProfit_R);
            this.cardReview.Controls.Add(this.text_MemberProfit_R);
            this.cardReview.LeftSahddow = false;
            this.cardReview.Location = new System.Drawing.Point(457, 694);
            this.cardReview.Name = "cardReview";
            this.cardReview.RightSahddow = true;
            this.cardReview.ShadowDepth = 10;
            this.cardReview.Size = new System.Drawing.Size(435, 172);
            this.cardReview.TabIndex = 11;
            // 
            // text_WeeklyCustomerSales_R
            // 
            this.text_WeeklyCustomerSales_R.AutoSize = true;
            this.text_WeeklyCustomerSales_R.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_WeeklyCustomerSales_R.ForeColor = System.Drawing.Color.DarkGray;
            this.text_WeeklyCustomerSales_R.Location = new System.Drawing.Point(19, 122);
            this.text_WeeklyCustomerSales_R.Name = "text_WeeklyCustomerSales_R";
            this.text_WeeklyCustomerSales_R.Size = new System.Drawing.Size(174, 25);
            this.text_WeeklyCustomerSales_R.TabIndex = 18;
            this.text_WeeklyCustomerSales_R.Text = "Weekly Customer Sales";
            // 
            // text_AverageWeeklyProfit_R
            // 
            this.text_AverageWeeklyProfit_R.AutoSize = true;
            this.text_AverageWeeklyProfit_R.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_AverageWeeklyProfit_R.ForeColor = System.Drawing.Color.DarkGray;
            this.text_AverageWeeklyProfit_R.Location = new System.Drawing.Point(19, 48);
            this.text_AverageWeeklyProfit_R.Name = "text_AverageWeeklyProfit_R";
            this.text_AverageWeeklyProfit_R.Size = new System.Drawing.Size(162, 25);
            this.text_AverageWeeklyProfit_R.TabIndex = 15;
            this.text_AverageWeeklyProfit_R.Text = "Average Weekly Profit";
            // 
            // lblAmtTotalProfit_R
            // 
            this.lblAmtTotalProfit_R.AutoSize = true;
            this.lblAmtTotalProfit_R.Font = new System.Drawing.Font("Poppins", 17.25F);
            this.lblAmtTotalProfit_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.lblAmtTotalProfit_R.Location = new System.Drawing.Point(307, 106);
            this.lblAmtTotalProfit_R.Name = "lblAmtTotalProfit_R";
            this.lblAmtTotalProfit_R.Size = new System.Drawing.Size(123, 41);
            this.lblAmtTotalProfit_R.TabIndex = 17;
            this.lblAmtTotalProfit_R.Text = "- € 00,00";
            // 
            // text_TotalProfit_R
            // 
            this.text_TotalProfit_R.AutoSize = true;
            this.text_TotalProfit_R.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TotalProfit_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_TotalProfit_R.Location = new System.Drawing.Point(17, 94);
            this.text_TotalProfit_R.Name = "text_TotalProfit_R";
            this.text_TotalProfit_R.Size = new System.Drawing.Size(100, 28);
            this.text_TotalProfit_R.TabIndex = 16;
            this.text_TotalProfit_R.Text = "Total  Profit";
            // 
            // sep1_R
            // 
            this.sep1_R.BackColor = System.Drawing.Color.Transparent;
            this.sep1_R.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.sep1_R.LineThickness = 1;
            this.sep1_R.Location = new System.Drawing.Point(18, 81);
            this.sep1_R.Name = "sep1_R";
            this.sep1_R.Size = new System.Drawing.Size(398, 10);
            this.sep1_R.TabIndex = 15;
            this.sep1_R.Transparency = 255;
            this.sep1_R.Vertical = false;
            // 
            // lblAmtMemberProfit_R
            // 
            this.lblAmtMemberProfit_R.AutoSize = true;
            this.lblAmtMemberProfit_R.Font = new System.Drawing.Font("Poppins", 17.25F);
            this.lblAmtMemberProfit_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.lblAmtMemberProfit_R.Location = new System.Drawing.Point(309, 11);
            this.lblAmtMemberProfit_R.Name = "lblAmtMemberProfit_R";
            this.lblAmtMemberProfit_R.Size = new System.Drawing.Size(126, 41);
            this.lblAmtMemberProfit_R.TabIndex = 6;
            this.lblAmtMemberProfit_R.Text = "+ € 00,00";
            // 
            // text_MemberProfit_R
            // 
            this.text_MemberProfit_R.AutoSize = true;
            this.text_MemberProfit_R.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MemberProfit_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_MemberProfit_R.Location = new System.Drawing.Point(17, 20);
            this.text_MemberProfit_R.Name = "text_MemberProfit_R";
            this.text_MemberProfit_R.Size = new System.Drawing.Size(123, 28);
            this.text_MemberProfit_R.TabIndex = 3;
            this.text_MemberProfit_R.Text = "Member Profit";
            // 
            // cardDailyRevenue
            // 
            this.cardDailyRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardDailyRevenue.BackColor = System.Drawing.Color.White;
            this.cardDailyRevenue.BorderRadius = 10;
            this.cardDailyRevenue.BottomSahddow = true;
            this.cardDailyRevenue.color = System.Drawing.Color.Transparent;
            this.cardDailyRevenue.Controls.Add(this.pnlChartDailyRevenure);
            this.cardDailyRevenue.Controls.Add(this.text_UpdateTimeago_DR);
            this.cardDailyRevenue.Controls.Add(this.picTimeAgo_DR);
            this.cardDailyRevenue.Controls.Add(this.lblDailyRevenueComment);
            this.cardDailyRevenue.Controls.Add(this.picDailyRevenurePtg);
            this.cardDailyRevenue.Controls.Add(this.lblDailyRevenurePtg);
            this.cardDailyRevenue.Controls.Add(this.Seperator_DR);
            this.cardDailyRevenue.Controls.Add(this.text_DailyRevenue);
            this.cardDailyRevenue.LeftSahddow = false;
            this.cardDailyRevenue.Location = new System.Drawing.Point(16, 149);
            this.cardDailyRevenue.Name = "cardDailyRevenue";
            this.cardDailyRevenue.RightSahddow = true;
            this.cardDailyRevenue.ShadowDepth = 10;
            this.cardDailyRevenue.Size = new System.Drawing.Size(435, 353);
            this.cardDailyRevenue.TabIndex = 12;
            // 
            // pnlChartDailyRevenure
            // 
            this.pnlChartDailyRevenure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.pnlChartDailyRevenure.Controls.Add(this.chartDailyRevenueHost);
            this.pnlChartDailyRevenure.Location = new System.Drawing.Point(18, 3);
            this.pnlChartDailyRevenure.Name = "pnlChartDailyRevenure";
            this.pnlChartDailyRevenure.Size = new System.Drawing.Size(398, 211);
            this.pnlChartDailyRevenure.TabIndex = 13;
            // 
            // chartDailyRevenueHost
            // 
            this.chartDailyRevenueHost.BackColor = System.Drawing.Color.White;
            this.chartDailyRevenueHost.Location = new System.Drawing.Point(14, 11);
            this.chartDailyRevenueHost.Name = "chartDailyRevenueHost";
            this.chartDailyRevenueHost.Size = new System.Drawing.Size(371, 189);
            this.chartDailyRevenueHost.TabIndex = 15;
            this.chartDailyRevenueHost.Text = "elementHost1";
            this.chartDailyRevenueHost.Child = this.chartDailyRevenue;
            // 
            // text_UpdateTimeago_DR
            // 
            this.text_UpdateTimeago_DR.AutoSize = true;
            this.text_UpdateTimeago_DR.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_UpdateTimeago_DR.ForeColor = System.Drawing.Color.DarkGray;
            this.text_UpdateTimeago_DR.Location = new System.Drawing.Point(55, 309);
            this.text_UpdateTimeago_DR.Name = "text_UpdateTimeago_DR";
            this.text_UpdateTimeago_DR.Size = new System.Drawing.Size(136, 25);
            this.text_UpdateTimeago_DR.TabIndex = 14;
            this.text_UpdateTimeago_DR.Text = "updated  just now";
            // 
            // picTimeAgo_DR
            // 
            this.picTimeAgo_DR.BackColor = System.Drawing.Color.Transparent;
            this.picTimeAgo_DR.Image = global::Vendstor.Properties.Resources.watch_w;
            this.picTimeAgo_DR.ImageActive = null;
            this.picTimeAgo_DR.Location = new System.Drawing.Point(31, 312);
            this.picTimeAgo_DR.Name = "picTimeAgo_DR";
            this.picTimeAgo_DR.Size = new System.Drawing.Size(18, 18);
            this.picTimeAgo_DR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimeAgo_DR.TabIndex = 13;
            this.picTimeAgo_DR.TabStop = false;
            this.picTimeAgo_DR.Zoom = 10;
            // 
            // lblDailyRevenueComment
            // 
            this.lblDailyRevenueComment.AutoSize = true;
            this.lblDailyRevenueComment.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDailyRevenueComment.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDailyRevenueComment.Location = new System.Drawing.Point(89, 252);
            this.lblDailyRevenueComment.Name = "lblDailyRevenueComment";
            this.lblDailyRevenueComment.Size = new System.Drawing.Size(194, 25);
            this.lblDailyRevenueComment.TabIndex = 11;
            this.lblDailyRevenueComment.Text = "increase in today revenue";
            // 
            // picDailyRevenurePtg
            // 
            this.picDailyRevenurePtg.BackColor = System.Drawing.Color.Transparent;
            this.picDailyRevenurePtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picDailyRevenurePtg.ImageActive = null;
            this.picDailyRevenurePtg.Location = new System.Drawing.Point(18, 255);
            this.picDailyRevenurePtg.Name = "picDailyRevenurePtg";
            this.picDailyRevenurePtg.Size = new System.Drawing.Size(15, 15);
            this.picDailyRevenurePtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDailyRevenurePtg.TabIndex = 10;
            this.picDailyRevenurePtg.TabStop = false;
            this.picDailyRevenurePtg.Zoom = 10;
            // 
            // lblDailyRevenurePtg
            // 
            this.lblDailyRevenurePtg.AutoSize = true;
            this.lblDailyRevenurePtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDailyRevenurePtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblDailyRevenurePtg.Location = new System.Drawing.Point(39, 252);
            this.lblDailyRevenurePtg.Name = "lblDailyRevenurePtg";
            this.lblDailyRevenurePtg.Size = new System.Drawing.Size(33, 25);
            this.lblDailyRevenurePtg.TabIndex = 9;
            this.lblDailyRevenurePtg.Text = "- %";
            // 
            // Seperator_DR
            // 
            this.Seperator_DR.BackColor = System.Drawing.Color.Transparent;
            this.Seperator_DR.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator_DR.LineThickness = 1;
            this.Seperator_DR.Location = new System.Drawing.Point(18, 296);
            this.Seperator_DR.Name = "Seperator_DR";
            this.Seperator_DR.Size = new System.Drawing.Size(398, 10);
            this.Seperator_DR.TabIndex = 3;
            this.Seperator_DR.Transparency = 255;
            this.Seperator_DR.Vertical = false;
            // 
            // text_DailyRevenue
            // 
            this.text_DailyRevenue.AutoSize = true;
            this.text_DailyRevenue.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_DailyRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_DailyRevenue.Location = new System.Drawing.Point(18, 217);
            this.text_DailyRevenue.Name = "text_DailyRevenue";
            this.text_DailyRevenue.Size = new System.Drawing.Size(154, 35);
            this.text_DailyRevenue.TabIndex = 2;
            this.text_DailyRevenue.Text = "Daily Revenue";
            // 
            // cardDailySales
            // 
            this.cardDailySales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardDailySales.BackColor = System.Drawing.Color.White;
            this.cardDailySales.BorderRadius = 10;
            this.cardDailySales.BottomSahddow = true;
            this.cardDailySales.color = System.Drawing.Color.Transparent;
            this.cardDailySales.Controls.Add(this.pnlChartDailySales);
            this.cardDailySales.Controls.Add(this.text_UpdateTimeago_DS);
            this.cardDailySales.Controls.Add(this.picTimeAgo_DS);
            this.cardDailySales.Controls.Add(this.lblDailySalesComment);
            this.cardDailySales.Controls.Add(this.picDailySalesPtg);
            this.cardDailySales.Controls.Add(this.lblDailySalesPtg);
            this.cardDailySales.Controls.Add(this.Seperator_DS);
            this.cardDailySales.Controls.Add(this.text_DailySales);
            this.cardDailySales.LeftSahddow = false;
            this.cardDailySales.Location = new System.Drawing.Point(457, 152);
            this.cardDailySales.Name = "cardDailySales";
            this.cardDailySales.RightSahddow = true;
            this.cardDailySales.ShadowDepth = 10;
            this.cardDailySales.Size = new System.Drawing.Size(435, 353);
            this.cardDailySales.TabIndex = 13;
            // 
            // pnlChartDailySales
            // 
            this.pnlChartDailySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.pnlChartDailySales.Controls.Add(this.chartDailySalesHost);
            this.pnlChartDailySales.Location = new System.Drawing.Point(18, 3);
            this.pnlChartDailySales.Name = "pnlChartDailySales";
            this.pnlChartDailySales.Size = new System.Drawing.Size(398, 211);
            this.pnlChartDailySales.TabIndex = 13;
            // 
            // chartDailySalesHost
            // 
            this.chartDailySalesHost.BackColor = System.Drawing.Color.White;
            this.chartDailySalesHost.Location = new System.Drawing.Point(14, 11);
            this.chartDailySalesHost.Name = "chartDailySalesHost";
            this.chartDailySalesHost.Size = new System.Drawing.Size(371, 189);
            this.chartDailySalesHost.TabIndex = 16;
            this.chartDailySalesHost.Text = "elementHost2";
            this.chartDailySalesHost.Child = this.chartDailySales;
            // 
            // text_UpdateTimeago_DS
            // 
            this.text_UpdateTimeago_DS.AutoSize = true;
            this.text_UpdateTimeago_DS.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_UpdateTimeago_DS.ForeColor = System.Drawing.Color.DarkGray;
            this.text_UpdateTimeago_DS.Location = new System.Drawing.Point(55, 309);
            this.text_UpdateTimeago_DS.Name = "text_UpdateTimeago_DS";
            this.text_UpdateTimeago_DS.Size = new System.Drawing.Size(136, 25);
            this.text_UpdateTimeago_DS.TabIndex = 14;
            this.text_UpdateTimeago_DS.Text = "updated  just now";
            // 
            // picTimeAgo_DS
            // 
            this.picTimeAgo_DS.BackColor = System.Drawing.Color.Transparent;
            this.picTimeAgo_DS.Image = global::Vendstor.Properties.Resources.watch_w;
            this.picTimeAgo_DS.ImageActive = null;
            this.picTimeAgo_DS.Location = new System.Drawing.Point(31, 312);
            this.picTimeAgo_DS.Name = "picTimeAgo_DS";
            this.picTimeAgo_DS.Size = new System.Drawing.Size(18, 18);
            this.picTimeAgo_DS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimeAgo_DS.TabIndex = 13;
            this.picTimeAgo_DS.TabStop = false;
            this.picTimeAgo_DS.Zoom = 10;
            // 
            // lblDailySalesComment
            // 
            this.lblDailySalesComment.AutoSize = true;
            this.lblDailySalesComment.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDailySalesComment.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDailySalesComment.Location = new System.Drawing.Point(89, 252);
            this.lblDailySalesComment.Name = "lblDailySalesComment";
            this.lblDailySalesComment.Size = new System.Drawing.Size(171, 25);
            this.lblDailySalesComment.TabIndex = 11;
            this.lblDailySalesComment.Text = "increase in today sales";
            // 
            // picDailySalesPtg
            // 
            this.picDailySalesPtg.BackColor = System.Drawing.Color.Transparent;
            this.picDailySalesPtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picDailySalesPtg.ImageActive = null;
            this.picDailySalesPtg.Location = new System.Drawing.Point(18, 255);
            this.picDailySalesPtg.Name = "picDailySalesPtg";
            this.picDailySalesPtg.Size = new System.Drawing.Size(15, 15);
            this.picDailySalesPtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDailySalesPtg.TabIndex = 10;
            this.picDailySalesPtg.TabStop = false;
            this.picDailySalesPtg.Zoom = 10;
            // 
            // lblDailySalesPtg
            // 
            this.lblDailySalesPtg.AutoSize = true;
            this.lblDailySalesPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDailySalesPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblDailySalesPtg.Location = new System.Drawing.Point(39, 252);
            this.lblDailySalesPtg.Name = "lblDailySalesPtg";
            this.lblDailySalesPtg.Size = new System.Drawing.Size(33, 25);
            this.lblDailySalesPtg.TabIndex = 9;
            this.lblDailySalesPtg.Text = "- %";
            // 
            // Seperator_DS
            // 
            this.Seperator_DS.BackColor = System.Drawing.Color.Transparent;
            this.Seperator_DS.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator_DS.LineThickness = 1;
            this.Seperator_DS.Location = new System.Drawing.Point(18, 296);
            this.Seperator_DS.Name = "Seperator_DS";
            this.Seperator_DS.Size = new System.Drawing.Size(398, 10);
            this.Seperator_DS.TabIndex = 3;
            this.Seperator_DS.Transparency = 255;
            this.Seperator_DS.Vertical = false;
            // 
            // text_DailySales
            // 
            this.text_DailySales.AutoSize = true;
            this.text_DailySales.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_DailySales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_DailySales.Location = new System.Drawing.Point(18, 217);
            this.text_DailySales.Name = "text_DailySales";
            this.text_DailySales.Size = new System.Drawing.Size(122, 35);
            this.text_DailySales.TabIndex = 2;
            this.text_DailySales.Text = "Daily Sales";
            // 
            // cardWeeklyCustomers
            // 
            this.cardWeeklyCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardWeeklyCustomers.BackColor = System.Drawing.Color.White;
            this.cardWeeklyCustomers.BorderRadius = 10;
            this.cardWeeklyCustomers.BottomSahddow = true;
            this.cardWeeklyCustomers.color = System.Drawing.Color.Transparent;
            this.cardWeeklyCustomers.Controls.Add(this.pnlChartWeeklyCustomers);
            this.cardWeeklyCustomers.Controls.Add(this.text_UpdateTimeago_WC);
            this.cardWeeklyCustomers.Controls.Add(this.picTimeAgo_WC);
            this.cardWeeklyCustomers.Controls.Add(this.lblWeeklyCustomersComment);
            this.cardWeeklyCustomers.Controls.Add(this.picWeeklyCustomersPtg);
            this.cardWeeklyCustomers.Controls.Add(this.lblWeeklyCustomersPtg);
            this.cardWeeklyCustomers.Controls.Add(this.Seperator_WC);
            this.cardWeeklyCustomers.Controls.Add(this.text_WeeklyCustomers);
            this.cardWeeklyCustomers.LeftSahddow = false;
            this.cardWeeklyCustomers.Location = new System.Drawing.Point(898, 152);
            this.cardWeeklyCustomers.Name = "cardWeeklyCustomers";
            this.cardWeeklyCustomers.RightSahddow = true;
            this.cardWeeklyCustomers.ShadowDepth = 10;
            this.cardWeeklyCustomers.Size = new System.Drawing.Size(435, 353);
            this.cardWeeklyCustomers.TabIndex = 15;
            // 
            // pnlChartWeeklyCustomers
            // 
            this.pnlChartWeeklyCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(98)))), ((int)(((byte)(224)))));
            this.pnlChartWeeklyCustomers.Controls.Add(this.chartWeeklyCustomersHost);
            this.pnlChartWeeklyCustomers.Location = new System.Drawing.Point(18, 3);
            this.pnlChartWeeklyCustomers.Name = "pnlChartWeeklyCustomers";
            this.pnlChartWeeklyCustomers.Size = new System.Drawing.Size(398, 211);
            this.pnlChartWeeklyCustomers.TabIndex = 13;
            // 
            // chartWeeklyCustomersHost
            // 
            this.chartWeeklyCustomersHost.BackColor = System.Drawing.Color.White;
            this.chartWeeklyCustomersHost.Location = new System.Drawing.Point(14, 11);
            this.chartWeeklyCustomersHost.Name = "chartWeeklyCustomersHost";
            this.chartWeeklyCustomersHost.Size = new System.Drawing.Size(371, 189);
            this.chartWeeklyCustomersHost.TabIndex = 16;
            this.chartWeeklyCustomersHost.Text = "elementHost3";
            this.chartWeeklyCustomersHost.Child = this.chartWeeklyCustomers;
            // 
            // text_UpdateTimeago_WC
            // 
            this.text_UpdateTimeago_WC.AutoSize = true;
            this.text_UpdateTimeago_WC.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_UpdateTimeago_WC.ForeColor = System.Drawing.Color.DarkGray;
            this.text_UpdateTimeago_WC.Location = new System.Drawing.Point(55, 309);
            this.text_UpdateTimeago_WC.Name = "text_UpdateTimeago_WC";
            this.text_UpdateTimeago_WC.Size = new System.Drawing.Size(136, 25);
            this.text_UpdateTimeago_WC.TabIndex = 14;
            this.text_UpdateTimeago_WC.Text = "updated  just now";
            // 
            // picTimeAgo_WC
            // 
            this.picTimeAgo_WC.BackColor = System.Drawing.Color.Transparent;
            this.picTimeAgo_WC.Image = global::Vendstor.Properties.Resources.watch_w;
            this.picTimeAgo_WC.ImageActive = null;
            this.picTimeAgo_WC.Location = new System.Drawing.Point(31, 312);
            this.picTimeAgo_WC.Name = "picTimeAgo_WC";
            this.picTimeAgo_WC.Size = new System.Drawing.Size(18, 18);
            this.picTimeAgo_WC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimeAgo_WC.TabIndex = 13;
            this.picTimeAgo_WC.TabStop = false;
            this.picTimeAgo_WC.Zoom = 10;
            // 
            // lblWeeklyCustomersComment
            // 
            this.lblWeeklyCustomersComment.AutoSize = true;
            this.lblWeeklyCustomersComment.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblWeeklyCustomersComment.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWeeklyCustomersComment.Location = new System.Drawing.Point(89, 252);
            this.lblWeeklyCustomersComment.Name = "lblWeeklyCustomersComment";
            this.lblWeeklyCustomersComment.Size = new System.Drawing.Size(234, 25);
            this.lblWeeklyCustomersComment.TabIndex = 11;
            this.lblWeeklyCustomersComment.Text = "increase in this week customers";
            // 
            // picWeeklyCustomersPtg
            // 
            this.picWeeklyCustomersPtg.BackColor = System.Drawing.Color.Transparent;
            this.picWeeklyCustomersPtg.Image = global::Vendstor.Properties.Resources.upward_f_w;
            this.picWeeklyCustomersPtg.ImageActive = null;
            this.picWeeklyCustomersPtg.Location = new System.Drawing.Point(18, 255);
            this.picWeeklyCustomersPtg.Name = "picWeeklyCustomersPtg";
            this.picWeeklyCustomersPtg.Size = new System.Drawing.Size(15, 15);
            this.picWeeklyCustomersPtg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeeklyCustomersPtg.TabIndex = 10;
            this.picWeeklyCustomersPtg.TabStop = false;
            this.picWeeklyCustomersPtg.Zoom = 10;
            // 
            // lblWeeklyCustomersPtg
            // 
            this.lblWeeklyCustomersPtg.AutoSize = true;
            this.lblWeeklyCustomersPtg.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblWeeklyCustomersPtg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.lblWeeklyCustomersPtg.Location = new System.Drawing.Point(39, 252);
            this.lblWeeklyCustomersPtg.Name = "lblWeeklyCustomersPtg";
            this.lblWeeklyCustomersPtg.Size = new System.Drawing.Size(33, 25);
            this.lblWeeklyCustomersPtg.TabIndex = 9;
            this.lblWeeklyCustomersPtg.Text = "- %";
            // 
            // Seperator_WC
            // 
            this.Seperator_WC.BackColor = System.Drawing.Color.Transparent;
            this.Seperator_WC.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator_WC.LineThickness = 1;
            this.Seperator_WC.Location = new System.Drawing.Point(18, 296);
            this.Seperator_WC.Name = "Seperator_WC";
            this.Seperator_WC.Size = new System.Drawing.Size(398, 10);
            this.Seperator_WC.TabIndex = 3;
            this.Seperator_WC.Transparency = 255;
            this.Seperator_WC.Vertical = false;
            // 
            // text_WeeklyCustomers
            // 
            this.text_WeeklyCustomers.AutoSize = true;
            this.text_WeeklyCustomers.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_WeeklyCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_WeeklyCustomers.Location = new System.Drawing.Point(18, 217);
            this.text_WeeklyCustomers.Name = "text_WeeklyCustomers";
            this.text_WeeklyCustomers.Size = new System.Drawing.Size(198, 35);
            this.text_WeeklyCustomers.TabIndex = 2;
            this.text_WeeklyCustomers.Text = "Weekly Customers";
            // 
            // pgbLoading
            // 
            this.pgbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbLoading.animated = true;
            this.pgbLoading.animationIterval = 5;
            this.pgbLoading.animationSpeed = 1;
            this.pgbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pgbLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgbLoading.BackgroundImage")));
            this.pgbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pgbLoading.LabelVisible = false;
            this.pgbLoading.LineProgressThickness = 2;
            this.pgbLoading.LineThickness = 1;
            this.pgbLoading.Location = new System.Drawing.Point(630, 400);
            this.pgbLoading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbLoading.MaxValue = 100;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pgbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.pgbLoading.Size = new System.Drawing.Size(79, 79);
            this.pgbLoading.TabIndex = 1;
            this.pgbLoading.Value = 10;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLoading.Controls.Add(this.pgbLoading);
            this.pnlLoading.Location = new System.Drawing.Point(7, 10);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(1339, 879);
            this.pnlLoading.TabIndex = 16;
            this.pnlLoading.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.cardWeeklyCustomers);
            this.Controls.Add(this.cardDailySales);
            this.Controls.Add(this.cardDailyRevenue);
            this.Controls.Add(this.cardReview);
            this.Controls.Add(this.card);
            this.Controls.Add(this.cardStatistics);
            this.Controls.Add(this.cardTopSoldProducts);
            this.Controls.Add(this.cardCustomers);
            this.Controls.Add(this.cardSales);
            this.Controls.Add(this.cardProducts);
            this.Controls.Add(this.cardRevenue);
            this.Controls.Add(this.pnlLoading);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1349, 892);
            this.Load += new System.EventHandler(this.OnLoad);
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenuePtg)).EndInit();
            this.imgpnlRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalRevenue)).EndInit();
            this.cardProducts.ResumeLayout(false);
            this.cardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductsPtg)).EndInit();
            this.imgpnlProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalProducts)).EndInit();
            this.cardSales.ResumeLayout(false);
            this.cardSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalesCountPtg)).EndInit();
            this.imgpnlSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnSalesDate)).EndInit();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomersCountPtg)).EndInit();
            this.imgpnlCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTotalCustomers)).EndInit();
            this.cardTopSoldProducts.ResumeLayout(false);
            this.cardTopSoldProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorEmptyProducts)).EndInit();
            this.cardStatistics.ResumeLayout(false);
            this.cardStatistics.PerformLayout();
            this.cardReview.ResumeLayout(false);
            this.cardReview.PerformLayout();
            this.cardDailyRevenue.ResumeLayout(false);
            this.cardDailyRevenue.PerformLayout();
            this.pnlChartDailyRevenure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_DR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDailyRevenurePtg)).EndInit();
            this.cardDailySales.ResumeLayout(false);
            this.cardDailySales.PerformLayout();
            this.pnlChartDailySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDailySalesPtg)).EndInit();
            this.cardWeeklyCustomers.ResumeLayout(false);
            this.cardWeeklyCustomers.PerformLayout();
            this.pnlChartWeeklyCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimeAgo_WC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeeklyCustomersPtg)).EndInit();
            this.pnlLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardRevenue;
        private System.Windows.Forms.Label text_TotalRevenue_Card;
        private System.Windows.Forms.Label lblTotalRevenue;
        private Bunifu.Framework.UI.BunifuCards cardProducts;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label text_Products_Card;
        private Bunifu.Framework.UI.BunifuCards cardSales;
        private System.Windows.Forms.Label lblSalesCount;
        private System.Windows.Forms.Label text_Sales_Card;
        private Bunifu.Framework.UI.BunifuCards cardCustomers;
        private System.Windows.Forms.Label text_TotalCustomers;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Label text_Customers_Card;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTotalRevenue;
        private Bunifu.Framework.UI.BunifuImageButton picRevenuePtg;
        private System.Windows.Forms.Label lblRevenuePtg;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTotalProducts;
        private System.Windows.Forms.Label text_TotalProducts;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSalesDate;
        private System.Windows.Forms.Label text_WeeklySales;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTotalCustomers;
        private System.Windows.Forms.Panel imgpnlRevenue;
        private System.Windows.Forms.Panel imgpnlProducts;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnProducts;
        private System.Windows.Forms.Panel imgpnlSales;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnSales;
        private System.Windows.Forms.Panel imgpnlCustomers;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCustomers;
        private Bunifu.Framework.UI.BunifuImageButton picProductsPtg;
        private System.Windows.Forms.Label lblProductsPtg;
        private Bunifu.Framework.UI.BunifuImageButton picSalesCountPtg;
        private System.Windows.Forms.Label lblSalesCountPtg;
        private Bunifu.Framework.UI.BunifuImageButton picCustomersCountPtg;
        private System.Windows.Forms.Label lblCustomersCountPtg;
        private Bunifu.Framework.UI.BunifuCards cardTopSoldProducts;
        private Bunifu.Framework.UI.BunifuCards cardStatistics;
        private Bunifu.Framework.UI.BunifuCards card;
        private Bunifu.Framework.UI.BunifuCards cardReview;
        private System.Windows.Forms.Label text_ThisMonth;
        private System.Windows.Forms.Label lblMonthlySalesAmount;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgbSalesPtg_XS;
        private System.Windows.Forms.Label text_TopSoldProducts;
        private System.Windows.Forms.Label lblAmtMemberProfit_R;
        private System.Windows.Forms.Label text_MemberProfit_R;
        private Bunifu.Framework.UI.BunifuCards cardDailyRevenue;
        private Bunifu.Framework.UI.BunifuSeparator Seperator_DR;
        private System.Windows.Forms.Label text_DailyRevenue;
        private System.Windows.Forms.Label text_UpdateTimeago_DR;
        private Bunifu.Framework.UI.BunifuImageButton picTimeAgo_DR;
        private System.Windows.Forms.Label lblDailyRevenueComment;
        private Bunifu.Framework.UI.BunifuImageButton picDailyRevenurePtg;
        private System.Windows.Forms.Label lblDailyRevenurePtg;
        private System.Windows.Forms.Panel pnlChartDailyRevenure;
        private Bunifu.Framework.UI.BunifuCards cardDailySales;
        private System.Windows.Forms.Panel pnlChartDailySales;
        private System.Windows.Forms.Label text_UpdateTimeago_DS;
        private Bunifu.Framework.UI.BunifuImageButton picTimeAgo_DS;
        private System.Windows.Forms.Label lblDailySalesComment;
        private Bunifu.Framework.UI.BunifuImageButton picDailySalesPtg;
        private System.Windows.Forms.Label lblDailySalesPtg;
        private Bunifu.Framework.UI.BunifuSeparator Seperator_DS;
        private System.Windows.Forms.Label text_DailySales;
        private Bunifu.Framework.UI.BunifuCards cardWeeklyCustomers;
        private System.Windows.Forms.Panel pnlChartWeeklyCustomers;
        private System.Windows.Forms.Label text_UpdateTimeago_WC;
        private Bunifu.Framework.UI.BunifuImageButton picTimeAgo_WC;
        private System.Windows.Forms.Label lblWeeklyCustomersComment;
        private Bunifu.Framework.UI.BunifuImageButton picWeeklyCustomersPtg;
        private System.Windows.Forms.Label lblWeeklyCustomersPtg;
        private Bunifu.Framework.UI.BunifuSeparator Seperator_WC;
        private System.Windows.Forms.Label text_WeeklyCustomers;
        private System.Windows.Forms.FlowLayoutPanel TopSoldProductsGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 tbtnMonthlySalesPtg;
        private System.Windows.Forms.Label text_WeeklyCustomerSales_R;
        private System.Windows.Forms.Label text_AverageWeeklyProfit_R;
        private System.Windows.Forms.Label lblAmtTotalProfit_R;
        private System.Windows.Forms.Label text_TotalProfit_R;
        private Bunifu.Framework.UI.BunifuSeparator sep1_R;
        private System.Windows.Forms.Integration.ElementHost chartDailyRevenueHost;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pgbLoading;
        private System.Windows.Forms.Panel pnlLoading;
        private Bunifu.Framework.UI.BunifuImageButton imgVectorEmptyProducts;
        private System.Windows.Forms.Integration.ElementHost chartDailySalesHost;
        private System.Windows.Forms.Integration.ElementHost chartWeeklyCustomersHost;
        private LiveCharts.Wpf.CartesianChart chartWeeklyCustomers;
        private LiveCharts.Wpf.CartesianChart chartDailyRevenue;
        private LiveCharts.Wpf.CartesianChart chartDailySales;
    }
}
