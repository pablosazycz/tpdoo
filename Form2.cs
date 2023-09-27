using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OcultarMenu();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool yaPreguntado = false;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!yaPreguntado)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    yaPreguntado = true; // Marcar como que ya se hizo la pregunta
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }



        private void OcultarMenu()
        {
            panelSubmenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelSubmenu.Visible == true)
                panelSubmenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubmenu);
        }

        private Form FormActivo = null;
        private void abrirPanelHijo(Form formularioHijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelHijoForm.Controls.Add(formularioHijo);
            panelHijoForm.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form4());
        }



    }
}
