namespace Proyecto_escuela_informatica
{
    partial class Alumno
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroGrupo = new System.Windows.Forms.TextBox();
            this.txtCIProfesor = new System.Windows.Forms.TextBox();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscarGrupo = new System.Windows.Forms.TextBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSeleccionar2 = new System.Windows.Forms.Button();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSeleccionar3 = new System.Windows.Forms.Button();
            this.txtBuscarTFC = new System.Windows.Forms.TextBox();
            this.cboTFC = new System.Windows.Forms.ComboBox();
            this.dgvTFC = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del alumno";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(188, 110);
            this.txtMatricula.MaxLength = 10;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(202, 30);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(544, 105);
            this.txtCI.MaxLength = 5;
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(211, 30);
            this.txtCI.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(188, 173);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 58);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNumeroGrupo
            // 
            this.txtNumeroGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroGrupo.Location = new System.Drawing.Point(684, 176);
            this.txtNumeroGrupo.MaxLength = 10;
            this.txtNumeroGrupo.Name = "txtNumeroGrupo";
            this.txtNumeroGrupo.Size = new System.Drawing.Size(211, 30);
            this.txtNumeroGrupo.TabIndex = 4;
            // 
            // txtCIProfesor
            // 
            this.txtCIProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIProfesor.Location = new System.Drawing.Point(252, 267);
            this.txtCIProfesor.MaxLength = 5;
            this.txtCIProfesor.Name = "txtCIProfesor";
            this.txtCIProfesor.Size = new System.Drawing.Size(211, 30);
            this.txtCIProfesor.TabIndex = 5;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Location = new System.Drawing.Point(1136, 173);
            this.txtNumeroOrden.MaxLength = 10;
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(141, 30);
            this.txtNumeroOrden.TabIndex = 6;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(619, 264);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(211, 30);
            this.txtEstatus.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(842, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 68);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(633, 355);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 68);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(410, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 68);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Habilitar y/o Deshabilitar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(209, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 58);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.AllowUserToResizeColumns = false;
            this.dgvAlumno.AllowUserToResizeRows = false;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(103, 636);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowHeadersWidth = 62;
            this.dgvAlumno.RowTemplate.Height = 28;
            this.dgvAlumno.Size = new System.Drawing.Size(1045, 214);
            this.dgvAlumno.TabIndex = 15;
            this.dgvAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_escuela_informatica.Properties.Resources.regreso__2_;
            this.btnSalir.Location = new System.Drawing.Point(1302, 785);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 65);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(324, 568);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(242, 30);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // cboAlumno
            // 
            this.cboAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Items.AddRange(new object[] {
            "Matricula",
            "CI",
            "Nombre",
            "Numero_grupo",
            "CI_profesor",
            "Numero_orden",
            "Estatus"});
            this.cboAlumno.Location = new System.Drawing.Point(132, 568);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(169, 33);
            this.cboAlumno.TabIndex = 17;
            this.cboAlumno.Text = "Consulta Por:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(98, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Consulta Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Matricula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(934, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Numero de Orden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(482, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "CI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(482, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Numero de Grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "CI del Profesor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(509, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Estatus";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.txtNumeroOrden);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNumeroGrupo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvAlumno);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMatricula);
            this.panel1.Controls.Add(this.cboAlumno);
            this.panel1.Controls.Add(this.txtEstatus);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtCIProfesor);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1481, 910);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 377);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnSeleccionar);
            this.tabPage1.Controls.Add(this.txtBuscarGrupo);
            this.tabPage1.Controls.Add(this.cboGrupo);
            this.tabPage1.Controls.Add(this.dgvGrupo);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(661, 227);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(104, 46);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarGrupo
            // 
            this.txtBuscarGrupo.Location = new System.Drawing.Point(257, 62);
            this.txtBuscarGrupo.Name = "txtBuscarGrupo";
            this.txtBuscarGrupo.Size = new System.Drawing.Size(161, 26);
            this.txtBuscarGrupo.TabIndex = 2;
            this.txtBuscarGrupo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarGrupo_KeyUp);
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "Numero_grupo",
            "Nombre",
            "Componentes"});
            this.cboGrupo.Location = new System.Drawing.Point(96, 62);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(130, 28);
            this.cboGrupo.TabIndex = 1;
            this.cboGrupo.Text = "Consultar Por:";
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.AllowUserToResizeColumns = false;
            this.dgvGrupo.AllowUserToResizeRows = false;
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(96, 112);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.RowHeadersWidth = 62;
            this.dgvGrupo.RowTemplate.Height = 28;
            this.dgvGrupo.Size = new System.Drawing.Size(510, 161);
            this.dgvGrupo.TabIndex = 0;
            this.dgvGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnSeleccionar2);
            this.tabPage2.Controls.Add(this.txtBuscarProfesor);
            this.tabPage2.Controls.Add(this.cboProfesor);
            this.tabPage2.Controls.Add(this.dgvProfesor);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(119, 3);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profesor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar2
            // 
            this.btnSeleccionar2.Location = new System.Drawing.Point(656, 232);
            this.btnSeleccionar2.Name = "btnSeleccionar2";
            this.btnSeleccionar2.Size = new System.Drawing.Size(104, 46);
            this.btnSeleccionar2.TabIndex = 4;
            this.btnSeleccionar2.Text = "Seleccionar";
            this.btnSeleccionar2.UseVisualStyleBackColor = true;
            this.btnSeleccionar2.Click += new System.EventHandler(this.btnSeleccionar2_Click);
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(274, 60);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(182, 26);
            this.txtBuscarProfesor.TabIndex = 3;
            this.txtBuscarProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProfesor_KeyUp);
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Items.AddRange(new object[] {
            "CI",
            "Nombre",
            "Domicilio"});
            this.cboProfesor.Location = new System.Drawing.Point(96, 60);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(130, 28);
            this.cboProfesor.TabIndex = 2;
            this.cboProfesor.Text = "Consultar Por:";
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.AllowUserToAddRows = false;
            this.dgvProfesor.AllowUserToDeleteRows = false;
            this.dgvProfesor.AllowUserToResizeColumns = false;
            this.dgvProfesor.AllowUserToResizeRows = false;
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesor.Location = new System.Drawing.Point(96, 120);
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.RowHeadersWidth = 62;
            this.dgvProfesor.RowTemplate.Height = 28;
            this.dgvProfesor.Size = new System.Drawing.Size(510, 161);
            this.dgvProfesor.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.btnSeleccionar3);
            this.tabPage3.Controls.Add(this.txtBuscarTFC);
            this.tabPage3.Controls.Add(this.cboTFC);
            this.tabPage3.Controls.Add(this.dgvTFC);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(119, 3);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TFC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar3
            // 
            this.btnSeleccionar3.Location = new System.Drawing.Point(698, 181);
            this.btnSeleccionar3.Name = "btnSeleccionar3";
            this.btnSeleccionar3.Size = new System.Drawing.Size(104, 46);
            this.btnSeleccionar3.TabIndex = 5;
            this.btnSeleccionar3.Text = "Seleccionar";
            this.btnSeleccionar3.UseVisualStyleBackColor = true;
            this.btnSeleccionar3.Click += new System.EventHandler(this.btnSeleccionar3_Click);
            // 
            // txtBuscarTFC
            // 
            this.txtBuscarTFC.Location = new System.Drawing.Point(243, 48);
            this.txtBuscarTFC.Name = "txtBuscarTFC";
            this.txtBuscarTFC.Size = new System.Drawing.Size(188, 26);
            this.txtBuscarTFC.TabIndex = 3;
            this.txtBuscarTFC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarTFC_KeyUp);
            // 
            // cboTFC
            // 
            this.cboTFC.FormattingEnabled = true;
            this.cboTFC.Items.AddRange(new object[] {
            "Numero_orden",
            "Fecha_comienzo",
            "Tema"});
            this.cboTFC.Location = new System.Drawing.Point(76, 46);
            this.cboTFC.Name = "cboTFC";
            this.cboTFC.Size = new System.Drawing.Size(133, 28);
            this.cboTFC.TabIndex = 2;
            this.cboTFC.Text = "Consultar Por:";
            // 
            // dgvTFC
            // 
            this.dgvTFC.AllowUserToAddRows = false;
            this.dgvTFC.AllowUserToDeleteRows = false;
            this.dgvTFC.AllowUserToResizeColumns = false;
            this.dgvTFC.AllowUserToResizeRows = false;
            this.dgvTFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTFC.Location = new System.Drawing.Point(76, 106);
            this.dgvTFC.Name = "dgvTFC";
            this.dgvTFC.RowHeadersWidth = 62;
            this.dgvTFC.RowTemplate.Height = 28;
            this.dgvTFC.Size = new System.Drawing.Size(564, 161);
            this.dgvTFC.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarGrupoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1481, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarGrupoToolStripMenuItem
            // 
            this.consultarGrupoToolStripMenuItem.Name = "consultarGrupoToolStripMenuItem";
            this.consultarGrupoToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.consultarGrupoToolStripMenuItem.Text = "Consultar Datos";
            this.consultarGrupoToolStripMenuItem.Click += new System.EventHandler(this.consultarGrupoToolStripMenuItem_Click);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1481, 910);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroGrupo;
        private System.Windows.Forms.TextBox txtCIProfesor;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarGrupoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.DataGridView dgvTFC;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.ComboBox cboTFC;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtBuscarGrupo;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.TextBox txtBuscarTFC;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSeleccionar2;
        private System.Windows.Forms.Button btnSeleccionar3;
    }
}