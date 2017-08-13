using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1
{
    public partial class RespuestaMensaje : Form
    {
        public RespuestaMensaje()
        {
            InitializeComponent();
            mostrarTabla();                         //Mostramos tabla del dashboard en el webBrows

            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recargarNavegador();
        }

        private void recargarNavegador()
        {
            webBrowser.Refresh();
        }

        private void mostrarTabla()
        {
            try
            {
                webBrowser.Url = new Uri("file:///C:/Users/JOSED/Documents/Visual%20Studio%202017/Projects/[EDD]Practica1/[EDD]Practica1/bin/Debug/servidor/app/template/tablaMensajes.html");
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mostrar empezando por los más antiguos
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar empezando por los más recientes
        }
    }
}
