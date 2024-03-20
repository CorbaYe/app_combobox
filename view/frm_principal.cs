using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            fnt_sexo();
        }
        private void fnt_sexo()
        {
            cls_personas objSexo = new cls_personas();
            objSexo.fnt_cargarDatos();
            cbx_sexo.DataSource = objSexo.getDt();
            cbx_sexo.ValueMember = "pk_id";
            cbx_sexo.DisplayMember = "descripcion";
        }
    }
}
