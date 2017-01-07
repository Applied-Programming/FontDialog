using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fontdialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd_obj = new FontDialog();
            fd_obj.MinSize = 10;
            fd_obj.MaxSize = 40;
            fd_obj.ShowColor = true;
            fd_obj.ShowHelp = true;
            fd_obj.HelpRequest += new EventHandler(fd_obj_HelpRequest);
            if (fd_obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font = fd_obj.Font;
                textBox1.ForeColor = fd_obj.Color;

            }
        }

        void fd_obj_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose the font and the color of the text");
        }
    }
}
