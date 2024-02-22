using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestion_De_Facturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ConsorcioNegocio consorcioNegocio = new ConsorcioNegocio();
            FacturaNegocio facturaNegocio = new FacturaNegocio();

            cargarMes();
            cboConsorcio.DataSource = consorcioNegocio.listar();
            listarBasico();
            ocultarColumnas();
        }

        private void cboConsorcio_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarBasico();
        }

        private void cargarMes()
        {
            int mesActual, anioActual;
            DateTime fechaActual = DateTime.Now;
            mesActual = fechaActual.Month;
            anioActual = fechaActual.Year;
            txtMes.Text = mesActual.ToString();
            txtAnio.Text = anioActual.ToString();
        }
        private void btnIzq_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMes.Text) > 1)
            {
                txtMes.Text = (int.Parse(txtMes.Text) - 1).ToString();
            }
            else
            {
                txtMes.Text = "12";
                txtAnio.Text = (int.Parse(txtAnio.Text) - 1).ToString();
            }

            listarBasico();
        }
        private void btnDer_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMes.Text) < 12)
            {
                txtMes.Text = (int.Parse(txtMes.Text) + 1).ToString();
            }
            else
            {
                txtMes.Text = "1";
                txtAnio.Text = (int.Parse(txtAnio.Text) + 1).ToString();
            }

            listarBasico();
        }
        private void listarBasico()
        {
            try
            {
                FacturaNegocio facturaNegocio = new FacturaNegocio();

                int mes = int.Parse(txtMes.Text);
                int anio = int.Parse(txtAnio.Text);
                Consorcio aux = (Consorcio)cboConsorcio.SelectedValue;
                dgvFacturas.DataSource = facturaNegocio.listarBasico(mes, anio, aux.Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvFacturas.Columns["Id"].Visible = false;
            dgvFacturas.Columns["Mes"].Visible = false;
            dgvFacturas.Columns["Anio"].Visible = false;
            dgvFacturas.Columns["Consorcio"].Visible = false;
            dgvFacturas.Columns["Activo"].Visible = false;
            dgvFacturas.Columns["Proveedor"].Width = 100;
            dgvFacturas.Columns["Precio"].Width = 100;
            dgvFacturas.Columns["Numero"].Width = 100;
            dgvFacturas.Columns["Descripcion"].Width = 234;
            dgvFacturas.Columns["Aclaracion"].Width = 100;
            dgvFacturas.Columns["Estado"].Width = 100;

        }
    }
}
