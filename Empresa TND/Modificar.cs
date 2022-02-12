using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Empresa_TND
{
    class Modificar
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

        public int ID_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto_de_trabajo { get; set; }
        public string Sueldo { get; set; }
        public string Direccion { get; set; }
        public string cedula { get; set; }

        public void Modificar_Empleado() {    
            try
            {
                string Query = "update Empleado set Nombre=@Nombre, Apellido=@Apellido,Puesto_de_trabajo=@Puesto_de_trabajo,Sueldo=@Sueldo,Direccion=@Direccion,cedula=@cedula where ID_Empleado=@ID_Empleado"; 
        conexion.Open();
                SqlCommand comando = new SqlCommand(Query, conexion);

                comando.Parameters.AddWithValue("@ID_Empleado", ID_Empleado);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Puesto_de_trabajo", Puesto_de_trabajo);
                comando.Parameters.AddWithValue("@Sueldo", Sueldo);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los Datos fueron Modificados");
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al insertar");
            }
        }
        

    }


}
class Modificar_Cliente
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

    public int ID_Cliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Sexo { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string cedula { get; set; }

    public void Modificar_Clientes()
    {
        try
        {
            string Query = "update Empleado set Nombre=@Nombre, Apellido=@Apellido,Direccion=@Direccion,Correo=@Correo,Cedula=@Cedula,Sexo=@Sexo where ID_Cliente=@ID_Cliente";
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);

            comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Cedula", Direccion);
            comando.Parameters.AddWithValue("@Sexo", Sexo);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos fueron Modificados");
            conexion.Close();
        }
        
        catch
        {
            MessageBox.Show("Error al insertar");
        }
        
    }
}

class Modificar_Boleto
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

    public int ID_boleto { get; set; }
    public int ID_cliente { get; set; }
    public string PDPartida { get; set; }
    public string Destino { get; set; }
    public string TipoDeTransporte { get; set; }
    public string Precio { get; set; }
    public string FechaBoleto { get; set; }

    public void Modificar_Boletos()
    {
        try
        {
            string Query = "update Boleto set ID_Boleto=@ID_Boleto,Punto_de_partida=@Punto_de_partida, Destino=@Destino,Tipo_de_trasnporte=@Tipo_de_trasnporte,Precio=@Precio,Fecha_Boleto=@Fecha_Boleto where ID_Cliente=@ID_Cliente";
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);

            comando.Parameters.AddWithValue("@ID_Boleto", ID_boleto);
            comando.Parameters.AddWithValue("@ID_Cliente", ID_cliente);
            comando.Parameters.AddWithValue("@Punto_de_partida", PDPartida);
            comando.Parameters.AddWithValue("@Destino", Destino);
            comando.Parameters.AddWithValue("@Tipo_de_trasnporte", TipoDeTransporte);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Fecha_Boleto", FechaBoleto);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos fueron Modificados");
            conexion.Close();
        }

        catch
        {
            MessageBox.Show("Error al insertar");
        }
    }
}