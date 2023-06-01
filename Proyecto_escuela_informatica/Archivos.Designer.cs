namespace Proyecto_escuela_informatica
{
    partial class Archivos
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
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnVerArchivo = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtsep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(122, 70);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(382, 32);
            this.txtRuta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(557, 63);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(79, 44);
            this.BtnAbrir.TabIndex = 2;
            this.BtnAbrir.Text = "....";
            this.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(122, 165);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(331, 49);
            this.BtnExportar.TabIndex = 3;
            this.BtnExportar.Text = "Exportar a CSV";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnVerArchivo
            // 
            this.BtnVerArchivo.Location = new System.Drawing.Point(122, 220);
            this.BtnVerArchivo.Name = "BtnVerArchivo";
            this.BtnVerArchivo.Size = new System.Drawing.Size(331, 49);
            this.BtnVerArchivo.TabIndex = 4;
            this.BtnVerArchivo.Text = "Ver Archivo";
            this.BtnVerArchivo.UseVisualStyleBackColor = true;
            this.BtnVerArchivo.Click += new System.EventHandler(this.BtnVerArchivo_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(670, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtsep
            // 
            this.txtsep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsep.Location = new System.Drawing.Point(122, 120);
            this.txtsep.Name = "txtsep";
            this.txtsep.Size = new System.Drawing.Size(18, 30);
            this.txtsep.TabIndex = 6;
            this.txtsep.Text = ",";
            this.txtsep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 339);
            this.ControlBox = false;
            this.Controls.Add(this.txtsep);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnVerArchivo);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuta);
            this.Name = "Archivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.Archivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnVerArchivo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtsep;
    }
}