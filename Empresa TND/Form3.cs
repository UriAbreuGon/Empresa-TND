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
    public partial class Form3 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Insertar MyclassEmpleado = new Insertar();
            //Valores de variables
            MyclassEmpleado.ID_Empleado = Convert.ToInt32(ID.Text);
            MyclassEmpleado.Nombre = Nombre.Text;
            MyclassEmpleado.Apellido = Apellido.Text;
            MyclassEmpleado.Puesto_de_trabajo = Cargo.Text;
            MyclassEmpleado.Sueldo = Sueldo.Text;
            MyclassEmpleado.Direccion = Direccion.Text;
            MyclassEmpleado.cedula = Cedula.Text;

            //Correr Metodo
            MyclassEmpleado.insertar_Clientes();
            //Limpiar Imputs
            Nombre.Text = " ";
            Apellido.Text = " ";
            Cargo.Text = " ";
            Sueldo.Text = " ";
            Sueldo.Text = " ";
            Direccion.Text = " ";
            Cedula.Text = " ";
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Eliminar myEliminar = new Eliminar();
            myEliminar.ID_Empleado = Convert.ToInt32(ID.Text);
            myEliminar.Eliminar_Empleado();

            

            conexion.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 Visible = new Form2();
            Visible.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select * From Empleado";
            SqlDataAdapter adaptador = new SqlDataAdapter(query,conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.dt.DataSource = dt;

            MessageBox.Show("Consulta mostrada");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Modificar MyclassEmpleado = new Modificar();
            //Valores de variables
            MyclassEmpleado.ID_Empleado = Convert.ToInt32(ID.Text);
            MyclassEmpleado.Nombre = Nombre.Text;
            MyclassEmpleado.Apellido = Apellido.Text;
            MyclassEmpleado.Puesto_de_trabajo = Cargo.Text;
            MyclassEmpleado.Sueldo = Sueldo.Text;
            MyclassEmpleado.Direccion = Direccion.Text;
            MyclassEmpleado.cedula = Cedula.Text;

            //Correr Metodo
            MyclassEmpleado.Modificar_Empleado();
            //Limpiar Imputs
            ID.Text = "";
            Nombre.Text = " ";
            Apellido.Text = " ";
            Cargo.Text = " ";
            Sueldo.Text = " ";
            Sueldo.Text = " ";
            Direccion.Text = " ";
            Cedula.Text = " ";
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

