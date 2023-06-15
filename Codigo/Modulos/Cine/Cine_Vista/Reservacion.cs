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
    public partial class Reservacion : Form
    {
        Cine_Controlador.Controlador controlador = new Cine_Controlador.Controlador();
        public Reservacion()
        {
            InitializeComponent(); 
            bloquear();
            llenarTextbox();
            controlador.setNewId(txt_factura, "factura", "idFactura");
        }
        public void bloquear()
        {
            txt_factura.Enabled = false;
            txt_cine.Enabled = false;
            txt_pelicula.Enabled = false;
        }

        private void llenarTextbox()
        {
            controlador.llenarComboBox(txt_cliente, "clientes");
            controlador.llenarComboBox(txt_cine, "cines");
            controlador.llenarComboBox(txt_pelicula, "peliculas");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_factura.Text.Length != 0 && txt_cliente.SelectedIndex != null && txt_metodo.Text.Length != 0)
            {
                txt_cine.Enabled = true;
                txt_pelicula.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_cine.SelectedIndex != null && txt_pelicula.SelectedIndex != null)
            {

                string[] infoCine = txt_cine.SelectedItem.ToString().Split('-');
                string[] infoPelicula = txt_pelicula.SelectedItem.ToString().Split('-');

                DataTable data = controlador.mostrarAsientos(infoCine[1], infoPelicula[1]);
                tbl_asientos.DataSource = data;
            }
        }
    }
}
