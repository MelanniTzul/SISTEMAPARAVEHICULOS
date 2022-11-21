using SistemaParaVehiculos.Clases;
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
    public partial class Form2D : Form
    {

        DataTable datosFor2 = Clases.variablesGlobales.baseDatosGlobal;  //Declaramos la tabla

        private static Form2D instancia = null;

        //Funcion que me permite mostrar o abrir otra ventana 
        public static Form2D ventanaUnica()
        {
            if (instancia == null)
            {
                instancia = new Form2D();
                return instancia;
            }
            return instancia;
        }
        public Form2D()
        {
            InitializeComponent();
        }
        //Mensajes en imagen
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido, llene el formulario!");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Ingrese en la base de datos!");
        }

        //Funcion limpiar
        public void limpiartxt()
        {
            foreach (Control crt in this.Controls) //Corre todo lo que sea text, btn etc
            {
                if (crt is TextBox)
                {
                    crt.Text = string.Empty;//vaciar
                }
            }
            txtPrimerNombre.Focus();//Regresa el cursor a mi text principal
        }


        //Funcion que lee el archivo
        public void mostrarDatosTabla()
        {
            //Funcion para leer el archivo
            StreamReader sr = new StreamReader(variablesGlobales.rutaDueno);//definimos la ruta
            while (!sr.EndOfStream)//mientras no sea el final de linea entra
            {
                string linea = sr.ReadLine();//Lee la linea
                string[] aux = linea.Split(',');//separa la cadena por coma crea un vector y los almacena en posiciones
                datosFor2.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4], aux[5], aux[6], aux[7], aux[8], aux[9], aux[10], aux[11]);
            }
            dataGridView2.DataSource = datosFor2;
            sr.Close();
        }

        //Ingreso de datos a la tabal ycomboBox
        private void Form2_Load(object sender, EventArgs e)
        {
            //Crear columnas en la tabla
            datosFor2.Columns.Add("PRIMER NOMBRE");
            datosFor2.Columns.Add("SEGUNDO NOMBRE");
            datosFor2.Columns.Add("PRIMER APELLIDO");
            datosFor2.Columns.Add("SEGUNDO APELLIDO");
            datosFor2.Columns.Add("APELLIDO DE CASAD@");
            datosFor2.Columns.Add("TELEFONO");
            datosFor2.Columns.Add("DPI");
            datosFor2.Columns.Add("GENERO");
            datosFor2.Columns.Add("DIRECCION");
            datosFor2.Columns.Add("CORREO");
            datosFor2.Columns.Add("NIT");
            datosFor2.Columns.Add("ESTADO");
            dataGridView2.DataSource = datosFor2;//Asignamos columnas a la tabla

            //Llenando comboBox de genero
            DataTable datosGenero = new DataTable();
            datosGenero.Columns.Add("VALOR");//ID
            datosGenero.Columns.Add("MOSTRAR");//NOMBRE O DESCRIPCION

            datosGenero.Rows.Add("1", "FEMENINO");
            datosGenero.Rows.Add("2", "MASCULINO");
            datosGenero.Rows.Add("3", "NO BINARIO");
            comboGenero.DataSource = datosGenero;
            comboGenero.DisplayMember = "MOSTRAR";
            comboGenero.ValueMember = "VALOR";

            //Llenar comboBox estado

            DataTable datosEstado = new DataTable();//Creamos tabla        
            datosEstado.Columns.Add("VALOR");//ID
            datosEstado.Columns.Add("MOSTRAR");//nombre o descripcion
            datosEstado.Rows.Add("1", "ACTIVO");
            datosEstado.Rows.Add("0", "INACTIVO");
            comboEstado.DataSource = datosEstado;
            comboEstado.DisplayMember = "MOSTRAR";
            comboEstado.ValueMember = "VALOR";

        }


        //Boton para ingresar datos
        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text != String.Empty && txtSegundoNombre.Text != String.Empty && txtPrimerApellido.Text != String.Empty && txtSegundoApellido.Text != String.Empty && txtApellidoCasad.Text != String.Empty && txtTelefono.Text != String.Empty && txtDpi.Text != String.Empty && comboGenero.Text != String.Empty && txtDireccion.Text != String.Empty && txtCorreo.Text != String.Empty && txtNit.Text != String.Empty && comboEstado.Text != String.Empty)
            {
                //Ingresar los datos a la tabla
                datosFor2.Rows.Add(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtApellidoCasad.Text, txtTelefono.Text, txtDpi.Text, comboGenero.Text, txtDireccion.Text, txtCorreo.Text, txtNit.Text, comboEstado.Text);
                limpiartxt();
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }

        }


        //Modificar 
        int index = -1;
        //Evento DoubleClick de dataGridView
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            //Guardar el indice seleccionadao
            index=dataGridView2.CurrentRow.Index;//obtento el index de la fila que hago doble click
            txtPrimerNombre.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][0].ToString();
            txtSegundoNombre.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][1].ToString();
            txtPrimerApellido.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][2].ToString();
            txtSegundoApellido.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][3].ToString();
            txtApellidoCasad.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][4].ToString();
            txtTelefono.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][5].ToString();
            txtDpi.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][6].ToString();
            comboGenero.Text=datosFor2.Rows[dataGridView2.CurrentRow.Index][7].ToString();
            txtDireccion.Text= datosFor2.Rows[dataGridView2.CurrentRow.Index][8].ToString();
            txtCorreo.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][9].ToString();
            txtNit.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][10].ToString();
            comboEstado.Text = datosFor2.Rows[dataGridView2.CurrentRow.Index][11].ToString();
            btnIngresoDatos.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardatosArchivo.Enabled = true;



        }
        //Boton para modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            datosFor2.Rows[index][0] = txtPrimerNombre;
            datosFor2.Rows[index][1]=txtSegundoNombre;
            datosFor2.Rows[index][2]=txtPrimerApellido;
            datosFor2.Rows[index][3]=txtSegundoApellido;
            datosFor2.Rows[index][4] = txtApellidoCasad;
            datosFor2.Rows[index][5] = txtTelefono;
            datosFor2.Rows[index][6] = txtDpi;
            datosFor2.Rows[index][7] = comboGenero;
            datosFor2.Rows[index][8] = txtDireccion;
            datosFor2.Rows[index][9] = txtCorreo;
            datosFor2.Rows[index][10] = txtNit;
            datosFor2.Rows[index][11]=comboEstado;

            btnIngresoDatos.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            limpiartxt();
        }

       // Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Preguntamos si quiere eliminar el dato
            if (MessageBox.Show("¿Esta seguro que quiere eliminar?", "ATENTO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                datosFor2.Rows.RemoveAt(index);
                btnIngresoDatos.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                limpiartxt();
            }
        }

        //Boton guardar datos en un archivo de texto
        private void btnGuardatosArchivo_Click(object sender, EventArgs e)
        {
            //Para escribir o crear archivos de texto
            StreamWriter sw = new StreamWriter(Clases.variablesGlobales.rutaDueno);
            //Recorrer /Crear archivo
            for(int i = 0; i <datosFor2.Rows.Count; i++)
            {
                string linea = datosFor2.Rows[i][0].ToString() + "," + datosFor2.Rows[i][1].ToString() + "," + datosFor2.Rows[i][2].ToString() + "," + datosFor2.Rows[i][3].ToString() + "," + datosFor2.Rows[i][4].ToString() + "," + datosFor2.Rows[i][5].ToString() + "," + datosFor2.Rows[i][6].ToString() + "," + datosFor2.Rows[i][7].ToString() + "," + datosFor2.Rows[i][8].ToString() + "," + datosFor2.Rows[i][9].ToString() + "," + datosFor2.Rows[i][10].ToString() + "," + datosFor2.Rows[i][11].ToString();
                sw.WriteLine(linea);
            }
            sw.Close();//cerramos

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}



