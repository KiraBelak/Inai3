using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;


namespace Inai3.Datos
{
    class Conexion
    {
        //Aqui chicos cambien el data source por su ip, es para hacer la conexion a la base de datos
        public static string conexion = ("Data Source= 192.168.236.2; Initial Catalog=Inai; Integrated Security=True ");
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void Abrir()
        {
            if (conectar.State== ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
