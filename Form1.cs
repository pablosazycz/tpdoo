using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {

                MessageBox.Show("Bienvenido al sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide(); 
                Form2 principal = new Form2();
                principal.Show();               
              
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
    }
}
