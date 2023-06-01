namespace Proyecto_escuela_informatica
{
    partial class Cargar_archivo
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
            this.dgvCargar = new System.Windows.Forms.DataGridView();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // dgvCargar
            // 
            this.dgvCargar.AllowUserToAddRows = false;
            this.dgvCargar.AllowUserToDeleteRows = false;
            this.dgvCargar.AllowUserToResizeColumns = false;
            this.dgvCargar.AllowUserToResizeRows = false;
            this.dgvCargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargar.Location = new System.Drawing.Point(48, 92);
            this.dgvCargar.Name = "dgvCargar";
            this.dgvCargar.RowHeadersWidth = 62;
            this.dgvCargar.RowTemplate.Height = 28;
            this.dgvCargar.Size = new System.Drawing.Size(725, 290);
            this.dgvCargar.TabIndex = 1;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(83, 26);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(490, 26);
            this.txtRuta.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(590, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 31);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(671, 21);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 31);
            this.BtnCargar.TabIndex = 4;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(246, 400);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(268, 43);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar Datos";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(759, 433);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Cargar_archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 467);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.dgvCargar);
            this.Controls.Add(this.label1);
            this.Name = "Cargar_archivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar_archivo";
            this.Load += new System.EventHandler(this.Cargar_archivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCargar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}