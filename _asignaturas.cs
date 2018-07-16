using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class _asignaturas
    {

        private string _idasignatura = "";
        private string _nombre = "";
        private int _creditos = 0;
        private int _horasteoricas = 0;
        private int _horaspracticas = 0;

        public string Idasignatura { get => _idasignatura; set => _idasignatura = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Creditos { get => _creditos; set => _creditos = value; }
        public int Horasteoricas { get => _horasteoricas; set => _horasteoricas = value; }
        public int Horaspracticas { get => _horaspracticas; set => _horaspracticas = value; }

        public _asignaturas() { }
        public _asignaturas(string idasignatura, string nombre, int creditos, int horasteoricas, int horaspracticas)
        {
            Idasignatura = idasignatura;
            Nombre = nombre;
            Creditos = creditos;
            Horasteoricas = horasteoricas;
            Horaspracticas = horaspracticas;
        }
        public void regis_asig()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into ASIGNATURA values (@idasignatura,@nombre,@creditos,@horasteoricas,@horaspracticas)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idasignatura", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idasignatura"].Value = _idasignatura;

            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _nombre;

            comando.Parameters.Add("@creditos", System.Data.SqlDbType.Int);
            comando.Parameters["@creditos"].Value = _creditos;

            comando.Parameters.Add("@horasteoricas", System.Data.SqlDbType.Int);
            comando.Parameters["@horasteoricas"].Value = _horasteoricas;

            comando.Parameters.Add("@horaspracticas", System.Data.SqlDbType.Int);
            comando.Parameters["@horaspracticas"].Value = _horaspracticas;


            con.ejecutartransaccion(comando, conexion);

        }
        public void actualizar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "update ASIGNATURA set IDASIGNATURA = @idasignatura,NOMBRE=@nombre,CREDITOS=@creditos,HORASTEORICAS=@horasteoricas," +
                "HORASPRACTICAS=@horaspracticas, where IDASIGNATURA = @idasignatura";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros

            comando.Parameters.Add("@idasignatura", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idasignatura"].Value = _idasignatura;

            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _nombre;

            comando.Parameters.Add("@creditos", System.Data.SqlDbType.Int);
            comando.Parameters["@creditos"].Value = _creditos;

            comando.Parameters.Add("@horasteoricas", System.Data.SqlDbType.Int);
            comando.Parameters["@horasteoricas"].Value = _horasteoricas;

            comando.Parameters.Add("@horaspracticas", System.Data.SqlDbType.Int);
            comando.Parameters["@horaspracticas"].Value = _horaspracticas;

            con.ejecutartransaccion(comando, conexion);
        }
        public void eliminar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "delete from ASIGNATURA where IDASIGNATURA = @idasignatura";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idasignatura", System.Data.SqlDbType.Int);
            comando.Parameters["@idasignatura"].Value = _idasignatura;

            con.ejecutartransaccion(comando, conexion);
        }
    }
}
