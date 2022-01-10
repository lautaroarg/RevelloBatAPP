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
        negocioBateria batnego = new negocioBateria();
        private DateTime fechain;
        private DateTime fechafin;
       
        


        public frmCompras()
        {
            InitializeComponent();
        }
        public void LimpiarForms()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtTotal.Text = "";
            cboBaterias.Text = "";
            dtpFecha.Text = "";
            dgvCompras.ClearSelection();
            cboBaterias.Focus();
            
        }
        private void frmCompras_Load(object sender, EventArgs e)

        {
            
            MostrarCompras();
            LimpiarForms();
            cboBaterias.DataSource = batnego.TablaActivas();
            cboBaterias.DisplayMember = "Nombre";
            cboBaterias.ValueMember = "IdBateria";
            cboBaterias.Text = "";
            
        }
        public void MostrarCompras()
        {
            
            dgvCompras.DataSource = objNegocio.ListarCompras();
            dgvCompras.Columns[0].Visible = false;
            dgvCompras.Columns[1].Width = 190;
            dgvCompras.Columns[2].Width = 35;
            dgvCompras.Columns[3].Width =70;
            dgvCompras.Columns[4].Width = 90;
            
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    entidad.Bateria1 =Int32.Parse(cboBaterias.SelectedValue.ToString());
                    entidad.CantidadComprado1 =Int32.Parse(txtCantidad.Text);
                    entidad.FechaCompra1 = dtpFecha.Value;

                    objNegocio.AgregarCompra(entidad);
                    MessageBox.Show("Compra cargada con exito");
                    MostrarCompras();
                    LimpiarForms();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fechain = dtpDesde.Value;
            fechafin = dtpHasta.Value;
            
            dgvCompras.DataSource = objNegocio.ListarComprasporFecha(fechain, fechafin);
            dgvCompras.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "") 
            {
                MessageBox.Show("Primero debes seleccionar una compra para eliminarla");
            }
            else
            {
                entidad.Bateria1 =Int32.Parse(txtCodigo.Text);
                objNegocio.EliminarCompra(entidad);
                MessageBox.Show("Compra eliminada con exito");
                MostrarCompras();
                LimpiarForms();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
                cboBaterias.Text= dgvCompras.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text= dgvCompras.CurrentRow.Cells[2].Value.ToString();
                dtpFecha.Text= dgvCompras.CurrentRow.Cells[3].Value.ToString();
                txtTotal.Text= dgvCompras.CurrentRow.Cells[4].Value.ToString();
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarForms();

        }
    }
}
