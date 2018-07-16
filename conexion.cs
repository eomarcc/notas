using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_SOFTWARE_II
{
    class conexion

    {
        //metodo para conectar
        public SqlConnection conectar()
        {//inicio de conectar
         //creamos un obj    eto con de conexion
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-OFL50G6;" + "initial catalog =CERTIFICADO;" + "user=sa;" + "password=1234";
          
            //abrir la conexion
            con.Open();
            return con;
        }//fin de conectar

        //metodo para ejecutar una transaccion
        public void ejecutartransaccion(SqlCommand comando, SqlConnection con)
        {//inicio de ejecutar
            comando.Connection = con;
            SqlTransaction transaccion = con.BeginTransaction();
            comando.Transaction = transaccion;
            comando.ExecuteNonQuery(); //error
            transaccion.Commit();
        }//fin de ejecutar
    }
}
