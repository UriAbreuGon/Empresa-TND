using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Empresa_TND
{
    public partial class Boletos : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
        public Boletos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 Visible = new Form2();
            Visible.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select * From Boleto";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.dt.DataSource = dt;

            MessageBox.Show("Consulta mostrada");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Eliminar_Boletos myEliminarboletos = new Eliminar_Boletos();
            myEliminarboletos.ID_Boleto = Convert.ToInt32(IDCliente.Text);
            myEliminarboletos.Eliminar_Boleto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Insertar_Boletos MyclassBoletos = new Insertar_Boletos();
            //Valores de variables
            MyclassBoletos.ID_Cliente = Convert.ToInt32(IDCliente.Text);
            MyclassBoletos.ID_Boleto = Convert.ToInt32(IDBoleto.Text);
            MyclassBoletos.PDPartida = PuntoP.Text;
            MyclassBoletos.Destino = Destino.Text;
            MyclassBoletos.TipoDeTransporte = MDTransporte.Text;
            MyclassBoletos.Precio = Precio.Text;
            MyclassBoletos.FechaBoleto = Fechaa.Text;

            //Correr Metodo
            MyclassBoletos.insertar_Boleto();
            //Limpiar Imputs
            IDCliente.Text = " ";
            IDBoleto.Text = " ";
            PuntoP.Text = " ";
            Destino.Text = " ";
            MDTransporte.Text = " ";
            Precio.Text = " ";
        
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Modificar_Boleto MyclassBoletos = new Modificar_Boleto();
            //Valores de variables
            MyclassBoletos.ID_cliente = Convert.ToInt32(IDCliente.Text);
            MyclassBoletos.ID_boleto = Convert.ToInt32(IDBoleto.Text);
            MyclassBoletos.PDPartida = PuntoP.Text;
            MyclassBoletos.Destino = Destino.Text;
            MyclassBoletos.TipoDeTransporte = MDTransporte.Text;
            MyclassBoletos.Precio = Precio.Text;
            MyclassBoletos.FechaBoleto = Fechaa.Text;

            conexion.Close();
            //Correr Metodo
            MyclassBoletos.Modificar_Boletos();
            //Limpiar Imputs
            IDCliente.Text = " ";
            IDBoleto.Text = " ";
            PuntoP.Text = " ";
            Destino.Text = " ";
            MDTransporte.Text = " ";
            Precio.Text = " ";
            
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
