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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dashboard
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Ver respuesta de mensajes
            RespuestaMensaje rm = new RespuestaMensaje();
            rm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Enviar mensaje
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ver cola de mensajes
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ver reportes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir JSON
        }
    }
}
