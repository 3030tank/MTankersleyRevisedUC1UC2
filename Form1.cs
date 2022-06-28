using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTankersleyRevisedUC1UC2
{
    public partial class Form1 : Form
    {

        UserControl1? uc1 { get; set; }
        UserControl2? uc2 { get; set; } 
        public Form1()
        {
            InitializeComponent();
        }

        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ucb1_Click(object sender, EventArgs e)
        {
            if (ucb1.Text == "Remove UC1")
            {
                ucb1.Text = "Add UC1";
                Controls.Remove(uc1);
                return;
            }
            ucb1.Text = "Remove UC1";

            uc1 = new UserControl1();
            uc1.Name = "uc1";
            Controls.Add(uc1);
            uc1.Size = new System.Drawing.Size(46, 17);
            uc1.Height = 17;
            uc1.Width = 46;
            uc1.Location = new System.Drawing.Point(315, 100);
            uc1.lbl1.Text = "User Control 1";
            uc1.AutoSize = true;
          
            
           
        }

        private void ucb2_Click(object sender, EventArgs e)
        {
            if (ucb2.Text == "Remove UC2")
            {
                ucb2.Text = "Add UC2";
                Controls.Remove(uc2);
                return;
            }

            ucb2.Text = "Remove UC2";

            uc2 = new UserControl2();
            uc2.Name = "uc2";
            Controls.Add(uc2);
            uc2.Size = new System.Drawing.Size(46, 17);
            uc2.Location = new System.Drawing.Point(405, 200);
            uc2.uc2tb.Text = "User Control 2";
            
            
            
           
        }
    }
}
