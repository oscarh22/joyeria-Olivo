using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joyeria_Olivos
{
    public partial class Form1 : Form
    {
        public object Pas { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.Usuario.Text == "joyeria olivo" && pas.Text == "123")

            {
                menu menu = new menu();
                menu.Show();

                Visible = false;
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
