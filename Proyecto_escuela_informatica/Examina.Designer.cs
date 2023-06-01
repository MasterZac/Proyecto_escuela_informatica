namespace Proyecto_escuela_informatica
{
    partial class Examina
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
            this.consultaDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnNuevo1 = new System.Windows.Forms.Button();
            this.txtNumeroComponentes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLugarExamen = new System.Windows.Forms.TextBox();
            this.txtNumeroTribunal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo2 = new System.Windows.Forms.Button();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.btnSeleccion1 = new System.Windows.Forms.Button();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscarTribunal = new System.Windows.Forms.TextBox();
            this.cboTribunal = new System.Windows.Forms.ComboBox();
            this.btnSelecciona2 = new System.Windows.Forms.Button();
            this.dgvTribunal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvExamina = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComponentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribunal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamina)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDatosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaDatosToolStripMenuItem
            // 
            this.consultaDatosToolStripMenuItem.Name = "consultaDatosToolStripMenuItem";
            this.consultaDatosToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.consultaDatosToolStripMenuItem.Text = "Consulta Datos";
            this.consultaDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaDatosToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnNuevo1);
            this.groupBox.Controls.Add(this.txtNumeroComponentes);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txtLugarExamen);
            this.groupBox.Controls.Add(this.txtNumeroTribunal);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Teal;
            this.groupBox.Location = new System.Drawing.Point(84, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(941, 237);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos Tribunal";
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.Location = new System.Drawing.Point(655, 166);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Size = new System.Drawing.Size(100, 39);
            this.btnNuevo1.TabIndex = 12;
            this.btnNuevo1.Text = "Nuevo";
            this.btnNuevo1.UseVisualStyleBackColor = true;
            this.btnNuevo1.Click += new System.EventHandler(this.btnNuevo1_Click);
            // 
            // txtNumeroComponentes
            // 
            this.txtNumeroComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroComponentes.Location = new System.Drawing.Point(337, 118);
            this.txtNumeroComponentes.Name = "txtNumeroComponentes";
            this.txtNumeroComponentes.Size = new System.Drawing.Size(120, 30);
            this.txtNumeroComponentes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de componentes:";
            // 
            // txtLugarExamen
            // 
            this.txtLugarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarExamen.Location = new System.Drawing.Point(638, 54);
            this.txtLugarExamen.MaxLength = 100;
            this.txtLugarExamen.Multiline = true;
            this.txtLugarExamen.Name = "txtLugarExamen";
            this.txtLugarExamen.Size = new System.Drawing.Size(280, 72);
            this.txtLugarExamen.TabIndex = 9;
            // 
            // txtNumeroTribunal
            // 
            this.txtNumeroTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTribunal.Location = new System.Drawing.Point(263, 54);
            this.txtNumeroTribunal.MaxLength = 5;
            this.txtNumeroTribunal.Name = "txtNumeroTribunal";
            this.txtNumeroTribunal.Size = new System.Drawing.Size(143, 30);
            this.txtNumeroTribunal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lugar de examen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de tribunal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo2);
            this.groupBox1.Controls.Add(this.txtTema);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumeroOrden);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(84, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alumno";
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.Location = new System.Drawing.Point(514, 227);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(100, 39);
            this.btnNuevo2.TabIndex = 40;
            this.btnNuevo2.Text = "Nuevo";
            this.btnNuevo2.UseVisualStyleBackColor = true;
            this.btnNuevo2.Click += new System.EventHandler(this.btnNuevo2_Click);
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(585, 145);
            this.txtTema.MaxLength = 100;
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(252, 58);
            this.txtTema.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(489, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tema:";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Location = new System.Drawing.Point(316, 143);
            this.txtNumeroOrden.MaxLength = 10;
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(141, 30);
            this.txtNumeroOrden.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Numero de Orden de TFC:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(160, 54);
            this.txtMatricula.MaxLength = 10;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(202, 30);
            this.txtMatricula.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(532, 54);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 58);
            this.txtNombre.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Matricula:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(203, 656);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(199, 30);
            this.txtFecha.TabIndex = 39;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(104, 663);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fecha:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Teal;
            this.btnRegistrar.Location = new System.Drawing.Point(722, 624);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 40);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_escuela_informatica.Properties.Resources.regreso__2_;
            this.btnSalir.Location = new System.Drawing.Point(1030, 652);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 43);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 364);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscarAlumno);
            this.tabPage1.Controls.Add(this.cboAlumno);
            this.tabPage1.Controls.Add(this.btnSeleccion1);
            this.tabPage1.Controls.Add(this.dgvAlumno);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAlumno.Location = new System.Drawing.Point(238, 20);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(199, 30);
            this.txtBuscarAlumno.TabIndex = 5;
            this.txtBuscarAlumno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumno_KeyUp);
            // 
            // cboAlumno
            // 
            this.cboAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Items.AddRange(new object[] {
            "Numero_tribunal",
            "Lugar_examen",
            "Numero_componentes"});
            this.cboAlumno.Location = new System.Drawing.Point(48, 16);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(165, 33);
            this.cboAlumno.TabIndex = 4;
            this.cboAlumno.Text = "Consulta Por:";
            // 
            // btnSeleccion1
            // 
            this.btnSeleccion1.Location = new System.Drawing.Point(612, 129);
            this.btnSeleccion1.Name = "btnSeleccion1";
            this.btnSeleccion1.Size = new System.Drawing.Size(102, 52);
            this.btnSeleccion1.TabIndex = 1;
            this.btnSeleccion1.Text = "Seleccionar";
            this.btnSeleccion1.UseVisualStyleBackColor = true;
            this.btnSeleccion1.Click += new System.EventHandler(this.btnSeleccion1_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.AllowUserToResizeColumns = false;
            this.dgvAlumno.AllowUserToResizeRows = false;
            this.dgvAlumno.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.GridColor = System.Drawing.Color.Teal;
            this.dgvAlumno.Location = new System.Drawing.Point(40, 75);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowHeadersWidth = 62;
            this.dgvAlumno.RowTemplate.Height = 28;
            this.dgvAlumno.Size = new System.Drawing.Size(555, 193);
            this.dgvAlumno.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBuscarTribunal);
            this.tabPage3.Controls.Add(this.cboTribunal);
            this.tabPage3.Controls.Add(this.btnSelecciona2);
            this.tabPage3.Controls.Add(this.dgvTribunal);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(818, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tribunal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTribunal
            // 
            this.txtBuscarTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTribunal.Location = new System.Drawing.Point(238, 31);
            this.txtBuscarTribunal.Name = "txtBuscarTribunal";
            this.txtBuscarTribunal.Size = new System.Drawing.Size(199, 30);
            this.txtBuscarTribunal.TabIndex = 9;
            this.txtBuscarTribunal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarTribunal_KeyUp);
            // 
            // cboTribunal
            // 
            this.cboTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTribunal.FormattingEnabled = true;
            this.cboTribunal.Items.AddRange(new object[] {
            "Numero_tribunal",
            "Lugar_examen",
            "Numero_componentes"});
            this.cboTribunal.Location = new System.Drawing.Point(48, 27);
            this.cboTribunal.Name = "cboTribunal";
            this.cboTribunal.Size = new System.Drawing.Size(165, 33);
            this.cboTribunal.TabIndex = 8;
            this.cboTribunal.Text = "Consulta Por:";
            // 
            // btnSelecciona2
            // 
            this.btnSelecciona2.Location = new System.Drawing.Point(681, 147);
            this.btnSelecciona2.Name = "btnSelecciona2";
            this.btnSelecciona2.Size = new System.Drawing.Size(108, 52);
            this.btnSelecciona2.TabIndex = 7;
            this.btnSelecciona2.Text = "Seleccionar";
            this.btnSelecciona2.UseVisualStyleBackColor = true;
            this.btnSelecciona2.Click += new System.EventHandler(this.btnSelecciona2_Click);
            // 
            // dgvTribunal
            // 
            this.dgvTribunal.AllowUserToAddRows = false;
            this.dgvTribunal.AllowUserToDeleteRows = false;
            this.dgvTribunal.AllowUserToResizeColumns = false;
            this.dgvTribunal.AllowUserToResizeRows = false;
            this.dgvTribunal.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvTribunal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTribunal.Location = new System.Drawing.Point(48, 86);
            this.dgvTribunal.Name = "dgvTribunal";
            this.dgvTribunal.RowHeadersWidth = 62;
            this.dgvTribunal.RowTemplate.Height = 28;
            this.dgvTribunal.Size = new System.Drawing.Size(595, 190);
            this.dgvTribunal.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvExamina);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Examina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExamina
            // 
            this.dgvExamina.AllowUserToAddRows = false;
            this.dgvExamina.AllowUserToDeleteRows = false;
            this.dgvExamina.AllowUserToResizeColumns = false;
            this.dgvExamina.AllowUserToResizeRows = false;
            this.dgvExamina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamina.Location = new System.Drawing.Point(3, 3);
            this.dgvExamina.Name = "dgvExamina";
            this.dgvExamina.RowHeadersWidth = 62;
            this.dgvExamina.RowTemplate.Height = 28;
            this.dgvExamina.Size = new System.Drawing.Size(812, 292);
            this.dgvExamina.TabIndex = 6;
            // 
            // Examina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1126, 707);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Examina";
            this.Text = "Examina";
            this.Load += new System.EventHandler(this.Examina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComponentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribunal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaDatosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtLugarExamen;
        private System.Windows.Forms.TextBox txtNumeroTribunal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNumeroComponentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevo2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.Button btnSeleccion1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.TextBox txtBuscarTribunal;
        private System.Windows.Forms.ComboBox cboTribunal;
        private System.Windows.Forms.Button btnSelecciona2;
        private System.Windows.Forms.DataGridView dgvTribunal;
        private System.Windows.Forms.DataGridView dgvExamina;
    }
}