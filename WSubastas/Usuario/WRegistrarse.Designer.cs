namespace WSubastas
{
    partial class WRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioNuevo = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblGuardar = new System.Windows.Forms.Button();
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
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarToolStripMenuItem.MergeIndex = 1;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // lblUsuarioNuevo
            // 
            this.lblUsuarioNuevo.AutoSize = true;
            this.lblUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNuevo.Location = new System.Drawing.Point(123, 82);
            this.lblUsuarioNuevo.Name = "lblUsuarioNuevo";
            this.lblUsuarioNuevo.Size = new System.Drawing.Size(186, 25);
            this.lblUsuarioNuevo.TabIndex = 1;
            this.lblUsuarioNuevo.Text = "USUARIO NUEVO";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(123, 155);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(235, 25);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "NUEVA CONTRASEÑA";
            // 
            // txtUsuarioNuevo
            // 
            this.txtUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioNuevo.Location = new System.Drawing.Point(315, 76);
            this.txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            this.txtUsuarioNuevo.Size = new System.Drawing.Size(214, 31);
            this.txtUsuarioNuevo.TabIndex = 2;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(364, 155);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(216, 31);
            this.txtNuevaContraseña.TabIndex = 2;
            // 
            // lblGuardar
            // 
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.Location = new System.Drawing.Point(211, 269);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(268, 99);
            this.lblGuardar.TabIndex = 3;
            this.lblGuardar.Text = "GUARDAR";
            this.lblGuardar.UseVisualStyleBackColor = true;
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            // 
            // WRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtUsuarioNuevo);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Controls.Add(this.lblUsuarioNuevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WRegistrarse";
            this.Text = "WRegistrarse";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuarioNuevo;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtUsuarioNuevo;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Button lblGuardar;
    }
}