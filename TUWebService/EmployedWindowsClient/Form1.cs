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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = textBoxReadFile.Text;
            string content = "";

            content = dal.ReadFile(fileName);

            if(content == "")
            {
                labelFeedback.Text = "Could not find file, please try again.";

            } else
            {
                labelFeedback.ResetText();
                richTextBoxPrintFile.Text = content;
            }
            

        }
    }
}
