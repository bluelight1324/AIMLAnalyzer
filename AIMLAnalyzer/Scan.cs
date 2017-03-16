using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AIMLAnalyzer
{
    class Scan
    {
        public string CategoryScan(string file)
        {
            int CountCat = 0;
            int UnCloseCat = 0;
            string report_Unclosed = null;
            bool FoundCat = false;
            int i = 0;
            StreamReader read = new StreamReader(file);
            while (!read.EndOfStream)
            {
                string line = read.ReadLine().ToLower();

                if (line.Contains("<category>") && line.Contains("</category>"))
                {
                    CountCat++;
                }
                else if (FoundCat && line.Contains("</category>"))
                {
                    CountCat++;
                    FoundCat = false;
                }
                else if (FoundCat == false && line.Contains("<category>"))
                {
                    FoundCat = true;
                }
                else if (FoundCat && line.Contains("<category>"))
                {
                    UnCloseCat++;
                    report_Unclosed += "\nMT: Line: " + (i - 1);
                }

                i++;
            }

            read.Close();
            if (UnCloseCat > 0)
            {
                return "Found Unit(s) of Knowledge: " + CountCat + "\nFound Unclosed Tag(s): " + UnCloseCat + "\nReport:\n " + report_Unclosed;
            } else
            {
                return "Found Unit(s) of Knowledge: " + CountCat + "\nFound Unclosed Tag(s): " + UnCloseCat + "\nReport: OK";
            }
            
        }

        public string PatternScan(string file)
        {
            int CountPat = 0;
            int UnClosedPat = 0;
            string report_Unclosed = null;
            bool FoundPat = false;
            int i = 0;
            StreamReader read = new StreamReader(file);
            while (!read.EndOfStream)
            {
                string line = read.ReadLine().ToLower();

                if (line.Contains("<pattern>") && line.Contains("</pattern>"))
                {
                    CountPat++;
                }
                else if (FoundPat && line.Contains("</pattern>"))
                {
                    CountPat++;
                    FoundPat = false;
                }
                else if (FoundPat == false && line.Contains("<pattern>"))
                {
                    FoundPat = true;
                }
                else if (FoundPat && line.Contains("<pattern>"))
                {
                    UnClosedPat++;
                    report_Unclosed += "\nMT: Line: " + (i - 1);
                }

                i++;
            }

            read.Close();
            if (UnClosedPat > 0)
            {
               return "Found Pattern(s): " + CountPat + "\nFound Unclosed Tag(s): " + UnClosedPat + "\nReport:\n " + report_Unclosed;
            } else
            {
                return "Found Pattern(s): " + CountPat + "\nFound Unclosed Tag(s): " + UnClosedPat + "\nReport: OK";
            }
            
        }

        public string TemplateScan(string file)
        {
            int CountTemp = 0;
            int UnClosedTemp = 0;
            string report_Unclosed = null;
            bool FoundTemp = false;
            int i = 0;
            StreamReader read = new StreamReader(file);
            while (!read.EndOfStream)
            {
                string line = read.ReadLine().ToLower();

                if (line.Contains("<template>") && line.Contains("</template>"))
                {
                    CountTemp++;
                }
                else if (FoundTemp && line.Contains("</template>"))
                {
                    CountTemp++;
                    FoundTemp = false;
                }
                else if (FoundTemp == false && line.Contains("<template>"))
                {
                    FoundTemp = true;
                }
                else if (FoundTemp && line.Contains("<template>"))
                {
                    UnClosedTemp++;
                    report_Unclosed += "\nMT: Line: " + (i - 1);
                }

                i++;
            }

            read.Close();
            if (UnClosedTemp > 0)
            {
                return "Found Templates(s): " + CountTemp + "\nFound Unclosed Tag(s): " + UnClosedTemp + "\nReport:\n " + report_Unclosed;
            } else
            {
                return "Found Templates(s): " + CountTemp + "\nFound Unclosed Tag(s): " + UnClosedTemp + "\nReport: OK";
            }
        }
            
    }
}
