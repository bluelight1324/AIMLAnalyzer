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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.gbEval = new System.Windows.Forms.GroupBox();
            this.box_log = new System.Windows.Forms.RichTextBox();
            this.gbAIML = new System.Windows.Forms.GroupBox();
            this.desc_Location = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnOpenAIML = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.gbEval.SuspendLayout();
            this.gbAIML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Configuration);
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
            this.txtLocation.Size = new System.Drawing.Size(510, 20);
            this.txtLocation.TabIndex = 1;
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
            // main
            // 
            this.AcceptButton = this.btnOpenAIML;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 732);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIMLAnalyzer";
            this.tabControl1.ResumeLayout(false);
            this.Configuration.ResumeLayout(false);
            this.gbEval.ResumeLayout(false);
            this.gbAIML.ResumeLayout(false);
            this.gbAIML.PerformLayout();
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
    }
}

