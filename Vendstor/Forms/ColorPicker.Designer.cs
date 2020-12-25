namespace Vendstor.Forms
{
    partial class ColorPicker
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
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardColor = new Bunifu.Framework.UI.BunifuCards();
            this.trackRed = new Bunifu.Framework.UI.BunifuTrackbar();
            this.trackGreen = new Bunifu.Framework.UI.BunifuTrackbar();
            this.trackBlue = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.timSetColor = new System.Windows.Forms.Timer(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(407, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 17);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 133;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // cardColor
            // 
            this.cardColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.cardColor.BorderRadius = 0;
            this.cardColor.BottomSahddow = true;
            this.cardColor.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.cardColor.LeftSahddow = false;
            this.cardColor.Location = new System.Drawing.Point(105, 12);
            this.cardColor.Name = "cardColor";
            this.cardColor.RightSahddow = true;
            this.cardColor.ShadowDepth = 20;
            this.cardColor.Size = new System.Drawing.Size(227, 90);
            this.cardColor.TabIndex = 134;
            // 
            // trackRed
            // 
            this.trackRed.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.trackRed.BackColor = System.Drawing.Color.Transparent;
            this.trackRed.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.trackRed.BorderRadius = 5;
            this.trackRed.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.trackRed.Location = new System.Drawing.Point(84, 119);
            this.trackRed.MaximumValue = 255;
            this.trackRed.MinimumValue = 0;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(269, 30);
            this.trackRed.SliderRadius = 0;
            this.trackRed.TabIndex = 135;
            this.trackRed.Value = 0;
            this.trackRed.ValueChanged += new System.EventHandler(this.OnTrackValueChange);
            // 
            // trackGreen
            // 
            this.trackGreen.BackColor = System.Drawing.Color.Transparent;
            this.trackGreen.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.trackGreen.BorderRadius = 5;
            this.trackGreen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.trackGreen.Location = new System.Drawing.Point(84, 155);
            this.trackGreen.MaximumValue = 255;
            this.trackGreen.MinimumValue = 0;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(269, 30);
            this.trackGreen.SliderRadius = 0;
            this.trackGreen.TabIndex = 136;
            this.trackGreen.Value = 0;
            this.trackGreen.ValueChanged += new System.EventHandler(this.OnTrackValueChange);
            // 
            // trackBlue
            // 
            this.trackBlue.BackColor = System.Drawing.Color.Transparent;
            this.trackBlue.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.trackBlue.BorderRadius = 5;
            this.trackBlue.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.trackBlue.Location = new System.Drawing.Point(84, 191);
            this.trackBlue.MaximumValue = 255;
            this.trackBlue.MinimumValue = 0;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(269, 30);
            this.trackBlue.SliderRadius = 0;
            this.trackBlue.TabIndex = 137;
            this.trackBlue.Value = 0;
            this.trackBlue.ValueChanged += new System.EventHandler(this.OnTrackValueChange);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblRed.Location = new System.Drawing.Point(12, 119);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(40, 26);
            this.lblRed.TabIndex = 138;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblGreen.Location = new System.Drawing.Point(12, 155);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(56, 26);
            this.lblGreen.TabIndex = 139;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblBlue.Location = new System.Drawing.Point(12, 191);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(42, 26);
            this.lblBlue.TabIndex = 140;
            this.lblBlue.Text = "Blue";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblRedValue.Location = new System.Drawing.Point(372, 119);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(21, 26);
            this.lblRedValue.TabIndex = 141;
            this.lblRedValue.Text = "0";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblGreenValue.Location = new System.Drawing.Point(372, 155);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(21, 26);
            this.lblGreenValue.TabIndex = 142;
            this.lblGreenValue.Text = "0";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblBlueValue.Location = new System.Drawing.Point(372, 191);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(21, 26);
            this.lblBlueValue.TabIndex = 143;
            this.lblBlueValue.Text = "0";
            // 
            // timSetColor
            // 
            this.timSetColor.Enabled = true;
            this.timSetColor.Interval = 500;
            this.timSetColor.Tick += new System.EventHandler(this.TimSetColor_Tick);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 237);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.cardColor);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Color Picker";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCards cardColor;
        private Bunifu.Framework.UI.BunifuTrackbar trackBlue;
        private Bunifu.Framework.UI.BunifuTrackbar trackGreen;
        private Bunifu.Framework.UI.BunifuTrackbar trackRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Timer timSetColor;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}