namespace AIMLAnalyzer
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.gbEval = new System.Windows.Forms.GroupBox();
            this.box_log = new System.Windows.Forms.RichTextBox();
            this.gbAIML = new System.Windows.Forms.GroupBox();
            this.desc_Location = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.Report = new System.Windows.Forms.TabPage();
            this.gbIndividual = new System.Windows.Forms.GroupBox();
            this.combo_report = new System.Windows.Forms.ComboBox();
            this.lblFileReport = new System.Windows.Forms.Label();
            this.box_report = new System.Windows.Forms.RichTextBox();
            this.gbExport = new System.Windows.Forms.GroupBox();
            this.btnOpenAIML = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.gbEval.SuspendLayout();
            this.gbAIML.SuspendLayout();
            this.Report.SuspendLayout();
            this.gbIndividual.SuspendLayout();
            this.gbExport.SuspendLayout();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Configuration);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.gbEval);
            this.Configuration.Controls.Add(this.gbAIML);
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(807, 682);
            this.Configuration.TabIndex = 0;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // gbEval
            // 
            this.gbEval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEval.Controls.Add(this.box_log);
            this.gbEval.Location = new System.Drawing.Point(7, 161);
            this.gbEval.Name = "gbEval";
            this.gbEval.Size = new System.Drawing.Size(794, 515);
            this.gbEval.TabIndex = 1;
            this.gbEval.TabStop = false;
            this.gbEval.Text = "Evaluation";
            // 
            // box_log
            // 
            this.box_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_log.BackColor = System.Drawing.Color.Black;
            this.box_log.ForeColor = System.Drawing.Color.White;
            this.box_log.Location = new System.Drawing.Point(6, 19);
            this.box_log.Name = "box_log";
            this.box_log.ReadOnly = true;
            this.box_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.box_log.Size = new System.Drawing.Size(782, 490);
            this.box_log.TabIndex = 0;
            this.box_log.Text = "";
            this.box_log.TextChanged += new System.EventHandler(this.box_log_TextChanged);
            // 
            // gbAIML
            // 
            this.gbAIML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAIML.Controls.Add(this.btnScan);
            this.gbAIML.Controls.Add(this.desc_Location);
            this.gbAIML.Controls.Add(this.txtLocation);
            this.gbAIML.Controls.Add(this.btnOpenAIML);
            this.gbAIML.Location = new System.Drawing.Point(7, 7);
            this.gbAIML.Name = "gbAIML";
            this.gbAIML.Size = new System.Drawing.Size(794, 147);
            this.gbAIML.TabIndex = 0;
            this.gbAIML.TabStop = false;
            this.gbAIML.Text = "AIML";
            // 
            // desc_Location
            // 
            this.desc_Location.AutoSize = true;
            this.desc_Location.Location = new System.Drawing.Point(197, 28);
            this.desc_Location.Name = "desc_Location";
            this.desc_Location.Size = new System.Drawing.Size(52, 13);
            this.desc_Location.TabIndex = 2;
            this.desc_Location.Text = "Directory:";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.CausesValidation = false;
            this.txtLocation.Location = new System.Drawing.Point(200, 47);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(588, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.gbExport);
            this.Report.Controls.Add(this.gbIndividual);
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(807, 682);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // gbIndividual
            // 
            this.gbIndividual.Controls.Add(this.box_report);
            this.gbIndividual.Controls.Add(this.lblFileReport);
            this.gbIndividual.Controls.Add(this.combo_report);
            this.gbIndividual.Enabled = false;
            this.gbIndividual.Location = new System.Drawing.Point(4, 4);
            this.gbIndividual.Name = "gbIndividual";
            this.gbIndividual.Size = new System.Drawing.Size(800, 466);
            this.gbIndividual.TabIndex = 0;
            this.gbIndividual.TabStop = false;
            this.gbIndividual.Text = "Individualized Report";
            // 
            // combo_report
            // 
            this.combo_report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_report.FormattingEnabled = true;
            this.combo_report.Location = new System.Drawing.Point(6, 37);
            this.combo_report.Name = "combo_report";
            this.combo_report.Size = new System.Drawing.Size(788, 21);
            this.combo_report.TabIndex = 0;
            this.combo_report.SelectedIndexChanged += new System.EventHandler(this.combo_report_SelectedIndexChanged);
            // 
            // lblFileReport
            // 
            this.lblFileReport.AutoSize = true;
            this.lblFileReport.Location = new System.Drawing.Point(3, 21);
            this.lblFileReport.Name = "lblFileReport";
            this.lblFileReport.Size = new System.Drawing.Size(59, 13);
            this.lblFileReport.TabIndex = 1;
            this.lblFileReport.Text = "Select File:";
            // 
            // box_report
            // 
            this.box_report.Location = new System.Drawing.Point(6, 64);
            this.box_report.Name = "box_report";
            this.box_report.ReadOnly = true;
            this.box_report.Size = new System.Drawing.Size(788, 396);
            this.box_report.TabIndex = 2;
            this.box_report.Text = "";
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.btnExportAll);
            this.gbExport.Controls.Add(this.btnExport);
            this.gbExport.Enabled = false;
            this.gbExport.Location = new System.Drawing.Point(4, 477);
            this.gbExport.Name = "gbExport";
            this.gbExport.Size = new System.Drawing.Size(794, 190);
            this.gbExport.TabIndex = 1;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Export";
            // 
            // btnOpenAIML
            // 
            this.btnOpenAIML.Image = global::AIMLAnalyzer.Properties.Resources.folder;
            this.btnOpenAIML.Location = new System.Drawing.Point(42, 30);
            this.btnOpenAIML.Name = "btnOpenAIML";
            this.btnOpenAIML.Size = new System.Drawing.Size(109, 98);
            this.btnOpenAIML.TabIndex = 0;
            this.btnOpenAIML.Text = "&Browse AIML";
            this.btnOpenAIML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenAIML.UseVisualStyleBackColor = true;
            this.btnOpenAIML.Click += new System.EventHandler(this.btnOpenAIML_Click);
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Image = global::AIMLAnalyzer.Properties.Resources.analytics;
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.Location = new System.Drawing.Point(645, 93);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(143, 48);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "&Analyze";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::AIMLAnalyzer.Properties.Resources.import;
            this.btnExport.Location = new System.Drawing.Point(21, 51);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 112);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Report for File: ";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Image = global::AIMLAnalyzer.Properties.Resources.import;
            this.btnExportAll.Location = new System.Drawing.Point(153, 51);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(126, 112);
            this.btnExportAll.TabIndex = 1;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // About
            // 
            this.About.Controls.Add(this.linkLabel1);
            this.About.Controls.Add(this.label4);
            this.About.Controls.Add(this.label3);
            this.About.Controls.Add(this.label2);
            this.About.Controls.Add(this.label1);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(807, 682);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Icons are Designed by Freepik and distributed by Flaticon\r\nImages and Icons are t" +
    "he property of their respective author(s).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acknowledgement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "License";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(668, 60);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(20, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "flaticon.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // main
            // 
            this.AcceptButton = this.btnOpenAIML;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 732);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(855, 771);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIMLAnalyzer";
            this.tabControl1.ResumeLayout(false);
            this.Configuration.ResumeLayout(false);
            this.gbEval.ResumeLayout(false);
            this.gbAIML.ResumeLayout(false);
            this.gbAIML.PerformLayout();
            this.Report.ResumeLayout(false);
            this.gbIndividual.ResumeLayout(false);
            this.gbIndividual.PerformLayout();
            this.gbExport.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.GroupBox gbAIML;
        private System.Windows.Forms.Button btnOpenAIML;
        private System.Windows.Forms.Label desc_Location;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox gbEval;
        private System.Windows.Forms.Button btnScan;
        public System.Windows.Forms.RichTextBox box_log;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.GroupBox gbIndividual;
        private System.Windows.Forms.Label lblFileReport;
        private System.Windows.Forms.ComboBox combo_report;
        private System.Windows.Forms.RichTextBox box_report;
        private System.Windows.Forms.GroupBox gbExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

