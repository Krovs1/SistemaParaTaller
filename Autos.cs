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
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Placa, marca, modelo y color

            string placa = txtPlaca.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = txtColor.Text;

            string query = "Insert into Autos(Placa, Marca, Modelo, Color) VALUES('" + placa + "','" + marca + "','" + modelo + "','" + color + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=ASUSPC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema_Para_Taller");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtColor.Text = "";
                
                oleDbDataAdapter1.Fill(dsAutos1);
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
            string query = "UPDATE Autos SET Marca = '" + txtMarca.Text + "', Modelo = '" + txtModelo.Text + "', Color = '" + txtColor.Text + "' WHERE Placa = '" + txtPlaca.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = txtColor.Text;

            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=ASUSPC\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema_Para_Taller");
            con.Open();
            string query = "Delete from Autos where Placa = '" + txtPlaca.Text + "'";  
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino");
            con.Close();
        }
    }
}
