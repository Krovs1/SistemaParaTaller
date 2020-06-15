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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text == "Kevin" && this.txtContraseña.Text == "1234")
            {
                Catálogos llamar = new Catálogos();
                llamar.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
