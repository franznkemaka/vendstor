using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard
{
    public partial class Home : UserControl
    {
        #region Variables

        Backend.Objects.Insights Insights = new Backend.Objects.Insights();
        Backend.Objects.Store Store = new Backend.Objects.Store();

        string Currency
        {
            get { return Store.CurrencySign; }
        }

        string[] LastSevenDays ={
                 DateTime.Now.AddDays(-6).ToShortDateString(),
                 DateTime.Now.AddDays(-5).ToShortDateString(),
                 DateTime.Now.AddDays(-4).ToShortDateString(),
                 DateTime.Now.AddDays(-3).ToShortDateString(),
                 DateTime.Now.AddDays(-2).ToShortDateString(),
                 DateTime.Now.AddDays(-1).ToShortDateString(),
                 DateTime.Now.ToShortDateString(),
        };

        Color SoftColor;

        #endregion

        #region Constructors

        public Home()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            if (!UserControlUtil.IsLargeScreen)
                RequestAutoScroll();

            Initialize();
        }

        #endregion

        #region Control - Event Handler

        #endregion

        #region  Methods

        void Initialize()
        {
            Store = Util.Data.GetStore();

            GetInsights();

            Translate();
        }

        void GetInsights()
        {
            var response = QueryController.Store.GetInsights(Insights);
            if (response.StatusCode == 200)
            {
                Insights = (Backend.Objects.Insights)response.Data;
                RenderInsights();

                // Get TopSoldProducts
                var topProductsResponse = QueryController.Store.GetTopSoldProducts(Insights, limit: 3);
                if (response.StatusCode == 200)
                {
                    TopSoldProductsGrid.Controls.Clear();
                    Insights = (Backend.Objects.Insights)response.Data;

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(Insights.TopSoldProducts.Count == 0);

                    int medalIndex = 0;
                    foreach (Backend.Objects.Product product in Insights.TopSoldProducts)
                    {
                        medalIndex++;
                        AddTopProductToGrid(product, medalIndex);
                    }
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderEmptyData();

                GetCharts();
            }
            else
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
        }

        void GetCharts()
        {
            RenderCharts();
            // Get DailyRevenue Chart Data
            var dailyRevenueResponse = QueryController.Store.GetDailyRevenueData(Insights);
            if (dailyRevenueResponse.StatusCode == 200)
            {
                RenderEmptyChart(chartDailyRevenueHost, Insights.ChartData.Count != 0);
                RenderDailyRevenueChart((Backend.Objects.Insights)dailyRevenueResponse.Data);
            }
            else if (dailyRevenueResponse.StatusCode == 204)
                // No Content
                RenderEmptyChart(chartDailyRevenueHost, false);

            // Get DailySales Chart Data
            var dailySalesResponse = QueryController.Store.GetDailySalesData(Insights);
            if (dailySalesResponse.StatusCode == 200)
            {
                RenderEmptyChart(chartDailySalesHost, Insights.ChartData.Count != 0);
                RenderDailySalesChart((Backend.Objects.Insights)dailySalesResponse.Data);
            }
            else if (dailySalesResponse.StatusCode == 204)
                // No Content
                RenderEmptyChart(chartDailySalesHost, false);

            // Get WeeklyCustomers Chart Data
            var weeklyCustomersResponse = QueryController.Store.GetWeeklyCustomersData(Insights);
            if (weeklyCustomersResponse.StatusCode == 200)
            {
                RenderEmptyChart(chartWeeklyCustomersHost, Insights.ChartData.Count != 0);
                RenderWeeklyCustomersChart((Backend.Objects.Insights)weeklyCustomersResponse.Data);
            }
            else if (weeklyCustomersResponse.StatusCode == 204)
                // No Content
                RenderEmptyChart(chartWeeklyCustomersHost, false);
        }

        void AddTopProductToGrid(Backend.Objects.Product product, int medalIndex)
        {
            //Fill Grid [ TopSoldProductsGrid ] With Rows
            TopSoldProductModel productModel = new TopSoldProductModel
            {
                Product = product,
                Currency = Currency,
                MedalIndex = medalIndex,
            };
            //Add To Grid
            TopSoldProductsGrid.Controls.Add(productModel);
        }

        void RenderInsights()
        {
            lblTotalRevenue.Text = Currency + " " + Insights.TotalRevenue.ToString();
            lblMonthlySalesAmount.Text = Currency + " " + Insights.MonthlyRevenue.ToString();

            lblProductsCount.Text = Insights.TotalProductsCount.ToString();
            lblSalesCount.Text = Insights.WeeklySalesCount.ToString();
            lblCustomersCount.Text = Insights.TotalCustomersCount.ToString();
        }

        void RenderCharts()
        {
            chartDailyRevenueHost.BackColor = chartDailySalesHost.BackColor = chartWeeklyCustomersHost.BackColor = Color.White;
        }

        void RenderDailyRevenueChart(Backend.Objects.Insights insights)
        {
            IDictionary<string, double> dailyRevenue = new Dictionary<string, double>();
            ChartValues<double> chartValues = new ChartValues<double>();

            foreach (Backend.Objects.DailyRevenueChart chart in insights.ChartData)
                dailyRevenue.Add(chart.Date.ToShortDateString(), (double)chart.Amount);

            // Add Value to ChartValues
            foreach (var day in LastSevenDays)
            {
                // Zero if not set
                double amount = 0; 
                try { amount = dailyRevenue[day]; } catch { }
                chartValues.Add(amount);
            }

            chartDailyRevenue.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = new[] { AddDaysToTime(-6), AddDaysToTime(-5), AddDaysToTime(-4), AddDaysToTime(-3), AddDaysToTime(-2), "Yesterday", "Today" }
            });

            chartDailyRevenue.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });
            chartDailyRevenue.LegendLocation = LegendLocation.Right;
            chartDailyRevenue.Series.Add(new LineSeries
            {
                Title = "Daily Revenue",
                Values = chartValues,
                PointForeground = System.Windows.Media.Brushes.White,
            });
        }

        string AddDaysToTime(double index, DateTime? dateTime = null)
        {
            dateTime = dateTime ?? DateTime.Now;
            return ((DateTime)dateTime).AddDays(index).ToString("dddd");
        }

        void RenderDailySalesChart(Backend.Objects.Insights insights)
        {
            IDictionary<string, double> dailySales = new Dictionary<string, double>();
            ChartValues<double> chartValues = new ChartValues<double>();

            foreach (Backend.Objects.DailySalesChart chart in insights.ChartData)
                dailySales.Add(chart.Date.ToShortDateString(), (double)chart.Count);

            // Add Value to ChartValues
            foreach (var day in LastSevenDays)
            {
                // Zero if not set
                double count = 0;
                try { count = dailySales[day]; } catch { }
                chartValues.Add(count);
            }

            chartDailySales.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = new[] { AddDaysToTime(-6), AddDaysToTime(-5), AddDaysToTime(-4), AddDaysToTime(-3), AddDaysToTime(-2), "Yesterday", "Today" }
            });

            chartDailySales.AxisY.Add(new Axis
            {
                Title = "Sales Count",
                LabelFormatter = value => value.ToString()
            });
            chartDailySales.LegendLocation = LegendLocation.Right;
            chartDailySales.Series.Add(new LineSeries
            {
                Title = "Daily Sales",
                Values = chartValues,
                PointForeground = System.Windows.Media.Brushes.White,
            });
        }

        void RenderWeeklyCustomersChart(Backend.Objects.Insights insights)
        {
            IDictionary<string, double> dailyCustomers = new Dictionary<string, double>();
            ChartValues<double> chartValues = new ChartValues<double>();

            foreach (Backend.Objects.WeeklyCustomersChart chart in insights.ChartData)
                dailyCustomers.Add(chart.Date.ToShortDateString(), (double)chart.Count);

            // Add Value to ChartValues
            foreach (var day in LastSevenDays)
            {
                // Zero if not set
                double count = 0;
                try { count = dailyCustomers[day]; } catch { }
                chartValues.Add(count);
            }

            chartWeeklyCustomers.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = new[] { AddDaysToTime(-6), AddDaysToTime(-5), AddDaysToTime(-4), AddDaysToTime(-3), AddDaysToTime(-2), "Yesterday", "Today" }
            });

            chartWeeklyCustomers.AxisY.Add(new Axis
            {
                Title = "Customers Count",
                LabelFormatter = value => value.ToString()
            });
            chartWeeklyCustomers.LegendLocation = LegendLocation.Right;
            chartWeeklyCustomers.Series.Add(new LineSeries
            {
                Title = "Daily Customers ",
                Values = chartValues,
                PointForeground = System.Windows.Media.Brushes.White,
            });
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorImageButton(imgbtnTotalProducts, Color.DimGray);
            ImageUtil.ColorImageButton(imgbtnSalesDate, Color.DimGray);
            ImageUtil.ColorImageButton(imgbtnTotalCustomers, Color.DimGray);
            ImageUtil.ColorPictureBox(picTimeAgo_WC, Color.DimGray);
            picTimeAgo_DR.Image = picTimeAgo_DS.Image = picTimeAgo_WC.Image;
            UserControlUtil.Func.MoveControlTo(text_Sales_Card, text_Sales_Card.Location, text_Sales_Card.Size,
                new Point(210, 18), new Size(101, 28));
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            imgVectorEmptyProducts.Visible = isEmpty;
            TopSoldProductsGrid.Visible = !isEmpty;
        }

        void RenderEmptyChart(System.Windows.Forms.Integration.ElementHost chart, bool isEmpty = true)
        {
            chart.Visible = isEmpty;
        }

        void RequestAutoScroll(bool scrollOnMaximized = true, bool scrollOnNormalized = true)
        {
            try
            {
                DashboardForm parent = (DashboardForm)this.ParentForm;
                parent.RequestAutoScroll(scrollOnMaximized, scrollOnNormalized);
            }
            catch { }
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_TotalRevenue_Card);
                Translation.TranslateControl(text_Products_Card);
                Translation.TranslateControl(text_Sales_Card);
                Translation.TranslateControl(text_Customers_Card);

                Translation.TranslateControl(text_TotalProducts);
                Translation.TranslateControl(text_TotalCustomers);
                Translation.TranslateControl(text_WeeklySales);

                Translation.TranslateControl(text_DailyRevenue);
                Translation.TranslateControl(text_DailySales);
                Translation.TranslateControl(text_WeeklyCustomers);

                Translation.TranslateControl(lblDailyRevenueComment);
                Translation.TranslateControl(lblDailySalesComment);
                Translation.TranslateControl(lblWeeklyCustomersComment);

                Translation.TranslateControl(text_TopSoldProducts);
                Translation.TranslateControl(text_ThisMonth);
                Translation.TranslateControl(text_MemberProfit_R);
                Translation.TranslateControl(text_TotalProfit_R);
                Translation.TranslateControl(text_AverageWeeklyProfit_R);
                Translation.TranslateControl(text_WeeklyCustomerSales_R);
            }

        }

        #endregion

        #region OnClose

        #endregion
    }
}
