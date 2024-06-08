namespace Sistema_de_liquidacion
{
    partial class FrmMantenedorEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cboContrato = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dpFechaFinal = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dpFechaInicial = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboCargos = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboEstado = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            this.btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.txtDocumento = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtSalario = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombreProducto = new RJCodeAdvance.RJControls.RJTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIdContrato = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtIdCargo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtIdProducto = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.BorderSize = 1;
            this.cboFiltroEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFiltroEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cboFiltroEstado.IconColor = System.Drawing.Color.White;
            this.cboFiltroEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroEstado.ListTextColor = System.Drawing.Color.White;
            this.cboFiltroEstado.Location = new System.Drawing.Point(0, 0);
            this.cboFiltroEstado.Margin = new System.Windows.Forms.Padding(5);
            this.cboFiltroEstado.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cboFiltroEstado.Size = new System.Drawing.Size(334, 44);
            this.cboFiltroEstado.TabIndex = 23;
            this.cboFiltroEstado.Texts = "";
            this.cboFiltroEstado.OnSelectedIndexChanged += new System.EventHandler(this.cboFiltroEstado_OnSelectedIndexChanged);
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
            this.txtBuscar.Location = new System.Drawing.Point(439, 5);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(561, 40);
            this.txtBuscar.TabIndex = 22;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // tblRegistro
            // 
            this.tblRegistro.AllowUserToAddRows = false;
            this.tblRegistro.AllowUserToDeleteRows = false;
            this.tblRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdProducto,
            this.Column2,
            this.Column3,
            this.Documento,
            this.NombreProducto,
            this.IdContrato,
            this.IdCargo,
            this.Cargo,
            this.FechaInicio,
            this.FechaFin,
            this.TipoContrato,
            this.Salario,
            this.Estado,
            this.FechaRegistro2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.GridColor = System.Drawing.Color.White;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            this.tblRegistro.RowHeadersWidth = 51;
            this.tblRegistro.RowTemplate.Height = 24;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(1776, 283);
            this.tblRegistro.TabIndex = 19;
            this.tblRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistro_CellContentClick);
            this.tblRegistro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistro_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id del producto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 250;
            // 
            // IdContrato
            // 
            this.IdContrato.HeaderText = "Id de contrato";
            this.IdContrato.MinimumWidth = 6;
            this.IdContrato.Name = "IdContrato";
            this.IdContrato.ReadOnly = true;
            this.IdContrato.Visible = false;
            this.IdContrato.Width = 125;
            // 
            // IdCargo
            // 
            this.IdCargo.HeaderText = "Id del cargo";
            this.IdCargo.MinimumWidth = 6;
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.ReadOnly = true;
            this.IdCargo.Visible = false;
            this.IdCargo.Width = 160;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de incio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de vencimiento";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 125;
            // 
            // TipoContrato
            // 
            this.TipoContrato.HeaderText = "Contrato";
            this.TipoContrato.MinimumWidth = 6;
            this.TipoContrato.Name = "TipoContrato";
            this.TipoContrato.ReadOnly = true;
            this.TipoContrato.Width = 125;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // FechaRegistro2
            // 
            this.FechaRegistro2.HeaderText = "Fecha de registro";
            this.FechaRegistro2.MinimumWidth = 6;
            this.FechaRegistro2.Name = "FechaRegistro2";
            this.FechaRegistro2.ReadOnly = true;
            this.FechaRegistro2.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Location = new System.Drawing.Point(96, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1776, 263);
            this.panel1.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboContrato);
            this.panel8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(1104, 80);
            this.panel8.Margin = new System.Windows.Forms.Padding(5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 51);
            this.panel8.TabIndex = 28;
            // 
            // cboContrato
            // 
            this.cboContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboContrato.BorderColor = System.Drawing.Color.Transparent;
            this.cboContrato.BorderSize = 0;
            this.cboContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboContrato.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboContrato.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboContrato.IconColor = System.Drawing.Color.White;
            this.cboContrato.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboContrato.ListTextColor = System.Drawing.Color.Gainsboro;
            this.cboContrato.Location = new System.Drawing.Point(0, 0);
            this.cboContrato.Margin = new System.Windows.Forms.Padding(5);
            this.cboContrato.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboContrato.Name = "cboContrato";
            this.cboContrato.Size = new System.Drawing.Size(334, 51);
            this.cboContrato.TabIndex = 13;
            this.cboContrato.Texts = "Contrato";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 17;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::Sistema_de_liquidacion.Properties.Resources.cuadrado_de_la_pluma;
            this.btnModificar.Location = new System.Drawing.Point(1538, 96);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(203, 51);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(978, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "FECHA INICIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1254, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "FECHA FINAL";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel6.Controls.Add(this.dpFechaFinal);
            this.panel6.Location = new System.Drawing.Point(1243, 163);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 35);
            this.panel6.TabIndex = 45;
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
            this.dpFechaFinal.Size = new System.Drawing.Size(239, 35);
            this.dpFechaFinal.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.TabIndex = 0;
            this.dpFechaFinal.TextColor = System.Drawing.Color.White;
            this.dpFechaFinal.Value = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.dpFechaInicial);
            this.panel7.Location = new System.Drawing.Point(961, 164);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 34);
            this.panel7.TabIndex = 46;
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
            this.dpFechaInicial.Size = new System.Drawing.Size(242, 35);
            this.dpFechaInicial.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.TabIndex = 0;
            this.dpFechaInicial.TextColor = System.Drawing.Color.White;
            this.dpFechaInicial.Value = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboCargos);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(269, 136);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 50);
            this.panel5.TabIndex = 28;
            // 
            // cboCargos
            // 
            this.cboCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboCargos.BorderColor = System.Drawing.Color.Transparent;
            this.cboCargos.BorderSize = 0;
            this.cboCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCargos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargos.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboCargos.IconColor = System.Drawing.Color.White;
            this.cboCargos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboCargos.ListTextColor = System.Drawing.Color.Gainsboro;
            this.cboCargos.Location = new System.Drawing.Point(0, 0);
            this.cboCargos.Margin = new System.Windows.Forms.Padding(5);
            this.cboCargos.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboCargos.Name = "cboCargos";
            this.cboCargos.Size = new System.Drawing.Size(334, 50);
            this.cboCargos.TabIndex = 17;
            this.cboCargos.Texts = "Cargo desempeñado";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboEstado);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(613, 137);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 51);
            this.panel4.TabIndex = 27;
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboEstado.BorderColor = System.Drawing.Color.Transparent;
            this.cboEstado.BorderSize = 0;
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboEstado.IconColor = System.Drawing.Color.White;
            this.cboEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboEstado.ListTextColor = System.Drawing.Color.Gainsboro;
            this.cboEstado.Location = new System.Drawing.Point(0, 0);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(5);
            this.cboEstado.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(334, 51);
            this.cboEstado.TabIndex = 13;
            this.cboEstado.Texts = "Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 17;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Sistema_de_liquidacion.Properties.Resources.escoba;
            this.btnLimpiar.Location = new System.Drawing.Point(1535, 154);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(206, 51);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 17;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sistema_de_liquidacion.Properties.Resources.disk;
            this.btnGuardar.Location = new System.Drawing.Point(1537, 40);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 51);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumento.BorderColor = System.Drawing.Color.White;
            this.txtDocumento.BorderFocusColor = System.Drawing.Color.White;
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.BorderSize = 2;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDocumento.Location = new System.Drawing.Point(750, 83);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(6);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(334, 42);
            this.txtDocumento.TabIndex = 10;
            this.txtDocumento.Texts = "Documento";
            this.txtDocumento.UnderlinedStyle = false;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalario.BorderColor = System.Drawing.Color.White;
            this.txtSalario.BorderFocusColor = System.Drawing.Color.White;
            this.txtSalario.BorderRadius = 15;
            this.txtSalario.BorderSize = 2;
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSalario.Location = new System.Drawing.Point(404, 83);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalario.Multiline = false;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtSalario.PasswordChar = false;
            this.txtSalario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSalario.PlaceholderText = "";
            this.txtSalario.Size = new System.Drawing.Size(334, 42);
            this.txtSalario.TabIndex = 12;
            this.txtSalario.Texts = "Salario";
            this.txtSalario.UnderlinedStyle = false;
            this.txtSalario.Enter += new System.EventHandler(this.txtSalario_Enter);
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            this.txtSalario.Leave += new System.EventHandler(this.txtSalario_Leave);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProducto.BorderColor = System.Drawing.Color.White;
            this.txtNombreProducto.BorderFocusColor = System.Drawing.Color.White;
            this.txtNombreProducto.BorderRadius = 15;
            this.txtNombreProducto.BorderSize = 2;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombreProducto.Location = new System.Drawing.Point(58, 83);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtNombreProducto.PasswordChar = false;
            this.txtNombreProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(334, 42);
            this.txtNombreProducto.TabIndex = 11;
            this.txtNombreProducto.Texts = "Nombre";
            this.txtNombreProducto.UnderlinedStyle = false;
            this.txtNombreProducto.Enter += new System.EventHandler(this.txtNombreProducto_Enter);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            this.txtNombreProducto.Leave += new System.EventHandler(this.txtNombreProducto_Leave);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(103, 135);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(299, 32);
            this.label19.TabIndex = 9;
            this.label19.Text = "Detalle del empleado";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdContrato.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdContrato.BorderColor = System.Drawing.Color.White;
            this.txtIdContrato.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdContrato.BorderRadius = 15;
            this.txtIdContrato.BorderSize = 2;
            this.txtIdContrato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdContrato.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIdContrato.Location = new System.Drawing.Point(533, 944);
            this.txtIdContrato.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdContrato.Multiline = false;
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtIdContrato.PasswordChar = false;
            this.txtIdContrato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdContrato.PlaceholderText = "";
            this.txtIdContrato.Size = new System.Drawing.Size(334, 42);
            this.txtIdContrato.TabIndex = 10;
            this.txtIdContrato.Texts = "";
            this.txtIdContrato.UnderlinedStyle = false;
            this.txtIdContrato.Visible = false;
            this.txtIdContrato.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtIdContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtIdContrato.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCargo.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdCargo.BorderColor = System.Drawing.Color.White;
            this.txtIdCargo.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdCargo.BorderRadius = 15;
            this.txtIdCargo.BorderSize = 2;
            this.txtIdCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIdCargo.Location = new System.Drawing.Point(878, 998);
            this.txtIdCargo.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdCargo.Multiline = false;
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtIdCargo.PasswordChar = false;
            this.txtIdCargo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdCargo.PlaceholderText = "";
            this.txtIdCargo.Size = new System.Drawing.Size(334, 42);
            this.txtIdCargo.TabIndex = 10;
            this.txtIdCargo.Texts = "";
            this.txtIdCargo.UnderlinedStyle = false;
            this.txtIdCargo.Visible = false;
            this.txtIdCargo.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtIdCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtIdCargo.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProducto.BorderColor = System.Drawing.Color.White;
            this.txtIdProducto.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdProducto.BorderRadius = 15;
            this.txtIdProducto.BorderSize = 2;
            this.txtIdProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIdProducto.Location = new System.Drawing.Point(532, 998);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdProducto.Multiline = false;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtIdProducto.PasswordChar = false;
            this.txtIdProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdProducto.PlaceholderText = "";
            this.txtIdProducto.Size = new System.Drawing.Size(334, 42);
            this.txtIdProducto.TabIndex = 10;
            this.txtIdProducto.Texts = "";
            this.txtIdProducto.UnderlinedStyle = false;
            this.txtIdProducto.Visible = false;
            this.txtIdProducto.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtIdProducto.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.lbltbl);
            this.panel2.Controls.Add(this.tblRegistro);
            this.panel2.Location = new System.Drawing.Point(109, 585);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1776, 283);
            this.panel2.TabIndex = 25;
            // 
            // lbltbl
            // 
            this.lbltbl.AutoSize = true;
            this.lbltbl.ForeColor = System.Drawing.Color.White;
            this.lbltbl.Location = new System.Drawing.Point(836, 127);
            this.lbltbl.Name = "lbltbl";
            this.lbltbl.Size = new System.Drawing.Size(216, 17);
            this.lbltbl.TabIndex = 50;
            this.lbltbl.Text = "No hay registro de empleados.";
            this.lbltbl.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboFiltroEstado);
            this.panel3.Location = new System.Drawing.Point(1299, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 40);
            this.panel3.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Location = new System.Drawing.Point(109, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1776, 51);
            this.panel9.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(119, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gestion de empleado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Registro de empleados";
            // 
            // FrmMantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.txtIdCargo);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMantenedorEmpleado";
            this.Text = " Gestion de empleado";
            this.Load += new System.EventHandler(this.FrmMantenedorEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroEstado;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private RJCodeAdvance.RJControls.RJComboBox cboCargos;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJComboBox cboEstado;
        private RJCodeAdvance.RJControls.RJTextBox txtDocumento;
        private RJCodeAdvance.RJControls.RJTextBox txtSalario;
        private RJCodeAdvance.RJControls.RJTextBox txtNombreProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaFinal;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaInicial;
        private RJCodeAdvance.RJControls.RJTextBox txtIdProducto;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private RJCodeAdvance.RJControls.RJTextBox txtIdContrato;
        private RJCodeAdvance.RJControls.RJTextBox txtIdCargo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private RJCodeAdvance.RJControls.RJComboBox cboContrato;
        private System.Windows.Forms.Label lbltbl;
    }
}