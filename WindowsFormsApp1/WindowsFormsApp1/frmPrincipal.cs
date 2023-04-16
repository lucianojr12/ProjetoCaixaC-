﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        private Form objForm;





        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnAbrirCaixa_Paint(object sender, PaintEventArgs e)
        {
        
            
        }

        private void pnAbrirCaixa_MouseClick(object sender, MouseEventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmCaixa();
            objForm.TopLevel = false;
            objForm.Visible = true;
            panel6.Controls.Add(objForm);
            objForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmVendas();
            objForm.TopLevel = false;
            objForm.Visible = true;
            panel6.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmEstoque();
            objForm.TopLevel = false;
            objForm.Visible = true;
            panel6.Controls.Add(objForm);
            objForm.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmRelatorio();
            objForm.TopLevel = false;
            objForm.Visible = true;
            panel6.Controls.Add(objForm);
            objForm.Show();

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmAdmin();
            objForm.TopLevel = false;
            objForm.Visible = true;
            panel6.Controls.Add(objForm);
            objForm.Show();

        }
    }
}
