namespace Gestion_De_Facturas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMes = new System.Windows.Forms.Label();
            this.lblConsorcio = new System.Windows.Forms.Label();
            this.cboConsorcio = new System.Windows.Forms.ComboBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.lblSep = new System.Windows.Forms.Label();
            this.pnlSeleccion = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAclaracion = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboConsorcioAlta = new System.Windows.Forms.ComboBox();
            this.txtMesAlta = new System.Windows.Forms.TextBox();
            this.txtAnioAlta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFormato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlSeleccion.SuspendLayout();
            this.pnlAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(201, 40);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(38, 19);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes:";
            // 
            // lblConsorcio
            // 
            this.lblConsorcio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsorcio.AutoSize = true;
            this.lblConsorcio.BackColor = System.Drawing.Color.Transparent;
            this.lblConsorcio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsorcio.ForeColor = System.Drawing.Color.White;
            this.lblConsorcio.Location = new System.Drawing.Point(527, 39);
            this.lblConsorcio.Name = "lblConsorcio";
            this.lblConsorcio.Size = new System.Drawing.Size(74, 19);
            this.lblConsorcio.TabIndex = 2;
            this.lblConsorcio.Text = "Consorcio:";
            // 
            // cboConsorcio
            // 
            this.cboConsorcio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboConsorcio.BackColor = System.Drawing.Color.White;
            this.cboConsorcio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsorcio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsorcio.FormattingEnabled = true;
            this.cboConsorcio.Location = new System.Drawing.Point(607, 36);
            this.cboConsorcio.Name = "cboConsorcio";
            this.cboConsorcio.Size = new System.Drawing.Size(199, 27);
            this.cboConsorcio.TabIndex = 2;
            this.cboConsorcio.SelectedIndexChanged += new System.EventHandler(this.cboConsorcio_SelectedIndexChanged);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.White;
            this.dgvFacturas.Location = new System.Drawing.Point(25, 109);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1005, 557);
            this.dgvFacturas.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.pnlFiltro.Controls.Add(this.pbxLogo);
            this.pnlFiltro.Controls.Add(this.txtMes);
            this.pnlFiltro.Controls.Add(this.txtAnio);
            this.pnlFiltro.Controls.Add(this.btnDer);
            this.pnlFiltro.Controls.Add(this.btnIzq);
            this.pnlFiltro.Controls.Add(this.lblSep);
            this.pnlFiltro.Controls.Add(this.lblMes);
            this.pnlFiltro.Controls.Add(this.lblConsorcio);
            this.pnlFiltro.Controls.Add(this.cboConsorcio);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(1402, 94);
            this.pnlFiltro.TabIndex = 5;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(1188, 8);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(80, 80);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 9;
            this.pbxLogo.TabStop = false;
            // 
            // txtMes
            // 
            this.txtMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMes.Enabled = false;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMes.Location = new System.Drawing.Point(272, 39);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(37, 20);
            this.txtMes.TabIndex = 8;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnio
            // 
            this.txtAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnio.Enabled = false;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(338, 39);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(62, 20);
            this.txtAnio.TabIndex = 7;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDer
            // 
            this.btnDer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(406, 38);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(21, 21);
            this.btnDer.TabIndex = 1;
            this.btnDer.Text = ">";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.Location = new System.Drawing.Point(245, 39);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(21, 21);
            this.btnIzq.TabIndex = 0;
            this.btnIzq.Text = "<";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // lblSep
            // 
            this.lblSep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSep.AutoSize = true;
            this.lblSep.BackColor = System.Drawing.Color.Transparent;
            this.lblSep.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep.ForeColor = System.Drawing.Color.White;
            this.lblSep.Location = new System.Drawing.Point(315, 38);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(17, 21);
            this.lblSep.TabIndex = 4;
            this.lblSep.Text = "/";
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.pnlSeleccion.Controls.Add(this.btnEliminar);
            this.pnlSeleccion.Controls.Add(this.pnlAlta);
            this.pnlSeleccion.Controls.Add(this.btnModificar);
            this.pnlSeleccion.Controls.Add(this.btnAgregar);
            this.pnlSeleccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeleccion.Location = new System.Drawing.Point(1057, 94);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.Size = new System.Drawing.Size(345, 595);
            this.pnlSeleccion.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(345, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(0, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(345, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlAlta
            // 
            this.pnlAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.pnlAlta.Controls.Add(this.lblFormato);
            this.pnlAlta.Controls.Add(this.btnCancelar);
            this.pnlAlta.Controls.Add(this.btnAceptar);
            this.pnlAlta.Controls.Add(this.txtAnioAlta);
            this.pnlAlta.Controls.Add(this.txtMesAlta);
            this.pnlAlta.Controls.Add(this.cboConsorcioAlta);
            this.pnlAlta.Controls.Add(this.cboEstado);
            this.pnlAlta.Controls.Add(this.txtAclaracion);
            this.pnlAlta.Controls.Add(this.txtDescripcion);
            this.pnlAlta.Controls.Add(this.txtNumero);
            this.pnlAlta.Controls.Add(this.txtPrecio);
            this.pnlAlta.Controls.Add(this.txtProveedor);
            this.pnlAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlta.Location = new System.Drawing.Point(0, 90);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(345, 437);
            this.pnlAlta.TabIndex = 10;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(56, 28);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(230, 20);
            this.txtProveedor.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(56, 66);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(186, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(56, 117);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtAclaracion
            // 
            this.txtAclaracion.Location = new System.Drawing.Point(56, 154);
            this.txtAclaracion.Name = "txtAclaracion";
            this.txtAclaracion.Size = new System.Drawing.Size(230, 20);
            this.txtAclaracion.TabIndex = 4;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(56, 191);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(230, 21);
            this.cboEstado.TabIndex = 5;
            // 
            // cboConsorcioAlta
            // 
            this.cboConsorcioAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsorcioAlta.FormattingEnabled = true;
            this.cboConsorcioAlta.Location = new System.Drawing.Point(56, 294);
            this.cboConsorcioAlta.Name = "cboConsorcioAlta";
            this.cboConsorcioAlta.Size = new System.Drawing.Size(230, 21);
            this.cboConsorcioAlta.TabIndex = 8;
            // 
            // txtMesAlta
            // 
            this.txtMesAlta.Location = new System.Drawing.Point(56, 259);
            this.txtMesAlta.Name = "txtMesAlta";
            this.txtMesAlta.Size = new System.Drawing.Size(100, 20);
            this.txtMesAlta.TabIndex = 6;
            // 
            // txtAnioAlta
            // 
            this.txtAnioAlta.Location = new System.Drawing.Point(186, 259);
            this.txtAnioAlta.Name = "txtAnioAlta";
            this.txtAnioAlta.Size = new System.Drawing.Size(100, 20);
            this.txtAnioAlta.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(56, 361);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 25);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(186, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 25);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 527);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(345, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(53, 89);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(90, 13);
            this.lblFormato.TabIndex = 11;
            this.lblFormato.Text = "Formato: 0000,00";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1402, 689);
            this.Controls.Add(this.pnlSeleccion);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.dgvFacturas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de facturas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlSeleccion.ResumeLayout(false);
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblConsorcio;
        private System.Windows.Forms.ComboBox cboConsorcio;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Label lblSep;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Panel pnlSeleccion;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAnioAlta;
        private System.Windows.Forms.TextBox txtMesAlta;
        private System.Windows.Forms.ComboBox cboConsorcioAlta;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtAclaracion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFormato;
    }
}

