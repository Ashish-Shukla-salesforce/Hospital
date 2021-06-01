namespace RFID_SmartHealthCard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.LogOutBTN = new DevComponents.DotNetBar.ButtonX();
            this.SearchPatientBTN = new DevComponents.DotNetBar.ButtonX();
            this.SettingBTN = new DevComponents.DotNetBar.ButtonX();
            this.PatientBTN = new DevComponents.DotNetBar.ButtonX();
            this.ScanCardBTN = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.InValidCardL = new DevComponents.DotNetBar.LabelX();
            this.LogBTN = new DevComponents.DotNetBar.ButtonX();
            this.InfoL = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.reflectionImage1);
            this.splitContainer1.Panel1.Controls.Add(this.reflectionLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 521);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.TabIndex = 0;
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.BackgroundImage = global::RFID_SmartHealthCard.Properties.Resources.Health_care_shield;
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Location = new System.Drawing.Point(11, 7);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(64, 64);
            this.reflectionImage1.TabIndex = 3;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.reflectionLabel1.Location = new System.Drawing.Point(93, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(267, 61);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "Smart Health Card";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelEx1);
            this.splitContainer2.Panel1.Controls.Add(this.SearchPatientBTN);
            this.splitContainer2.Panel1.Controls.Add(this.SettingBTN);
            this.splitContainer2.Panel1.Controls.Add(this.PatientBTN);
            this.splitContainer2.Panel1.Controls.Add(this.ScanCardBTN);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1107, 436);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.LogOutBTN);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 344);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(241, 90);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            this.panelEx1.Text = "panelEx1";
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LogOutBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LogOutBTN.Location = new System.Drawing.Point(11, 10);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(217, 70);
            this.LogOutBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LogOutBTN.TabIndex = 3;
            this.LogOutBTN.Text = "Close";
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // SearchPatientBTN
            // 
            this.SearchPatientBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SearchPatientBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SearchPatientBTN.Location = new System.Drawing.Point(11, 80);
            this.SearchPatientBTN.Name = "SearchPatientBTN";
            this.SearchPatientBTN.Size = new System.Drawing.Size(217, 70);
            this.SearchPatientBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SearchPatientBTN.TabIndex = 4;
            this.SearchPatientBTN.Text = "Select Patient";
            this.SearchPatientBTN.Click += new System.EventHandler(this.SearchPatientBTN_Click);
            // 
            // SettingBTN
            // 
            this.SettingBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SettingBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SettingBTN.Location = new System.Drawing.Point(12, 232);
            this.SettingBTN.Name = "SettingBTN";
            this.SettingBTN.Size = new System.Drawing.Size(217, 70);
            this.SettingBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SettingBTN.TabIndex = 2;
            this.SettingBTN.Text = "Settings";
            this.SettingBTN.Click += new System.EventHandler(this.SettingBTN_Click);
            // 
            // PatientBTN
            // 
            this.PatientBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PatientBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.PatientBTN.Location = new System.Drawing.Point(12, 156);
            this.PatientBTN.Name = "PatientBTN";
            this.PatientBTN.Size = new System.Drawing.Size(217, 70);
            this.PatientBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PatientBTN.TabIndex = 1;
            this.PatientBTN.Text = "Patients";
            this.PatientBTN.Click += new System.EventHandler(this.PatientBTN_Click);
            // 
            // ScanCardBTN
            // 
            this.ScanCardBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ScanCardBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ScanCardBTN.Location = new System.Drawing.Point(11, 6);
            this.ScanCardBTN.Name = "ScanCardBTN";
            this.ScanCardBTN.Size = new System.Drawing.Size(217, 70);
            this.ScanCardBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ScanCardBTN.TabIndex = 0;
            this.ScanCardBTN.Text = "Scan Card";
            this.ScanCardBTN.Click += new System.EventHandler(this.ScanCardBTN_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.InValidCardL);
            this.groupPanel1.Controls.Add(this.LogBTN);
            this.groupPanel1.Controls.Add(this.InfoL);
            this.groupPanel1.Location = new System.Drawing.Point(395, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(448, 424);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Patient Details";
            // 
            // InValidCardL
            // 
            this.InValidCardL.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.InValidCardL.BackgroundStyle.Class = "";
            this.InValidCardL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InValidCardL.ForeColor = System.Drawing.Color.Red;
            this.InValidCardL.Location = new System.Drawing.Point(21, 10);
            this.InValidCardL.Name = "InValidCardL";
            this.InValidCardL.Size = new System.Drawing.Size(418, 23);
            this.InValidCardL.TabIndex = 29;
            // 
            // LogBTN
            // 
            this.LogBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LogBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LogBTN.Enabled = false;
            this.LogBTN.Location = new System.Drawing.Point(21, 317);
            this.LogBTN.Name = "LogBTN";
            this.LogBTN.Size = new System.Drawing.Size(405, 70);
            this.LogBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LogBTN.TabIndex = 3;
            this.LogBTN.Text = "Patient Case History - Medical Log";
            this.LogBTN.Click += new System.EventHandler(this.LogBTN_Click);
            // 
            // InfoL
            // 
            this.InfoL.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.InfoL.BackgroundStyle.Class = "";
            this.InfoL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InfoL.Location = new System.Drawing.Point(21, 32);
            this.InfoL.Name = "InfoL";
            this.InfoL.Size = new System.Drawing.Size(361, 263);
            this.InfoL.TabIndex = 0;
            this.InfoL.Text = "No Patient Selected";
            this.InfoL.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.InfoL.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::RFID_SmartHealthCard.Properties.Resources.Patient_50_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 521);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.ButtonX SettingBTN;
        private DevComponents.DotNetBar.ButtonX PatientBTN;
        private DevComponents.DotNetBar.ButtonX LogOutBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX InfoL;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX LogBTN;
        private DevComponents.DotNetBar.ButtonX ScanCardBTN;
        private DevComponents.DotNetBar.LabelX InValidCardL;
        private DevComponents.DotNetBar.ButtonX SearchPatientBTN;
        private DevComponents.DotNetBar.PanelEx panelEx1;

    }
}