namespace WSubastas
{
    partial class WSubasta
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
            this.saveFileDialogSubasta = new System.Windows.Forms.SaveFileDialog();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProductoInicial = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioInicial = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblReglas = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtReglas = new System.Windows.Forms.TextBox();
            this.dgvSubastas = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubastas)).BeginInit();
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
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(28, 58);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(116, 24);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "PRODUCTO";
            // 
            // lblProductoInicial
            // 
            this.lblProductoInicial.AutoSize = true;
            this.lblProductoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoInicial.Location = new System.Drawing.Point(364, 58);
            this.lblProductoInicial.Name = "lblProductoInicial";
            this.lblProductoInicial.Size = new System.Drawing.Size(147, 24);
            this.lblProductoInicial.TabIndex = 3;
            this.lblProductoInicial.Text = "PRECIO INICIAL";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(150, 55);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(191, 29);
            this.txtProducto.TabIndex = 4;
            // 
            // txtPrecioInicial
            // 
            this.txtPrecioInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioInicial.Location = new System.Drawing.Point(517, 55);
            this.txtPrecioInicial.Name = "txtPrecioInicial";
            this.txtPrecioInicial.Size = new System.Drawing.Size(160, 29);
            this.txtPrecioInicial.TabIndex = 5;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(28, 114);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(200, 24);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "DURACION SUBASTA";
            // 
            // lblReglas
            // 
            this.lblReglas.AutoSize = true;
            this.lblReglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglas.Location = new System.Drawing.Point(426, 114);
            this.lblReglas.Name = "lblReglas";
            this.lblReglas.Size = new System.Drawing.Size(85, 24);
            this.lblReglas.TabIndex = 7;
            this.lblReglas.Text = "REGLAS";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(234, 111);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(183, 29);
            this.txtDuracion.TabIndex = 8;
            // 
            // txtReglas
            // 
            this.txtReglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReglas.Location = new System.Drawing.Point(517, 111);
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.Size = new System.Drawing.Size(160, 29);
            this.txtReglas.TabIndex = 9;
            // 
            // dgvSubastas
            // 
            this.dgvSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubastas.Location = new System.Drawing.Point(12, 229);
            this.dgvSubastas.Name = "dgvSubastas";
            this.dgvSubastas.Size = new System.Drawing.Size(776, 150);
            this.dgvSubastas.TabIndex = 10;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnIngresar.Location = new System.Drawing.Point(172, 174);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(124, 35);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCSV.Location = new System.Drawing.Point(430, 174);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(141, 35);
            this.btnCSV.TabIndex = 12;
            this.btnCSV.Text = "Archivo CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // WSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvSubastas);
            this.Controls.Add(this.txtReglas);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblReglas);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtPrecioInicial);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProductoInicial);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WSubasta";
            this.Text = "WSubasta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubastas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSubasta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProductoInicial;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecioInicial;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblReglas;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtReglas;
        private System.Windows.Forms.DataGridView dgvSubastas;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCSV;
    }
}