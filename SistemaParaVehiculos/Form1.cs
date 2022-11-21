using SistemaParaVehiculos.Clases;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace SistemaParaVehiculos


{
    public partial class Form1 : Form
    {
      

        DataTable datos = Clases.variablesGlobales.baseDatosGlobal;//Declaramos tabla
         
        //Declaro variable
        private static Form1 instancia = null;
       

        //Funcion verificar si la ventana ya esta abierta si no que me abra una nueva
        public static Form1 ventanaUnica()
        {
            if(instancia == null)
            {
                instancia = new Form1();
                return instancia;
            }
            return instancia; 
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llene el formulario!");
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
            txt_placa.Focus();//Regresa el cursor a mi text principal
        }


        //Funcion que lee el archivo
        public void mostrarDatosTabla()
        {
            //Funcion para leer el archivo
            StreamReader sr = new StreamReader(variablesGlobales.ruta);//definimos la ruta
            while (!sr.EndOfStream)//mientras no sea el final de linea entra
            {
                string linea = sr.ReadLine();//Lee la linea
                string[] aux = linea.Split(',');//separa la cadena por coma crea un vector y los almacena en posiciones
                datos.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4], aux[5]);
            }
            dataGridView1.DataSource = datos;
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datos.Columns.Add("PLACA");
            datos.Columns.Add("DUEÑO");
            datos.Columns.Add("M");
            datos.Columns.Add("MODELO");
            datos.Columns.Add("AÑO");
            datos.Columns.Add("CONDICION");
            dataGridView1.DataSource = datos;//Asignamos columnas
            mostrarDatosTabla();//Mostramos la tabla

            //Llenando comboBox de marca
            DataTable datosMarca = new DataTable();
            datosMarca.Columns.Add("VALOR");//ID
            datosMarca.Columns.Add("MOSTRAR");//nombre//Descripcion

            datosMarca.Rows.Add("1", "BMW");
            datosMarca.Rows.Add("2", "MAZDA");
            datosMarca.Rows.Add("3", "TOYOTA");
            datosMarca.Rows.Add("4", "HONDA");
            datosMarca.Rows.Add("5", "SUZUKI");
            combo_marca.DataSource = datosMarca; //Llenamos comboBox
            combo_marca.DisplayMember = "MOSTRAR";//Indicamos que vamos a mostrar
            combo_marca.ValueMember = "VALOR";//indicamos quien es el que nos va servir para estar operando

            //Llenando comboBox de modelo
            DataTable datosModelo = new DataTable();
            datosModelo.Columns.Add("VALOR");//ID
            datosModelo.Columns.Add("MOSTRAR");//nombre//Descripcion

            datosModelo.Rows.Add("1", "RAV 4");
            datosModelo.Rows.Add("2", "YARIS");
            datosModelo.Rows.Add("3", "COROLA");
            datosModelo.Rows.Add("4", "CRV");
            datosModelo.Rows.Add("5", "CIVIC");
            datosModelo.Rows.Add("6", "ALTO");
            datosModelo.Rows.Add("7", "B3");
            combo_modelo.DataSource = datosModelo;//Llenamos comboBox
            combo_modelo.DisplayMember = "MOSTRAR";
            combo_modelo.ValueMember = "VALOR";

            //Llenando comboBox de year
            DataTable datosAn = new DataTable();
            datosAn.Columns.Add("VALOR");//ID
            datosAn.Columns.Add("MOSTRAR");//Nombre o descripcion

            datosAn.Rows.Add("1", "2010");
            datosAn.Rows.Add("2", "2011");
            datosAn.Rows.Add("3", "2012");
            datosAn.Rows.Add("4", "2013");
            datosAn.Rows.Add("5", "2014");
            datosAn.Rows.Add("6", "2015");
            datosAn.Rows.Add("7", "2016");
            datosAn.Rows.Add("8", "2017");
            datosAn.Rows.Add("9", "2018");
            datosAn.Rows.Add("10", "2019");

            combo_year.DataSource = datosAn;//Llenamos comboBox
            combo_year.DisplayMember = "MOSTRAR";
            combo_year.ValueMember = "VALOR";

            //Llenando comboBox de condicion
            DataTable datosCondicion = new DataTable();//Creacion de tabla
            datosCondicion.Columns.Add("VALOR");//ID
            datosCondicion.Columns.Add("MOSTRAR");//nombre o descripcion

            datosCondicion.Rows.Add("1", "NUEVO");
            datosCondicion.Rows.Add("2", "SEMI NUEVO");
            datosCondicion.Rows.Add("3", "RODADO");
            datosCondicion.Rows.Add("4", "AGENCIA");

            combo_condicion.DataSource = datosCondicion;//Llenamos comboBox
            combo_condicion.DisplayMember = "MOSTRAR";
            combo_condicion.ValueMember = "VALOR";

        }

        //Guardar datos -Ingresarlos en el dataGridView
        private void btn_guardarDatos_Click(object sender, EventArgs e)
        {
            if (txt_placa.Text != string.Empty && txt_dueno.Text != string.Empty && combo_marca.Text != string.Empty && combo_modelo.Text != string.Empty && combo_year.Text != string.Empty && combo_condicion.Text != string.Empty)
            {
                //Ingresar datos a la tabla
                datos.Rows.Add(txt_placa.Text, txt_dueno.Text, combo_marca.Text, combo_modelo.Text, combo_year.Text, combo_condicion.Text);
                limpiartxt();
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
        }





        //Modificar
        int index = -1;//variable que permite hubicarme en el indice de la tabla 
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Guarda el indice seleccionado
            index = dataGridView1.CurrentRow.Index;//obtento el index de la fila que hago doble click
            txt_placa.Text = datos.Rows[dataGridView1.CurrentRow.Index][0].ToString();
            txt_dueno.Text = datos.Rows[dataGridView1.CurrentRow.Index][1].ToString();
            combo_marca.Text = datos.Rows[dataGridView1.CurrentRow.Index][2].ToString();
            combo_modelo.Text = datos.Rows[dataGridView1.CurrentRow.Index][3].ToString();
            combo_year.Text = datos.Rows[dataGridView1.CurrentRow.Index][4].ToString();
            combo_condicion.Text = datos.Rows[dataGridView1.CurrentRow.Index][5].ToString();

            btn_guardarDatos.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        //Boton modificar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            datos.Rows[index][0] = txt_placa.Text;
            datos.Rows[index][1] = txt_dueno.Text;
            datos.Rows[index][2] = combo_marca.Text;
            datos.Rows[index][3] = combo_modelo.Text;
            datos.Rows[index][4] = combo_year.Text;
            datos.Rows[index][5] = combo_condicion.Text;


            btn_guardarDatos.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            limpiartxt();


        }

        //Boton eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Preguntamos si quiere eliminar el dato
            if (MessageBox.Show("¿Esta seguro que quiere eliminar?", "ATENTO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                datos.Rows.RemoveAt(index);
                btn_guardarDatos.Enabled = true;
                btn_eliminar.Enabled = false;
                btn_modificar.Enabled = false;
                limpiartxt();
            }

        }

        //Boton guardar archivo
        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            //Para escribir o crear archivos de texto
            StreamWriter sw = new StreamWriter(Clases.variablesGlobales.ruta);
            //Recorrer /Crear archivo
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                string linea = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                sw.WriteLine(linea);
            }
            sw.Close();//cerramos 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Ingres el dato que desea buscar!");
        }


        //Boton  de busqueda
        private void btn_BuscarPalabra_Click(object sender, EventArgs e)
        {
            if (checkBox_busqueda.Checked)//Si es true
            {
                //Buscamos por nombre
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    if (datos.Rows[i][1].ToString().Contains(txt_dueno.Text))
                    {
                        lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][2].ToString().Contains(combo_marca.Text))
                    {
                        lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][3].ToString().Contains(combo_modelo.Text))
                    {
                        lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][4].ToString().Contains(combo_year.Text)){
                        lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][5].ToString().Contains(combo_condicion.Text))
                    {
                        lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                    }

                }

            }else
            {
                //Buscar por placa
                if (txt_buscarPalabra.Text != String.Empty)//Hace la accion si encuentra datos
                {
                    //Recorrer base de datos
                    for(int i=0; i<datos.Rows.Count; i++)
                    {
                        if (datos.Rows[i][0].ToString()==txt_placa.Text)
                        {
                            lbl_palabraBuscada.Text = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString() + "," + datos.Rows[i][5].ToString();
                        }
                    }
                }
            }
        }
    }
}