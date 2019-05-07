using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form //patrial
    {
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lbResult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = this.OrgStr + this.textEdit.Text;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
