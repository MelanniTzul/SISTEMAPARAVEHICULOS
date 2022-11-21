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
    public partial class Form3 : Form
    {
        DataTable datosFrom3 = Clases.variablesGlobales.baseDatosGlobal;//Declaramos tabla


        private static Form3 instancia = null;


        //Funcion verificar si la ventana ya esta abierta si no que me abra una nueva
        public static Form3 ventanaUnica()
        {
            if (instancia == null)
            {
                instancia = new Form3();
                return instancia;
            }
            return instancia;
        }


        public Form3()
        {
            InitializeComponent();
        }

        //Funcion limpiar*/
        public void limpiarComboBox()
        {
            foreach (Control crt in this.Controls)//Corre todo lo que sea text, btn etc
                if (crt is TextBox)
                {
                    crt.Text = String.Empty;//vaciar
                }
            comboMarca.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, ingrese los datos");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos que desea buscar");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            datosFrom3.Columns.Add("MARCA");
            datosFrom3.Columns.Add("DESCRIPCION");
            datosFrom3.Columns.Add("es");
            dataGridView3.DataSource = datosFrom3;

            //Ingresar datos al comboBox marca
            DataTable datosMarca = new DataTable();
            datosMarca.Columns.Add("VALOR");//ID
            datosMarca.Columns.Add("MOSTRAR");//PALABRA O DESCRIPCION       
            datosMarca.Rows.Add("1", "BMW");
            datosMarca.Rows.Add("2", "MAZDA");
            datosMarca.Rows.Add("3", "TOYOTA");
            datosMarca.Rows.Add("4", "HONDA");
            datosMarca.Rows.Add("5", "SUZUKI");
            comboMarca.DataSource = datosMarca;
            comboMarca.DisplayMember = "MOSTRAR";
            comboMarca.ValueMember = "VALOR";

            //Mostrar datos en el combox descripcion
            DataTable datosDescripcion = new DataTable();
            datosDescripcion.Columns.Add("VALOR");
            datosDescripcion.Columns.Add("MOSTRAR");
            datosDescripcion.Rows.Add("1", "NUEVO");
            datosDescripcion.Rows.Add("2", "SEMI NUEVO");
            datosDescripcion.Rows.Add("3", "RODADO");
            datosDescripcion.Rows.Add("4", "AGENCIA");
            comboDescripcion.DataSource = datosDescripcion;
            comboDescripcion.DisplayMember = "MOSTRAR";
            comboDescripcion.ValueMember = "VALOR";

            //Ingreso de datos al comboBox estado
            DataTable datosEstado = new DataTable();
            datosEstado.Columns.Add("VALOR");//ID
            datosEstado.Columns.Add("MOSTRAR");//PALABRA          
            datosEstado.Rows.Add("1", "ACTIVO");
            datosEstado.Rows.Add("0", "INACTIVO");
            comboEstado.DataSource = datosEstado;
            comboEstado.DisplayMember = "MOSTRAR";
            comboEstado.ValueMember = "VALOR";

        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            if (comboMarca.Text != String.Empty && comboDescripcion.Text != String.Empty && comboEstado.Text != String.Empty)
            {
                datosFrom3.Rows.Add(comboMarca.Text, comboDescripcion.Text, comboEstado.Text);
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }

        }

        

        
       
    }
}
