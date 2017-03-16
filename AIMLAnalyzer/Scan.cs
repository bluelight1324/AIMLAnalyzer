using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string RandomScan(string file)
        {
            int CountRan = 0;
            int CountLi = 0;
            int UnClosedRan = 0;
            int UnClosedLi = 0;
            string report_UnclosedRan = null;
            string report_UnClosedLi = null;
            bool FoundRan = false;
            bool FoundLi = false;
            int i = 0;
            StreamReader read = new StreamReader(file);
            while (!read.EndOfStream)
            {
                string line = read.ReadLine().ToLower();

               if (line.Contains("<random>") && line.Contains("</random>"))
                {
                    if (line.Contains("<li>") && line.Contains("</li>"))
                    {
                        int nLi = Regex.Matches(Regex.Escape(line), "<li>").Count;
                        int notLi = Regex.Matches(Regex.Escape(line), "</li>").Count;

                        if ((nLi + notLi) /2 == 0)
                        {
                            CountLi += nLi;
                        } else
                        {
                            report_UnClosedLi += "\nMT: Line: " + (i - 1);
                        }

                        CountRan++;
                    } else if (line.Contains("<li>"))
                    {
                        report_UnClosedLi += "\nMT: Line: " + (i - 1);
                    }
                } else if (line.Contains("<random>") && FoundRan == false)
                {
                    FoundRan = true;
                } else if (FoundRan && !line.Contains("</random>"))
                {
                    if (line.Contains("<li>") && line.Contains("</li>"))
                    {
                        CountLi++;
                    } else if (line.Contains("<li>") && FoundLi == false)
                    {
                        FoundLi = true;
                    } else if (FoundLi && line.Contains("</li>"))
                    {
                        CountLi++;
                        FoundLi = false;
                    } else if(line.Contains("</li>") && FoundLi)
                    {
                        report_UnClosedLi += "\nMT: Line: " + (i - 1);
                        UnClosedLi++;
                    }
                } else if (FoundRan && line.Contains("</random>"))
                {
                    CountRan++;
                } else if (FoundRan && line.Contains("<random>"))
                {
                    report_UnclosedRan += "\nMT: Line: " + (i - 1);
                }

                i++;
            }

            read.Close();
            if (UnClosedRan > 0 && UnClosedLi > 0)
            {
                return "\nFix Answers: " + CountRan + " with " +
                    "\nDefined Possiblities: " + CountLi +
                    "\nFound <random> Unclosed Tag(s): " + UnClosedRan +
                    "\nReport:\n " + report_UnclosedRan +
                    "\nFound <li> Unclosed Tag(s): " + UnClosedLi +
                    "\nReport:\n " + report_UnClosedLi;
            }
            else if (UnClosedLi > 0 && UnClosedRan < 0)
            {
                return "\nFix Answers: " + CountRan + " with " +
                    "\nDefined Possiblities: " + CountLi +
                    "\nFound <random> Unclosed Tag(s): " + UnClosedRan +
                    "\nReport: OK" +
                    "\nFound <li> Unclosed Tag(s): " + UnClosedLi;

            } else if (UnClosedRan > 0 && UnClosedLi < 0 )
            {
                return "\nFix Answers: " + CountRan + " with " +
                    "\nDefined Possiblities: " + CountLi +
                    "\nFound <random> Unclosed Tag(s): " + UnClosedRan +
                    "\nReport:\n " + report_UnclosedRan +
                    "\nFound <li> Unclosed Tag(s): " + UnClosedLi +
                    "\nReport: OK";
            } else
            {
                return "\nFix Answers: " + CountRan + " with " +
                    "\nDefined Possiblities: " + CountLi +
                    "\nFound <random> Unclosed Tag(s): " + UnClosedRan +
                    "\nReport: OK" +
                    "\nFound <li> Unclosed Tag(s): " + UnClosedLi +
                    "\nReport: OK";
            }

        }
    }
}
