using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AIMLAnalyzer
{
    public partial class main : Form
    {
        public List<string> files = new List<string>();
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            Scan analyze = new Scan();
            foreach (string file in files)
            {
                string report; 

                report = "\nFile Report: \"" + file + "\"\n" + analyze.CategoryScan(file) + "\n" + analyze.PatternScan(file) + "\n" + analyze.TemplateScan(file);
                Log(report);

            }

            Log("\nAnalysis Completed.");
        }

        private void box_log_TextChanged(object sender, EventArgs e)
        {
            box_log.SelectionStart = box_log.Text.Length;
            box_log.ScrollToCaret();
        }
    }
}
