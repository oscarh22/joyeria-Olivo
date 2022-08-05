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
    public partial class historia_ventas : Form
    {
        public historia_ventas()
        {
            InitializeComponent();
            custiomizeDesing();
        }
        private void custiomizeDesing()
        {



            paneInicio.Visible = false;


        }
        private void hideSubMenu()
        {

            if (paneInicio.Visible == true)
                paneInicio.Visible = false;


        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(paneInicio);
        }
    }
}
