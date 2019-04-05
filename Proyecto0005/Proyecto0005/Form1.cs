using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto0005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //iteem son todos los componentes que tendran la lista
            listBox1.Items.Clear();
            //crear arreglo y que me traiga la informacion de discos y que me lo guarde en la variable
            
            DriveInfo[] u = DriveInfo.GetDrives();
            // que me traiga lainformacion de driveinfo y me lo almacene en la variable unidad
            foreach (DriveInfo unidad in u)
            {
                try
                {
                    listBox1.Items.Add(unidad.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de lectura"+ex.Message);
                }
               // MessageBox.Show("Error leyendo los discos");
            }
            //try y catch  intentarlo y no hacerlo
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiando solo abra una vez
            listBox2.Items.Clear();
            //index posicion, index texto
            String unidades = listBox1.SelectedItem.ToString();
            //llenar el otro lisbot
            listBox2.Items.Add(unidades);
            DriveInfo d = new DriveInfo(unidades);
            listBox2.Items.Add("Disco: "+d.Name + "\n");

            if(d.IsReady)
            {
                listBox2.Items.Add("Espacio ocupado (GB): " + (d.TotalSize - d.AvailableFreeSpace)
                    / 1024 / 1024 / 1024 + "\n");
                //k /m /g
                listBox2.Items.Add("Espacio Disponible (GB): " + (d.TotalFreeSpace) 
                    / 1024 / 1024 / 1024 + "\n");
                listBox2.Items.Add("Espacio Total (GB): " + (d.TotalSize)
                    / 1024 / 1024 / 1024 + "\n");

            }
            //vamos a utilizar dentro del lisbos la informacion que vamos a agregar
            listBox2.Items.Add("Tipo de disco utilizado "+d.DriveType.ToString()+"\n");
            //convertir a cedema
            
            //limpiar
            treeView1.Nodes.Clear();
            if(d.IsReady)
            {
                DirectoryInfo dir = new DirectoryInfo(unidades);
                //agregar nodes de las propiedades

                
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
