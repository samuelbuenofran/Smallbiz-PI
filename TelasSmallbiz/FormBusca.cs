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
using Microsoft.SqlServer.Server;

namespace TelasSmallbiz
{
    public partial class FormBusca : Form
    {
        public FormBusca()
        {
            InitializeComponent();
        }

        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {

        }



        public void buttonBuscar_Click(object sender, EventArgs e)
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


        public class vendedorPF
        {
            public int id_vend { get; set; }
            public string nome_vend { get; set; }
            
            public string dt_nasc_vend { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        public void mostrarPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBusca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VITRINEDEPRODUTOSDataSet.TB_PRODUTO' table. You can move, or remove it, as needed.
            //this.tB_PRODUTOTableAdapter.Fill(this.dB_VITRINEDEPRODUTOSDataSet.TB_PRODUTO);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormBusca.ActiveForm.Close();
        }
    }
}
