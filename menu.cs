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
    public partial class menu : Form


    {

        decimal total = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                datos_de_ventas datos_De_Ventas = new datos_de_ventas();
                datos_De_Ventas.Show();
                     Visible = false;

                // datos_de_ventas datosVenta = new datos_de_ventas //(total, textBox1.Text);
                //datosVenta.Show();
                //dataGridView2.Rows.Clear();
            }
            else
                MessageBox.Show("La venta esta vacia");


        } public menu()
        {
            InitializeComponent();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            historia_ventas historia_Ventas = new historia_ventas();
            historia_Ventas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Corte corte = new Corte();
            corte.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Re_ticket re_Ticket = new Re_ticket();
            re_Ticket.Show();
        }
    }
}
