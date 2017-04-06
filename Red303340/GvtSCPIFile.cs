using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red303340
{
    class GvtSCPIFile
    {
        Dictionary<string, string[]> SCPIdic =
           new Dictionary<string, string[]>();
        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "xls files (*.*)|*.*";
          
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(dialog.FileName);
                parseSCPI(lines);
            }
        }
        void parseSCPI(string[] lines)
        {
            List<string> termsList = new List<string>();
            string title = "";
            string lastlGvtTitle = "";
            int i = 0;
            foreach (string line in lines)
            {
                string s;
                s = parseLine(line);
                if (s.Length < 1) { continue; }

                if (s.Contains(GVTCommonConfig.GVTKEY))
                {

                    if (termsList.Count < 2) { continue; }
                    title = scpiTitle(i, s);
                    SCPIdic.Add(title, termsList.ToArray());
                    termsList.Clear();
                    i++;
                    lastlGvtTitle = scpiTitle(i, s);
                }
                else
                {

                    termsList.Add(s);
                }

            }

            SCPIdic.Add(lastlGvtTitle, termsList.ToArray());
            //string[] c = termsList.ToArray();
        
        }
        string parseLine(string s)
        {
            return s.Replace(" ", "").Replace("//", " ").Trim().Replace("\\s", " ");
        }
        string scpiTitle(int index, string line)
        {
            string result;
            if (index < 4)
            { result = GVTCommonConfig.testEnv[index]; }
            else
            {
                result = line;
            }
            return result;

        }
    }
}
