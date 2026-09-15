using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad04_Vr_0001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = Txtb_Nom.Text;
            string apellido = Txtb_Ape.Text;
            string telefono = Txtb_Tel.Text;
            string edad = Txtb_Edad.Text;
            string estatura = Txtb_Est.Text;
            string genero = "";
            if (Rbtn_Mas.Checked)
            {
                genero = "Masculino";
            }
            else if (Rbtn_Fem.Checked)
            {
                genero = "femenino";
            }
            else if (Rbtn_Otro.Checked)
            {
                genero = "Otro";
            }

            string mensaje = $" Nombres:{nombre}\n Apellido:{apellido}\n Genero:{genero}\n Edad:{edad}\n Telefono:{telefono}\n Estatura:{estatura}\n";

            //Ruta del almacenamiento de archivo txt
            string rutaFile = "C:\\Users\\haloz\\Documents\\Actividad04_Vr_0001.txt";
            //Valor de verificacion de archivo existente
            bool ArchivoExiste = File.Exists(rutaFile);

            //Instanciacion de la clase/objeto streamwriter para escribir archivo txt
            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if(ArchivoExiste)
                {
                    //añade un separador
                    Escritor.WriteLine();
                }
                Escritor.WriteLine("Datos");
            }

            MessageBox.Show(mensaje, "Registros de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
