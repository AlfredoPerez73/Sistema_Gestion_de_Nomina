namespace Sistema_de_liquidacion
{
    partial class FrmGestionUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroRol = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPasswordChar = new RJCodeAdvance.RJControls.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rjTextBox6 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox7 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox8 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox9 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox10 = new RJCodeAdvance.RJControls.RJTextBox();
            this.cboRoles = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnLimpiar = new RJCodeAdvance.RJControls.RJButton();
            this.btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.txtIdUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDocumento = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCorreo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtContraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombreUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new RJCodeAdvance.RJControls.RJButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboFiltroRol);
            this.panel3.Location = new System.Drawing.Point(1210, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 40);
            this.panel3.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.tblRegistro);
            this.panel2.Location = new System.Drawing.Point(98, 532);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1747, 400);
            this.panel2.TabIndex = 30;
            // 
            // tblRegistro
            // 
            this.tblRegistro.AllowUserToAddRows = false;
            this.tblRegistro.AllowUserToDeleteRows = false;
            this.tblRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.btnSEliminar,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.IdUsuario,
            this.Documento,
            this.Usuario,
            this.Contraseña,
            this.IdRol,
            this.Rol,
            this.Correo,
            this.FechaRegistro});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.tblRegistro.Size = new System.Drawing.Size(1747, 400);
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
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Visible = false;
            this.Contraseña.Width = 125;
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
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnPasswordChar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Location = new System.Drawing.Point(99, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 226);
            this.panel1.TabIndex = 29;
            // 
            // btnPasswordChar
            // 
            this.btnPasswordChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasswordChar.BackColor = System.Drawing.Color.White;
            this.btnPasswordChar.BackgroundColor = System.Drawing.Color.White;
            this.btnPasswordChar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPasswordChar.BorderRadius = 15;
            this.btnPasswordChar.BorderSize = 0;
            this.btnPasswordChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordChar.FlatAppearance.BorderSize = 0;
            this.btnPasswordChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordChar.ForeColor = System.Drawing.Color.White;
            this.btnPasswordChar.Image = global::Sistema_de_liquidacion.Properties.Resources.ojo__1_;
            this.btnPasswordChar.Location = new System.Drawing.Point(1084, 38);
            this.btnPasswordChar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPasswordChar.Name = "btnPasswordChar";
            this.btnPasswordChar.Size = new System.Drawing.Size(44, 43);
            this.btnPasswordChar.TabIndex = 29;
            this.btnPasswordChar.TextColor = System.Drawing.Color.White;
            this.btnPasswordChar.UseVisualStyleBackColor = false;
            this.btnPasswordChar.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
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
            this.panel5.Location = new System.Drawing.Point(559, 96);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 52);
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
            this.rjTextBox6.Location = new System.Drawing.Point(0, -132);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.PlaceholderText = "";
            this.rjTextBox6.Size = new System.Drawing.Size(334, 42);
            this.rjTextBox6.TabIndex = 11;
            this.rjTextBox6.Texts = "Usuario";
            this.rjTextBox6.UnderlinedStyle = false;
            this.rjTextBox6.Enter += new System.EventHandler(this.txtNombreUsuario_Enter);
            this.rjTextBox6.Leave += new System.EventHandler(this.txtNombreUsuario_Leave);
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
            this.rjTextBox7.Location = new System.Drawing.Point(0, -68);
            this.rjTextBox7.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.rjTextBox7.PasswordChar = false;
            this.rjTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox7.PlaceholderText = "";
            this.rjTextBox7.Size = new System.Drawing.Size(334, 42);
            this.rjTextBox7.TabIndex = 11;
            this.rjTextBox7.Texts = "Contraseña";
            this.rjTextBox7.UnderlinedStyle = false;
            this.rjTextBox7.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.rjTextBox7.Leave += new System.EventHandler(this.txtContraseña_Leave);
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
            this.rjTextBox8.Location = new System.Drawing.Point(-4, 76);
            this.rjTextBox8.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox8.Multiline = false;
            this.rjTextBox8.Name = "rjTextBox8";
            this.rjTextBox8.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.rjTextBox8.PasswordChar = false;
            this.rjTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox8.PlaceholderText = "";
            this.rjTextBox8.Size = new System.Drawing.Size(334, 42);
            this.rjTextBox8.TabIndex = 12;
            this.rjTextBox8.Texts = "Correo";
            this.rjTextBox8.UnderlinedStyle = false;
            this.rjTextBox8.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.rjTextBox8.Leave += new System.EventHandler(this.txtCorreo_Leave);
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
            this.rjTextBox9.Location = new System.Drawing.Point(0, -190);
            this.rjTextBox9.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox9.Multiline = false;
            this.rjTextBox9.Name = "rjTextBox9";
            this.rjTextBox9.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.rjTextBox9.PasswordChar = false;
            this.rjTextBox9.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox9.PlaceholderText = "";
            this.rjTextBox9.Size = new System.Drawing.Size(334, 42);
            this.rjTextBox9.TabIndex = 10;
            this.rjTextBox9.Texts = "Documento";
            this.rjTextBox9.UnderlinedStyle = false;
            this.rjTextBox9._TextChanged += new System.EventHandler(this.txtDocumento__TextChanged);
            this.rjTextBox9.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.rjTextBox9.Leave += new System.EventHandler(this.txtDocumento_Leave);
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
            this.rjTextBox10.Location = new System.Drawing.Point(0, -245);
            this.rjTextBox10.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox10.Multiline = false;
            this.rjTextBox10.Name = "rjTextBox10";
            this.rjTextBox10.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.rjTextBox10.PasswordChar = false;
            this.rjTextBox10.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox10.PlaceholderText = "";
            this.rjTextBox10.Size = new System.Drawing.Size(334, 42);
            this.rjTextBox10.TabIndex = 10;
            this.rjTextBox10.Texts = "Id de Usuario";
            this.rjTextBox10.UnderlinedStyle = false;
            this.rjTextBox10.Visible = false;
            this.rjTextBox10._TextChanged += new System.EventHandler(this.txtDocumento__TextChanged);
            this.rjTextBox10.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.rjTextBox10.Leave += new System.EventHandler(this.txtDocumento_Leave);
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
            this.cboRoles.Margin = new System.Windows.Forms.Padding(5);
            this.cboRoles.MinimumSize = new System.Drawing.Size(334, 44);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(334, 52);
            this.cboRoles.TabIndex = 17;
            this.cboRoles.Texts = "Rol desempeñado";
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
            this.btnLimpiar.Location = new System.Drawing.Point(1487, 84);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnGuardar.Location = new System.Drawing.Point(1486, 23);
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
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdUsuario.BorderColor = System.Drawing.Color.White;
            this.txtIdUsuario.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdUsuario.BorderRadius = 15;
            this.txtIdUsuario.BorderSize = 2;
            this.txtIdUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIdUsuario.Location = new System.Drawing.Point(1141, 38);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdUsuario.Multiline = false;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtIdUsuario.PasswordChar = false;
            this.txtIdUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdUsuario.PlaceholderText = "";
            this.txtIdUsuario.Size = new System.Drawing.Size(334, 42);
            this.txtIdUsuario.TabIndex = 10;
            this.txtIdUsuario.Texts = "Id de Usuario";
            this.txtIdUsuario.UnderlinedStyle = false;
            this.txtIdUsuario.Visible = false;
            this.txtIdUsuario._TextChanged += new System.EventHandler(this.txtDocumento__TextChanged);
            this.txtIdUsuario.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtIdUsuario.Leave += new System.EventHandler(this.txtDocumento_Leave);
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
            this.txtDocumento.Location = new System.Drawing.Point(47, 38);
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
            this.txtDocumento._TextChanged += new System.EventHandler(this.txtDocumento__TextChanged);
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.BorderColor = System.Drawing.Color.White;
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.White;
            this.txtCorreo.BorderRadius = 15;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCorreo.Location = new System.Drawing.Point(214, 96);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.Size = new System.Drawing.Size(334, 42);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Texts = "Correo";
            this.txtCorreo.UnderlinedStyle = false;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.BorderColor = System.Drawing.Color.White;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.White;
            this.txtContraseña.BorderRadius = 15;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtContraseña.Location = new System.Drawing.Point(739, 38);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(334, 42);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.Texts = "Contraseña";
            this.txtContraseña.UnderlinedStyle = false;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderFocusColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderRadius = 15;
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombreUsuario.Location = new System.Drawing.Point(393, 38);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUsuario.PlaceholderText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(334, 42);
            this.txtNombreUsuario.TabIndex = 11;
            this.txtNombreUsuario.Texts = "Usuario";
            this.txtNombreUsuario.UnderlinedStyle = false;
            this.txtNombreUsuario.Enter += new System.EventHandler(this.txtNombreUsuario_Enter);
            this.txtNombreUsuario.Leave += new System.EventHandler(this.txtNombreUsuario_Leave);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(98, 160);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(269, 32);
            this.label19.TabIndex = 9;
            this.label19.Text = "Detalle del usuarios";
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
            this.btnBuscarEmpleado.Image = global::Sistema_de_liquidacion.Properties.Resources.ojo__1_;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(256, 209);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarEmpleado.TabIndex = 29;
            this.btnBuscarEmpleado.TextColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Location = new System.Drawing.Point(99, 58);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1760, 51);
            this.panel9.TabIndex = 48;
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
            this.txtBuscar.Location = new System.Drawing.Point(492, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(496, 40);
            this.txtBuscar.TabIndex = 28;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gestion de usuario";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Registro de usuarios";
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGestionUsuario";
            this.Text = "Gestion de usuario";
            this.Load += new System.EventHandler(this.FrmGestionUsuario_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroRol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJComboBox cboRoles;
        private System.Windows.Forms.Label label19;
        private RJCodeAdvance.RJControls.RJButton btnLimpiar;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJTextBox txtDocumento;
        private RJCodeAdvance.RJControls.RJTextBox txtCorreo;
        private RJCodeAdvance.RJControls.RJTextBox txtNombreUsuario;
        private RJCodeAdvance.RJControls.RJTextBox txtContraseña;
        private RJCodeAdvance.RJControls.RJTextBox txtIdUsuario;
        private RJCodeAdvance.RJControls.RJButton btnPasswordChar;
        private RJCodeAdvance.RJControls.RJButton btnBuscarEmpleado;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox6;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox7;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox8;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox9;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}