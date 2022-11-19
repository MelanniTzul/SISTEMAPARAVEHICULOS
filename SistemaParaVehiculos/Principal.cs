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

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1Vehiculo = new Form1();//creamos una variable y llamamos alformualrio que queremos mostrar 
            form1Vehiculo.MdiParent = this;//que se ingrente dentro de MdiParent
            form1Vehiculo.Show();//mostramos el formulario

        }

        private void cONDICIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2Condicion = new Form2();//creamos una variable y llamamos alformualrio que queremos mostrar 
            form2Condicion.MdiParent = this;//que se ingrente dentro de MdiParent
            form2Condicion.Show();//mostramos el formulario
        }

        private void aÑOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3year = new Form3();//creamos una variable y llamamos alformualrio que queremos mostrar 
            form3year.MdiParent = this;//que se ingrente dentro de MdiParent
            form3year.Show();//mostramos el formulario
        }

        private void dUEÑOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4Dueno = new Form4();
            form4Dueno.MdiParent = this;
            form4Dueno.Show();
        }

        private void gENEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5Genero= new Form5();
            form5Genero.MdiParent = this;
            form5Genero.Show();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6Marca= new Form6();
            form6Marca.MdiParent = this;
            form6Marca.Show();
        }

        

        private void mODELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7Modelo = new Form7();
            form7Modelo.MdiParent = this;
            form7Modelo.Show();
        }
    }
}

