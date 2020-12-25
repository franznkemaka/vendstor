using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendstor.Backend.Utils;

namespace Vendstor.Forms.PointOfSale
{
    public partial class Calculator : Form
    {
        /**
         * Copyright : © Franz Nkemaka -  All Rights Reserved  */

        #region Variables

        private double LastAnswer { get; set; }
        private string Expression = "";
        private int ProgressValue = 0;

        #endregion

        #region Constructors

        public Calculator()
        {
            InitializeComponent();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
        }

        #endregion

        #region  Event Handler

        private void OnClick(object sender, EventArgs e)
        {
            //this.Close();
        }

        #endregion

        #region Control - Event Handler

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear Input
            lblExpression.Text = Expression = "";
            lblAnswer.Text = "0";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Substring Expression
                lblExpression.Text = Expression = Expression.Substring(0, Expression.Length - 1);
            }
            catch { return; }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Submit, Evaluate Expression & Start Timer ...
            LastAnswer = Evaluate(Expression);
            timAnimate.Start();
        }

        private void ButtonNumPad_Click(object sender, EventArgs e)
        {
            // Append Tag to Expression
            lblExpression.Text = (Expression += ((Control)sender).Tag);
        }

        private void TimAnimate_Tick(object sender, EventArgs e)
        {
            if (ProgressValue < 15)
            {
                // Animate Answer 
                lblAnswer.Text = GetRandomNums(this.LastAnswer.ToString().Length);
                ProgressValue++;
            }
            else
            {
                // Show Answer & Reset ProgressValue
                ProgressValue = 0;
                lblAnswer.Text = LastAnswer.ToString();
                timAnimate.Stop();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate an Expression and returns Answer 
        /// </summary>
        /// <param name="expression"> Expression to calculate ex. 2+2*5 </param>
        /// <returns></returns>
        public static double Evaluate(string expression)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                return double.Parse((string)row["expression"]);
            }
            catch { return 0; }
        }

        /// <summary>
        /// Generate a Random Number
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GetRandomNums(int length)
        {
            string randomString = "";
            Random random = new Random();
            for (int index = 0; index < length; index++)
                randomString += random.Next(0, 10);

            return randomString;
        }

        #endregion

        #region OnClose

        #endregion

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
