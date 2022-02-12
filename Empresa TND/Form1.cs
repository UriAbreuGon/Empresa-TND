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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

        Login Mylogin = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string query = "select Usuario, Contraseña from Usuarios where Usuario=@Usuario and Contraseña=@Contraseña";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Usuario", Usuario.Text);
            comando.Parameters.AddWithValue("@Contraseña", Contraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                Form2 Visible = new Form2();
                Visible.Show();
                this.Hide();


                MessageBox.Show("Inicio de sesión Correctamente!");
            }
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
