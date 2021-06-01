namespace RFID_SmartHealthCard
{
    partial class NewLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLog));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.TitleTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ExaminedByTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LogDate = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.TypeCB = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.DoneBTN = new DevComponents.DotNetBar.ButtonX();
            this.CancelBTN = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.FinalReportTypeCB = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.LogIdL = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.reflectionLabel1.Location = new System.Drawing.Point(14, 14);
            this.reflectionLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(153, 48);
            this.reflectionLabel1.TabIndex = 3;
            this.reflectionLabel1.Text = "New Log";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(370, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 24);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Description";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Log Title";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 239);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 24);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Date";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(24, 182);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(201, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Doctor | Attender | Hospital | Lab";
            // 
            // TitleTB
            // 
            // 
            // 
            // 
            this.TitleTB.Border.Class = "TextBoxBorder";
            this.TitleTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleTB.Location = new System.Drawing.Point(24, 96);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(292, 22);
            this.TitleTB.TabIndex = 10;
            this.superValidator1.SetValidator1(this.TitleTB, this.regularExpressionValidator1);
            // 
            // ExaminedByTB
            // 
            // 
            // 
            // 
            this.ExaminedByTB.Border.Class = "TextBoxBorder";
            this.ExaminedByTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExaminedByTB.Location = new System.Drawing.Point(24, 211);
            this.ExaminedByTB.Name = "ExaminedByTB";
            this.ExaminedByTB.Size = new System.Drawing.Size(292, 22);
            this.ExaminedByTB.TabIndex = 11;
            this.superValidator1.SetValidator1(this.ExaminedByTB, this.regularExpressionValidator2);
            // 
            // LogDate
            // 
            this.LogDate.Location = new System.Drawing.Point(24, 269);
            this.LogDate.Name = "LogDate";
            this.LogDate.Size = new System.Drawing.Size(292, 22);
            this.LogDate.TabIndex = 12;
            // 
            // DescriptionTB
            // 
            // 
            // 
            // 
            this.DescriptionTB.Border.Class = "TextBoxBorder";
            this.DescriptionTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DescriptionTB.Location = new System.Drawing.Point(370, 68);
            this.DescriptionTB.MaxLength = 1000;
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(447, 243);
            this.DescriptionTB.TabIndex = 13;
            this.DescriptionTB.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(24, 124);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "Log Type";
            // 
            // TypeCB
            // 
            this.TypeCB.DisplayMember = "Text";
            this.TypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.ItemHeight = 16;
            this.TypeCB.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.TypeCB.Location = new System.Drawing.Point(24, 154);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(292, 22);
            this.TypeCB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TypeCB.TabIndex = 15;
            this.superValidator1.SetValidator1(this.TypeCB, this.requiredFieldValidator1);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Test CheckUp";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Operation";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Symptoms Show";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Desease Traumic Attack";
            // 
            // DoneBTN
            // 
            this.DoneBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DoneBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DoneBTN.Location = new System.Drawing.Point(633, 321);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(184, 53);
            this.DoneBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DoneBTN.TabIndex = 16;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelBTN.Location = new System.Drawing.Point(370, 321);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(184, 53);
            this.CancelBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelBTN.TabIndex = 17;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "[\\w]";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "[\\w]";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // FinalReportTypeCB
            // 
            this.FinalReportTypeCB.DisplayMember = "Text";
            this.FinalReportTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FinalReportTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinalReportTypeCB.FormattingEnabled = true;
            this.FinalReportTypeCB.ItemHeight = 16;
            this.FinalReportTypeCB.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem10});
            this.FinalReportTypeCB.Location = new System.Drawing.Point(24, 327);
            this.FinalReportTypeCB.Name = "FinalReportTypeCB";
            this.FinalReportTypeCB.Size = new System.Drawing.Size(292, 22);
            this.FinalReportTypeCB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.FinalReportTypeCB.TabIndex = 20;
            this.superValidator1.SetValidator1(this.FinalReportTypeCB, this.requiredFieldValidator1);
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "Negative";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "Positive";
            // 
            // LogIdL
            // 
            // 
            // 
            // 
            this.LogIdL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LogIdL.Location = new System.Drawing.Point(172, 28);
            this.LogIdL.Name = "LogIdL";
            this.LogIdL.Size = new System.Drawing.Size(54, 23);
            this.LogIdL.TabIndex = 18;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(24, 297);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(115, 23);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "Final Report Type";
            // 
            // NewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 389);
            this.Controls.Add(this.FinalReportTypeCB);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.LogIdL);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.LogDate);
            this.Controls.Add(this.ExaminedByTB);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewLog";
            this.Text = "NewLog";
            this.Load += new System.EventHandler(this.NewLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX TitleTB;
        private DevComponents.DotNetBar.Controls.TextBoxX ExaminedByTB;
        private System.Windows.Forms.DateTimePicker LogDate;
        private DevComponents.DotNetBar.Controls.TextBoxX DescriptionTB;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TypeCB;
        private DevComponents.DotNetBar.ButtonX DoneBTN;
        private DevComponents.DotNetBar.ButtonX CancelBTN;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.LabelX LogIdL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx FinalReportTypeCB;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
    }
}