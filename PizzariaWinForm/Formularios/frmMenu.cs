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
    public partial class frmMenu : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public frmMenu()
        {
            InitializeComponent();
            timerTempo.Start();
            PanelWidth = painelEsquerda.Width;
            isCollapsed = false;        
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            this.Hide();
            cli.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel7.BackColor = Color.FromArgb(173, 7, 66);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

     
        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            moveSidePanel(btnSair);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                painelEsquerda.Width = painelEsquerda.Width + 10; 
                if (painelEsquerda.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                painelEsquerda.Width = painelEsquerda.Width - 10;
                if (painelEsquerda.Width<=70)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn) 
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCadastrar);
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCardapio);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnConsulta);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPedidos);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVendas);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRelatorios);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnClientes);
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFornecedores);
        }

        private void timerTempo_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
          
        }
    }
}
