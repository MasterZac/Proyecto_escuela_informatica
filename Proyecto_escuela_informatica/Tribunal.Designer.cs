namespace Proyecto_escuela_informatica
{
    partial class Tribunal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroTribunal = new System.Windows.Forms.TextBox();
            this.txtLugarExamen = new System.Windows.Forms.TextBox();
            this.txtNumeroComponentes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTribunal = new System.Windows.Forms.DataGridView();
            this.cboTribunal = new System.Windows.Forms.ComboBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarArchivoCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cargarArchivoCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribunal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del tribunal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de tribunal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(556, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar de examen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de componentes:";
            // 
            // txtNumeroTribunal
            // 
            this.txtNumeroTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTribunal.Location = new System.Drawing.Point(271, 93);
            this.txtNumeroTribunal.MaxLength = 5;
            this.txtNumeroTribunal.Name = "txtNumeroTribunal";
            this.txtNumeroTribunal.Size = new System.Drawing.Size(143, 30);
            this.txtNumeroTribunal.TabIndex = 4;
            // 
            // txtLugarExamen
            // 
            this.txtLugarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarExamen.Location = new System.Drawing.Point(766, 93);
            this.txtLugarExamen.MaxLength = 100;
            this.txtLugarExamen.Multiline = true;
            this.txtLugarExamen.Name = "txtLugarExamen";
            this.txtLugarExamen.Size = new System.Drawing.Size(280, 72);
            this.txtLugarExamen.TabIndex = 5;
            // 
            // txtNumeroComponentes
            // 
            this.txtNumeroComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroComponentes.Location = new System.Drawing.Point(333, 202);
            this.txtNumeroComponentes.Name = "txtNumeroComponentes";
            this.txtNumeroComponentes.Size = new System.Drawing.Size(120, 30);
            this.txtNumeroComponentes.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(53, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consulta Tribunal";
            // 
            // dgvTribunal
            // 
            this.dgvTribunal.AllowUserToAddRows = false;
            this.dgvTribunal.AllowUserToDeleteRows = false;
            this.dgvTribunal.AllowUserToResizeColumns = false;
            this.dgvTribunal.AllowUserToResizeRows = false;
            this.dgvTribunal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTribunal.Location = new System.Drawing.Point(82, 518);
            this.dgvTribunal.Name = "dgvTribunal";
            this.dgvTribunal.RowHeadersWidth = 62;
            this.dgvTribunal.RowTemplate.Height = 28;
            this.dgvTribunal.Size = new System.Drawing.Size(754, 205);
            this.dgvTribunal.TabIndex = 16;
            this.dgvTribunal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTribunal_CellClick);
            this.dgvTribunal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cboTribunal
            // 
            this.cboTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTribunal.FormattingEnabled = true;
            this.cboTribunal.Items.AddRange(new object[] {
            "Numero_tribunal",
            "Lugar_examen",
            "Numero_componentes",
            "Estatus"});
            this.cboTribunal.Location = new System.Drawing.Point(149, 462);
            this.cboTribunal.Name = "cboTribunal";
            this.cboTribunal.Size = new System.Drawing.Size(174, 33);
            this.cboTribunal.TabIndex = 17;
            this.cboTribunal.Text = "Consulta Por:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(356, 465);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(224, 30);
            this.txtConsulta.TabIndex = 18;
            this.txtConsulta.Click += new System.EventHandler(this.txtConsulta_Click);
            this.txtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(651, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Estatus:";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(766, 204);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(153, 30);
            this.txtEstatus.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarArchivoCSVToolStripMenuItem,
            this.cargarArchivoCsvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 33);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generarArchivoCSVToolStripMenuItem
            // 
            this.generarArchivoCSVToolStripMenuItem.Name = "generarArchivoCSVToolStripMenuItem";
            this.generarArchivoCSVToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.generarArchivoCSVToolStripMenuItem.Text = "Generar archivo CSV";
            this.generarArchivoCSVToolStripMenuItem.Click += new System.EventHandler(this.generarArchivoCSVToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_escuela_informatica.Properties.Resources.regreso__2_;
            this.btnSalir.Location = new System.Drawing.Point(1008, 712);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 43);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Proyecto_escuela_informatica.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.Location = new System.Drawing.Point(766, 273);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 68);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Image = global::Proyecto_escuela_informatica.Properties.Resources.actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(597, 273);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 68);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = global::Proyecto_escuela_informatica.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnEliminar.Location = new System.Drawing.Point(394, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 68);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::Proyecto_escuela_informatica.Properties.Resources.agregar__1_;
            this.btnAgregar.Location = new System.Drawing.Point(199, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 68);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cargarArchivoCsvToolStripMenuItem
            // 
            this.cargarArchivoCsvToolStripMenuItem.Name = "cargarArchivoCsvToolStripMenuItem";
            this.cargarArchivoCsvToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.cargarArchivoCsvToolStripMenuItem.Text = "Cargar archivo CSV";
            this.cargarArchivoCsvToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoCsvToolStripMenuItem_Click);
            // 
            // Tribunal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1107, 783);
            this.ControlBox = false;
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.cboTribunal);
            this.Controls.Add(this.dgvTribunal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumeroComponentes);
            this.Controls.Add(this.txtLugarExamen);
            this.Controls.Add(this.txtNumeroTribunal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tribunal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tribunal";
            this.Load += new System.EventHandler(this.Tribunal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribunal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroTribunal;
        private System.Windows.Forms.TextBox txtLugarExamen;
        private System.Windows.Forms.NumericUpDown txtNumeroComponentes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTribunal;
        private System.Windows.Forms.ComboBox cboTribunal;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarArchivoCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoCsvToolStripMenuItem;
    }
}