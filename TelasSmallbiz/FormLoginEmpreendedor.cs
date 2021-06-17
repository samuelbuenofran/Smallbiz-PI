using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TelasSmallbiz
{
    public partial class FormLoginEmpreendedor : Form
    {
        Thread novathead;
             
        public FormLoginEmpreendedor()
        {
            InitializeComponent();
            // In this code example, the link area has been set to begin
            // at the first character and extend for eight characters.
            // You may need to modify this based on the text entered in Step 1.
            linkLabelRecuperarSenha.LinkArea = new LinkArea(0,17);
            linkLabelCadastro.LinkArea = new LinkArea(0, 24);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text=="leianny2010@hotmail.com" && textBoxSenha.Text=="1234")
            {
                this.Close();
                novathead = new Thread(FormTelainicial);
                novathead.SetApartmentState(ApartmentState.STA);
                novathead.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
            }
        }

        private void FormTelainicial()
        {
            Application.Run(new FormCadastroEmpreendedor());
        }

        private void checkBoxLembrarCredenciais_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabelRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            novathead = new Thread(FormllCadastro);
            novathead.SetApartmentState(ApartmentState.STA);
            novathead.Start(); ;
        }
        private void FormllCadastro()
        {
            Application.Run(new FormCadastroEmpreendedor());
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

