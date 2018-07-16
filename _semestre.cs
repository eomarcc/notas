using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class _semestre
    {
        private string _idsemestre = "";
        private string _ciclo="";
        private string _fechainicio = "";
        private string _fechafin = "";
        private string _observacion = "";

  
        public string Idsemestre { get => _idsemestre; set => _idsemestre = value; }
        public string Ciclo { get => _ciclo; set => _ciclo = value; }
        public string Fechainicio { get => _fechainicio; set => _fechainicio = value; }
        public string Fechafin { get => _fechafin; set => _fechafin = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }

        public _semestre() { }

        public _semestre(string idsemestre, string ciclo, string fechainicio, string fechafin, string observacion)
        {
            _idsemestre = idsemestre;
            _ciclo = ciclo;
            _fechainicio = fechainicio;
            _fechafin = fechafin;
            _observacion = observacion;
        }

        public void registrar_semestre()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into SEMESTRE values (@idsemestre,@ciclo,@fechainicio,@fechafin,@observacion)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idsemestre"].Value = _idsemestre;

            comando.Parameters.Add("@ciclo", System.Data.SqlDbType.VarChar);
            comando.Parameters["@ciclo"].Value = _ciclo;

            comando.Parameters.Add("@fechainicio", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechainicio"].Value = _fechainicio;

            comando.Parameters.Add("@fechafin", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechafin"].Value = _fechafin;

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

            string sql = "update SEMESTRE set IDSEMESTRE = @idsemestre,CICLO=@ciclo,FECHAINICIO=@fechainicio,FECHATERMINO=@fechafin," +
                "OBSERVACION=@observacion, where IDSEMESTRE = @idsemestre";

            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros
            comando.Parameters.Add("@idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idsemestre"].Value = _idsemestre;

            comando.Parameters.Add("@ciclo", System.Data.SqlDbType.VarChar);
            comando.Parameters["@ciclo"].Value = _ciclo;

            comando.Parameters.Add("@fechainicio", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechainicio"].Value = _fechainicio;

            comando.Parameters.Add("@fechafin", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechafin"].Value = _fechafin;

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

            string sql = "delete from SEMESTRE where IDSEMESTRE = @idsemestre";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idsemestre", System.Data.SqlDbType.Int);
            comando.Parameters["@idsemestre"].Value = _idsemestre;

            con.ejecutartransaccion(comando, conexion);
        }
    }
}
