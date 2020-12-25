namespace Vendstor.UserControls.Dashboard
{
    partial class Settings
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
            this.SettingsControl = new System.Windows.Forms.FlowLayoutPanel();
            this.TabIndicator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabTaxes = new System.Windows.Forms.Label();
            this.TabPaymentTypes = new System.Windows.Forms.Label();
            this.TabSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabSoftware = new System.Windows.Forms.Label();
            this.TabGeneral = new System.Windows.Forms.Label();
            this.TabUsers = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.Panel();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsControl
            // 
            this.SettingsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.SettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsControl.Location = new System.Drawing.Point(0, 53);
            this.SettingsControl.Name = "SettingsControl";
            this.SettingsControl.Size = new System.Drawing.Size(1138, 607);
            this.SettingsControl.TabIndex = 128;
            // 
            // TabIndicator
            // 
            this.TabIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabIndicator.BackColor = System.Drawing.Color.Transparent;
            this.TabIndicator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.TabIndicator.LineThickness = 2;
            this.TabIndicator.Location = new System.Drawing.Point(244, 42);
            this.TabIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.TabIndicator.Name = "TabIndicator";
            this.TabIndicator.Size = new System.Drawing.Size(82, 10);
            this.TabIndicator.TabIndex = 11;
            this.TabIndicator.Transparency = 255;
            this.TabIndicator.Vertical = false;
            // 
            // TabTaxes
            // 
            this.TabTaxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabTaxes.AutoSize = true;
            this.TabTaxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabTaxes.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabTaxes.ForeColor = System.Drawing.Color.DarkGray;
            this.TabTaxes.Location = new System.Drawing.Point(577, 11);
            this.TabTaxes.Name = "TabTaxes";
            this.TabTaxes.Size = new System.Drawing.Size(56, 28);
            this.TabTaxes.TabIndex = 121;
            this.TabTaxes.Text = "Taxes";
            this.TabTaxes.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabPaymentTypes
            // 
            this.TabPaymentTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabPaymentTypes.AutoSize = true;
            this.TabPaymentTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPaymentTypes.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabPaymentTypes.ForeColor = System.Drawing.Color.DarkGray;
            this.TabPaymentTypes.Location = new System.Drawing.Point(383, 11);
            this.TabPaymentTypes.Name = "TabPaymentTypes";
            this.TabPaymentTypes.Size = new System.Drawing.Size(133, 28);
            this.TabPaymentTypes.TabIndex = 122;
            this.TabPaymentTypes.Text = "Payment Types";
            this.TabPaymentTypes.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabSeperator
            // 
            this.TabSeperator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSeperator.BackColor = System.Drawing.Color.Transparent;
            this.TabSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.TabSeperator.LineThickness = 1;
            this.TabSeperator.Location = new System.Drawing.Point(8, 42);
            this.TabSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.TabSeperator.Name = "TabSeperator";
            this.TabSeperator.Size = new System.Drawing.Size(1135, 10);
            this.TabSeperator.TabIndex = 10;
            this.TabSeperator.Transparency = 255;
            this.TabSeperator.Vertical = false;
            // 
            // TabSoftware
            // 
            this.TabSoftware.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabSoftware.AutoSize = true;
            this.TabSoftware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSoftware.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabSoftware.ForeColor = System.Drawing.Color.DarkGray;
            this.TabSoftware.Location = new System.Drawing.Point(810, 10);
            this.TabSoftware.Name = "TabSoftware";
            this.TabSoftware.Size = new System.Drawing.Size(82, 28);
            this.TabSoftware.TabIndex = 120;
            this.TabSoftware.Text = "Software";
            this.TabSoftware.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabGeneral.AutoSize = true;
            this.TabGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabGeneral.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabGeneral.Location = new System.Drawing.Point(246, 10);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Size = new System.Drawing.Size(76, 28);
            this.TabGeneral.TabIndex = 117;
            this.TabGeneral.Text = "General";
            this.TabGeneral.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // TabUsers
            // 
            this.TabUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabUsers.AutoSize = true;
            this.TabUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabUsers.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.TabUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.TabUsers.Location = new System.Drawing.Point(694, 10);
            this.TabUsers.Name = "TabUsers";
            this.TabUsers.Size = new System.Drawing.Size(55, 28);
            this.TabUsers.TabIndex = 118;
            this.TabUsers.Text = "Users";
            this.TabUsers.Click += new System.EventHandler(this.TabLabel_Click);
            // 
            // Tabs
            // 
            this.Tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Tabs.Controls.Add(this.TabIndicator);
            this.Tabs.Controls.Add(this.TabTaxes);
            this.Tabs.Controls.Add(this.TabPaymentTypes);
            this.Tabs.Controls.Add(this.TabSeperator);
            this.Tabs.Controls.Add(this.TabSoftware);
            this.Tabs.Controls.Add(this.TabGeneral);
            this.Tabs.Controls.Add(this.TabUsers);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(1138, 53);
            this.Tabs.TabIndex = 127;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsControl);
            this.Controls.Add(this.Tabs);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1138, 660);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Click += new System.EventHandler(this.OnClick);
            this.Tabs.ResumeLayout(false);
            this.Tabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SettingsControl;
        internal Bunifu.Framework.UI.BunifuSeparator TabIndicator;
        private System.Windows.Forms.Label TabTaxes;
        private System.Windows.Forms.Label TabPaymentTypes;
        internal Bunifu.Framework.UI.BunifuSeparator TabSeperator;
        private System.Windows.Forms.Label TabSoftware;
        private System.Windows.Forms.Label TabGeneral;
        private System.Windows.Forms.Label TabUsers;
        private System.Windows.Forms.Panel Tabs;
    }
}
