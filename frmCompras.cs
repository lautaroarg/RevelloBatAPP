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
    public partial class frmCompras : Form
    {
        E_COMPRAS entidad = new E_COMPRAS();
        negocioCompra objNegocio = new negocioCompra();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)

        {
            MostrarCompras();
            
        }
        public void MostrarCompras()
        {
            
            dgvCompras.DataSource = objNegocio.ListarCompras();
            dgvCompras.ClearSelection();
            dgvCompras.Columns[0].Visible = false;
            dgvCompras.Columns[1].Width = 190;
            dgvCompras.Columns[2].Width = 35;
            dgvCompras.Columns[3].Width =70;
            dgvCompras.Columns[4].Width = 90;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entidad.Bateria1 = Int32.Parse(cboBaterias.SelectedValue());
            entidad.CantidadComprado1 =Int32.Parse(txtCantidad.Text);
            entidad.FechaCompra1 = dtpFecha.Value;

            objNegocio.AgregarCompra(entidad);
        }
    }
}
