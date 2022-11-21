namespace SistemaParaVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDueno = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.btn_guardarDatos = new System.Windows.Forms.Button();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_dueno = new System.Windows.Forms.TextBox();
            this.combo_marca = new System.Windows.Forms.ComboBox();
            this.combo_modelo = new System.Windows.Forms.ComboBox();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.combo_condicion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btn_BuscarPalabra = new System.Windows.Forms.Button();
            this.checkBox_busqueda = new System.Windows.Forms.CheckBox();
            this.lbl_palabraBuscada = new System.Windows.Forms.Label();
            this.txt_buscarPalabra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlaca.Location = new System.Drawing.Point(27, 206);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(57, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "PLACA";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.Location = new System.Drawing.Point(25, 371);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(72, 20);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "MODELO";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(25, 319);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Tag = "";
            this.lblMarca.Text = "MARCA";
            // 
            // lblDueno
            // 
            this.lblDueno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDueno.AutoSize = true;
            this.lblDueno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueno.Location = new System.Drawing.Point(27, 257);
            this.lblDueno.Name = "lblDueno";
            this.lblDueno.Size = new System.Drawing.Size(62, 20);
            this.lblDueno.TabIndex = 6;
            this.lblDueno.Text = "DUEÑO";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(27, 423);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "AÑO";
            // 
            // lblCondicion
            // 
            this.lblCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCondicion.Location = new System.Drawing.Point(27, 484);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(94, 20);
            this.lblCondicion.TabIndex = 8;
            this.lblCondicion.Text = "CONDICION";
            // 
            // btn_guardarDatos
            // 
            this.btn_guardarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardarDatos.Location = new System.Drawing.Point(68, 618);
            this.btn_guardarDatos.Name = "btn_guardarDatos";
            this.btn_guardarDatos.Size = new System.Drawing.Size(146, 29);
            this.btn_guardarDatos.TabIndex = 15;
            this.btn_guardarDatos.Text = "INGRESAR";
            this.btn_guardarDatos.UseVisualStyleBackColor = true;
            this.btn_guardarDatos.Click += new System.EventHandler(this.btn_guardarDatos_Click);
            // 
            // txt_placa
            // 
            this.txt_placa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_placa.Location = new System.Drawing.Point(143, 203);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(125, 27);
            this.txt_placa.TabIndex = 16;
            // 
            // txt_dueno
            // 
            this.txt_dueno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_dueno.Location = new System.Drawing.Point(143, 257);
            this.txt_dueno.Name = "txt_dueno";
            this.txt_dueno.Size = new System.Drawing.Size(240, 27);
            this.txt_dueno.TabIndex = 17;
            // 
            // combo_marca
            // 
            this.combo_marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.combo_marca.FormattingEnabled = true;
            this.combo_marca.Location = new System.Drawing.Point(143, 316);
            this.combo_marca.Name = "combo_marca";
            this.combo_marca.Size = new System.Drawing.Size(151, 28);
            this.combo_marca.TabIndex = 18;
            // 
            // combo_modelo
            // 
            this.combo_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(143, 368);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(151, 28);
            this.combo_modelo.TabIndex = 19;
            // 
            // combo_year
            // 
            this.combo_year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.combo_year.FormattingEnabled = true;
            this.combo_year.Location = new System.Drawing.Point(143, 415);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(151, 28);
            this.combo_year.TabIndex = 20;
            // 
            // combo_condicion
            // 
            this.combo_condicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.combo_condicion.FormattingEnabled = true;
            this.combo_condicion.Location = new System.Drawing.Point(143, 481);
            this.combo_condicion.Name = "combo_condicion";
            this.combo_condicion.Size = new System.Drawing.Size(151, 28);
            this.combo_condicion.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(784, 331);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.Location = new System.Drawing.Point(1212, 398);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.Location = new System.Drawing.Point(1212, 492);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 29);
            this.btn_eliminar.TabIndex = 24;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(1212, 562);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(94, 54);
            this.btnGuardarArchivo.TabIndex = 25;
            this.btnGuardarArchivo.Text = "GUARDAR DATOS";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btn_BuscarPalabra
            // 
            this.btn_BuscarPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BuscarPalabra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarPalabra.Location = new System.Drawing.Point(1212, 92);
            this.btn_BuscarPalabra.Name = "btn_BuscarPalabra";
            this.btn_BuscarPalabra.Size = new System.Drawing.Size(94, 29);
            this.btn_BuscarPalabra.TabIndex = 27;
            this.btn_BuscarPalabra.Text = "BUSCAR";
            this.btn_BuscarPalabra.UseVisualStyleBackColor = true;
            this.btn_BuscarPalabra.Click += new System.EventHandler(this.btn_BuscarPalabra_Click);
            // 
            // checkBox_busqueda
            // 
            this.checkBox_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_busqueda.AutoSize = true;
            this.checkBox_busqueda.Checked = true;
            this.checkBox_busqueda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_busqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_busqueda.Location = new System.Drawing.Point(982, 98);
            this.checkBox_busqueda.Name = "checkBox_busqueda";
            this.checkBox_busqueda.Size = new System.Drawing.Size(215, 24);
            this.checkBox_busqueda.TabIndex = 28;
            this.checkBox_busqueda.Text = "BUSQUEDA POR NOMBRE";
            this.checkBox_busqueda.UseVisualStyleBackColor = true;
            // 
            // lbl_palabraBuscada
            // 
            this.lbl_palabraBuscada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_palabraBuscada.AutoSize = true;
            this.lbl_palabraBuscada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_palabraBuscada.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_palabraBuscada.Location = new System.Drawing.Point(759, 154);
            this.lbl_palabraBuscada.Name = "lbl_palabraBuscada";
            this.lbl_palabraBuscada.Size = new System.Drawing.Size(0, 20);
            this.lbl_palabraBuscada.TabIndex = 29;
            // 
            // txt_buscarPalabra
            // 
            this.txt_buscarPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscarPalabra.Location = new System.Drawing.Point(506, 94);
            this.txt_buscarPalabra.Name = "txt_buscarPalabra";
            this.txt_buscarPalabra.Size = new System.Drawing.Size(463, 27);
            this.txt_buscarPalabra.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(440, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 704);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscarPalabra);
            this.Controls.Add(this.lbl_palabraBuscada);
            this.Controls.Add(this.checkBox_busqueda);
            this.Controls.Add(this.btn_BuscarPalabra);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_condicion);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.combo_modelo);
            this.Controls.Add(this.combo_marca);
            this.Controls.Add(this.txt_dueno);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.btn_guardarDatos);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDueno);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlaca;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblDueno;
        private Label lblYear;
        private Label lblCondicion;
        private Button btn_guardarDatos;
        private TextBox txt_placa;
        private TextBox txt_dueno;
        private ComboBox combo_marca;
        private ComboBox combo_modelo;
        private ComboBox combo_year;
        private ComboBox combo_condicion;
        private DataGridView dataGridView1;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btnGuardarArchivo;
        private Button btn_BuscarPalabra;
        private CheckBox checkBox_busqueda;
        private Label lbl_palabraBuscada;
        private TextBox txt_buscarPalabra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}