using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.VisaNS;
using System.Windows.Forms;

namespace Red303340
{
    class gvtMessageSession
    {
        public MessageBasedSession mbSession;
        public void InstrumentConnect(string connectStr)
        {
            try
            {
                mbSession = (MessageBasedSession)ResourceManager.GetLocalManager().Open(connectStr);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(connectStr + "Resource selected must be a message-based session");
            }
            catch (Exception exp)
            {
                MessageBox.Show(connectStr + exp.Message);
            }
        }
        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }
        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }
        public string readSession()
        {  
                try
                {
                    string responseString = mbSession.ReadString();
                    return InsertCommonEscapeSequences(responseString);

                }
                catch (Exception exp)
                {
                    
                    MessageBox.Show(exp.Message);
                    return "0xFFFF";
                }

        }
        public void writeSession(string cmdStr)
        {
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(cmdStr);
                mbSession.Write(textToWrite);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public string QuerrySession(string s)
        {
            string rs = "";
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(s);
                mbSession.Write(s);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            try
            {
                string responseString = readSession();

                rs = InsertCommonEscapeSequences(responseString);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return rs;
        }
    }
}
