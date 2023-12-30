namespace CREADOR_DE_LICENCIAS_EN_C_SHARP
{
    partial class Creador_de_licencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creador_de_licencia));
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.XMLparte1 = new System.Windows.Forms.Label();
            this.xmlParte2 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtserialpc = new System.Windows.Forms.TextBox();
            this.txtsoftware = new System.Windows.Forms.ComboBox();
            this.txtperiodo = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtfecha_caducidad = new System.Windows.Forms.DateTimePicker();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Panel8.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel8
            // 
            this.Panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel8.BackgroundImage")));
            this.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel8.Controls.Add(this.Panel1);
            this.Panel8.Controls.Add(this.txtRuta);
            this.Panel8.Controls.Add(this.Label9);
            this.Panel8.Controls.Add(this.ToolStrip1);
            this.Panel8.Controls.Add(this.Label1);
            this.Panel8.Controls.Add(this.txtserialpc);
            this.Panel8.Controls.Add(this.txtsoftware);
            this.Panel8.Controls.Add(this.txtperiodo);
            this.Panel8.Controls.Add(this.Label5);
            this.Panel8.Controls.Add(this.Label2);
            this.Panel8.Controls.Add(this.txtnumero);
            this.Panel8.Controls.Add(this.Label4);
            this.Panel8.Controls.Add(this.txtfecha_caducidad);
            this.Panel8.Controls.Add(this.btn_insertar);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(1095, 492);
            this.Panel8.TabIndex = 473;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.RichTextBox1);
            this.Panel1.Controls.Add(this.XMLparte1);
            this.Panel1.Controls.Add(this.xmlParte2);
            this.Panel1.Location = new System.Drawing.Point(618, 92);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(10, 10);
            this.Panel1.TabIndex = 603;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(365, 111);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(157, 102);
            this.RichTextBox1.TabIndex = 602;
            this.RichTextBox1.Text = "<?xml version=\"1.0\"?><database DBcnString=\"hola\"></database>";
            // 
            // XMLparte1
            // 
            this.XMLparte1.AutoSize = true;
            this.XMLparte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.XMLparte1.ForeColor = System.Drawing.Color.DimGray;
            this.XMLparte1.Location = new System.Drawing.Point(27, 80);
            this.XMLparte1.Name = "XMLparte1";
            this.XMLparte1.Size = new System.Drawing.Size(510, 29);
            this.XMLparte1.TabIndex = 0;
            this.XMLparte1.Text = "<?xml version=\"1.0\"?><database DBcnString=\"";
            // 
            // xmlParte2
            // 
            this.xmlParte2.AutoSize = true;
            this.xmlParte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.xmlParte2.ForeColor = System.Drawing.Color.DimGray;
            this.xmlParte2.Location = new System.Drawing.Point(83, 51);
            this.xmlParte2.Name = "xmlParte2";
            this.xmlParte2.Size = new System.Drawing.Size(169, 29);
            this.xmlParte2.TabIndex = 0;
            this.xmlParte2.Text = "\"></database>";
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRuta.Location = new System.Drawing.Point(250, 321);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(506, 26);
            this.txtRuta.TabIndex = 600;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label9.Location = new System.Drawing.Point(246, 300);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(105, 20);
            this.Label9.TabIndex = 599;
            this.Label9.Text = "Guardar en:";
            this.Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.White;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton22});
            this.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip1.Location = new System.Drawing.Point(203, 287);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(72, 49);
            this.ToolStrip1.TabIndex = 601;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton22
            // 
            this.ToolStripButton22.BackColor = System.Drawing.Color.White;
            this.ToolStripButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ToolStripButton22.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton22.Image")));
            this.ToolStripButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton22.Name = "ToolStripButton22";
            this.ToolStripButton22.Size = new System.Drawing.Size(37, 46);
            this.ToolStripButton22.Text = "+";
            this.ToolStripButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripButton22.ToolTipText = "Buscar Ruta";
            this.ToolStripButton22.Click += new System.EventHandler(this.ToolStripButton22_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Label1.Location = new System.Drawing.Point(102, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 36);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Serial Pc:";
            // 
            // txtserialpc
            // 
            this.txtserialpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtserialpc.Location = new System.Drawing.Point(250, 28);
            this.txtserialpc.Name = "txtserialpc";
            this.txtserialpc.Size = new System.Drawing.Size(510, 41);
            this.txtserialpc.TabIndex = 1;
            // 
            // txtsoftware
            // 
            this.txtsoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoftware.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsoftware.FormattingEnabled = true;
            this.txtsoftware.Location = new System.Drawing.Point(250, 139);
            this.txtsoftware.Name = "txtsoftware";
            this.txtsoftware.Size = new System.Drawing.Size(305, 41);
            this.txtsoftware.TabIndex = 9;
            this.txtsoftware.Text = "Ada_369";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperiodo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtperiodo.FormattingEnabled = true;
            this.txtperiodo.Items.AddRange(new object[] {
            "mes (es)",
            "año (s)",
            "dia (s)"});
            this.txtperiodo.Location = new System.Drawing.Point(321, 78);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(159, 41);
            this.txtperiodo.TabIndex = 9;
            this.txtperiodo.Text = "mes (es)";
            this.txtperiodo.SelectedIndexChanged += new System.EventHandler(this.txtperiodo_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Label5.Location = new System.Drawing.Point(102, 139);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(140, 36);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Software:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Label2.Location = new System.Drawing.Point(117, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(127, 36);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Periodo:";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(250, 79);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(65, 41);
            this.txtnumero.TabIndex = 8;
            this.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnumero.ValueChanged += new System.EventHandler(this.txtnumero_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(82, 199);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(162, 29);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "F. Caducidad:";
            // 
            // txtfecha_caducidad
            // 
            this.txtfecha_caducidad.Enabled = false;
            this.txtfecha_caducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtfecha_caducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha_caducidad.Location = new System.Drawing.Point(250, 199);
            this.txtfecha_caducidad.Name = "txtfecha_caducidad";
            this.txtfecha_caducidad.Size = new System.Drawing.Size(230, 35);
            this.txtfecha_caducidad.TabIndex = 6;
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_insertar.ForeColor = System.Drawing.Color.Black;
            this.btn_insertar.Location = new System.Drawing.Point(250, 354);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(270, 39);
            this.btn_insertar.TabIndex = 5;
            this.btn_insertar.Text = "Crear Licencia";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // Creador_de_licencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 492);
            this.Controls.Add(this.Panel8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Creador_de_licencia";
            this.Text = "Creador de Licencia Local";
            this.Load += new System.EventHandler(this.Creador_de_licencia_Load);
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Label XMLparte1;
        internal System.Windows.Forms.Label xmlParte2;
        internal System.Windows.Forms.TextBox txtRuta;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton22;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtserialpc;
        internal System.Windows.Forms.ComboBox txtsoftware;
        internal System.Windows.Forms.ComboBox txtperiodo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.NumericUpDown txtnumero;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker txtfecha_caducidad;
        internal System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

