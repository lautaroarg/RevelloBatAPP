using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace RevelloAPP
{
    public partial class frmVentas : Form
    {
        negocioVenta obj = new negocioVenta();
        negocioBateria batnego = new negocioBateria();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
            cboBaterias.DataSource = batnego.TablaActivas();
            cboBaterias.DisplayMember = "Nombre";
            cboBaterias.ValueMember = "IdBateria";
            cboBaterias.Text = "";
            dgvVentas.ClearSelection();
        }
        public void MostrarVentas()
        {

            dgvVentas.DataSource = obj.ListarVentas();
            dgvVentas.Columns[0].Visible = false;
            dgvVentas.Columns[1].Width = 170;
            dgvVentas.Columns[2].Width = 35;
            dgvVentas.Columns[3].Width = 70;
            dgvVentas.Columns[4].Width = 180;
            dgvVentas.Columns[5].Visible = false;
            dgvVentas.Columns[6].Width = 100;
            
        }
    }
}
