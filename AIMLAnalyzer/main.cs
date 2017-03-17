using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AIMLAnalyzer
{
    public partial class main : Form
    {
        public List<string> files = new List<string>();
        public List<string> Reports = new List<string>();
        public main()
        {
            InitializeComponent();
        }

        private void btnOpenAIML_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            open.Description = "Select AIML Files Folder";
            open.ShowDialog();

            string location = open.SelectedPath;
            if (!string.IsNullOrEmpty(location))
            {
                txtLocation.Text = location;
                Log("Selected Directory: \"" + location + "\"" + "\n");

                
                files.Clear();

                foreach (string file in Directory.GetFiles(location))
                {
                    if (Path.GetExtension(file).ToLower() == ".aiml")
                    {
                        files.Add(file);
                        Log("Found AIML File: \"" + file + "\".");
                        combo_report.Items.Clear();

                        // Report ReportObjects
                        box_report.Text = "";
                        gbExport.Enabled = false;
                        gbIndividual.Enabled = false;
                        
                    }
                }

                if (files.Count == 0)
                {
                    Log("No AIML Files Found. \n");
                    btnScan.Enabled = false;
                } else
                {
                    Log("\n" + "(" + files.Count + ") AIML File(s) Added.");
                    btnScan.Enabled = true;
                }
            }

            
        }

        public void Log(string stdin)
        {
            if (string.IsNullOrEmpty(box_log.Text))
            {
                box_log.Text += stdin;
            } else { box_log.Text += "\n" + stdin; }      
        }

        private void CreateReport()
        {
            foreach (string file in this.files)
            {
                string filename = Path.GetFileName(file);
                combo_report.Items.Add(filename);
            }

            combo_report.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Scan analyze = new Scan();
            this.Reports.Clear();

            foreach (string file in files)
            {
                string report; 

                report = "\nFile Report: \"" + file + "\"\n\n" + analyze.CategoryScan(file) + "\n\n" + 
                    analyze.PatternScan(file) + "\n\n" + analyze.TemplateScan(file) + "\n\n" + analyze.RandomScan(file);

                this.Reports.Add(report);

                Log(report);

            }

            Log("\nAnalysis Completed.");

            CreateReport();
            gbIndividual.Enabled = true;
            gbExport.Enabled = true;
        }

        private void box_log_TextChanged(object sender, EventArgs e)
        {
            box_log.SelectionStart = box_log.Text.Length;
            box_log.ScrollToCaret();
        }

        private void combo_report_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string report in this.Reports)
            {
                if (report.Contains(combo_report.Text)) 
                {
                    box_report.Clear();
                    box_report.Text = report;
                    btnExport.Text = "Report for File: " + combo_report.Text;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Select Save Location";
            save.Filter = "Rich Text Document|*.rtf";
            save.ShowDialog();

            if (!string.IsNullOrEmpty(save.FileName))
            {
                StreamWriter writer = new StreamWriter(save.FileName.ToString());
                writer.Write(box_report.Text);
                writer.Close();
            }
         
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Select Save Location";
            save.Filter = "Rich Text Document|*.rtf";
            save.ShowDialog();

            if (!string.IsNullOrEmpty(save.FileName)) 
            {
                StreamWriter writer = new StreamWriter(save.FileName.ToString());
                string reportall = null;

                foreach (string report in this.Reports)
                {
                    reportall += "\n\n ****************************** \n\n" + report;
                }
                writer.Write(reportall);
                writer.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
