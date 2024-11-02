using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = "Google and Bing";
            linkLabel.LinkColor = System.Drawing.Color.Blue;
            linkLabel.LinkVisited = true;
            linkLabel.Location = new System.Drawing.Point(10, 10);
            linkLabel.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(linkLabel);
        }
    }
}
