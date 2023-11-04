using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ejercicios
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); //Conectarme a  la BD
        SqlCommand miComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es una representacion grafica de la BD en memoria.

    public Conexion()
     {
           String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
           miConexion.ConnectionString = cadenaConexion;
           miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from materias";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "materias");

            miComando.CommandText = "select * from alumnos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "alumnos");

            miComando.CommandText = "select * from usuarios";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "usuarios");

            return miDs;
        }
        private void parametrizacion()
        {
            miComando.Parameters.Add("@id", SqlDbType.Int).Value = 0;
            miComando.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            miComando.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            miComando.Parameters.Add("@dir", SqlDbType.Char).Value = "";
            miComando.Parameters.Add("@tel", SqlDbType.Char).Value = "";
            miComando.Parameters.Add("@uv", SqlDbType.Int).Value = 0;

        }
        public String mantenimientoMaterias(String[] materias)
        {
            String sql = "";
            if (materias[0] == "nuevo")
            {
                sql = "INSERT INTO materias (codigo, materia, uv) VALUES(@cod, @nom, @uv)";
            }
            else if (materias[0] == "modificar")
            {
                sql = "UPDATE materias SET codigo= @cod, materia= @nom, uv= @uv  WHERE idMateria= @id";
            }
            else if (materias[0] == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria=@id";
            }
            miComando.Parameters["@id"].Value = materias[4];
            miComando.Parameters["@cod"].Value = materias[1];
            miComando.Parameters["@nom"].Value = materias[2];
            miComando.Parameters["@uv"].Value = materias[3];
            return ejecutarSql(sql);
        }
        public String mantenimientoAlumnos(String[] alumnos)
        {
            String sql = "";
            if (alumnos[0] == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES(@cod, @nom, @dir, @tel)";
            }
            else if (alumnos[0] == "modificar")
            {
                sql = "UPDATE alumnos SET codigo= @cod, nombre= @nom, direccion= @dir, telefono= @tel WHERE idAlumno= @id";
            }
            else if (alumnos[0] == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno= @id";
            }
            return ejecutarSql(sql);
        }
        public String mantenimiento_usuarios(String[] usuarios)
        {
            String sql = "";
            if (usuarios[0] == "nuevo")
            {
                sql = "INSERT INTO usuarios (usuario, clave, nombre, direccion, telefono) VALUES('" + usuarios[1] + "', '" + usuarios[2] + "', '" +
                    usuarios[3] + "', '" + usuarios[4] + "','" + usuarios[5] + "')";
            }
            else if (usuarios[0] == "modificar")
            {
                sql = "UPDATE usuarios SET usuario='" + usuarios[1] + "', clave='" + usuarios[2] + "', nombre='" + usuarios[3] + "', direccion='" +
                 usuarios[4] + "', telefono='" + usuarios[5] + "' WHERE idUsuario='" + usuarios[6] + "'";
            }
            else if (usuarios[0] == "eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario='" + usuarios[6] + "'";
            }
            return ejecutarSql(sql);
        }
            private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}//.nghp
