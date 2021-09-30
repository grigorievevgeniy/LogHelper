using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Logger.Error(\"Enter\");");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Logger.Error(\"Exit\");");
        }

        private void btnLogValue_Click(object sender, EventArgs e)
        {
            // ToDo Проверка что в буфере текст.

            var text = Clipboard.GetText();
            if (!text.Contains("Logger.Error("))
            {
                var textText = text.Replace("\"", "\\\"");
                Clipboard.SetText($"Logger.Error($\"{textText} - {{{text}}}\");");
            }
        }

        private void btnLogName_Click(object sender, EventArgs e)
        {
            // ToDo Проверка что в буфере текст.
            
            var text = Clipboard.GetText();
            if (!text.Contains("Logger.Error("))
            {
                Clipboard.SetText($"Logger.Error(\"{text}\");");
            }
        }
    }
}
