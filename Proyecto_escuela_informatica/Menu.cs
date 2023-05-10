using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela_informatica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = GlobalVariables.Usuario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void BtnGrupo_Click(object sender, EventArgs e)
        {
            Grupo form = new Grupo();
            this.Hide();
            form.Show();
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            Profesor form = new Profesor();
            this.Hide();
            form.Show();
        }
    }
}
