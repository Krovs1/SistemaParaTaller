using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_Para_Taller
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //RFC, Nombre, Domicilio, Teléfono y Correo 

            string rfc = txtRFC.Text;
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            string query = "Insert into Clientes(RFC, Nombre, Domicilio, Teléfono, Correo) VALUES('" + rfc + "','" + nombre + "','" + domicilio + "','" + telefono + "','" + correo + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=ASUSPC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema_Para_Taller");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtRFC.Text = "";
                txtNombre.Text = "";
                txtDomicilio.Text= "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                oleDbDataAdapter1.Fill(dsCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=ASUSPC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema_Para_Taller");
            con.Open();
            string query = "UPDATE Clientes SET Nombre = '" + txtNombre.Text + "', Domicilio = '" + txtDomicilio.Text + "', Teléfono = '" + txtTelefono.Text + "', Correo ='" + txtCorreo.Text + "' WHERE RFC = '" + txtRFC.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            

            string rfc = txtRFC.Text;
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=ASUSPC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema_Para_Taller");
            con.Open();
            string query = "Delete from Clientes where RFC = '" + txtRFC.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino");
            con.Close();
        }
    }
}
