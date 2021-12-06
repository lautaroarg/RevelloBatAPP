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
    public partial class frmBaterias : Form
    {
        entidadBateria objEntidad = new entidadBateria();
        negocioBateria objNegocio = new negocioBateria();

        public frmBaterias()
        {
            InitializeComponent();
        }

        public void MostrarTabla(string buscar)
        {
            //Instancio el objeto de negocio bateria
            //al DGV le doy los datos que estan dentro del objeto listandoBaterias
            negocioBateria objNegocio = new negocioBateria();
            dgvBaterias.DataSource = objNegocio.ListandoBaterias(buscar);
        }

        private void frmBaterias_Load(object sender, EventArgs e)
        {
            MostrarTabla("");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEntidad.MarcaBateria = txtNombre.Text.ToUpper();
            objEntidad.PrecioCompra = Double.Parse(txtPCompra.Text);
            objEntidad.PrecioVenta = Double.Parse(txtPVenta.Text);

            objNegocio.AgregandoBateria(objEntidad);
        }
    }
}
