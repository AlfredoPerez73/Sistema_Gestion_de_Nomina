﻿namespace Sistema_de_liquidacion
{
    partial class FrmReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.drFechaActual = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltbl = new System.Windows.Forms.Label();
            this.tblRegistroReporte = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reporte2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerArchivo = new RJCodeAdvance.RJControls.RJButton();
            this.txtIdReporte = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtReporte = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnGuardarReporte = new RJCodeAdvance.RJControls.RJButton();
            this.txtFechaRegistro = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtExtension = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDocumento = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dpFechaInicial = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dpFechaFinal = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroReporte)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gestion de reportes";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.drFechaActual);
            this.panel7.Location = new System.Drawing.Point(881, 186);
            this.panel7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 42);
            this.panel7.TabIndex = 49;
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
            this.drFechaActual.Margin = new System.Windows.Forms.Padding(4);
            this.drFechaActual.MinimumSize = new System.Drawing.Size(4, 35);
            this.drFechaActual.Name = "drFechaActual";
            this.drFechaActual.Size = new System.Drawing.Size(196, 35);
            this.drFechaActual.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.drFechaActual.TabIndex = 0;
            this.drFechaActual.TextColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.lbltbl);
            this.panel3.Controls.Add(this.tblRegistroReporte);
            this.panel3.Location = new System.Drawing.Point(173, 673);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2350, 306);
            this.panel3.TabIndex = 47;
            // 
            // lbltbl
            // 
            this.lbltbl.AutoSize = true;
            this.lbltbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltbl.ForeColor = System.Drawing.Color.White;
            this.lbltbl.Location = new System.Drawing.Point(755, 129);
            this.lbltbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltbl.Name = "lbltbl";
            this.lbltbl.Size = new System.Drawing.Size(236, 19);
            this.lbltbl.TabIndex = 58;
            this.lbltbl.Text = "No hay registro de reportes.";
            this.lbltbl.Visible = false;
            // 
            // tblRegistroReporte
            // 
            this.tblRegistroReporte.AllowUserToAddRows = false;
            this.tblRegistroReporte.AllowUserToDeleteRows = false;
            this.tblRegistroReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistroReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistroReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistroReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistroReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistroReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar2,
            this.btnSEliminar,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.IdReporte,
            this.Reporte2,
            this.IdUsuario2,
            this.Usuario2,
            this.Documento,
            this.Extension,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistroReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistroReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistroReporte.EnableHeadersVisualStyles = false;
            this.tblRegistroReporte.GridColor = System.Drawing.Color.White;
            this.tblRegistroReporte.Location = new System.Drawing.Point(0, 0);
            this.tblRegistroReporte.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tblRegistroReporte.Name = "tblRegistroReporte";
            this.tblRegistroReporte.ReadOnly = true;
            this.tblRegistroReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistroReporte.RowHeadersVisible = false;
            this.tblRegistroReporte.RowHeadersWidth = 51;
            this.tblRegistroReporte.RowTemplate.Height = 24;
            this.tblRegistroReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistroReporte.Size = new System.Drawing.Size(2350, 306);
            this.tblRegistroReporte.TabIndex = 27;
            this.tblRegistroReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistroReporte_CellContentClick);
            this.tblRegistroReporte.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistroReporte_CellPainting);
            // 
            // btnSeleccionar2
            // 
            this.btnSeleccionar2.HeaderText = "";
            this.btnSeleccionar2.MinimumWidth = 6;
            this.btnSeleccionar2.Name = "btnSeleccionar2";
            this.btnSeleccionar2.ReadOnly = true;
            this.btnSeleccionar2.Width = 30;
            // 
            // btnSEliminar
            // 
            this.btnSEliminar.HeaderText = "";
            this.btnSEliminar.MinimumWidth = 6;
            this.btnSEliminar.Name = "btnSEliminar";
            this.btnSEliminar.ReadOnly = true;
            this.btnSEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSEliminar.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // IdReporte
            // 
            this.IdReporte.HeaderText = "Id de reporte";
            this.IdReporte.MinimumWidth = 6;
            this.IdReporte.Name = "IdReporte";
            this.IdReporte.ReadOnly = true;
            this.IdReporte.Visible = false;
            this.IdReporte.Width = 125;
            // 
            // Reporte2
            // 
            this.Reporte2.HeaderText = "Reporte";
            this.Reporte2.MinimumWidth = 6;
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.ReadOnly = true;
            this.Reporte2.Width = 125;
            // 
            // IdUsuario2
            // 
            this.IdUsuario2.HeaderText = "Id de usuario";
            this.IdUsuario2.MinimumWidth = 6;
            this.IdUsuario2.Name = "IdUsuario2";
            this.IdUsuario2.ReadOnly = true;
            this.IdUsuario2.Visible = false;
            this.IdUsuario2.Width = 125;
            // 
            // Usuario2
            // 
            this.Usuario2.HeaderText = "Usuario";
            this.Usuario2.MinimumWidth = 6;
            this.Usuario2.Name = "Usuario2";
            this.Usuario2.ReadOnly = true;
            this.Usuario2.Visible = false;
            this.Usuario2.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Visible = false;
            this.Documento.Width = 200;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extension";
            this.Extension.MinimumWidth = 6;
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Visible = false;
            this.Extension.Width = 125;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnVerArchivo);
            this.panel2.Controls.Add(this.txtIdReporte);
            this.panel2.Controls.Add(this.txtReporte);
            this.panel2.Controls.Add(this.btnGuardarReporte);
            this.panel2.Controls.Add(this.txtFechaRegistro);
            this.panel2.Controls.Add(this.txtExtension);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Location = new System.Drawing.Point(173, 236);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2350, 302);
            this.panel2.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1951, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 43);
            this.label3.TabIndex = 57;
            this.label3.Text = "Para guardar un archivo busquelo en su equipo";
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerArchivo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerArchivo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnVerArchivo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerArchivo.BorderRadius = 25;
            this.btnVerArchivo.BorderSize = 0;
            this.btnVerArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArchivo.ForeColor = System.Drawing.Color.White;
            this.btnVerArchivo.Image = global::Sistema_de_liquidacion.Properties.Resources.busqueda;
            this.btnVerArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerArchivo.Location = new System.Drawing.Point(2003, 166);
            this.btnVerArchivo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(272, 63);
            this.btnVerArchivo.TabIndex = 56;
            this.btnVerArchivo.Text = "Ver Archvio";
            this.btnVerArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerArchivo.TextColor = System.Drawing.Color.White;
            this.btnVerArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // txtIdReporte
            // 
            this.txtIdReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdReporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdReporte.BorderColor = System.Drawing.Color.White;
            this.txtIdReporte.BorderFocusColor = System.Drawing.Color.White;
            this.txtIdReporte.BorderRadius = 15;
            this.txtIdReporte.BorderSize = 2;
            this.txtIdReporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtIdReporte.Location = new System.Drawing.Point(1494, 75);
            this.txtIdReporte.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtIdReporte.Multiline = false;
            this.txtIdReporte.Name = "txtIdReporte";
            this.txtIdReporte.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtIdReporte.PasswordChar = false;
            this.txtIdReporte.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdReporte.PlaceholderText = "";
            this.txtIdReporte.Size = new System.Drawing.Size(445, 50);
            this.txtIdReporte.TabIndex = 10;
            this.txtIdReporte.Texts = "Id de reporte";
            this.txtIdReporte.UnderlinedStyle = false;
            this.txtIdReporte.Visible = false;
            // 
            // txtReporte
            // 
            this.txtReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtReporte.BorderColor = System.Drawing.Color.White;
            this.txtReporte.BorderFocusColor = System.Drawing.Color.White;
            this.txtReporte.BorderRadius = 15;
            this.txtReporte.BorderSize = 2;
            this.txtReporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtReporte.Location = new System.Drawing.Point(571, 75);
            this.txtReporte.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtReporte.Multiline = false;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtReporte.PasswordChar = false;
            this.txtReporte.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReporte.PlaceholderText = "";
            this.txtReporte.Size = new System.Drawing.Size(445, 50);
            this.txtReporte.TabIndex = 10;
            this.txtReporte.Texts = "Nombre de reporte";
            this.txtReporte.UnderlinedStyle = false;
            this.txtReporte.Enter += new System.EventHandler(this.txtReporte_Enter);
            this.txtReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReporte_KeyPress);
            this.txtReporte.Leave += new System.EventHandler(this.txtReporte_Leave);
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardarReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardarReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarReporte.BorderRadius = 25;
            this.btnGuardarReporte.BorderSize = 0;
            this.btnGuardarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarReporte.FlatAppearance.BorderSize = 0;
            this.btnGuardarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarReporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGuardarReporte.Image = global::Sistema_de_liquidacion.Properties.Resources.disk;
            this.btnGuardarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarReporte.Location = new System.Drawing.Point(2003, 91);
            this.btnGuardarReporte.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(272, 63);
            this.btnGuardarReporte.TabIndex = 56;
            this.btnGuardarReporte.Text = "Abrir gestor";
            this.btnGuardarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarReporte.TextColor = System.Drawing.Color.White;
            this.btnGuardarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarReporte.UseVisualStyleBackColor = false;
            this.btnGuardarReporte.Click += new System.EventHandler(this.btnGuardarReporte_Click);
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaRegistro.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaRegistro.BorderColor = System.Drawing.Color.White;
            this.txtFechaRegistro.BorderFocusColor = System.Drawing.Color.White;
            this.txtFechaRegistro.BorderRadius = 15;
            this.txtFechaRegistro.BorderSize = 2;
            this.txtFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtFechaRegistro.Location = new System.Drawing.Point(899, 142);
            this.txtFechaRegistro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFechaRegistro.Multiline = false;
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtFechaRegistro.PasswordChar = false;
            this.txtFechaRegistro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaRegistro.PlaceholderText = "";
            this.txtFechaRegistro.Size = new System.Drawing.Size(445, 50);
            this.txtFechaRegistro.TabIndex = 12;
            this.txtFechaRegistro.Texts = "Fecha de registro";
            this.txtFechaRegistro.UnderlinedStyle = false;
            this.txtFechaRegistro.Enter += new System.EventHandler(this.txtFechaRegistro_Enter);
            this.txtFechaRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaRegistro_KeyPress);
            this.txtFechaRegistro.Leave += new System.EventHandler(this.txtFechaRegistro_Leave);
            // 
            // txtExtension
            // 
            this.txtExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtension.BackColor = System.Drawing.SystemColors.Window;
            this.txtExtension.BorderColor = System.Drawing.Color.White;
            this.txtExtension.BorderFocusColor = System.Drawing.Color.White;
            this.txtExtension.BorderRadius = 15;
            this.txtExtension.BorderSize = 2;
            this.txtExtension.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtExtension.Location = new System.Drawing.Point(1361, 142);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtExtension.Multiline = false;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtExtension.PasswordChar = false;
            this.txtExtension.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtExtension.PlaceholderText = "";
            this.txtExtension.Size = new System.Drawing.Size(445, 50);
            this.txtExtension.TabIndex = 11;
            this.txtExtension.Texts = "Extension";
            this.txtExtension.UnderlinedStyle = false;
            this.txtExtension.Enter += new System.EventHandler(this.txtExtension_Enter);
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtension_KeyPress);
            this.txtExtension.Leave += new System.EventHandler(this.txtExtension_Leave);
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
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtDocumento.Location = new System.Drawing.Point(1033, 75);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(445, 50);
            this.txtDocumento.TabIndex = 11;
            this.txtDocumento.Texts = "Documento";
            this.txtDocumento.UnderlinedStyle = false;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(892, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "FECHA ACTUAL";
            this.label5.Visible = false;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(165, 177);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(325, 40);
            this.label19.TabIndex = 9;
            this.label19.Text = "Detalle del reporte";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Location = new System.Drawing.Point(169, 84);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2350, 63);
            this.panel9.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel4.Controls.Add(this.dpFechaInicial);
            this.panel4.Location = new System.Drawing.Point(1352, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 42);
            this.panel4.TabIndex = 50;
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
            this.dpFechaInicial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaInicial.Location = new System.Drawing.Point(0, 0);
            this.dpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dpFechaInicial.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(195, 35);
            this.dpFechaInicial.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.TabIndex = 0;
            this.dpFechaInicial.TextColor = System.Drawing.Color.White;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel5.Controls.Add(this.dpFechaFinal);
            this.panel5.Location = new System.Drawing.Point(1581, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 43);
            this.panel5.TabIndex = 48;
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
            this.dpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaFinal.Location = new System.Drawing.Point(0, 0);
            this.dpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dpFechaFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(212, 35);
            this.dpFechaFinal.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.TabIndex = 0;
            this.dpFechaFinal.TextColor = System.Drawing.Color.White;
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
            this.txtBuscar.Location = new System.Drawing.Point(512, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(21, 14, 21, 14);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(668, 49);
            this.txtBuscar.TabIndex = 46;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 614);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 40);
            this.label2.TabIndex = 59;
            this.label2.Text = "Registro de reportes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2565, 1298);
            this.panel1.TabIndex = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1018);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReporte";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroReporte)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJDatePicker drFechaActual;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltbl;
        public System.Windows.Forms.DataGridView tblRegistroReporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnVerArchivo;
        private RJCodeAdvance.RJControls.RJTextBox txtIdReporte;
        private RJCodeAdvance.RJControls.RJTextBox txtReporte;
        private RJCodeAdvance.RJControls.RJButton btnGuardarReporte;
        private RJCodeAdvance.RJControls.RJTextBox txtFechaRegistro;
        private RJCodeAdvance.RJControls.RJTextBox txtExtension;
        private RJCodeAdvance.RJControls.RJTextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaInicial;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaFinal;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reporte2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}