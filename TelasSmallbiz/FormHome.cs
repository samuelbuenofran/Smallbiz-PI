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

namespace TelasSmallbiz
{
    public partial class FormHome : Form
    {
        private object mostrarPesquisa;

        public FormHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            FormBusca fb = new FormBusca();
            fb.Show();

            
            


            /*SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = DB_VITRINEDEPRODUTOS; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_CADASTROVENDEDORPF", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Initialize the form
            // Put query here;
            mostrarPesquisa = dt;
            conn.Close();*/


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void novidadesNav_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            novidadesNav.DocumentText =
                "<html><body>Please enter your name:<br/>" +
                "<input type='text' name='userName'/><br/>" +
                "<a href='http://www.microsoft.com'>continue</a>" +
                "</body></html>";
            novidadesNav.Navigating += new WebBrowserNavigatingEventHandler(novidadesNav_Navigating);

            
        }

        private void novidadesNav_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            System.Windows.Forms.HtmlDocument document =
                this.novidadesNav.Document;

            if (document != null && document.All["userName"] != null &&
                String.IsNullOrEmpty(
                document.All["userName"].GetAttribute("value")))
            {
                e.Cancel = true;
                System.Windows.Forms.MessageBox.Show(
                    "You must enter your name before you can navigate to " +
                    e.Url.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginEmpreendedor fle = new FormLoginEmpreendedor();
            fle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroEmpreendedor fce = new FormCadastroEmpreendedor();
            fce.Show();
        }
    }
}
