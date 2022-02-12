using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empresa_TND
{
    class Login
    {
        
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
        public void conectar() { 
    
            conexion.Open();
            MessageBox.Show("Se abrió la conexión");
            conexion.Close();



            }

    }
}














