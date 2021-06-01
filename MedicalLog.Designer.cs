namespace RFID_SmartHealthCard
{
    partial class MedicalLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AddNewLogBTN = new DevComponents.DotNetBar.ButtonX();
            this.NextLog = new DevComponents.DotNetBar.ButtonX();
            this.PrevLog = new DevComponents.DotNetBar.ButtonX();
            this.DescriptionTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LogDateL = new DevComponents.DotNetBar.LabelX();
            this.DoctorL = new DevComponents.DotNetBar.LabelX();
            this.LogTitleL = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SearchBTN = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DeleteBTN = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DeleteBTN);
            this.splitContainer1.Panel2.Controls.Add(this.AddNewLogBTN);
            this.splitContainer1.Panel2.Controls.Add(this.NextLog);
            this.splitContainer1.Panel2.Controls.Add(this.PrevLog);
            this.splitContainer1.Panel2.Controls.Add(this.DescriptionTB);
            this.splitContainer1.Panel2.Controls.Add(this.LogDateL);
            this.splitContainer1.Panel2.Controls.Add(this.DoctorL);
            this.splitContainer1.Panel2.Controls.Add(this.LogTitleL);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 486);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewX1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(628, 484);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewX1_UserDeletingRow);
            this.dataGridViewX1.Click += new System.EventHandler(this.dataGridViewX1_Click);
            this.dataGridViewX1.DoubleClick += new System.EventHandler(this.dataGridViewX1_DoubleClick);
            // 
            // AddNewLogBTN
            // 
            this.AddNewLogBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddNewLogBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddNewLogBTN.Location = new System.Drawing.Point(174, 14);
            this.AddNewLogBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewLogBTN.Name = "AddNewLogBTN";
            this.AddNewLogBTN.Size = new System.Drawing.Size(165, 51);
            this.AddNewLogBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddNewLogBTN.TabIndex = 10;
            this.AddNewLogBTN.Text = "Add New Log";
            this.AddNewLogBTN.Click += new System.EventHandler(this.AddNewLogBTN_Click);
            // 
            // NextLog
            // 
            this.NextLog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.NextLog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.NextLog.Location = new System.Drawing.Point(357, 14);
            this.NextLog.Margin = new System.Windows.Forms.Padding(4);
            this.NextLog.Name = "NextLog";
            this.NextLog.Size = new System.Drawing.Size(137, 51);
            this.NextLog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.NextLog.TabIndex = 9;
            this.NextLog.Text = "Next Log >>";
            this.NextLog.Click += new System.EventHandler(this.NextLog_Click);
            // 
            // PrevLog
            // 
            this.PrevLog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PrevLog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.PrevLog.Location = new System.Drawing.Point(14, 14);
            this.PrevLog.Margin = new System.Windows.Forms.Padding(4);
            this.PrevLog.Name = "PrevLog";
            this.PrevLog.Size = new System.Drawing.Size(137, 51);
            this.PrevLog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PrevLog.TabIndex = 8;
            this.PrevLog.Text = "<< Previous Log";
            this.PrevLog.Click += new System.EventHandler(this.PrevLog_Click);
            // 
            // DescriptionTB
            // 
            // 
            // 
            // 
            this.DescriptionTB.Border.Class = "TextBoxBorder";
            this.DescriptionTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DescriptionTB.Location = new System.Drawing.Point(14, 159);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(506, 293);
            this.DescriptionTB.TabIndex = 4;
            // 
            // LogDateL
            // 
            // 
            // 
            // 
            this.LogDateL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LogDateL.Location = new System.Drawing.Point(30, 101);
            this.LogDateL.Name = "LogDateL";
            this.LogDateL.Size = new System.Drawing.Size(327, 23);
            this.LogDateL.TabIndex = 3;
            this.LogDateL.Text = "Date :";
            // 
            // DoctorL
            // 
            // 
            // 
            // 
            this.DoctorL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DoctorL.Location = new System.Drawing.Point(30, 130);
            this.DoctorL.Name = "DoctorL";
            this.DoctorL.Size = new System.Drawing.Size(464, 23);
            this.DoctorL.TabIndex = 2;
            this.DoctorL.Text = "Doctor / Hospital / Lab :";
            // 
            // LogTitleL
            // 
            // 
            // 
            // 
            this.LogTitleL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LogTitleL.Location = new System.Drawing.Point(30, 72);
            this.LogTitleL.Name = "LogTitleL";
            this.LogTitleL.Size = new System.Drawing.Size(464, 23);
            this.LogTitleL.TabIndex = 0;
            this.LogTitleL.Text = "Event Name :";
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
            this.reflectionLabel1.Location = new System.Drawing.Point(16, 15);
            this.reflectionLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(298, 75);
            this.reflectionLabel1.TabIndex = 2;
            this.reflectionLabel1.Text = "Patient Case History";
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(576, 28);
            this.StartdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(336, 22);
            this.StartdateTimePicker.TabIndex = 3;
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Location = new System.Drawing.Point(576, 65);
            this.EnddateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(336, 22);
            this.EnddateTimePicker.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(532, 28);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "From";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(532, 59);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(36, 28);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "To";
            // 
            // SearchBTN
            // 
            this.SearchBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SearchBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SearchBTN.Location = new System.Drawing.Point(920, 28);
            this.SearchBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(215, 62);
            this.SearchBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SearchBTN.TabIndex = 7;
            this.SearchBTN.Text = "Show Logs Between Dates";
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.reflectionLabel1);
            this.splitContainer2.Panel1.Controls.Add(this.SearchBTN);
            this.splitContainer2.Panel1.Controls.Add(this.StartdateTimePicker);
            this.splitContainer2.Panel1.Controls.Add(this.labelX2);
            this.splitContainer2.Panel1.Controls.Add(this.EnddateTimePicker);
            this.splitContainer2.Panel1.Controls.Add(this.labelX1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1172, 591);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 8;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DeleteBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DeleteBTN.Location = new System.Drawing.Point(357, 73);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(137, 51);
            this.DeleteBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DeleteBTN.TabIndex = 9;
            this.DeleteBTN.Text = "Delete Record";
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // MedicalLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 591);
            this.Controls.Add(this.splitContainer2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicalLog";
            this.Text = "MedicalLog";
            this.Load += new System.EventHandler(this.MedicalLog_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private DevComponents.DotNetBar.ButtonX SearchBTN;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.LabelX LogDateL;
        private DevComponents.DotNetBar.LabelX DoctorL;
        private DevComponents.DotNetBar.LabelX LogTitleL;
        private DevComponents.DotNetBar.Controls.TextBoxX DescriptionTB;
        private DevComponents.DotNetBar.ButtonX PrevLog;
        private DevComponents.DotNetBar.ButtonX NextLog;
        private DevComponents.DotNetBar.ButtonX AddNewLogBTN;
        private DevComponents.DotNetBar.ButtonX DeleteBTN;
    }
}