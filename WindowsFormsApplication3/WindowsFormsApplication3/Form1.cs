using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;


namespace WindowsFormsApplication3
{
    public partial class frmOperaciones : Form
    {
        Operacion  ingreso = new Operacion();
        Resta obj;
        Multiplicar multi = new Multiplicar();
        Division div = new Division();
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void grbGrupoA_Enter(object sender, EventArgs e)
        {

        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instanciar
            
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValorA.Text);
            ingreso.V2 = double.Parse(txtValorB.Text);

            txtResultado.Text = ingreso.Calcular().ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Resta();
            obj.R1 = double.Parse(txtValorA.Text);
            obj.R2 = double.Parse(txtValorB.Text);

            txtResultado.Text = obj.Restar().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            multi.N1 = double.Parse(txtValorA.Text);
            multi.N2 = double.Parse(txtValorB.Text);

            txtResultado.Text = multi.Multiplica().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            div.N1 = double.Parse(txtValorA.Text);
            div.N2 = double.Parse(txtValorB.Text);

            txtResultado.Text = div.Dividir().ToString();
        }
    }
}
