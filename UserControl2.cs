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
    public partial class UserControl2 : UserControl
    {

        const int width = 100;
        public UserControl2()
        {
            InitializeComponent();
            
        }

        private void ucb2tb_TextChanged(object sender, EventArgs e)
        {
            

            Size s = TextRenderer.MeasureText(uc2tb.Text,uc2tb.Font);
            
        }
    }
}
