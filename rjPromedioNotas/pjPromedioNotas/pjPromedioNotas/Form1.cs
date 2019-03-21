using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciacion de singleton
        singleton director = singleton.Instance;
        //singleton
        private void nameDirector_Click(object sender, EventArgs e)
        {
            nameDirector.Text = director.Nombre;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Objeto de la clase promedio
            Promedio objP = new Promedio();

            //Enviando los valores a la clase
            objP.alumno = txtAlumno.Text;
            objP.nota1 = int.Parse(txtNota1.Text);
            objP.nota2 = int.Parse(txtNota2.Text);
            objP.nota3 = int.Parse(txtNota3.Text);
            objP.nota4 = int.Parse(txtNota4.Text);

            //Imprimiendo los valores
            lblPromedio.Text = objP.calculaPromedio().ToString("0.00");
            lblBaja.Text = objP.masBaja().ToString("0.00");
            lblCondicion.Text = objP.asignaCondicion();
            nameDirector.Text = director.Nombre;
            if (objP.asignaCondicion() == "Aprobado")
            {
                lblCuadroH.Text = clsCuadroHonor.Mensaje();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string x = txtDoc.Text;
            var tipo = factoryMethod.Build(x);
            lblDoc.Text = tipo.GetType().Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCondicion.Text="";
            lblCuadroH.Text="";
            lblBaja.Text="";
            lblPromedio.Text="";
            txtAlumno.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
