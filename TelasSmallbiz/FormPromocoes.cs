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
    public partial class FormPromocoes : Form
    {
        public FormPromocoes()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
