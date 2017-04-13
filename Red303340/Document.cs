using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Document;


namespace Red303340
{
    public partial class gvtDocument : Form
    {
        public gvtDocument()
        {
            InitializeComponent();
        }

        private void Document_Load(object sender, EventArgs e)
        {
            // If using Professional version, put your serial key below.
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            DocumentModel document = DocumentModel.Load("en_303340v010102p.docx");

            StringBuilder sb = new StringBuilder();

            foreach (Paragraph paragraph in document.GetChildElements(true, ElementType.Paragraph))
            {
                foreach (Run run in paragraph.GetChildElements(true, ElementType.Run))
                {
                    bool isBold = run.CharacterFormat.Bold;
                    string text = run.Text;

                    sb.AppendFormat("{0}{1}{2}", isBold ? "<b>" : "", text, isBold ? "</b>" : "");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
