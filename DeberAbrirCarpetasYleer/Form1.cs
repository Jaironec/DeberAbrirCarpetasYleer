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

namespace DeberAbrirCarpetasYleer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            string Carpeta = this.textCargar.Text;
            DirectoryInfo di = new DirectoryInfo(Carpeta);

            //recorre la lista y almacena en lisbox
            this.listAbrirCarpetas.Items.Clear();
            foreach (var archivo in di.GetDirectories())
            {
                this.listAbrirCarpetas.Items.Add(archivo);
            }
        }

        private void listAbrirCarpetas_DoubleClick(object sender, EventArgs e)
        {
            string Carpeta1 = this.textCargar.Text + listAbrirCarpetas.SelectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(Carpeta1);
            this.listAbrirArchivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {

                this.listAbrirArchivos.Items.Add(archivo);
            }
        }

        private void listAbrirArchivos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
            string file = this.textCargar.Text + listAbrirCarpetas.SelectedItem.ToString()+listAbrirArchivos.SelectedItem.ToString();
            FileStream archivo = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(archivo);
            string cad, aux = "";
            cad = sr.ReadLine();
            while (cad != null)
            {
                aux += cad + Environment.NewLine;
                cad = sr.ReadLine();
            }
            this.textLeer.Text = aux;
            sr.Close();

        }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
}
    }
}
