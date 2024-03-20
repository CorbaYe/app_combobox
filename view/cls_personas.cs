using MySql.Data.MySqlClient;
using System.Data;
using datos;


namespace view
{
    public class cls_personas
    {
        private DataTable dt;
        cls_conexion objConectar = new cls_conexion();
        public void fnt_cargarDatos()
        {
            objConectar.fnt_conectar();
            MySqlDataAdapter ademp = new MySqlDataAdapter("select * from tbl_sexo", objConectar.conex);
            dt = new DataTable();
            ademp.Fill(dt);
        }

        public DataTable getDt() { return this.dt; }

    }
}
