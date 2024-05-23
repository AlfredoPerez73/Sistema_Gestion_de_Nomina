namespace Sistema_de_liquidacion
{
    partial class FrmGestionPermiso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroRol = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblRegistroPermiso = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox3 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox4 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox5 = new RJCodeAdvance.RJControls.RJTextBox();
            this.cboHerramienta = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rjTextBox6 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox7 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox8 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox9 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox10 = new RJCodeAdvance.RJControls.RJTextBox();
            this.cboRoles = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            this.btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.txtIdPermiso = new RJCodeAdvance.RJControls.RJTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroPermiso)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gestion de permisos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Registro de permisos";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Location = new System.Drawing.Point(108, 65);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1766, 51);
            this.panel9.TabIndex = 49;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.cboFiltroRol);
            this.panel6.Location = new System.Drawing.Point(909, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 40);
            this.panel6.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboFiltroRol
            // 
            this.cboFiltroRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroRol.BorderSize = 1;
            this.cboFiltroRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFiltroRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFiltroRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroRol.ForeColor = System.Drawing.Color.DimGray;
            this.cboFiltroRol.IconColor = System.Drawing.Color.White;
            this.cboFiltroRol.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroRol.ListTextColor = System.Drawing.Color.White;
            this.cboFiltroRol.Location = new System.Drawing.Point(0, 0);
            this.cboFiltroRol.Margin = new System.Windows.Forms.Padding(5);
            this.cboFiltroRol.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboFiltroRol.Name = "cboFiltroRol";
            this.cboFiltroRol.Padding = new System.Windows.Forms.Padding(1);
            this.cboFiltroRol.Size = new System.Drawing.Size(334, 44);
            this.cboFiltroRol.TabIndex = 23;
            this.cboFiltroRol.Texts = "";
            this.cboFiltroRol.OnSelectedIndexChanged += new System.EventHandler(this.cboFiltroRol_OnSelectedIndexChanged);
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
            this.txtBuscar.Location = new System.Drawing.Point(371, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(487, 40);
            this.txtBuscar.TabIndex = 28;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.tblRegistroPermiso);
            this.panel4.Location = new System.Drawing.Point(108, 524);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1766, 400);
            this.panel4.TabIndex = 31;
            // 
            // tblRegistroPermiso
            // 
            this.tblRegistroPermiso.AllowUserToAddRows = false;
            this.tblRegistroPermiso.AllowUserToDeleteRows = false;
            this.tblRegistroPermiso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistroPermiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistroPermiso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistroPermiso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroPermiso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistroPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistroPermiso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.btnSEliminar,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.IdPermiso,
            this.Permisos,
            this.IdRol,
            this.Rol,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistroPermiso.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistroPermiso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistroPermiso.EnableHeadersVisualStyles = false;
            this.tblRegistroPermiso.GridColor = System.Drawing.Color.White;
            this.tblRegistroPermiso.Location = new System.Drawing.Point(0, 0);
            this.tblRegistroPermiso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tblRegistroPermiso.Name = "tblRegistroPermiso";
            this.tblRegistroPermiso.ReadOnly = true;
            this.tblRegistroPermiso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistroPermiso.RowHeadersVisible = false;
            this.tblRegistroPermiso.RowHeadersWidth = 51;
            this.tblRegistroPermiso.RowTemplate.Height = 24;
            this.tblRegistroPermiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistroPermiso.Size = new System.Drawing.Size(1766, 400);
            this.tblRegistroPermiso.TabIndex = 19;
            this.tblRegistroPermiso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistroPermiso_CellContentClick);
            this.tblRegistroPermiso.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistroPermiso_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // btnSEliminar
            // 
            this.btnSEliminar.HeaderText = "";
            this.btnSEliminar.Name = "btnSEliminar";
            this.btnSEliminar.ReadOnly = true;
            this.btnSEliminar.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // IdPermiso
            // 
            this.IdPermiso.HeaderText = "Id de permiso";
            this.IdPermiso.Name = "IdPermiso";
            this.IdPermiso.ReadOnly = true;
            this.IdPermiso.Visible = false;
            // 
            // Permisos
            // 
            this.Permisos.HeaderText = "Permiso";
            this.Permisos.MinimumWidth = 6;
            this.Permisos.Name = "Permisos";
            this.Permisos.ReadOnly = true;
            this.Permisos.Width = 200;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "Id del rol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 200;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtIdPermiso);
            this.panel2.Location = new System.Drawing.Point(108, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1766, 206);
            this.panel2.TabIndex = 30;
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
            this.btnModificar.Location = new System.Drawing.Point(1326, 45);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(204, 51);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjTextBox1);
            this.panel3.Controls.Add(this.rjTextBox2);
            this.panel3.Controls.Add(this.rjTextBox3);
            this.panel3.Controls.Add(this.rjTextBox4);
            this.panel3.Controls.Add(this.rjTextBox5);
            this.panel3.Controls.Add(this.cboHerramienta);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(398, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 50);
            this.panel3.TabIndex = 28;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox1.Location = new System.Drawing.Point(22, -107);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox1.TabIndex = 11;
            this.rjTextBox1.Texts = "Usuario";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderRadius = 15;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox2.Location = new System.Drawing.Point(22, -55);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox2.TabIndex = 11;
            this.rjTextBox2.Texts = "Contraseña";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.White;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox3.BorderRadius = 15;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox3.Location = new System.Drawing.Point(20, 62);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox3.TabIndex = 12;
            this.rjTextBox3.Texts = "Correo";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.White;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox4.BorderRadius = 15;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox4.Location = new System.Drawing.Point(22, -154);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox4.TabIndex = 10;
            this.rjTextBox4.Texts = "Documento";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.White;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox5.BorderRadius = 15;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox5.Location = new System.Drawing.Point(22, -199);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox5.TabIndex = 10;
            this.rjTextBox5.Texts = "Id de Usuario";
            this.rjTextBox5.UnderlinedStyle = false;
            this.rjTextBox5.Visible = false;
            // 
            // cboHerramienta
            // 
            this.cboHerramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboHerramienta.BorderColor = System.Drawing.Color.Transparent;
            this.cboHerramienta.BorderSize = 0;
            this.cboHerramienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHerramienta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboHerramienta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHerramienta.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboHerramienta.IconColor = System.Drawing.Color.White;
            this.cboHerramienta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboHerramienta.ListTextColor = System.Drawing.Color.Gainsboro;
            this.cboHerramienta.Location = new System.Drawing.Point(0, 0);
            this.cboHerramienta.Margin = new System.Windows.Forms.Padding(4);
            this.cboHerramienta.MinimumSize = new System.Drawing.Size(250, 36);
            this.cboHerramienta.Name = "cboHerramienta";
            this.cboHerramienta.Size = new System.Drawing.Size(271, 50);
            this.cboHerramienta.TabIndex = 17;
            this.cboHerramienta.Texts = "Permisos";
            this.cboHerramienta.OnSelectedIndexChanged += new System.EventHandler(this.cboHerramienta_OnSelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rjTextBox6);
            this.panel5.Controls.Add(this.rjTextBox7);
            this.panel5.Controls.Add(this.rjTextBox8);
            this.panel5.Controls.Add(this.rjTextBox9);
            this.panel5.Controls.Add(this.rjTextBox10);
            this.panel5.Controls.Add(this.cboRoles);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(695, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 50);
            this.panel5.TabIndex = 28;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox6.BorderColor = System.Drawing.Color.White;
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox6.BorderRadius = 15;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox6.Location = new System.Drawing.Point(22, -107);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.PlaceholderText = "";
            this.rjTextBox6.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox6.TabIndex = 11;
            this.rjTextBox6.Texts = "Usuario";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox7
            // 
            this.rjTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox7.BorderColor = System.Drawing.Color.White;
            this.rjTextBox7.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox7.BorderRadius = 15;
            this.rjTextBox7.BorderSize = 2;
            this.rjTextBox7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox7.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox7.Location = new System.Drawing.Point(22, -55);
            this.rjTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox7.PasswordChar = false;
            this.rjTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox7.PlaceholderText = "";
            this.rjTextBox7.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox7.TabIndex = 11;
            this.rjTextBox7.Texts = "Contraseña";
            this.rjTextBox7.UnderlinedStyle = false;
            // 
            // rjTextBox8
            // 
            this.rjTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox8.BorderColor = System.Drawing.Color.White;
            this.rjTextBox8.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox8.BorderRadius = 15;
            this.rjTextBox8.BorderSize = 2;
            this.rjTextBox8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox8.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox8.Location = new System.Drawing.Point(20, 62);
            this.rjTextBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox8.Multiline = false;
            this.rjTextBox8.Name = "rjTextBox8";
            this.rjTextBox8.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox8.PasswordChar = false;
            this.rjTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox8.PlaceholderText = "";
            this.rjTextBox8.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox8.TabIndex = 12;
            this.rjTextBox8.Texts = "Correo";
            this.rjTextBox8.UnderlinedStyle = false;
            // 
            // rjTextBox9
            // 
            this.rjTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox9.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox9.BorderColor = System.Drawing.Color.White;
            this.rjTextBox9.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox9.BorderRadius = 15;
            this.rjTextBox9.BorderSize = 2;
            this.rjTextBox9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox9.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox9.Location = new System.Drawing.Point(22, -154);
            this.rjTextBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox9.Multiline = false;
            this.rjTextBox9.Name = "rjTextBox9";
            this.rjTextBox9.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox9.PasswordChar = false;
            this.rjTextBox9.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox9.PlaceholderText = "";
            this.rjTextBox9.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox9.TabIndex = 10;
            this.rjTextBox9.Texts = "Documento";
            this.rjTextBox9.UnderlinedStyle = false;
            // 
            // rjTextBox10
            // 
            this.rjTextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox10.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox10.BorderColor = System.Drawing.Color.White;
            this.rjTextBox10.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox10.BorderRadius = 15;
            this.rjTextBox10.BorderSize = 2;
            this.rjTextBox10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox10.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox10.Location = new System.Drawing.Point(22, -199);
            this.rjTextBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox10.Multiline = false;
            this.rjTextBox10.Name = "rjTextBox10";
            this.rjTextBox10.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rjTextBox10.PasswordChar = false;
            this.rjTextBox10.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox10.PlaceholderText = "";
            this.rjTextBox10.Size = new System.Drawing.Size(250, 38);
            this.rjTextBox10.TabIndex = 10;
            this.rjTextBox10.Texts = "Id de Usuario";
            this.rjTextBox10.UnderlinedStyle = false;
            this.rjTextBox10.Visible = false;
            // 
            // cboRoles
            // 
            this.cboRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboRoles.BorderColor = System.Drawing.Color.Transparent;
            this.cboRoles.BorderSize = 0;
            this.cboRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboRoles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoles.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboRoles.IconColor = System.Drawing.Color.White;
            this.cboRoles.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboRoles.ListTextColor = System.Drawing.Color.Gainsboro;
            this.cboRoles.Location = new System.Drawing.Point(0, 0);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoles.MinimumSize = new System.Drawing.Size(250, 36);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(271, 50);
            this.cboRoles.TabIndex = 17;
            this.cboRoles.Texts = "Rol desempeñado";
            this.cboRoles.OnSelectedIndexChanged += new System.EventHandler(this.cboRoles_OnSelectedIndexChanged);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1220, 107);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 51);
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
            this.btnGuardar.Location = new System.Drawing.Point(1109, 45);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
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
            // txtIdPermiso
            // 
            this.txtIdPermiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdPermiso.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdPermiso.BorderColor = System.Drawing.Color.White;
            this.txtIdPermiso.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdPermiso.BorderRadius = 15;
            this.txtIdPermiso.BorderSize = 2;
            this.txtIdPermiso.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPermiso.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIdPermiso.Location = new System.Drawing.Point(551, 104);
            this.txtIdPermiso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPermiso.Multiline = false;
            this.txtIdPermiso.Name = "txtIdPermiso";
            this.txtIdPermiso.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtIdPermiso.PasswordChar = false;
            this.txtIdPermiso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdPermiso.PlaceholderText = "";
            this.txtIdPermiso.Size = new System.Drawing.Size(250, 38);
            this.txtIdPermiso.TabIndex = 10;
            this.txtIdPermiso.Texts = "Id de Usuario";
            this.txtIdPermiso.UnderlinedStyle = false;
            this.txtIdPermiso.Visible = false;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(108, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(267, 32);
            this.label19.TabIndex = 9;
            this.label19.Text = "Detalle del permiso";
            // 
            // FrmGestionPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionPermiso";
            this.Text = "Gestion de permisos";
            this.Load += new System.EventHandler(this.FrmGestionPermiso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroPermiso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox6;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox7;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox8;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox9;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox10;
        private RJCodeAdvance.RJControls.RJComboBox cboRoles;
        private System.Windows.Forms.Label label19;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJTextBox txtIdPermiso;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox4;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox5;
        private RJCodeAdvance.RJControls.RJComboBox cboHerramienta;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tblRegistroPermiso;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroRol;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}