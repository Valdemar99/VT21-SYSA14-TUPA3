using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployedWindowsClient
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public Form1()
        {
            InitializeComponent();
            labelFeedback.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelFeedback.ResetText();
            richTextBoxPrintFile.ResetText();

            string fileName = textBoxReadFile.Text;
            string content = "";

            content = dal.ReadFile(fileName);

            if(content == "A file with the inserted filename above does not exist. Did you forget .txt?")
            {
                labelFeedback.Text = content;

            } else if(content == "Please type filename.")
            {
                labelFeedback.Text = content;

            }else if(content == "Check your connection and try again.")
            {
                labelFeedback.Text = content;
            }
            else
            {
                richTextBoxPrintFile.Text = content;
            }
            

        }
    }
}
