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
    public partial class Clientescs : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
        public Clientescs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clientescs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 Visible = new Form2();
            Visible.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            ClassClientes MyclassClientes = new ClassClientes();
            //Valores de variables
            MyclassClientes.ID_Cliente = Convert.ToInt32(IDC.Text);
            MyclassClientes.NombreC = NombreC.Text;
            MyclassClientes.ApellidoC = ApellidoC.Text;
            MyclassClientes.CedulaC = CedulaC.Text;
            MyclassClientes.CorreoC = CorreoC.Text;
            MyclassClientes.DireccionC = DireccionC.Text;
            MyclassClientes.SexoC = SexoC.Text;

            //Correr Metodo
            MyclassClientes.Insertar_Clientes();
            //Limpiar Imputs
            NombreC.Text = " ";
            ApellidoC.Text = " ";
            CedulaC.Text = " ";
            CorreoC.Text = " ";
            DireccionC.Text = " ";
            SexoC.Text = " ";
            IDC.Text = " ";
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Eliminar_Clientes myEliminarclientes = new Eliminar_Clientes();
            myEliminarclientes.ID_Empleado = Convert.ToInt32(IDC.Text);
            myEliminarclientes.Eliminar_Empleado();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select * From Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.dt.DataSource = dt;

            MessageBox.Show("Consulta mostrada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Modificar_Cliente MyclassCliente = new Modificar_Cliente();
            //Valores de variables
            MyclassCliente.ID_Cliente = Convert.ToInt32(IDC.Text);
            MyclassCliente.Nombre = NombreC.Text;
            MyclassCliente.Apellido = ApellidoC.Text;
            MyclassCliente.Direccion = DireccionC.Text;
            MyclassCliente.Correo = CorreoC.Text;
            MyclassCliente.cedula = CedulaC.Text;
            MyclassCliente.Sexo = SexoC.Text;
            

            //Correr Metodo
            MyclassCliente.Modificar_Clientes();
            //Limpiar Imputs
            IDC.Text = "";
            NombreC.Text = " ";
            ApellidoC.Text = " ";
            DireccionC.Text = " ";
            CorreoC.Text = " ";
            CedulaC.Text = " ";
            SexoC.Text = " ";
           
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

