namespace WSubastas
{
    partial class fmrGestionSubastas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subastasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participarToolStripMenuItem,
            this.subastaToolStripMenuItem,
            this.subastasToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // participarToolStripMenuItem
            // 
            this.participarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.registrarseToolStripMenuItem});
            this.participarToolStripMenuItem.Name = "participarToolStripMenuItem";
            this.participarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participarToolStripMenuItem.Text = "&Participar";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "&Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarseToolStripMenuItem.Text = "&Registrarse";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // subastaToolStripMenuItem
            // 
            this.subastaToolStripMenuItem.Name = "subastaToolStripMenuItem";
            this.subastaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subastaToolStripMenuItem.Text = "Subasta";
            // 
            // subastasToolStripMenuItem
            // 
            this.subastasToolStripMenuItem.Name = "subastasToolStripMenuItem";
            this.subastasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.subastasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subastasToolStripMenuItem.Text = "&Cerrar";
            this.subastasToolStripMenuItem.Click += new System.EventHandler(this.subastasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // fmrGestionSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrGestionSubastas";
            this.Text = "WAplicacion de Subastas ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subastasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem participarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
    }
}

