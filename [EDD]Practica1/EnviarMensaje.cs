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
    public partial class EnviarMensaje : Form
    {
        public EnviarMensaje()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Enviar mensaje
            try
            {
                String ip = DireccionIp.Text;
                String mensaje = Mensaje.Text;

                if (ip.Equals("") || ip.Length < 5 && mensaje.Equals("") || mensaje.Length < 5)
                {
                    //Cadena vacia
                    MessageBox.Show("No se puede enviar datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string resultado = "false";
                    try
                    {
                        resultado = respuesta(ip, mensaje);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al mandar el mensaje ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                    if (resultado.Equals("true"))
                    {
                        Console.WriteLine("Mensaje recibido");
                    }
                    else
                    {
                        Console.WriteLine("Mensaje no recibido");
                    }

                }  
            }
            catch (Exception)
            {
                //Error al cargar los archivos
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Limpiar TextBox
            DireccionIp.Text = "";
            Mensaje.Text = "";
        }

        private String respuesta(String ip, String mensaje)
        {
            var url = "http://"+ ip + ":5000/mensajeJSON";
            var parametroPOST = (HttpWebRequest)WebRequest.Create(url);
            parametroPOST.ContentType = "application/json; charset=utf-8";
            parametroPOST.Method = "POST";

            using (var streamWriter = new StreamWriter(parametroPOST.GetRequestStream()))
            {
                string json = "{\"ip\" : \"" + ip + "\", \"mensaje\" : \"" + mensaje + "\"}"; ;

                streamWriter.Write(json);
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
