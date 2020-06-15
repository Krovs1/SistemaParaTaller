using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Para_Taller
{
    public partial class Catálogos : Form
    {
        public Catálogos()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frmcliente = new Clientes();
            frmcliente.Show();

        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            Autos frmauto = new Autos();
            frmauto.Show();
        }
    }
}
