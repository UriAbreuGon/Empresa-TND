using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Empresa_TND
{
    class Insertar
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");
   
    
        public int ID_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto_de_trabajo { get; set; }
        public string Sueldo { get; set; }
        public string Direccion { get; set; }
        public string cedula { get; set; }

    
        public void insertar_Clientes()
        {
            try
            {
                string Query = "INSERT INTO Empleado(ID_Empleado, Nombre, Apellido,Puesto_de_trabajo,Sueldo,Direccion,cedula) Values (@ID_Empleado, @Nombre, @Apellido,@Puesto_de_trabajo,@Sueldo,@Direccion,@cedula)";
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
                MessageBox.Show("Los Datos fueron Insertados");
                conexion.Close();
            }
            catch
            {
              
            }
           

        }

       
    }
    
    }

    class ClassClientes
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");

    public int ID_Cliente { get; set; }
    
    public string NombreC { get; set; }
    public string ApellidoC { get; set; }
    public string DireccionC { get; set; }
    public string CorreoC { get; set; }
    public string CedulaC { get; set; }
    public string SexoC { get; set; }


    public string Insertar_Clientes()
    {

        try
        {
            string Query = "INSERT INTO Cliente(ID_Cliente, Nombre, Apellido,Direccion,correo,Cedula,Sexo) Values (@ID_Cliente,@Nombre, @Apellido,@Direccion,@correo,@Cedula,@Sexo)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);
            comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
           
            comando.Parameters.AddWithValue("@Nombre", NombreC);
            comando.Parameters.AddWithValue("@Apellido", ApellidoC);
            comando.Parameters.AddWithValue("@Direccion", DireccionC);
            comando.Parameters.AddWithValue("@correo", CorreoC);
            comando.Parameters.AddWithValue("@Cedula", CedulaC);
            comando.Parameters.AddWithValue("@Sexo", SexoC);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos fueron Insertados");
        }
        catch
        {
           
        }
        return Insertar_Clientes();

    }

}

class Insertar_Boletos
{
    SqlConnection conexion = new SqlConnection("server=DESKTOP-UG1DQPA\\SQLEXPRESS ; database=TND ; integrated security = true");


    public int ID_Boleto { get; set; }
    public int ID_Cliente { get; set; }
    public string PDPartida { get; set; }
    public string Destino { get; set; }
    public string TipoDeTransporte { get; set; }
    public string Precio { get; set; }
    public string FechaBoleto { get; set; }
    


    public void insertar_Boleto()
    {
        try
        {
            string Query = "INSERT INTO Boleto(ID_Boleto,ID_Cliente, Punto_de_partida,Destino,Tipo_de_trasnporte,Precio,Fecha_Boleto) Values (@ID_Boleto,@ID_Cliente,@Punto_de_partida,@Destino,@Tipo_de_trasnporte,@Precio,@Fecha_Boleto)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);
            comando.Parameters.AddWithValue("@ID_Boleto", ID_Boleto);
            comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            comando.Parameters.AddWithValue("@Punto_de_partida", PDPartida);
            comando.Parameters.AddWithValue("@Destino", Destino);
            comando.Parameters.AddWithValue("@Tipo_de_trasnporte", TipoDeTransporte);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Fecha_Boleto", FechaBoleto);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos fueron Insertados");
        }
        catch
        {
            MessageBox.Show("Error al insertar");
        }
    }



}

