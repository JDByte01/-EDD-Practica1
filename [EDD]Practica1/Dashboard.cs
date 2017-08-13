using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1
{
    public partial class Dashboard : Form
    {
        private String url = Path.Combine(Application.StartupPath, "\\servidor\\app\\template\\tablaDashboard.html");
        private String NodoCarnet = "127.0.0.1  -  201503836";

        public Dashboard()
        {
            InitializeComponent();
            mostrarTabla();                         //Mostramos tabla del dashboard en el webBrows

            this.myNodo.Text = this.NodoCarnet;     //En la etiqueta myNodo ponemos la información obtenida

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
                webBrowser.Url = new Uri("file:///C:/Users/JOSED/Documents/Visual%20Studio%202017/Projects/[EDD]Practica1/[EDD]Practica1/bin/Debug/servidor/app/template/tablaDashboard.html");
            }
            catch (Exception)
            {
                
            }
            
        }

        public void setNodoCarnet(String temp)
        {
            this.NodoCarnet = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cargar JSON
        }
    }
}
