using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class escuelaprofesional
    {

        private string _idescuelaprofesional = "";
        private string _nombre = "";
        private string _observacion = "";



        public string Idescuelaprofesional { get => _idescuelaprofesional; set => _idescuelaprofesional = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }

        public escuelaprofesional()
        {

        }
        public escuelaprofesional(string idescuelaprofesional, string nombre, string observacion)
        {
            _idescuelaprofesional = idescuelaprofesional;
            _nombre = nombre;
            _observacion = observacion;
        }
        public void registrar_escuelaprofesional()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into ESCUELAPROFESIONAL values (@idescuelaprofesional,@nombre,@observacion)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idescuelaprofesional"].Value = _idescuelaprofesional;

            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _nombre;

            comando.Parameters.Add("@observacion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@observacion"].Value = _observacion;

           

            con.ejecutartransaccion(comando, conexion);

        }
        public void actualizar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "update ESCUELAPROFESIONAL set IDESCUELAPROFESIONAL = @idescuelaprofesional,NOMBRE=@nombre,OBSERVACION=@observacion, where IDESCUELAPROFESIONAL = @idescuelaprofesional";
            //utilizamos la clase sqlcommand

            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros
            comando.Parameters.Add("@idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idescuelaprofesional"].Value = _idescuelaprofesional;

            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _nombre;

            comando.Parameters.Add("@observacion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@observacion"].Value = _observacion;

            con.ejecutartransaccion(comando, conexion);
        }
        public void eliminar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "delete from ESCUELAPROFESIONAL where IDESCUELAPROFESIONAL = @idescuelaprofesional";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idescuelaprofesional", System.Data.SqlDbType.Int);
            comando.Parameters["@idescuelaprofesional"].Value = _idescuelaprofesional;

            con.ejecutartransaccion(comando, conexion);
        }
    }
}
