﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void LblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();//chama a url do VisitLink
            }
            catch (Exception)//Se não encontrar exibe msg de erro
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }


        }
        private void VisitLink()
        {
           
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
