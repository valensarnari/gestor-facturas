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
        private Factura factura = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ConsorcioNegocio consorcioNegocio = new ConsorcioNegocio();
            FacturaNegocio facturaNegocio = new FacturaNegocio();

            dgvFacturas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            cargarMes();
            cboConsorcio.DataSource = consorcioNegocio.listar();
            listarBasico();
            ocultarColumnas();
            personalizarDiseno();
        }

        private void cboConsorcio_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarBasico();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlAlta);

            txtProveedor.Text = "";
            txtPrecio.Text = "";
            txtNumero.Text = "";
            txtDescripcion.Text = "";
            txtAclaracion.Text = "";

            txtMesAlta.Enabled = false;
            txtAnioAlta.Enabled = false;
            cboConsorcioAlta.Enabled = false;
            
            txtMesAlta.Text = txtMes.Text;
            txtAnioAlta.Text = txtAnio.Text;

            ConsorcioNegocio consorcioNegocio = new ConsorcioNegocio();
            cboConsorcioAlta.DataSource = consorcioNegocio.listar();
            cboConsorcioAlta.SelectedIndex = cboConsorcioAlta.FindStringExact(cboConsorcio.SelectedItem.ToString());
            cboEstado.Items.Add("Transferencia");
            cboEstado.Items.Add("No pagado");
            cboEstado.Items.Add("Pagado en efectivo");
            cboEstado.Items.Add("Pagado por otro");
            cboEstado.SelectedIndex = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlAlta);

            Factura seleccionada;
            seleccionada = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            this.factura = seleccionada;

            txtProveedor.Text = seleccionada.Proveedor;
            txtPrecio.Text = seleccionada.Precio.ToString();
            txtNumero.Text = seleccionada.Numero.ToString();
            txtDescripcion.Text = seleccionada.Descripcion;
            txtAclaracion.Text = seleccionada.Aclaracion;

            txtMesAlta.Enabled = true;
            txtAnioAlta.Enabled = true;
            cboConsorcioAlta.Enabled = true;

            txtMesAlta.Text = txtMes.Text;
            txtAnioAlta.Text = txtAnio.Text;

            ConsorcioNegocio consorcioNegocio = new ConsorcioNegocio();
            cboConsorcioAlta.DataSource = consorcioNegocio.listar();
            cboConsorcioAlta.SelectedIndex = cboConsorcioAlta.FindStringExact(cboConsorcio.SelectedItem.ToString());
            cboEstado.Items.Add("Transferencia");
            cboEstado.Items.Add("No pagado");
            cboEstado.Items.Add("Pagado en efectivo");
            cboEstado.Items.Add("Pagado por otro");
            cboEstado.SelectedIndex = cboEstado.FindStringExact(seleccionada.Estado);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaNegocio facturaNegocio = new FacturaNegocio();

                if(factura == null)
                    factura = new Factura();

                factura.Proveedor = txtProveedor.Text;
                // factura.Precio = Decimal.Parse(txtPrecio.Text);
                if(soloNumeros(txtNumero.Text) == false)
                    factura.Numero = int.Parse(txtNumero.Text);
                factura.Descripcion = txtDescripcion.Text;
                factura.Aclaracion = txtAclaracion.Text;
                factura.Estado = cboEstado.Text;
                factura.Mes = int.Parse(txtMesAlta.Text);
                factura.Anio = int.Parse(txtAnioAlta.Text);
                factura.Consorcio = (Consorcio)cboConsorcioAlta.SelectedItem;

                if (convertirNumero(txtPrecio.Text) == "")
                {
                    MessageBox.Show("Por favor, verifique que todos los campos estén completos.");
                    return;
                }
                else if (convertirNumero(txtPrecio.Text) == null)
                {
                    MessageBox.Show("Por favor, verifique que los campos numéricos tengan el formato correcto.");
                    return;
                }
                else
                {
                    if (estaVacio(txtProveedor.Text, txtDescripcion.Text, txtNumero.Text.ToString(), txtMes.Text.ToString(), txtAnio.Text.ToString()) == false)
                    {
                        MessageBox.Show("Por favor, verifique que todos los campos estén completos.");
                        return;
                    }
                }

                factura.Precio = Decimal.Parse(txtPrecio.Text);

                if (factura.Id != 0)
                {
                    facturaNegocio.modificar(factura);
                    MessageBox.Show("Modificado exitosamente");
                }  
                else
                {
                    facturaNegocio.agregar(factura);
                    MessageBox.Show("Agregado exitosamente");
                }
                
                listarBasico();
                ocultarSubmenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FacturaNegocio negocio = new FacturaNegocio();
            Factura seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    listarBasico();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, seleccione una Factura para eliminar.");
            }
        }

        // -----------------------------------------------------
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
            dgvFacturas.Columns["Descripcion"].Width = 505;
            dgvFacturas.Columns["Aclaracion"].Width = 100;
            dgvFacturas.Columns["Estado"].Width = 100;

        }
        private void personalizarDiseno()
        {
            pnlAlta.Visible = false;
        }
        private void ocultarSubmenu()
        {
            if (pnlAlta.Visible == true)
                pnlAlta.Visible = false;
        }
        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private string convertirNumero(string texto)
        {
            int cont = 0;
            string cadena = null;

            // si la cadena esta vacia devolverla para reiniciar dgv
            if (texto == "")
                return texto;

            // chequear si la cadena tiene algo que no sea un numero o ,
            foreach (char caracter in texto)
            {
                if (!(char.IsNumber(caracter)) && !(caracter == ','))
                    return null;
            }

            // si la cadena no tiene comas, le agrego el ,00
            if (texto.Contains(',') == false)
                texto += ",00";

            // si la cadena tiene una coma, lo reemplaza por un punto para la consulta
            foreach (char caracter in texto)
            {
                if (caracter == ',')
                    cont++;

                if (cont < 1)
                    cadena = texto.Replace(',', '.');
            }

            // verifico si la cadena tiene mas de dos comas
            if (cont > 1)
                return null;

            // verifico si la cadena tiene mas de dos numeros despues del punto
            int flag = 0;
            cont = 0;
            foreach (char caracter in cadena)
            {
                if (flag == 1)
                    cont++;

                if (caracter == '.')
                    flag = 1;

                if (cont > 2)
                    return null;
            }

            return cadena;
        }
        private bool estaVacio(string prov, string desc, string num, string mes, string anio)
        {
            if (prov == "" || desc == "" || num == "" || mes == "" || anio == "")
                return false;
            return true;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

    }
}
