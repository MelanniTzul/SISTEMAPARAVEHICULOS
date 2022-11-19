namespace SistemaParaVehiculos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONDICIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÑOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dUEÑOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.cONDICIONToolStripMenuItem,
            this.aÑOToolStripMenuItem,
            this.dUEÑOToolStripMenuItem,
            this.gENEROToolStripMenuItem,
            this.mARCAToolStripMenuItem,
            this.mODELOToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1145, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";         
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.vToolStripMenuItem.Text = "VEHICULO";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // cONDICIONToolStripMenuItem
            // 
            this.cONDICIONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cONDICIONToolStripMenuItem.Name = "cONDICIONToolStripMenuItem";
            this.cONDICIONToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cONDICIONToolStripMenuItem.Text = "CONDICION";
            this.cONDICIONToolStripMenuItem.Click += new System.EventHandler(this.cONDICIONToolStripMenuItem_Click);
            // 
            // aÑOToolStripMenuItem
            // 
            this.aÑOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aÑOToolStripMenuItem.Name = "aÑOToolStripMenuItem";
            this.aÑOToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.aÑOToolStripMenuItem.Text = "AÑO";
            this.aÑOToolStripMenuItem.Click += new System.EventHandler(this.aÑOToolStripMenuItem_Click);
            // 
            // dUEÑOToolStripMenuItem
            // 
            this.dUEÑOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dUEÑOToolStripMenuItem.Name = "dUEÑOToolStripMenuItem";
            this.dUEÑOToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.dUEÑOToolStripMenuItem.Text = "DUEÑO";
            this.dUEÑOToolStripMenuItem.Click += new System.EventHandler(this.dUEÑOToolStripMenuItem_Click);
            // 
            // gENEROToolStripMenuItem
            // 
            this.gENEROToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gENEROToolStripMenuItem.Name = "gENEROToolStripMenuItem";
            this.gENEROToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.gENEROToolStripMenuItem.Text = "GENERO";
            this.gENEROToolStripMenuItem.Click += new System.EventHandler(this.gENEROToolStripMenuItem_Click);
            // 
            // mARCAToolStripMenuItem
            // 
            this.mARCAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            this.mARCAToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.mARCAToolStripMenuItem.Text = "MARCA";
            this.mARCAToolStripMenuItem.Click += new System.EventHandler(this.mARCAToolStripMenuItem_Click);
            // 
            // mODELOToolStripMenuItem
            // 
            this.mODELOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mODELOToolStripMenuItem.Name = "mODELOToolStripMenuItem";
            this.mODELOToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.mODELOToolStripMenuItem.Text = "MODELO";
            this.mODELOToolStripMenuItem.Click += new System.EventHandler(this.mODELOToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 654);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1145, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 680);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem vToolStripMenuItem;
        private ToolStripMenuItem cONDICIONToolStripMenuItem;
        private ToolStripMenuItem aÑOToolStripMenuItem;
        private ToolStripMenuItem dUEÑOToolStripMenuItem;
        private ToolStripMenuItem gENEROToolStripMenuItem;
        private ToolStripMenuItem mARCAToolStripMenuItem;
        private ToolStripMenuItem mODELOToolStripMenuItem;
    }
}



