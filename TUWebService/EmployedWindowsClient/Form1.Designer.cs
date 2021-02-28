namespace EmployedWindowsClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxReadFile = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.richTextBoxPrintFile = new System.Windows.Forms.RichTextBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(397, 19);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(102, 23);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Read file";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(32, 24);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(80, 13);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "Enter file name:";
            // 
            // textBoxReadFile
            // 
            this.textBoxReadFile.Location = new System.Drawing.Point(138, 21);
            this.textBoxReadFile.Name = "textBoxReadFile";
            this.textBoxReadFile.Size = new System.Drawing.Size(220, 20);
            this.textBoxReadFile.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // richTextBoxPrintFile
            // 
            this.richTextBoxPrintFile.Location = new System.Drawing.Point(35, 69);
            this.richTextBoxPrintFile.Name = "richTextBoxPrintFile";
            this.richTextBoxPrintFile.Size = new System.Drawing.Size(464, 329);
            this.richTextBoxPrintFile.TabIndex = 5;
            this.richTextBoxPrintFile.Text = "";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(32, 53);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(35, 13);
            this.labelFeedback.TabIndex = 6;
            this.labelFeedback.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 439);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.richTextBoxPrintFile);
            this.Controls.Add(this.textBoxReadFile);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Form1";
            this.Text = "Programming Assignment 3 - Technological Unemployment, Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxReadFile;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxPrintFile;
        private System.Windows.Forms.Label labelFeedback;
    }
}

