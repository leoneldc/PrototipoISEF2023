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
    public partial class CINE : Form
    {
        public CINE()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void reservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Reservacion reservacion = new Reservacion();
            reservacion.MdiParent = this;
            reservacion.Show();
        }
    }
}
