using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace datos
{
    public class cls_conexion
    {
        public MySqlConnection conex;
        String cadenaconexion;
        public void fnt_conectar()
        {
            conex = new MySqlConnection();
            //************* CONEXION LOCAL ******************
            String servidor = "127.0.0.1";
            String bd = "dbs_sexo";
            String usuario = "root";
            String contraseña = "admin";
            String puerto = "3306";
            cadenaconexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";
            try
            {
                conex.ConnectionString = cadenaconexion;
                conex.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fnt_Desconectar() { conex.Close(); }
    }
}

