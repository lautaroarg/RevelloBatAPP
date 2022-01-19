using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevelloAPP
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBaterias_Click(object sender, EventArgs e)
        {
            frmBaterias ofrm = new frmBaterias();
            ofrm.Show();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras ofrm = new frmCompras();
            ofrm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ofrm = new frmVentas();
            ofrm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes ofrm = new frmReportes();
            ofrm.Show();
        }
    }
}
