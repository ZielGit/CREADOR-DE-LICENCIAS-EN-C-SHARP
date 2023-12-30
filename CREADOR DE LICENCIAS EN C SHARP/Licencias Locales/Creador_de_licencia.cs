using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Management;
namespace CREADOR_DE_LICENCIAS_EN_C_SHARP
{
    public partial class Creador_de_licencia : Form
    {
        public Creador_de_licencia()
        {
            InitializeComponent();
        }

        string serial_licencia;
        private PUNTO_DE_VENTA_CODIGO369_CSHARP.CONEXION.AES aes = new PUNTO_DE_VENTA_CODIGO369_CSHARP.CONEXION.AES();
        private void btn_insertar_Click(object sender, EventArgs e)
        {

            txtserialpc.Text= PUNTO_DE_VENTA_CODIGO369_CSHARP.CONEXION.Desencryptac
            if (txtRuta.Text != "")
            {
                string miCarpeta  = "Licencias_" + txtsoftware.Text;

                serial_licencia = "|" + txtserialpc.Text + "|" + txtfecha_caducidad.Text + "|" + "PENDIENTE" + "|" + txtsoftware.Text + "|";
                crear_xml();
                SavetoXML(aes.Encrypt(serial_licencia, PUNTO_DE_VENTA_CODIGO369_CSHARP.CONEXION.Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Licencia Creada y guardada en: " + txtRuta.Text + miCarpeta, "Creando Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un Disco", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SavetoXML(object dbcnString)
        {
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day;
            int mes = fechaSistema.Month;
            int año = fechaSistema.Year;

            int hora = fechaSistema.Hour;
            int minuto = fechaSistema.Minute;
            string miCarpeta = "Licencias_" + txtsoftware.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load(txtRuta.Text + miCarpeta + @"\Licencia_" + txtsoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter(txtRuta.Text + miCarpeta + @"\Licencia_" + txtsoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        private void crear_xml()

        {
           string miCarpeta = "Licencias_" + txtsoftware.Text;
            if (System.IO.Directory.Exists(txtRuta.Text + miCarpeta))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day ;
            int mes = fechaSistema.Month ;
            int año = fechaSistema.Year ;

            int hora = fechaSistema.Hour ;
            int minuto = fechaSistema.Minute ;

           

            string ruta = txtRuta.Text + miCarpeta + @"\Licencia_" + txtsoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora  + "_" + minuto  + ".xml";
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;
            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(XMLparte1.Text + "hola" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);

                    sw.WriteLine(XMLparte1.Text + "hola" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void txtRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
                string ruta = txtRuta.Text;
                if ((ruta.Contains(@"C:\")))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;

                }


            }
        }

        private void ToolStripButton22_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
                string ruta = txtRuta.Text;
                if ((ruta.Contains(@"C:\")))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;

                }


            }
        }
        private Random r;
        internal void periodos()
        {
                  
                try
                {
                    DateTime today = DateTime.Now;
                DateTime fechaFinal;
                    int numero_periodo=Convert.ToInt32(txtnumero.Value);

                    if (txtperiodo.Text == "mes (es)")
                    {
                        fechaFinal = today.AddMonths  (numero_periodo);
                        txtfecha_caducidad.Value = fechaFinal;

                    }
                    if (txtperiodo.Text == "año (s)")
                    {
                        fechaFinal = today.AddYears (numero_periodo);
                        txtfecha_caducidad.Value = fechaFinal;
                    }
                    if (txtperiodo.Text == "dia (s)")
                    {
                        fechaFinal = today.AddDays (numero_periodo);
                        txtfecha_caducidad.Value = fechaFinal;
                    }

                   
                }
                catch (Exception ex)
                {

                }
            }
        
        private void txtnumero_ValueChanged(object sender, EventArgs e)
        {
            periodos();
        }

        private void txtperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodos();
        }

        private void Creador_de_licencia_Load(object sender, EventArgs e)
        {

        }
    }
}
