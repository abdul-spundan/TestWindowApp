namespace ReportingUtility
{
    partial class PrintUserInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brnSecurityInfo = new System.Windows.Forms.Button();
            this.SecurityReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brnSecurityInfo);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // brnSecurityInfo
            // 
            this.brnSecurityInfo.Location = new System.Drawing.Point(48, 28);
            this.brnSecurityInfo.Name = "brnSecurityInfo";
            this.brnSecurityInfo.Size = new System.Drawing.Size(142, 28);
            this.brnSecurityInfo.TabIndex = 0;
            this.brnSecurityInfo.Text = "Get Report";
            this.brnSecurityInfo.UseVisualStyleBackColor = true;
            this.brnSecurityInfo.Click += new System.EventHandler(this.brnSecurityInfo_Click);
            // 
            // SecurityReportViewer
            // 
            this.SecurityReportViewer.ActiveViewIndex = -1;
            this.SecurityReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecurityReportViewer.CachedPageNumberPerDoc = 10;
            this.SecurityReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecurityReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SecurityReportViewer.Location = new System.Drawing.Point(0, 106);
            this.SecurityReportViewer.Name = "SecurityReportViewer";
            this.SecurityReportViewer.Size = new System.Drawing.Size(784, 456);
            this.SecurityReportViewer.TabIndex = 1;
            // 
            // PrintUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.SecurityReportViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintUserInformation";
            this.Text = "TestApp::-PrintUserSecurityInformation";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button brnSecurityInfo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer SecurityReportViewer;
    }
}