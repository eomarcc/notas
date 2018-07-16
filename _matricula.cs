using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class _matricula
    {
        private string _idmatricula = "";
        private string _idalumno = "";
        private string _idescuelaprofesional = "";
        private string _idsemestre = "";
        private string _fechamatricula = "";
        private int _totalcreditos=0;
        private string _observacion = "";

 

        public string Idmatricula { get => _idmatricula; set => _idmatricula = value; }
        public string Idalumno { get => _idalumno; set => _idalumno = value; }
        public string Idescuelaprofesional { get => _idescuelaprofesional; set => _idescuelaprofesional = value; }
        public string Idsemestre { get => _idsemestre; set => _idsemestre = value; }
        public string Fechamatricula { get => _fechamatricula; set => _fechamatricula = value; }
        public int Totalcreditos { get => _totalcreditos; set => _totalcreditos = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }
        public _matricula()
        {
        }

        public _matricula(string idmatricula, string idalumno, string idescuelaprofesional, string idsemestre, string fechamatricula, int totalcreditos, string observacion)
        {
            _idmatricula = idmatricula;
            _idalumno = idalumno;
            _idescuelaprofesional = idescuelaprofesional;
            _idsemestre = idsemestre;
            _fechamatricula = fechamatricula;
            _totalcreditos = totalcreditos;
            _observacion = observacion;
        }
        public void registrar_matricula()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into MATRICULA values (@idmatricula,@idalumno,@idescuelaprofesional,@idsemestre,@fechamatricula,@totalcreditos,@observacion)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idmatricula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idmatricula"].Value = _idmatricula;

            comando.Parameters.Add("@idalumno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idalumno"].Value = _idalumno;

            comando.Parameters.Add("@idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idescuelaprofesional"].Value = _idescuelaprofesional;

            comando.Parameters.Add("@idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idsemestre"].Value = _idsemestre;

            comando.Parameters.Add("@fechamatricula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechamatricula"].Value = _fechamatricula;

            comando.Parameters.Add("@totalcreditos", System.Data.SqlDbType.Int);
            comando.Parameters["@totalcreditos"].Value = _totalcreditos;

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

            string sql = "update MATRICULA set IDMATRICULA = @idmatricula,IDALUMNO=@idalumno,IDESCUELAPROFESIONAL=@idescuelaprofesional,IDSEMESTRE=@idsemestre," +
                "FECHAMATRICULA=@fechamatricula,TOTALCREDITOS=@totalcreditos,OBSERVACION=@observacion, where IDMATRICULA = @idmatricula";

            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros

            comando.Parameters.Add("@idmatricula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idmatricula"].Value = _idmatricula;

            comando.Parameters.Add("@idalumno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idalumno"].Value = _idalumno;

            comando.Parameters.Add("@idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idescuelaprofesional"].Value = _idescuelaprofesional;

            comando.Parameters.Add("@idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@idsemestre"].Value = _idsemestre;

            comando.Parameters.Add("@fechamatricula", System.Data.SqlDbType.VarChar);
            comando.Parameters["@fechamatricula"].Value = _fechamatricula;

            comando.Parameters.Add("@totalcreditos", System.Data.SqlDbType.Int);
            comando.Parameters["@totalcreditos"].Value = _totalcreditos;

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

            string sql = "delete from MATRICULA where IDMATRICULA = @idmatricula";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@idmatricula", System.Data.SqlDbType.Int);
            comando.Parameters["@idmatricula"].Value = _idmatricula;

            con.ejecutartransaccion(comando, conexion);
        }

    }
}
