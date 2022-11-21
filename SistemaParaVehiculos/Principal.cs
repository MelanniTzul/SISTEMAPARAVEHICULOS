using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaVehiculos
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;
       
        

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }



        //Evento de vehiculo
        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1 form1Vehiculo = new Form1();//creamos una variable y llamamos alformualrio que queremos mostrar 

            Form1 form1Vehiculo = Form1.ventanaUnica();
            form1Vehiculo.MdiParent = this;//que se ingrente dentro de MdiParent
            form1Vehiculo.Show();//mostramos el formulario
            form1Vehiculo.BringToFront();//trae el formulario al frente en el foco principal
        }

        //Evento de dueno
        private void dUEÑOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2D form2 = Form2D.ventanaUnica();
            form2.MdiParent = this;
            form2.Show();
            form2.BringToFront();

        }

        //Evento de Modelo
        private void mODELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3Modelo =Form3.ventanaUnica();
            form3Modelo.MdiParent = this;
            form3Modelo.Show();
            form3Modelo.BringToFront();
        }

        
    }
}

