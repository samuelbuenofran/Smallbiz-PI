using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TelasSmallbiz
{
    public partial class FormCadastroEmpreendedor : Form
    {
        public FormCadastroEmpreendedor()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // CODIGO FUNCIONANDO
            // Criamos a string de conexão;
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = DB_VITRINEDEPRODUTOS; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT NOME_PRODUTO, VALOR_PRODUTO, DESC_PRODUTO, CATEGORIA_PRODUTO, QNT_PRODUTO FROM TB_PRODUTO WHERE NOME_PRODUTO = @NomeProd", conn);
            cmd.Parameters.AddWithValue("@NomeProd", textBoxBusca.Text);
            //cmd.Parameters.AddWithValue("@");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mostrarPesquisa.DataSource = dt;

            conn.Close();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnexar_Click(object sender, EventArgs e)
        {
            aa_anexarArquivo.ShowDialog();
            textBox4.Text = aa_anexarArquivo.FileName;
        }
    }
}
