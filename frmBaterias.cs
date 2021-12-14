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
        E_BATERIA objEntidad = new E_BATERIA();
        negocioBateria objNegocio = new negocioBateria();
        private bool editarse;

        public frmBaterias()
        {
            InitializeComponent();
        }

        //Funcion para Mostrar las baterias activas.
        public void MostrarBateriasActivas()
        {
            //Instancio el objeto de negocio bateria
            //al DGV le doy los datos que estan dentro del objeto listandoBaterias
            negocioBateria objNegocio = new negocioBateria();
            //dgvBaterias.DataSource = objNegocio.ListandoBaterias();
            dgvBaterias.DataSource = objNegocio.TablaActivas();
            dgvBaterias.ClearSelection();
        }
        //Funcion para Mostrar todas las baterias.
        public void MostrarTodasBaterias()
        {
            dgvBaterias.DataSource = objNegocio.TablaTodas();
            dgvBaterias.ClearSelection();
        }

        //En el evento LOAD traigo las funciones de Mostrar las baterias activas y
        //La funcion de limpiar forms, tambien modifico el Datagridview.
        private void frmBaterias_Load(object sender, EventArgs e)
        {
            MostrarBateriasActivas();
            LimpiarForms();
            
            dgvBaterias.Columns[0].Visible = false;
            dgvBaterias.Columns[1].Width = 190;
            dgvBaterias.Columns[2].Width = 100;
            dgvBaterias.Columns[3].Width = 100;
            dgvBaterias.Columns[4].Width = 55;
            dgvBaterias.Columns[5].Width = 100;
           

        }
        //Funcion para cerrar el formulario.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Funcion para limpiar los textbox.
        private void LimpiarForms()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtPCompra.Text = "";
            txtPVenta.Text = "";
            txtStock.Text = "";
            cboEstado.Text = "";
            txtMarca.Focus();
            dgvBaterias.ClearSelection();
        }

        //Funcion para guardar la bateria, en el caso que no sea para editar, se instancia el metodo de Agregar bateria.
        //En el caso que sea para editar, se instancia el metodo MODIFICAR bateria.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.Nombre1 = txtMarca.Text.ToUpper();
                    objEntidad.PrecioCompra1 = Int32.Parse(txtPCompra.Text);
                    objEntidad.PrecioVenta1 = Int32.Parse(txtPVenta.Text);
                    objEntidad.Stock1 = Int32.Parse(txtStock.Text);
                    objEntidad.Estado1 = cboEstado.Text.ToUpper();
                    objNegocio.Agregar(objEntidad);

                    MessageBox.Show("Registro guardado");
                    LimpiarForms();
                    MostrarBateriasActivas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
            if (editarse == true)
            {
                objEntidad.IdBateria1 =Int32.Parse(txtCodigo.Text);
                objEntidad.Nombre1 = txtMarca.Text.ToUpper();
                objEntidad.PrecioCompra1 = Int32.Parse(txtPCompra.Text);
                objEntidad.PrecioVenta1 = Int32.Parse(txtPVenta.Text);
                objEntidad.Stock1 = Int32.Parse(txtStock.Text);
                objEntidad.Estado1 = cboEstado.Text.ToUpper();

                objNegocio.Modificar(objEntidad);

                MessageBox.Show("Registro modificado");
                LimpiarForms();
                MostrarBateriasActivas();
                editarse = false;
            }
        }
        //Dependiendo el Check, muestra o Todas, o activas.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                MostrarTodasBaterias();
            }
            else
            {
                MostrarBateriasActivas();
            }
        }
        //El evento Agregar, usa la funcion de limpiar forms, y modifica el valor de editarse a false.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarForms();
            editarse = false;
        }
        
        //El evento editar click, si selecciona una fila, trae sus valores a los textboxs, y cambia el valor de editarse a true.|
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBaterias.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvBaterias.CurrentRow.Cells[0].Value.ToString();
                txtMarca.Text = dgvBaterias.CurrentRow.Cells[1].Value.ToString();
                txtPCompra.Text = dgvBaterias.CurrentRow.Cells[2].Value.ToString();
                txtPVenta.Text = dgvBaterias.CurrentRow.Cells[3].Value.ToString();
                txtStock.Text = dgvBaterias.CurrentRow.Cells[4].Value.ToString();
               cboEstado.Text = dgvBaterias.CurrentRow.Cells[5].Value.ToString();
                editarse = true;

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para editarla");
            }
        }

        //Instancia el metodo Inactivar, limpiarforms y mostrar bateriasactivas
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (editarse == true)
            {
            objEntidad.IdBateria1 =Int32.Parse(txtCodigo.Text);
            objNegocio.Inactivar(objEntidad);
            MessageBox.Show("Bateria inactivada");
            LimpiarForms();
            MostrarBateriasActivas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila y hacer click en editarse, antes de eliminarla");
            }
        }
    }

}
