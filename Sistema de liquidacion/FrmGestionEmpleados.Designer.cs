namespace Sistema_de_liquidacion
{
    partial class FrmGestionEmpleados
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
            this.txtDetalle = new RJCodeAdvance.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdProducto = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtcargo = new RJCodeAdvance.RJControls.RJTextBox();
            this.fecha = new RJCodeAdvance.RJControls.RJTextBox();
            this.fecha2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAño = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtLiquidacion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtMes = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDiasTrabajados = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtHorasExtras = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDocumento2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtSalario2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEstado = new RJCodeAdvance.RJControls.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboCargo = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnGuardarLiquidacion = new RJCodeAdvance.RJControls.RJButton();
            this.btnBuscarEmpleado = new RJCodeAdvance.RJControls.RJButton();
            this.txtCodigo = new RJCodeAdvance.RJControls.RJTextBox();
            this.tblRegistroLiquidaciones = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFactura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasTrabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxAlimentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaNavidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devengado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dpFechaInicial = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dpFechaFinal = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.drFechaActual = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new RJCodeAdvance.RJControls.RJButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroLiquidaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDetalle
            // 
            this.txtDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetalle.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDetalle.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtDetalle.BorderRadius = 15;
            this.txtDetalle.BorderSize = 2;
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalle.Location = new System.Drawing.Point(1960, 913);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(6);
            this.txtDetalle.Multiline = false;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtDetalle.PasswordChar = false;
            this.txtDetalle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDetalle.PlaceholderText = "";
            this.txtDetalle.Size = new System.Drawing.Size(319, 40);
            this.txtDetalle.TabIndex = 30;
            this.txtDetalle.Texts = "";
            this.txtDetalle.UnderlinedStyle = false;
            this.txtDetalle.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gestion de liquidacion";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProducto.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtIdProducto.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtIdProducto.BorderRadius = 15;
            this.txtIdProducto.BorderSize = 2;
            this.txtIdProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdProducto.Location = new System.Drawing.Point(1960, 958);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdProducto.Multiline = false;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtIdProducto.PasswordChar = false;
            this.txtIdProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdProducto.PlaceholderText = "";
            this.txtIdProducto.Size = new System.Drawing.Size(319, 40);
            this.txtIdProducto.TabIndex = 34;
            this.txtIdProducto.Texts = "";
            this.txtIdProducto.UnderlinedStyle = false;
            this.txtIdProducto.Visible = false;
            // 
            // txtcargo
            // 
            this.txtcargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcargo.BackColor = System.Drawing.SystemColors.Window;
            this.txtcargo.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtcargo.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtcargo.BorderRadius = 15;
            this.txtcargo.BorderSize = 2;
            this.txtcargo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcargo.Location = new System.Drawing.Point(1960, 1005);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(6);
            this.txtcargo.Multiline = false;
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtcargo.PasswordChar = false;
            this.txtcargo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtcargo.PlaceholderText = "";
            this.txtcargo.Size = new System.Drawing.Size(319, 40);
            this.txtcargo.TabIndex = 33;
            this.txtcargo.Texts = "";
            this.txtcargo.UnderlinedStyle = false;
            this.txtcargo.Visible = false;
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.BackColor = System.Drawing.SystemColors.Window;
            this.fecha.BorderColor = System.Drawing.Color.SteelBlue;
            this.fecha.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.fecha.BorderRadius = 15;
            this.fecha.BorderSize = 2;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fecha.Location = new System.Drawing.Point(1960, 1050);
            this.fecha.Margin = new System.Windows.Forms.Padding(6);
            this.fecha.Multiline = false;
            this.fecha.Name = "fecha";
            this.fecha.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.fecha.PasswordChar = false;
            this.fecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fecha.PlaceholderText = "";
            this.fecha.Size = new System.Drawing.Size(319, 40);
            this.fecha.TabIndex = 32;
            this.fecha.Texts = "";
            this.fecha.UnderlinedStyle = false;
            this.fecha.Visible = false;
            // 
            // fecha2
            // 
            this.fecha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha2.BackColor = System.Drawing.SystemColors.Window;
            this.fecha2.BorderColor = System.Drawing.Color.SteelBlue;
            this.fecha2.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.fecha2.BorderRadius = 15;
            this.fecha2.BorderSize = 2;
            this.fecha2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fecha2.Location = new System.Drawing.Point(1960, 1095);
            this.fecha2.Margin = new System.Windows.Forms.Padding(6);
            this.fecha2.Multiline = false;
            this.fecha2.Name = "fecha2";
            this.fecha2.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.fecha2.PasswordChar = false;
            this.fecha2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fecha2.PlaceholderText = "";
            this.fecha2.Size = new System.Drawing.Size(319, 40);
            this.fecha2.TabIndex = 31;
            this.fecha2.Texts = "";
            this.fecha2.UnderlinedStyle = false;
            this.fecha2.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.txtBuscar.Location = new System.Drawing.Point(383, 5);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(452, 40);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // txtAño
            // 
            this.txtAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAño.BackColor = System.Drawing.SystemColors.Window;
            this.txtAño.BorderColor = System.Drawing.Color.White;
            this.txtAño.BorderFocusColor = System.Drawing.Color.White;
            this.txtAño.BorderRadius = 15;
            this.txtAño.BorderSize = 2;
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAño.Location = new System.Drawing.Point(31, 318);
            this.txtAño.Margin = new System.Windows.Forms.Padding(6);
            this.txtAño.Multiline = false;
            this.txtAño.Name = "txtAño";
            this.txtAño.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtAño.PasswordChar = false;
            this.txtAño.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAño.PlaceholderText = "";
            this.txtAño.Size = new System.Drawing.Size(319, 42);
            this.txtAño.TabIndex = 18;
            this.txtAño.Texts = "Año";
            this.txtAño.UnderlinedStyle = false;
            this.txtAño.Enter += new System.EventHandler(this.txtAño_Enter);
            this.txtAño.Leave += new System.EventHandler(this.txtAño_Leave);
            // 
            // txtLiquidacion
            // 
            this.txtLiquidacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiquidacion.BackColor = System.Drawing.SystemColors.Window;
            this.txtLiquidacion.BorderColor = System.Drawing.Color.White;
            this.txtLiquidacion.BorderFocusColor = System.Drawing.Color.White;
            this.txtLiquidacion.BorderRadius = 15;
            this.txtLiquidacion.BorderSize = 2;
            this.txtLiquidacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquidacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLiquidacion.Location = new System.Drawing.Point(31, 235);
            this.txtLiquidacion.Margin = new System.Windows.Forms.Padding(6);
            this.txtLiquidacion.Multiline = false;
            this.txtLiquidacion.Name = "txtLiquidacion";
            this.txtLiquidacion.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtLiquidacion.PasswordChar = false;
            this.txtLiquidacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLiquidacion.PlaceholderText = "";
            this.txtLiquidacion.Size = new System.Drawing.Size(319, 42);
            this.txtLiquidacion.TabIndex = 17;
            this.txtLiquidacion.Texts = "Codigo de liquidacion";
            this.txtLiquidacion.UnderlinedStyle = false;
            this.txtLiquidacion.Enter += new System.EventHandler(this.txtLiquidacion_Enter);
            this.txtLiquidacion.Leave += new System.EventHandler(this.txtLiquidacion_Leave);
            // 
            // txtMes
            // 
            this.txtMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMes.BackColor = System.Drawing.SystemColors.Window;
            this.txtMes.BorderColor = System.Drawing.Color.White;
            this.txtMes.BorderFocusColor = System.Drawing.Color.White;
            this.txtMes.BorderRadius = 15;
            this.txtMes.BorderSize = 2;
            this.txtMes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMes.Location = new System.Drawing.Point(31, 399);
            this.txtMes.Margin = new System.Windows.Forms.Padding(6);
            this.txtMes.Multiline = false;
            this.txtMes.Name = "txtMes";
            this.txtMes.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtMes.PasswordChar = false;
            this.txtMes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMes.PlaceholderText = "";
            this.txtMes.Size = new System.Drawing.Size(319, 42);
            this.txtMes.TabIndex = 18;
            this.txtMes.Texts = "Mes";
            this.txtMes.UnderlinedStyle = false;
            this.txtMes.Enter += new System.EventHandler(this.txtMes_Enter);
            this.txtMes.Leave += new System.EventHandler(this.txtMes_Leave);
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiasTrabajados.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiasTrabajados.BorderColor = System.Drawing.Color.White;
            this.txtDiasTrabajados.BorderFocusColor = System.Drawing.Color.White;
            this.txtDiasTrabajados.BorderRadius = 15;
            this.txtDiasTrabajados.BorderSize = 2;
            this.txtDiasTrabajados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasTrabajados.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDiasTrabajados.Location = new System.Drawing.Point(31, 486);
            this.txtDiasTrabajados.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiasTrabajados.Multiline = false;
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtDiasTrabajados.PasswordChar = false;
            this.txtDiasTrabajados.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiasTrabajados.PlaceholderText = "";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(319, 42);
            this.txtDiasTrabajados.TabIndex = 18;
            this.txtDiasTrabajados.Texts = "Dias trabajados";
            this.txtDiasTrabajados.UnderlinedStyle = false;
            this.txtDiasTrabajados.Enter += new System.EventHandler(this.txtDiasTrabajados_Enter);
            this.txtDiasTrabajados.Leave += new System.EventHandler(this.txtDiasTrabajados_Leave);
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHorasExtras.BackColor = System.Drawing.SystemColors.Window;
            this.txtHorasExtras.BorderColor = System.Drawing.Color.White;
            this.txtHorasExtras.BorderFocusColor = System.Drawing.Color.White;
            this.txtHorasExtras.BorderRadius = 15;
            this.txtHorasExtras.BorderSize = 2;
            this.txtHorasExtras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtras.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtHorasExtras.Location = new System.Drawing.Point(31, 569);
            this.txtHorasExtras.Margin = new System.Windows.Forms.Padding(6);
            this.txtHorasExtras.Multiline = false;
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtHorasExtras.PasswordChar = false;
            this.txtHorasExtras.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHorasExtras.PlaceholderText = "";
            this.txtHorasExtras.Size = new System.Drawing.Size(319, 42);
            this.txtHorasExtras.TabIndex = 18;
            this.txtHorasExtras.Texts = "Horas extras";
            this.txtHorasExtras.UnderlinedStyle = false;
            this.txtHorasExtras.Enter += new System.EventHandler(this.txtHorasExtras_Enter);
            this.txtHorasExtras.Leave += new System.EventHandler(this.txtHorasExtras_Leave);
            // 
            // txtDocumento2
            // 
            this.txtDocumento2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento2.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumento2.BorderColor = System.Drawing.Color.White;
            this.txtDocumento2.BorderFocusColor = System.Drawing.Color.White;
            this.txtDocumento2.BorderRadius = 15;
            this.txtDocumento2.BorderSize = 2;
            this.txtDocumento2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento2.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDocumento2.Location = new System.Drawing.Point(362, 152);
            this.txtDocumento2.Margin = new System.Windows.Forms.Padding(6);
            this.txtDocumento2.Multiline = false;
            this.txtDocumento2.Name = "txtDocumento2";
            this.txtDocumento2.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtDocumento2.PasswordChar = false;
            this.txtDocumento2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento2.PlaceholderText = "";
            this.txtDocumento2.Size = new System.Drawing.Size(319, 42);
            this.txtDocumento2.TabIndex = 18;
            this.txtDocumento2.Texts = "Documento";
            this.txtDocumento2.UnderlinedStyle = false;
            this.txtDocumento2.Enter += new System.EventHandler(this.txtDocumento2_Enter);
            this.txtDocumento2.Leave += new System.EventHandler(this.txtDocumento2_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.Location = new System.Drawing.Point(362, 235);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(319, 42);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Texts = "Nombre";
            this.txtNombre.UnderlinedStyle = false;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtSalario2
            // 
            this.txtSalario2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario2.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalario2.BorderColor = System.Drawing.Color.White;
            this.txtSalario2.BorderFocusColor = System.Drawing.Color.White;
            this.txtSalario2.BorderRadius = 15;
            this.txtSalario2.BorderSize = 2;
            this.txtSalario2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario2.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSalario2.Location = new System.Drawing.Point(362, 401);
            this.txtSalario2.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalario2.Multiline = false;
            this.txtSalario2.Name = "txtSalario2";
            this.txtSalario2.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtSalario2.PasswordChar = false;
            this.txtSalario2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSalario2.PlaceholderText = "";
            this.txtSalario2.Size = new System.Drawing.Size(319, 42);
            this.txtSalario2.TabIndex = 18;
            this.txtSalario2.Texts = "Salario";
            this.txtSalario2.UnderlinedStyle = false;
            this.txtSalario2.Enter += new System.EventHandler(this.txtSalario2_Enter);
            this.txtSalario2.Leave += new System.EventHandler(this.txtSalario2_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderColor = System.Drawing.Color.White;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.White;
            this.txtEstado.BorderRadius = 15;
            this.txtEstado.BorderSize = 2;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.Location = new System.Drawing.Point(362, 486);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(6);
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(319, 42);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.Texts = "Estado";
            this.txtEstado.UnderlinedStyle = false;
            this.txtEstado.Enter += new System.EventHandler(this.txtEstado_Enter);
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(237, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "Detalle del empleado";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnGuardarLiquidacion);
            this.panel3.Controls.Add(this.btnBuscarEmpleado);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.txtSalario2);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.txtDocumento2);
            this.panel3.Controls.Add(this.txtHorasExtras);
            this.panel3.Controls.Add(this.txtDiasTrabajados);
            this.panel3.Controls.Add(this.txtMes);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.txtLiquidacion);
            this.panel3.Controls.Add(this.txtAño);
            this.panel3.Location = new System.Drawing.Point(1135, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 775);
            this.panel3.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel6.Controls.Add(this.cboCargo);
            this.panel6.Location = new System.Drawing.Point(365, 310);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 50);
            this.panel6.TabIndex = 41;
            // 
            // cboCargo
            // 
            this.cboCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cboCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboCargo.BorderSize = 1;
            this.cboCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboCargo.IconColor = System.Drawing.Color.White;
            this.cboCargo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboCargo.ListTextColor = System.Drawing.Color.White;
            this.cboCargo.Location = new System.Drawing.Point(0, 0);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(5);
            this.cboCargo.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Padding = new System.Windows.Forms.Padding(1);
            this.cboCargo.Size = new System.Drawing.Size(334, 50);
            this.cboCargo.TabIndex = 23;
            this.cboCargo.Texts = "Cargo desempeñado";
            // 
            // btnGuardarLiquidacion
            // 
            this.btnGuardarLiquidacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarLiquidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardarLiquidacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardarLiquidacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarLiquidacion.BorderRadius = 17;
            this.btnGuardarLiquidacion.BorderSize = 0;
            this.btnGuardarLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarLiquidacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarLiquidacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLiquidacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarLiquidacion.Image = global::Sistema_de_liquidacion.Properties.Resources.disk;
            this.btnGuardarLiquidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarLiquidacion.Location = new System.Drawing.Point(33, 624);
            this.btnGuardarLiquidacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarLiquidacion.Name = "btnGuardarLiquidacion";
            this.btnGuardarLiquidacion.Size = new System.Drawing.Size(666, 50);
            this.btnGuardarLiquidacion.TabIndex = 19;
            this.btnGuardarLiquidacion.Text = "Guardar Liqu.";
            this.btnGuardarLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarLiquidacion.TextColor = System.Drawing.Color.White;
            this.btnGuardarLiquidacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarLiquidacion.UseVisualStyleBackColor = false;
            this.btnGuardarLiquidacion.Click += new System.EventHandler(this.btnGuardarLiquidacion_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarEmpleado.BorderRadius = 15;
            this.btnBuscarEmpleado.BorderSize = 0;
            this.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.Image = global::Sistema_de_liquidacion.Properties.Resources.busqueda1;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(685, 152);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(48, 44);
            this.btnBuscarEmpleado.TabIndex = 20;
            this.btnBuscarEmpleado.TextColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.White;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.White;
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCodigo.Location = new System.Drawing.Point(33, 152);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(319, 42);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Texts = "Codigo de detalle de liquidacion";
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // tblRegistroLiquidaciones
            // 
            this.tblRegistroLiquidaciones.AllowUserToAddRows = false;
            this.tblRegistroLiquidaciones.AllowUserToDeleteRows = false;
            this.tblRegistroLiquidaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistroLiquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistroLiquidaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistroLiquidaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroLiquidaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistroLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistroLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar2,
            this.IdDetalle,
            this.IdFactura2,
            this.Codigo,
            this.IdProducto2,
            this.Año2,
            this.Mes2,
            this.Usuario,
            this.Documento2,
            this.Nombre,
            this.Cargo2,
            this.Estado2,
            this.DiasTrabajados,
            this.HorasTrabajadas,
            this.ValHorasExtras,
            this.Salario2,
            this.Salud,
            this.Pension,
            this.AuxT,
            this.Bonificacion,
            this.PrimaServicios,
            this.AuxAlimentacion,
            this.PrimaNavidad,
            this.Devengado,
            this.FechaRegistro3,
            this.IdUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistroLiquidaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistroLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistroLiquidaciones.EnableHeadersVisualStyles = false;
            this.tblRegistroLiquidaciones.GridColor = System.Drawing.Color.White;
            this.tblRegistroLiquidaciones.Location = new System.Drawing.Point(0, 0);
            this.tblRegistroLiquidaciones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tblRegistroLiquidaciones.Name = "tblRegistroLiquidaciones";
            this.tblRegistroLiquidaciones.ReadOnly = true;
            this.tblRegistroLiquidaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroLiquidaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistroLiquidaciones.RowHeadersVisible = false;
            this.tblRegistroLiquidaciones.RowHeadersWidth = 51;
            this.tblRegistroLiquidaciones.RowTemplate.Height = 24;
            this.tblRegistroLiquidaciones.Size = new System.Drawing.Size(982, 435);
            this.tblRegistroLiquidaciones.TabIndex = 27;
            this.tblRegistroLiquidaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistroLiquidaciones_CellPainting_1);
            // 
            // btnSeleccionar2
            // 
            this.btnSeleccionar2.HeaderText = "";
            this.btnSeleccionar2.MinimumWidth = 6;
            this.btnSeleccionar2.Name = "btnSeleccionar2";
            this.btnSeleccionar2.ReadOnly = true;
            this.btnSeleccionar2.Width = 30;
            // 
            // IdDetalle
            // 
            this.IdDetalle.HeaderText = "Id de detalle";
            this.IdDetalle.MinimumWidth = 6;
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            this.IdDetalle.Visible = false;
            this.IdDetalle.Width = 170;
            // 
            // IdFactura2
            // 
            this.IdFactura2.HeaderText = "Id de la factura";
            this.IdFactura2.MinimumWidth = 6;
            this.IdFactura2.Name = "IdFactura2";
            this.IdFactura2.ReadOnly = true;
            this.IdFactura2.Visible = false;
            this.IdFactura2.Width = 170;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // IdProducto2
            // 
            this.IdProducto2.HeaderText = "Id de producto";
            this.IdProducto2.MinimumWidth = 6;
            this.IdProducto2.Name = "IdProducto2";
            this.IdProducto2.ReadOnly = true;
            this.IdProducto2.Visible = false;
            this.IdProducto2.Width = 170;
            // 
            // Año2
            // 
            this.Año2.HeaderText = "Año";
            this.Año2.MinimumWidth = 6;
            this.Año2.Name = "Año2";
            this.Año2.ReadOnly = true;
            this.Año2.Width = 125;
            // 
            // Mes2
            // 
            this.Mes2.HeaderText = "Mes";
            this.Mes2.MinimumWidth = 6;
            this.Mes2.Name = "Mes2";
            this.Mes2.ReadOnly = true;
            this.Mes2.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // Documento2
            // 
            this.Documento2.HeaderText = "Documento";
            this.Documento2.MinimumWidth = 6;
            this.Documento2.Name = "Documento2";
            this.Documento2.ReadOnly = true;
            this.Documento2.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cargo2
            // 
            this.Cargo2.HeaderText = "Cargo";
            this.Cargo2.MinimumWidth = 6;
            this.Cargo2.Name = "Cargo2";
            this.Cargo2.ReadOnly = true;
            this.Cargo2.Width = 125;
            // 
            // Estado2
            // 
            this.Estado2.HeaderText = "Estado";
            this.Estado2.MinimumWidth = 6;
            this.Estado2.Name = "Estado2";
            this.Estado2.ReadOnly = true;
            this.Estado2.Width = 125;
            // 
            // DiasTrabajados
            // 
            this.DiasTrabajados.HeaderText = "Dias trabajados";
            this.DiasTrabajados.MinimumWidth = 6;
            this.DiasTrabajados.Name = "DiasTrabajados";
            this.DiasTrabajados.ReadOnly = true;
            this.DiasTrabajados.Width = 125;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.HeaderText = "Horas Extra";
            this.HorasTrabajadas.MinimumWidth = 6;
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.ReadOnly = true;
            this.HorasTrabajadas.Width = 125;
            // 
            // ValHorasExtras
            // 
            this.ValHorasExtras.HeaderText = "Valor de horas extras";
            this.ValHorasExtras.MinimumWidth = 6;
            this.ValHorasExtras.Name = "ValHorasExtras";
            this.ValHorasExtras.ReadOnly = true;
            this.ValHorasExtras.Width = 250;
            // 
            // Salario2
            // 
            this.Salario2.HeaderText = "Salario";
            this.Salario2.MinimumWidth = 6;
            this.Salario2.Name = "Salario2";
            this.Salario2.ReadOnly = true;
            this.Salario2.Width = 125;
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Salud";
            this.Salud.MinimumWidth = 6;
            this.Salud.Name = "Salud";
            this.Salud.ReadOnly = true;
            this.Salud.Width = 125;
            // 
            // Pension
            // 
            this.Pension.HeaderText = "Pension";
            this.Pension.MinimumWidth = 6;
            this.Pension.Name = "Pension";
            this.Pension.ReadOnly = true;
            this.Pension.Width = 125;
            // 
            // AuxT
            // 
            this.AuxT.HeaderText = "Aux. Transporte";
            this.AuxT.MinimumWidth = 6;
            this.AuxT.Name = "AuxT";
            this.AuxT.ReadOnly = true;
            this.AuxT.Width = 170;
            // 
            // Bonificacion
            // 
            this.Bonificacion.HeaderText = "Bonifiacion de servicios";
            this.Bonificacion.MinimumWidth = 6;
            this.Bonificacion.Name = "Bonificacion";
            this.Bonificacion.ReadOnly = true;
            this.Bonificacion.Width = 125;
            // 
            // PrimaServicios
            // 
            this.PrimaServicios.HeaderText = "Prima de servicios";
            this.PrimaServicios.MinimumWidth = 6;
            this.PrimaServicios.Name = "PrimaServicios";
            this.PrimaServicios.ReadOnly = true;
            this.PrimaServicios.Width = 125;
            // 
            // AuxAlimentacion
            // 
            this.AuxAlimentacion.HeaderText = "Aux. de alimentacion";
            this.AuxAlimentacion.MinimumWidth = 6;
            this.AuxAlimentacion.Name = "AuxAlimentacion";
            this.AuxAlimentacion.ReadOnly = true;
            this.AuxAlimentacion.Width = 125;
            // 
            // PrimaNavidad
            // 
            this.PrimaNavidad.HeaderText = "Prima de navidad";
            this.PrimaNavidad.MinimumWidth = 6;
            this.PrimaNavidad.Name = "PrimaNavidad";
            this.PrimaNavidad.ReadOnly = true;
            this.PrimaNavidad.Width = 125;
            // 
            // Devengado
            // 
            this.Devengado.HeaderText = "Devengado";
            this.Devengado.MinimumWidth = 6;
            this.Devengado.Name = "Devengado";
            this.Devengado.ReadOnly = true;
            this.Devengado.Width = 125;
            // 
            // FechaRegistro3
            // 
            this.FechaRegistro3.HeaderText = "Fecha de registro";
            this.FechaRegistro3.MinimumWidth = 6;
            this.FechaRegistro3.Name = "FechaRegistro3";
            this.FechaRegistro3.ReadOnly = true;
            this.FechaRegistro3.Width = 125;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id de usuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.tblRegistroLiquidaciones);
            this.panel1.Location = new System.Drawing.Point(89, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 435);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboFiltroEstado);
            this.panel2.Location = new System.Drawing.Point(969, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 40);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.BorderSize = 1;
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFiltroEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cboFiltroEstado.IconColor = System.Drawing.Color.White;
            this.cboFiltroEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.ListTextColor = System.Drawing.Color.White;
            this.cboFiltroEstado.Location = new System.Drawing.Point(0, -7);
            this.cboFiltroEstado.Margin = new System.Windows.Forms.Padding(5);
            this.cboFiltroEstado.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cboFiltroEstado.Size = new System.Drawing.Size(334, 50);
            this.cboFiltroEstado.TabIndex = 23;
            this.cboFiltroEstado.Texts = "";
            this.cboFiltroEstado.OnSelectedIndexChanged += new System.EventHandler(this.cboFiltroEstado_OnSelectedIndexChanged_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.dpFechaInicial);
            this.panel4.Location = new System.Drawing.Point(1428, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 40);
            this.panel4.TabIndex = 40;
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpFechaInicial.BorderSize = 0;
            this.dpFechaInicial.CalendarForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaInicial.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaInicial.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpFechaInicial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaInicial.Location = new System.Drawing.Point(0, 0);
            this.dpFechaInicial.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(147, 35);
            this.dpFechaInicial.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.TabIndex = 0;
            this.dpFechaInicial.TextColor = System.Drawing.Color.White;
            this.dpFechaInicial.ValueChanged += new System.EventHandler(this.dpFechaInicial_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel5.Controls.Add(this.dpFechaFinal);
            this.panel5.Location = new System.Drawing.Point(1583, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 40);
            this.panel5.TabIndex = 40;
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpFechaFinal.BorderSize = 0;
            this.dpFechaFinal.CalendarForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaFinal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaFinal.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaFinal.Location = new System.Drawing.Point(0, 0);
            this.dpFechaFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(160, 35);
            this.dpFechaFinal.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.TabIndex = 0;
            this.dpFechaFinal.TextColor = System.Drawing.Color.White;
            this.dpFechaFinal.ValueChanged += new System.EventHandler(this.dpFechaFinal_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.drFechaActual);
            this.panel7.Location = new System.Drawing.Point(821, 83);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 34);
            this.panel7.TabIndex = 40;
            this.panel7.Visible = false;
            // 
            // drFechaActual
            // 
            this.drFechaActual.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.drFechaActual.BorderSize = 0;
            this.drFechaActual.CalendarForeColor = System.Drawing.Color.White;
            this.drFechaActual.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.drFechaActual.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.drFechaActual.CalendarTitleForeColor = System.Drawing.Color.White;
            this.drFechaActual.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.drFechaActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drFechaActual.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.drFechaActual.Location = new System.Drawing.Point(0, 0);
            this.drFechaActual.MinimumSize = new System.Drawing.Size(4, 35);
            this.drFechaActual.Name = "drFechaActual";
            this.drFechaActual.Size = new System.Drawing.Size(147, 35);
            this.drFechaActual.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.drFechaActual.TabIndex = 0;
            this.drFechaActual.TextColor = System.Drawing.Color.White;
            this.drFechaActual.ValueChanged += new System.EventHandler(this.dpFechaInicial_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(829, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "FECHA ACTUAL";
            this.label5.Visible = false;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGenerarPDF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGenerarPDF.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerarPDF.BorderRadius = 17;
            this.btnGenerarPDF.BorderSize = 0;
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.Image = global::Sistema_de_liquidacion.Properties.Resources.archivo_pdf;
            this.btnGenerarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPDF.Location = new System.Drawing.Point(890, 675);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(181, 50);
            this.btnGenerarPDF.TabIndex = 19;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPDF.TextColor = System.Drawing.Color.White;
            this.btnGenerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Location = new System.Drawing.Point(100, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1791, 51);
            this.panel9.TabIndex = 46;
            // 
            // FrmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmGestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de empleados";
            this.Load += new System.EventHandler(this.FrmGestionEmpleados_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroLiquidaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox txtDetalle;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtIdProducto;
        private RJCodeAdvance.RJControls.RJTextBox txtcargo;
        private RJCodeAdvance.RJControls.RJTextBox fecha;
        private RJCodeAdvance.RJControls.RJTextBox fecha2;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private RJCodeAdvance.RJControls.RJTextBox txtAño;
        private RJCodeAdvance.RJControls.RJTextBox txtLiquidacion;
        private RJCodeAdvance.RJControls.RJTextBox txtMes;
        private RJCodeAdvance.RJControls.RJTextBox txtDiasTrabajados;
        private RJCodeAdvance.RJControls.RJTextBox txtHorasExtras;
        private RJCodeAdvance.RJControls.RJTextBox txtDocumento2;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private RJCodeAdvance.RJControls.RJTextBox txtSalario2;
        private RJCodeAdvance.RJControls.RJTextBox txtEstado;
        private RJCodeAdvance.RJControls.RJButton btnBuscarEmpleado;
        private RJCodeAdvance.RJControls.RJButton btnGuardarLiquidacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tblRegistroLiquidaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroEstado;
        private System.Windows.Forms.Panel panel4;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaInicial;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaFinal;
        private System.Windows.Forms.Panel panel6;
        private RJCodeAdvance.RJControls.RJComboBox cboCargo;
        private RJCodeAdvance.RJControls.RJButton btnGenerarPDF;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJDatePicker drFechaActual;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox txtCodigo;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasTrabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValHorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuxAlimentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaNavidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devengado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.Panel panel9;
    }
}

