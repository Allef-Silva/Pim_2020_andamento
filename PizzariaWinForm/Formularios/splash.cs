using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value >= 50)
            {
                frmLogin In = new frmLogin();
                this.Hide();
                In.Show();


                timer1.Enabled = true;
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }
        }
    }
}
