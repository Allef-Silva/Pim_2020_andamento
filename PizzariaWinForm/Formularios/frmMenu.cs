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
        Cadastros cad = new Cadastros();

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
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
                if (painelEsquerda.Width <= 70)
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


        private void AddControlsToPanel(Control c) 
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRealizarPedido);
            ControlesDeUsuario.CU_VendaPizza us = new ControlesDeUsuario.CU_VendaPizza();
            AddControlsToPanel(us);
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCardapio);
            ControlesDeUsuario.CU_Cardapio abs = new ControlesDeUsuario.CU_Cardapio();
            AddControlsToPanel(abs);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnConsulta);
            ControlesDeUsuario.CU_Consulta ubs = new ControlesDeUsuario.CU_Consulta();
            AddControlsToPanel(ubs);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPedidos);
            ControlesDeUsuario.CU_Pedidos ula = new ControlesDeUsuario.CU_Pedidos();
            AddControlsToPanel(ula);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVendas);
            ControlesDeUsuario.CU_Vendas ula = new ControlesDeUsuario.CU_Vendas();
            AddControlsToPanel(ula);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRelatorios);
            ControlesDeUsuario.CU_Relatorios upa = new ControlesDeUsuario.CU_Relatorios();
            AddControlsToPanel(upa);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            moveSidePanel(btnClientes);
            ControlesDeUsuario.CU_CadastroClientes ua = new ControlesDeUsuario.CU_CadastroClientes();
            AddControlsToPanel(ua);
        }

        

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFornecedores);
            ControlesDeUsuario.CU_CompraFornecedores up = new ControlesDeUsuario.CU_CompraFornecedores();
            AddControlsToPanel(up);
        }

        private void timerTempo_Tick(object sender, EventArgs e)
        {
           
            {
                labelTime.Text = DateTime.Now.ToString("hh:mm:ss ");
                lblData.Text = DateTime.Now.ToLongDateString();
            }

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            ControlesDeUsuario.CU_Home usc = new ControlesDeUsuario.CU_Home();
            AddControlsToPanel(usc);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelTime_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(249, 6, 6);
        }

        private void labelTimee_Click(object sender, EventArgs e)
        {
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCadastrarFunc);
            ControlesDeUsuario.CU_CadastrosUsuarios usb = new ControlesDeUsuario.CU_CadastrosUsuarios();
            AddControlsToPanel(usb);

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
    }
}
