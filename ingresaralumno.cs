using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SOFTWARE_II
{
    class ingresaralumno
    {
        private string id_alumno = "";
        private string nombres = "";
        private string apellido_paterno = "";
        private string apellido_materno = "";
        private int dni = 0;
        private string fecha_nacimiento = "";
        private string direccion = "";
        private string sexo = "";
        private int telefono = 0;
        private string estado = "";

        public string Id_alumno { get => id_alumno; set => id_alumno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }

        public ingresaralumno() { }

        public ingresaralumno(string _id_alumno, string _nombres, string _apellido_paterno, string _apellido_materno, int _dni, string _fecha_nacimiento,
                              string _direccion, string _sexo, int _telefono, string _estado)
        {
            id_alumno = _id_alumno;
            nombres = _nombres;
            apellido_paterno = _apellido_paterno;
            apellido_materno = _apellido_materno;
            dni = _dni;
            fecha_nacimiento = _fecha_nacimiento;
            direccion = _direccion;
            sexo = _sexo;
            telefono = _telefono;
            estado = _estado;
        }
        public void registrar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "insert into ALUMNO values (@_id_alumno,@_nombres,@_apellido_paterno,@_apellido_materno,@_dni,@_fecha_nacimiento,@_direccion,@_sexo,@_telefono,@_estado)";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@_id_alumno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_id_alumno"].Value = id_alumno;

            comando.Parameters.Add("@_nombres", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_nombres"].Value = nombres;

            comando.Parameters.Add("@_apellido_paterno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_apellido_paterno"].Value = apellido_paterno;

            comando.Parameters.Add("@_apellido_materno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_apellido_materno"].Value = apellido_paterno;

            comando.Parameters.Add("@_dni", System.Data.SqlDbType.Int);
            comando.Parameters["@_dni"].Value = dni;

            comando.Parameters.Add("@_fecha_nacimiento", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_fecha_nacimiento"].Value = fecha_nacimiento;

            comando.Parameters.Add("@_direccion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_direccion"].Value = direccion;

            comando.Parameters.Add("@_sexo", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_sexo"].Value = sexo;

            comando.Parameters.Add("@_telefono", System.Data.SqlDbType.Int);
            comando.Parameters["@_telefono"].Value = telefono;

            comando.Parameters.Add("@_estado", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_estado"].Value = estado;

            con.ejecutartransaccion(comando, conexion);

        }
        public void actualizar_alumno()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "update ALUMNO set IDALUMNO = @_id_alumno,NOMBRES=@_nombres,APELLIDOPATERNO=@_apellido_paterno,APELLIDOMATERNO=@_apellido_materno," +
                "DNI=@_dni,FECHANACIEMIENTO=@_fecha_nacimiento,DIRECCION=@_direccion,SEXO=@_sexo,TELEFONO=@_telefono,ESTADO=@_estado, where IDALUMNO = @_id_alumno";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            //definimos parametros

            comando.Parameters.Add("@_id_alumno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_id_alumno"].Value = id_alumno;

            comando.Parameters.Add("@_nombres", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_nombres"].Value = nombres;

            comando.Parameters.Add("@_apellido_paterno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_apellido_paterno"].Value = apellido_paterno;

            comando.Parameters.Add("@_apellido_materno", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_apellido_materno"].Value = apellido_paterno;

            comando.Parameters.Add("@_dni", System.Data.SqlDbType.Int);
            comando.Parameters["@_dni"].Value = dni;

            comando.Parameters.Add("@_fecha_nacimiento", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_fecha_nacimiento"].Value = fecha_nacimiento;

            comando.Parameters.Add("@_direccion", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_direccion"].Value = direccion;

            comando.Parameters.Add("@_sexo", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_sexo"].Value = sexo;

            comando.Parameters.Add("@_telefono", System.Data.SqlDbType.Int);
            comando.Parameters["@_telefono"].Value = telefono;

            comando.Parameters.Add("@_estado", System.Data.SqlDbType.VarChar);
            comando.Parameters["@_estado"].Value = estado;

            con.ejecutartransaccion(comando, conexion);
        }
        public void eliminar()
        {

            //crearun objeto sqlconnection
            SqlConnection conexion = new SqlConnection();

            //creamos un obvjeto de conexion
            conexion con = new conexion();

            conexion = con.conectar();

            string sql = "delete from ALUMNO where IDALUMNO = @_id_alumno";
            //utilizamos la clase sqlcommand
            SqlCommand comando = new SqlCommand(sql);

            //definimos parametros

            comando.Parameters.Add("@_id_alumno", System.Data.SqlDbType.Int);
            comando.Parameters["@_id_alumno"].Value = id_alumno;

            con.ejecutartransaccion(comando, conexion);
        }
    }
    
}
