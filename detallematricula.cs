using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class detallematricula
    {
        private string _idmatrciula = "";
        private string _idasignaturaprogramada = "";
        private string _fechadeactas = "";
        private decimal _nota = 0;
        private string _observacion = "";

  

        public string Idmatrciula { get => _idmatrciula; set => _idmatrciula = value; }
        public string Idasignaturaprogramada { get => _idasignaturaprogramada; set => _idasignaturaprogramada = value; }
        public string Fechadeactas { get => _fechadeactas; set => _fechadeactas = value; }
        public decimal Nota { get => _nota; set => _nota = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }

        public detallematricula() { }
        public detallematricula(string idmatrciula, string idasignaturaprogramada, string fechadeactas, decimal nota, string observacion)
        {
            _idmatrciula = idmatrciula;
            _idasignaturaprogramada = idasignaturaprogramada;
            _fechadeactas = fechadeactas;
            _nota = nota;
            _observacion = observacion;
        }

        public void registrar_detallematricula()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into DETALLEMATRICULA values (@idmatrciula,@idasignaturaprogramada,@fechadeactas,@nota,@observacion)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idmatrciula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idmatrciula"].Value = _idmatrciula;

            comando.Parameters.Add("@idasignaturaprogramada", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idasignaturaprogramada"].Value = _idasignaturaprogramada;

            comando.Parameters.Add("@fechadeactas", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechadeactas"].Value = _fechadeactas;

            comando.Parameters.Add("@nota", System.Data.SqlDbType.Decimal);
            comando.Parameters["@nota"].Value = _nota;

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
//            IDMATRICULA VARCHAR(10)NOT NULL,
//IDASIGNATURAPROGRAMADA VARCHAR(10)NOT NULL,
//FECHAACTAS VARCHAR(30) NOT NULL,
//NOTA DECIMAL NOT NULL,
//OBSERVACION VARCHAR(100),
            string sql = "update DETALLEMATRICULA set" +
                "IDMATRICULA = @idmatrciula," +
                "IDASIGNATURAPROGRAMADA=@idasignaturaprogramada," +
                "FECHAACTAS=@fechadeactas" +
                "NOTA=@nota," +
                "OBSERVACION=@observacion, " +
                "where IDMATRICULA = @idmatrciula";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros
            comando.Parameters.Add("@idmatrciula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idmatrciula"].Value = _idmatrciula;

            comando.Parameters.Add("@idasignaturaprogramada", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idasignaturaprogramada"].Value = _idasignaturaprogramada;

            comando.Parameters.Add("@fechadeactas", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechadeactas"].Value = _fechadeactas;

            comando.Parameters.Add("@nota", System.Data.SqlDbType.Decimal);
            comando.Parameters["@nota"].Value = _nota;

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

            string sql = "delete from DETALLEMATRICULA where IDMATRICULA = @idmatrciula";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idmatrciula", System.Data.SqlDbType.Int);
            comando.Parameters["@idmatrciula"].Value = _idmatrciula;

            con.ejecutartransaccion(comando, conexion);
        }
    }
}
