namespace Vendstor.Models.Customers
{
    partial class CustomerGroupModel
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
            this.GridSeperator_Expand = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewCustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // GridSeperator_Expand
            // 
            this.GridSeperator_Expand.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Expand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Expand.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Expand.LineThickness = 1;
            this.GridSeperator_Expand.Location = new System.Drawing.Point(0, 50);
            this.GridSeperator_Expand.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Expand.Name = "GridSeperator_Expand";
            this.GridSeperator_Expand.Size = new System.Drawing.Size(1045, 5);
            this.GridSeperator_Expand.TabIndex = 201;
            this.GridSeperator_Expand.Transparency = 255;
            this.GridSeperator_Expand.Vertical = false;
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblCustomersCount.Location = new System.Drawing.Point(697, 14);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(50, 26);
            this.lblCustomersCount.TabIndex = 197;
            this.lblCustomersCount.Text = "_000";
            this.lblCustomersCount.Click += new System.EventHandler(this.BtnViewCustomers_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblGroupName.Location = new System.Drawing.Point(22, 14);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(112, 26);
            this.lblGroupName.TabIndex = 196;
            this.lblGroupName.Text = "_GroupName";
            this.lblGroupName.Click += new System.EventHandler(this.OnClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Tomato;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::Vendstor.Properties.Resources.cancel_filled_w;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 37D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(977, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Tomato;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 26);
            this.btnDelete.TabIndex = 200;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCustomers.BorderRadius = 5;
            this.btnViewCustomers.ButtonText = "";
            this.btnViewCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewCustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewCustomers.Iconimage = global::Vendstor.Properties.Resources.details_filled_W;
            this.btnViewCustomers.Iconimage_right = null;
            this.btnViewCustomers.Iconimage_right_Selected = null;
            this.btnViewCustomers.Iconimage_Selected = null;
            this.btnViewCustomers.IconMarginLeft = 0;
            this.btnViewCustomers.IconMarginRight = 0;
            this.btnViewCustomers.IconRightVisible = true;
            this.btnViewCustomers.IconRightZoom = 0D;
            this.btnViewCustomers.IconVisible = true;
            this.btnViewCustomers.IconZoom = 37D;
            this.btnViewCustomers.IsTab = false;
            this.btnViewCustomers.Location = new System.Drawing.Point(901, 14);
            this.btnViewCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewCustomers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnViewCustomers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewCustomers.selected = false;
            this.btnViewCustomers.Size = new System.Drawing.Size(30, 26);
            this.btnViewCustomers.TabIndex = 199;
            this.btnViewCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewCustomers.Textcolor = System.Drawing.Color.White;
            this.btnViewCustomers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.Click += new System.EventHandler(this.BtnViewCustomers_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.ButtonText = "";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = global::Vendstor.Properties.Resources.edit_filled_w;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 37D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(939, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(30, 26);
            this.btnEdit.TabIndex = 198;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CustomerGroupModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridSeperator_Expand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCustomersCount);
            this.Controls.Add(this.lblGroupName);
            this.Name = "CustomerGroupModel";
            this.Size = new System.Drawing.Size(1045, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Expand;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewCustomers;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Label lblGroupName;
    }
}
