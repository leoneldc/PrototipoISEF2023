using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Vista
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2001";
            TextBox[] Grupotextbox = { txt_id, txt_nombre, txt_nit};
            TextBox[] Idtextbox = { txt_id, txt_nombre, txt_nit };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_cientes;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_cientes, Grupotextbox, "sig");
        }
    }
}
