using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1
{
    public partial class Form1 : Form
    {
        private String myIP = "";
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
            EnviarMensaje em = new EnviarMensaje();
            em.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ver cola de mensajes
            ColaMensaje cm = new ColaMensaje();
            cm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ver reportes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir JSON
            String json = "";
            // Mostrar OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON|*.json";
            openFileDialog.Title = "Seleccione una archivo JSON";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                json = sr.ReadToEnd();
                sr.Close();

                json = json.Replace("\"", "\\\"");
                //json = json.Replace('\n', '\0');
                //json = json.Replace(' ', '\0');
                Console.WriteLine(json);
            }

            //consulta WebService
            try
            {
                myIP = enviarNodos(json);
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo hacer consulta a: http://127.0.0.1:5000/cargarNodos");
                //throw;
            }

            //Mostrar en consola la ip
            Console.WriteLine(myIP);
        }

        private String enviarNodos(String Tempjson)
        {
            var url = "http://127.0.0.1:5000/cargarNodos"; //ruta del webService
            var parametroPOST = (HttpWebRequest)WebRequest.Create(url);
            parametroPOST.ContentType = "application/json; charset=utf-8";
            parametroPOST.Method = "POST";


            using (var streamWriter = new StreamWriter(parametroPOST.GetRequestStream()))
            {
                streamWriter.Write(Tempjson);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)parametroPOST.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}
