﻿namespace Sistema_de_liquidacion
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.SlideTimer = new System.Windows.Forms.Timer(this.components);
            this.SlideContenedor = new System.Windows.Forms.Panel();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.btnGestionPermisos = new FontAwesome.Sharp.IconButton();
            this.btnGestionUsuario = new FontAwesome.Sharp.IconButton();
            this.btnGestionRol = new FontAwesome.Sharp.IconButton();
            this.btnGestionCargo = new FontAwesome.Sharp.IconButton();
            this.btnMantenedorEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnLiquidacionTotal = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnGestionEmpleado = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SlideTitle = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstadoFrm = new FontAwesome.Sharp.IconPictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dpFechaActual = new RJCodeAdvance.RJControls.RJDatePicker();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.SlideContenedor.SuspendLayout();
            this.SlideTitle.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadoFrm)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlideTimer
            // 
            this.SlideTimer.Interval = 10;
            this.SlideTimer.Tick += new System.EventHandler(this.SlideTimer_Tick);
            // 
            // SlideContenedor
            // 
            this.SlideContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.SlideContenedor.Controls.Add(this.btnReporte);
            this.SlideContenedor.Controls.Add(this.btnGestionPermisos);
            this.SlideContenedor.Controls.Add(this.btnGestionUsuario);
            this.SlideContenedor.Controls.Add(this.btnGestionRol);
            this.SlideContenedor.Controls.Add(this.btnGestionCargo);
            this.SlideContenedor.Controls.Add(this.btnMantenedorEmpleado);
            this.SlideContenedor.Controls.Add(this.btnLiquidacionTotal);
            this.SlideContenedor.Controls.Add(this.btnInicio);
            this.SlideContenedor.Controls.Add(this.btnGestionEmpleado);
            this.SlideContenedor.Controls.Add(this.label3);
            this.SlideContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlideContenedor.Location = new System.Drawing.Point(0, 0);
            this.SlideContenedor.MaximumSize = new System.Drawing.Size(338, 0);
            this.SlideContenedor.MinimumSize = new System.Drawing.Size(73, 675);
            this.SlideContenedor.Name = "SlideContenedor";
            this.SlideContenedor.Size = new System.Drawing.Size(73, 857);
            this.SlideContenedor.TabIndex = 1;
            this.SlideContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReporte
            // 
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnReporte.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReporte.IconSize = 50;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(8, 916);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(316, 67);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "    Gestion de reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnGestionPermisos
            // 
            this.btnGestionPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionPermisos.FlatAppearance.BorderSize = 0;
            this.btnGestionPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPermisos.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPermisos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionPermisos.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.btnGestionPermisos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionPermisos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGestionPermisos.IconSize = 50;
            this.btnGestionPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPermisos.Location = new System.Drawing.Point(4, 826);
            this.btnGestionPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionPermisos.Name = "btnGestionPermisos";
            this.btnGestionPermisos.Size = new System.Drawing.Size(334, 67);
            this.btnGestionPermisos.TabIndex = 0;
            this.btnGestionPermisos.Text = "    Gestion de permisos";
            this.btnGestionPermisos.UseVisualStyleBackColor = true;
            this.btnGestionPermisos.Click += new System.EventHandler(this.btnGestionPermisos_Click);
            // 
            // btnGestionUsuario
            // 
            this.btnGestionUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionUsuario.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuario.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGestionUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGestionUsuario.IconSize = 50;
            this.btnGestionUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuario.Location = new System.Drawing.Point(4, 735);
            this.btnGestionUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionUsuario.Name = "btnGestionUsuario";
            this.btnGestionUsuario.Size = new System.Drawing.Size(334, 67);
            this.btnGestionUsuario.TabIndex = 0;
            this.btnGestionUsuario.Text = "    Gestion de usuarios";
            this.btnGestionUsuario.UseVisualStyleBackColor = true;
            this.btnGestionUsuario.Click += new System.EventHandler(this.btnGestionUsuario_Click);
            // 
            // btnGestionRol
            // 
            this.btnGestionRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionRol.FlatAppearance.BorderSize = 0;
            this.btnGestionRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionRol.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionRol.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnGestionRol.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionRol.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGestionRol.IconSize = 50;
            this.btnGestionRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionRol.Location = new System.Drawing.Point(4, 637);
            this.btnGestionRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionRol.Name = "btnGestionRol";
            this.btnGestionRol.Size = new System.Drawing.Size(303, 72);
            this.btnGestionRol.TabIndex = 0;
            this.btnGestionRol.Text = "    Gestion de roles";
            this.btnGestionRol.UseVisualStyleBackColor = true;
            this.btnGestionRol.Click += new System.EventHandler(this.btnGestionRol_Click);
            // 
            // btnGestionCargo
            // 
            this.btnGestionCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionCargo.FlatAppearance.BorderSize = 0;
            this.btnGestionCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCargo.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionCargo.IconChar = FontAwesome.Sharp.IconChar.DiceD20;
            this.btnGestionCargo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionCargo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGestionCargo.IconSize = 50;
            this.btnGestionCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCargo.Location = new System.Drawing.Point(2, 543);
            this.btnGestionCargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionCargo.Name = "btnGestionCargo";
            this.btnGestionCargo.Size = new System.Drawing.Size(316, 67);
            this.btnGestionCargo.TabIndex = 0;
            this.btnGestionCargo.Text = "    Gestion de cargos";
            this.btnGestionCargo.UseVisualStyleBackColor = true;
            this.btnGestionCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnMantenedorEmpleado
            // 
            this.btnMantenedorEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenedorEmpleado.FlatAppearance.BorderSize = 0;
            this.btnMantenedorEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedorEmpleado.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMantenedorEmpleado.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnMantenedorEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMantenedorEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMantenedorEmpleado.IconSize = 50;
            this.btnMantenedorEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenedorEmpleado.Location = new System.Drawing.Point(3, 432);
            this.btnMantenedorEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenedorEmpleado.Name = "btnMantenedorEmpleado";
            this.btnMantenedorEmpleado.Size = new System.Drawing.Size(362, 72);
            this.btnMantenedorEmpleado.TabIndex = 0;
            this.btnMantenedorEmpleado.Text = "    Gestion de empleados";
            this.btnMantenedorEmpleado.UseVisualStyleBackColor = true;
            this.btnMantenedorEmpleado.Click += new System.EventHandler(this.btnMantenedorEmpleado_Click);
            // 
            // btnLiquidacionTotal
            // 
            this.btnLiquidacionTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidacionTotal.FlatAppearance.BorderSize = 0;
            this.btnLiquidacionTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidacionTotal.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidacionTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLiquidacionTotal.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnLiquidacionTotal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLiquidacionTotal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLiquidacionTotal.IconSize = 50;
            this.btnLiquidacionTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiquidacionTotal.Location = new System.Drawing.Point(2, 335);
            this.btnLiquidacionTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiquidacionTotal.Name = "btnLiquidacionTotal";
            this.btnLiquidacionTotal.Size = new System.Drawing.Size(336, 73);
            this.btnLiquidacionTotal.TabIndex = 0;
            this.btnLiquidacionTotal.Text = "    Gestion de nomina";
            this.btnLiquidacionTotal.UseVisualStyleBackColor = true;
            this.btnLiquidacionTotal.Click += new System.EventHandler(this.btnLiquidacionTotal_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnInicio.IconSize = 50;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 136);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(233, 76);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "    Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnGestionEmpleado
            // 
            this.btnGestionEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionEmpleado.FlatAppearance.BorderSize = 0;
            this.btnGestionEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEmpleado.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnGestionEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGestionEmpleado.IconSize = 50;
            this.btnGestionEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEmpleado.Location = new System.Drawing.Point(4, 228);
            this.btnGestionEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionEmpleado.Name = "btnGestionEmpleado";
            this.btnGestionEmpleado.Size = new System.Drawing.Size(382, 76);
            this.btnGestionEmpleado.TabIndex = 0;
            this.btnGestionEmpleado.Text = "    Gestion de liquidaciones";
            this.btnGestionEmpleado.UseVisualStyleBackColor = true;
            this.btnGestionEmpleado.Click += new System.EventHandler(this.btnGestionEmpleado_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = global::Sistema_de_liquidacion.Properties.Resources.Liquidez_logo_3__1_;
            this.label3.Location = new System.Drawing.Point(-6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 97);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SlideTitle
            // 
            this.SlideTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.SlideTitle.Controls.Add(this.panel9);
            this.SlideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlideTitle.Location = new System.Drawing.Point(73, 0);
            this.SlideTitle.Name = "SlideTitle";
            this.SlideTitle.Size = new System.Drawing.Size(1370, 97);
            this.SlideTitle.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Location = new System.Drawing.Point(27, 22);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1314, 51);
            this.panel9.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Location = new System.Drawing.Point(1037, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 40);
            this.panel2.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Image = global::Sistema_de_liquidacion.Properties.Resources.circulo_de_usuario;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblUsuario.Location = new System.Drawing.Point(9, -1);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(223, 42);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnEstadoFrm);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnEstadoFrm
            // 
            this.btnEstadoFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEstadoFrm.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnEstadoFrm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnEstadoFrm.IconColor = System.Drawing.Color.MediumPurple;
            this.btnEstadoFrm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEstadoFrm.IconSize = 38;
            this.btnEstadoFrm.Location = new System.Drawing.Point(8, 2);
            this.btnEstadoFrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstadoFrm.Name = "btnEstadoFrm";
            this.btnEstadoFrm.Size = new System.Drawing.Size(38, 42);
            this.btnEstadoFrm.TabIndex = 1;
            this.btnEstadoFrm.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstado.Location = new System.Drawing.Point(48, 7);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 25);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Inicio";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel5.Controls.Add(this.dpFechaActual);
            this.panel5.Location = new System.Drawing.Point(467, 7);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 40);
            this.panel5.TabIndex = 40;
            // 
            // dpFechaActual
            // 
            this.dpFechaActual.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpFechaActual.BorderSize = 0;
            this.dpFechaActual.CalendarForeColor = System.Drawing.Color.White;
            this.dpFechaActual.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaActual.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dpFechaActual.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpFechaActual.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dpFechaActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpFechaActual.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaActual.Location = new System.Drawing.Point(0, 0);
            this.dpFechaActual.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaActual.Name = "dpFechaActual";
            this.dpFechaActual.Size = new System.Drawing.Size(386, 35);
            this.dpFechaActual.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaActual.TabIndex = 0;
            this.dpFechaActual.TextColor = System.Drawing.Color.White;
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Contenedor.Location = new System.Drawing.Point(0, 95);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1672, 860);
            this.Contenedor.TabIndex = 0;
            this.Contenedor.Tag = "";
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.SlideTitle);
            this.Controls.Add(this.SlideContenedor);
            this.Controls.Add(this.Contenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.SlideContenedor.ResumeLayout(false);
            this.SlideTitle.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadoFrm)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel SlideContenedor;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SlideTitle;
        private FontAwesome.Sharp.IconButton btnGestionEmpleado;
        private FontAwesome.Sharp.IconButton btnLiquidacionTotal;
        private FontAwesome.Sharp.IconButton btnMantenedorEmpleado;
        private FontAwesome.Sharp.IconButton btnGestionCargo;
        private FontAwesome.Sharp.IconButton btnGestionRol;
        private FontAwesome.Sharp.IconButton btnGestionUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconPictureBox btnEstadoFrm;
        private System.Windows.Forms.Label lblEstado;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnReporte;
        private FontAwesome.Sharp.IconButton btnGestionPermisos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaActual;
        private System.Windows.Forms.Panel panel2;
    }
}