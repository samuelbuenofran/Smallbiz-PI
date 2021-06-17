using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSmallbiz
{
    public partial class FormPaginaInicialEmpreendedor : Form
    {
        public FormPaginaInicialEmpreendedor()
        {
            InitializeComponent();
        }
                       
        private void FormPaginaInicialEmpreendedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void buttonPublicar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto fi = new FormCadastroProduto();
            fi.Show();
        }

        private void buttonVisualizacoes_Click(object sender, EventArgs e)
        {
            FormVisualizacoes fv = new FormVisualizacoes();
            fv.Show();
        }

        private void buttonPromocao_Click(object sender, EventArgs e)
        {
            FormPromocoes fp = new FormPromocoes();
            fp.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroEmpreendedor fce = new FormCadastroEmpreendedor();
            fce.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FormCadastroEmpreendedor exit = new FormCadastroEmpreendedor();
            //exit.Close();
            this.Close();
        }
    }
}
