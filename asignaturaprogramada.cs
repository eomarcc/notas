using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class asignaturaprogramada
    {
        private string idasiganturaprogramada = "";
        private string idasignatura = "";
        private string idsemestre = "";
        private string idescuelaprofesional = "";
        private string observacion = "";

        public string Idasiganturaprogramada { get => idasiganturaprogramada; set => idasiganturaprogramada = value; }
        public string Idasignatura { get => idasignatura; set => idasignatura = value; }
        public string Idsemestre { get => idsemestre; set => idsemestre = value; }
        public string Idescuelaprofesional { get => idescuelaprofesional; set => idescuelaprofesional = value; }
        public string Observacion { get => observacion; set => observacion = value; }

        public asignaturaprogramada()
        {

        }
        public asignaturaprogramada (string _idasiganturaprogramada, string _idasignatura, string _idsemestre, string _idescuelaprofesional, string _observacion)
        {
            Idasiganturaprogramada = _idasiganturaprogramada;
            Idasignatura = _idasignatura;
            Idsemestre = _idsemestre;
            Idescuelaprofesional = _idescuelaprofesional;
            Observacion = _observacion;
        
        }
        public void registrarasignaturaprogramada()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();
        

        string sql = "insert into ASIGNATURAPROGRAMADA values (@_idasiganturaprogramada,@_idasignatura,@_idsemestre,@_idescuelaprofesional,@_observacion)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);
          //definimos parametros

            comando.Parameters.Add("@_idasiganturaprogramada", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idasiganturaprogramada"].Value = idasiganturaprogramada;

            comando.Parameters.Add("@_idasignatura", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idasignatura"].Value = idasignatura;

            comando.Parameters.Add("@_idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idsemestre"].Value = idsemestre;

            comando.Parameters.Add("@_idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idescuelaprofesional"].Value = idescuelaprofesional;

            comando.Parameters.Add("@_observacion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_observacion"].Value = observacion;

        }
        public void actualizar_asignaturaprogramada()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "update ASIGNATURAPROGRAMADA set IDASIGNATURAPROGRAMADA = @_idasiganturaprogramada,IDASIGNATURA=@_idasignatura,IDSEMESTRE=@_idsemestre,IDESCUELPROFESIONAL=@_idescuelaprofesional," +
                "OBSERVACION=@_observacion, where IDASIGNATURAPROGRAMADA = @_idasiganturaprogramada";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros

            comando.Parameters.Add("@_idasiganturaprogramada", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idasiganturaprogramada"].Value = idasiganturaprogramada;

            comando.Parameters.Add("@_idasignatura", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idasignatura"].Value = idasignatura;

            comando.Parameters.Add("@_idsemestre", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idsemestre"].Value = idsemestre;

            comando.Parameters.Add("@_idescuelaprofesional", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_idescuelaprofesional"].Value = idescuelaprofesional;

            comando.Parameters.Add("@_observacion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_observacion"].Value = observacion;

            con.ejecutartransaccion(comando, conexion);
        }
        public void eliminar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "delete from ASIGNATURAPROGRAMADA where IDASIGNATURAPROGRAMADA = @_idasiganturaprogramada";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@_idasiganturaprogramada", System.Data.SqlDbType.Int);
            comando.Parameters["@_idasiganturaprogramada"].Value = idasiganturaprogramada;

            con.ejecutartransaccion(comando, conexion);
        }
    }
}
