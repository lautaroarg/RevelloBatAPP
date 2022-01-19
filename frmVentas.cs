using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Net.Mail;
using System.Net;

namespace RevelloAPP
{
    public partial class frmVentas : Form
    {
        negocioVenta obj = new negocioVenta();
        negocioBateria batnego = new negocioBateria();
        E_VENTA entidad = new E_VENTA();
        private DateTime fechain;
        private DateTime fechafin;
        private Boolean editarse;
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
            editarse = false;
            MostrarVentas();
            cboBaterias.DataSource = batnego.TablaActivas();
            cboBaterias.DisplayMember = "Nombre";
            cboBaterias.ValueMember = "IdBateria";
            cboBaterias.Text = "";
            dgvVentas.ClearSelection();
        }
        public void LimpiarForms()
        {
            txtCantidad.Text = "";
            cboBaterias.Text = "";
            txtCodigo.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTotal.Text = "";
            editarse = false;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fechafin = dtpHasta.Value;
            fechain = dtpDesde.Value;
            dgvVentas.DataSource =obj.ListarVentasFecha(fechain,fechafin);
            dgvVentas.ClearSelection();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            editarse = false;
            LimpiarForms();
        }
        
        private bool TextosVacios()
        {
            if (txtEmail.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || cboBaterias.Text == "")
            {
                return true;
            }
            {
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TextosVacios())
            {
                MessageBox.Show("Debes llenar los datos correspondientes");

            }
            else
            {
                try
                {
                    entidad.IdBateria = Int32.Parse(cboBaterias.SelectedValue.ToString());
                    entidad.Cantidad = Int32.Parse(txtCantidad.Text);
                    entidad.NombreCliente1 = txtNombre.Text;
                    entidad.EmailCliente1 = txtEmail.Text;
                    entidad.FechaVenta1 = dtpFecha.Value;
                    obj.AgregarVenta(entidad);
                    MessageBox.Show("Venta realizada con exito");
                    MostrarVentas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TextosVacios() == true)
            {
                MessageBox.Show("Primero debes seleccionar una venta para eliminarla");
            }
            else
            {
                entidad.IdVenta = Int32.Parse(txtCodigo.Text);
                obj.EliminarVenta(entidad);
                MessageBox.Show("Venta eliminada con exito");
                MostrarVentas();
                LimpiarForms();

            }
        }
        private void mandarMail()
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(txtEmail.Text);
            msg.Subject = "Comprobante de compra en Baterias Revello";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Haz realizado la compra de " + txtCantidad.Text + " " + cboBaterias.Text + "en Baterias Revello. Utiliza este email como un comprobante por cualquier motivo y/o consulta. Muchas gracias por confiar en nosotros :)";
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false;
            msg.From = new MailAddress("bateriasrevello@gmail.com");

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("bateriasrevello@gmail.com", "revello2020");
            cliente.Port = 587; cliente.EnableSsl = true; cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (TextosVacios() == true)
            {
                MessageBox.Show("Debes seleccionar los datos de la venta");
                
            }
            else
            {
                if (editarse == true)
                {
                    mandarMail();
                    MessageBox.Show("Comprobante enviado correctamente al cliente");
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos... ");
                }
                
            }
            
                

            
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                cboBaterias.Text = dgvVentas.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dgvVentas.CurrentRow.Cells[2].Value.ToString();
                txtTotal.Text = dgvVentas.CurrentRow.Cells[3].Value.ToString();
                txtNombre.Text = dgvVentas.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvVentas.CurrentRow.Cells[5].Value.ToString();
                dtpFecha.Text = dgvVentas.CurrentRow.Cells[6].Value.ToString();
                editarse = true;
            }
        }
    }
}
