using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empresa_TND
{
    class Eliminar
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
       
        public int ID_Empleado {  get;set; }
        public int ID_Cliente { get; set; }

       
            public void Eliminar_Empleado()
        {

            string cadena2 = "delete from Empleado where ID_Empleado = @ID_Empleado";
            conexion.Open();
            SqlCommand comando2 = new SqlCommand(cadena2, conexion);
            comando2.Parameters.AddWithValue("ID_Empleado",ID_Empleado);
            comando2.ExecuteNonQuery();
            try 
            {

                MessageBox.Show("Se borró el dato");
                conexion.Close();
            }

             catch
            {
                MessageBox.Show("");
            }
            

   
            }
        }
    }
class Eliminar_Clientes
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

    public int ID_Empleado { get; set; }
    public int ID_Cliente { get; set; }


    public void Eliminar_Empleado()
    {

        string cadena2 = "delete from Cliente where ID_Cliente = @ID_Cliente";
        conexion.Open();
        SqlCommand comando2 = new SqlCommand(cadena2, conexion);
        comando2.Parameters.AddWithValue("ID_Cliente", ID_Empleado);
        comando2.ExecuteNonQuery();
        try
        {

            MessageBox.Show("Se borró el dato");
            conexion.Close();
        }

        catch
        {
            MessageBox.Show("");
        }


    }
}


class Eliminar_Boletos
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

    
    public int ID_Boleto { get; set; }


    public void Eliminar_Boleto()
    {

        string cadena2 = "delete from Boleto where ID_Boleto = @ID_Boleto";
        conexion.Open();
        SqlCommand comando2 = new SqlCommand(cadena2, conexion);
        comando2.Parameters.AddWithValue("ID_Boleto", ID_Boleto);
        comando2.ExecuteNonQuery();
        try
        {

            MessageBox.Show("Se borró el dato");
            conexion.Close();
        }

        catch
        {
            MessageBox.Show("");
        }
  
   }

}