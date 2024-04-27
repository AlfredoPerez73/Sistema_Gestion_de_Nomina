namespace Sistema_de_liquidacion
{
    partial class FrmNomina
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dpFechaFinal = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dpFechaInicial = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFiltroMes = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroAño = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chGanancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.icoGanancias = new FontAwesome.Sharp.IconPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblRegistroDetalleLiquidaciones = new System.Windows.Forms.DataGridView();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaludTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PensionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonificacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaSTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxATotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaNTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoGanancias)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroDetalleLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 895);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Location = new System.Drawing.Point(100, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1791, 51);
            this.panel9.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(72, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Nomina";
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
            this.txtBuscar.Location = new System.Drawing.Point(266, 4);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(455, 40);
            this.txtBuscar.TabIndex = 46;
            this.txtBuscar.Texts = "Buscar:";
            this.txtBuscar.UnderlinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel5.Controls.Add(this.dpFechaFinal);
            this.panel5.Location = new System.Drawing.Point(1628, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 34);
            this.panel5.TabIndex = 44;
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.BorderSize = 0;
            this.dpFechaFinal.CalendarForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dpFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaFinal.Location = new System.Drawing.Point(0, 0);
            this.dpFechaFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(146, 35);
            this.dpFechaFinal.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaFinal.TabIndex = 0;
            this.dpFechaFinal.TextColor = System.Drawing.Color.White;
            this.dpFechaFinal.ValueChanged += new System.EventHandler(this.dpFechaFinal_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel6.Controls.Add(this.dpFechaInicial);
            this.panel6.Location = new System.Drawing.Point(1471, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 34);
            this.panel6.TabIndex = 45;
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.BorderSize = 0;
            this.dpFechaInicial.CalendarForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dpFechaInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpFechaInicial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaInicial.Location = new System.Drawing.Point(0, 0);
            this.dpFechaInicial.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(150, 35);
            this.dpFechaInicial.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dpFechaInicial.TabIndex = 0;
            this.dpFechaInicial.TextColor = System.Drawing.Color.White;
            this.dpFechaInicial.ValueChanged += new System.EventHandler(this.dpFechaInicial_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboFiltroMes);
            this.panel3.Location = new System.Drawing.Point(1093, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 40);
            this.panel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filtrar:";
            // 
            // cboFiltroMes
            // 
            this.cboFiltroMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroMes.BorderSize = 1;
            this.cboFiltroMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFiltroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFiltroMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroMes.ForeColor = System.Drawing.Color.DimGray;
            this.cboFiltroMes.IconColor = System.Drawing.Color.White;
            this.cboFiltroMes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroMes.ListTextColor = System.Drawing.Color.White;
            this.cboFiltroMes.Location = new System.Drawing.Point(0, 0);
            this.cboFiltroMes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboFiltroMes.Name = "cboFiltroMes";
            this.cboFiltroMes.Padding = new System.Windows.Forms.Padding(1);
            this.cboFiltroMes.Size = new System.Drawing.Size(293, 40);
            this.cboFiltroMes.TabIndex = 23;
            this.cboFiltroMes.Texts = "";
            this.cboFiltroMes.OnSelectedIndexChanged += new System.EventHandler(this.cboFiltroAño_OnSelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboFiltroAño);
            this.panel2.Location = new System.Drawing.Point(784, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 40);
            this.panel2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
            // 
            // cboFiltroAño
            // 
            this.cboFiltroAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroAño.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroAño.BorderSize = 1;
            this.cboFiltroAño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFiltroAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFiltroAño.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroAño.ForeColor = System.Drawing.Color.DimGray;
            this.cboFiltroAño.IconColor = System.Drawing.Color.White;
            this.cboFiltroAño.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboFiltroAño.ListTextColor = System.Drawing.Color.White;
            this.cboFiltroAño.Location = new System.Drawing.Point(0, 0);
            this.cboFiltroAño.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboFiltroAño.Name = "cboFiltroAño";
            this.cboFiltroAño.Padding = new System.Windows.Forms.Padding(1);
            this.cboFiltroAño.Size = new System.Drawing.Size(293, 40);
            this.cboFiltroAño.TabIndex = 23;
            this.cboFiltroAño.Texts = "";
            this.cboFiltroAño.OnSelectedIndexChanged += new System.EventHandler(this.cboFiltroAño_OnSelectedIndexChanged_1);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.chGanancia);
            this.panel7.Controls.Add(this.icoGanancias);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(1050, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 687);
            this.panel7.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(118, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = " y año de nomina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(127, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ganancias por mes";
            // 
            // chGanancia
            // 
            this.chGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.chGanancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chGanancia.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.chGanancia.BorderlineWidth = 0;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chGanancia.ChartAreas.Add(chartArea1);
            this.chGanancia.Enabled = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chGanancia.Legends.Add(legend1);
            this.chGanancia.Location = new System.Drawing.Point(2, 2);
            this.chGanancia.Name = "chGanancia";
            this.chGanancia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.MediumPurple;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            series1.Legend = "Legend1";
            series1.MarkerSize = 6;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chGanancia.Series.Add(series1);
            this.chGanancia.Size = new System.Drawing.Size(846, 569);
            this.chGanancia.TabIndex = 2;
            title1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.Text = "Ganancias Nomina";
            this.chGanancia.Titles.Add(title1);
            // 
            // icoGanancias
            // 
            this.icoGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.icoGanancias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.icoGanancias.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            this.icoGanancias.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.icoGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoGanancias.IconSize = 76;
            this.icoGanancias.Location = new System.Drawing.Point(45, 597);
            this.icoGanancias.Name = "icoGanancias";
            this.icoGanancias.Size = new System.Drawing.Size(76, 81);
            this.icoGanancias.TabIndex = 0;
            this.icoGanancias.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-275, -31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "NOMINA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.tblRegistroDetalleLiquidaciones);
            this.panel4.Location = new System.Drawing.Point(140, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 395);
            this.panel4.TabIndex = 43;
            // 
            // tblRegistroDetalleLiquidaciones
            // 
            this.tblRegistroDetalleLiquidaciones.AllowUserToAddRows = false;
            this.tblRegistroDetalleLiquidaciones.AllowUserToDeleteRows = false;
            this.tblRegistroDetalleLiquidaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblRegistroDetalleLiquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistroDetalleLiquidaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistroDetalleLiquidaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistroDetalleLiquidaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistroDetalleLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistroDetalleLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.Año,
            this.Mes,
            this.SalarioTotal,
            this.SaludTotal,
            this.PensionTotal,
            this.AuxTotal,
            this.BonificacionTotal,
            this.PrimaSTotal,
            this.AuxATotal,
            this.PrimaNTotal,
            this.TotalGeneral,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistroDetalleLiquidaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistroDetalleLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistroDetalleLiquidaciones.EnableHeadersVisualStyles = false;
            this.tblRegistroDetalleLiquidaciones.GridColor = System.Drawing.Color.SteelBlue;
            this.tblRegistroDetalleLiquidaciones.Location = new System.Drawing.Point(0, 0);
            this.tblRegistroDetalleLiquidaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tblRegistroDetalleLiquidaciones.Name = "tblRegistroDetalleLiquidaciones";
            this.tblRegistroDetalleLiquidaciones.ReadOnly = true;
            this.tblRegistroDetalleLiquidaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistroDetalleLiquidaciones.RowHeadersVisible = false;
            this.tblRegistroDetalleLiquidaciones.RowHeadersWidth = 51;
            this.tblRegistroDetalleLiquidaciones.RowTemplate.Height = 24;
            this.tblRegistroDetalleLiquidaciones.Size = new System.Drawing.Size(835, 395);
            this.tblRegistroDetalleLiquidaciones.TabIndex = 21;
            this.tblRegistroDetalleLiquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistroDetalleLiquidaciones_CellContentClick);
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "Id de la factura";
            this.IdFactura.MinimumWidth = 6;
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.ReadOnly = true;
            this.IdFactura.Visible = false;
            this.IdFactura.Width = 170;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 125;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.MinimumWidth = 6;
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            this.Mes.Width = 125;
            // 
            // SalarioTotal
            // 
            this.SalarioTotal.HeaderText = "Total salario";
            this.SalarioTotal.MinimumWidth = 6;
            this.SalarioTotal.Name = "SalarioTotal";
            this.SalarioTotal.ReadOnly = true;
            this.SalarioTotal.Width = 160;
            // 
            // SaludTotal
            // 
            this.SaludTotal.HeaderText = "Total salud";
            this.SaludTotal.MinimumWidth = 6;
            this.SaludTotal.Name = "SaludTotal";
            this.SaludTotal.ReadOnly = true;
            this.SaludTotal.Width = 125;
            // 
            // PensionTotal
            // 
            this.PensionTotal.HeaderText = "Total pension";
            this.PensionTotal.MinimumWidth = 6;
            this.PensionTotal.Name = "PensionTotal";
            this.PensionTotal.ReadOnly = true;
            this.PensionTotal.Width = 160;
            // 
            // AuxTotal
            // 
            this.AuxTotal.HeaderText = "Total aux transprote";
            this.AuxTotal.MinimumWidth = 6;
            this.AuxTotal.Name = "AuxTotal";
            this.AuxTotal.ReadOnly = true;
            this.AuxTotal.Width = 200;
            // 
            // BonificacionTotal
            // 
            this.BonificacionTotal.HeaderText = "Bonificacion de servicios total";
            this.BonificacionTotal.MinimumWidth = 6;
            this.BonificacionTotal.Name = "BonificacionTotal";
            this.BonificacionTotal.ReadOnly = true;
            this.BonificacionTotal.Width = 125;
            // 
            // PrimaSTotal
            // 
            this.PrimaSTotal.HeaderText = "Prima de serivicios total";
            this.PrimaSTotal.MinimumWidth = 6;
            this.PrimaSTotal.Name = "PrimaSTotal";
            this.PrimaSTotal.ReadOnly = true;
            this.PrimaSTotal.Width = 125;
            // 
            // AuxATotal
            // 
            this.AuxATotal.HeaderText = "Auxilio de alimentacion total";
            this.AuxATotal.MinimumWidth = 6;
            this.AuxATotal.Name = "AuxATotal";
            this.AuxATotal.ReadOnly = true;
            this.AuxATotal.Width = 125;
            // 
            // PrimaNTotal
            // 
            this.PrimaNTotal.HeaderText = "Prima navidad total";
            this.PrimaNTotal.MinimumWidth = 6;
            this.PrimaNTotal.Name = "PrimaNTotal";
            this.PrimaNTotal.ReadOnly = true;
            this.PrimaNTotal.Width = 125;
            // 
            // TotalGeneral
            // 
            this.TotalGeneral.HeaderText = "Total";
            this.TotalGeneral.MinimumWidth = 6;
            this.TotalGeneral.Name = "TotalGeneral";
            this.TotalGeneral.ReadOnly = true;
            this.TotalGeneral.Width = 125;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // FrmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 895);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.FrmLiquidacionTotal_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoGanancias)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroDetalleLiquidaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblRegistroDetalleLiquidaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroMes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cboFiltroAño;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaFinal;
        private System.Windows.Forms.Panel panel6;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaInicial;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox icoGanancias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaludTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PensionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonificacionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaSTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuxATotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaNTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
    }
}