using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btnVentas};
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1000, apps[0]);
            cn.getAccesoApp(2000, apps[1]);



        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            //this.Close();
        }

        public void btnVentas_Click(object sender, EventArgs e)
        {
            Cine_Vista.CINE mdi = new Cine_Vista.CINE();
            mdi.Show();
            cn.setBtitacora("2000", "Ingreso Ventas");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("999", "Cerro Sesion");
            b.Show();
            this.Close();
        }

    }
}
