namespace Sistema_de_liquidacion.Modales
{
    partial class mdArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdArchivo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreArchivo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtRutaArchivo = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnGuardar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.btnBuscarDoc = new RJCodeAdvance.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.txtRutaArchivo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnBuscarDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 267);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreArchivo.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNombreArchivo.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNombreArchivo.BorderRadius = 15;
            this.txtNombreArchivo.BorderSize = 2;
            this.txtNombreArchivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArchivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombreArchivo.Location = new System.Drawing.Point(61, 134);
            this.txtNombreArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreArchivo.Multiline = false;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreArchivo.PasswordChar = false;
            this.txtNombreArchivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreArchivo.PlaceholderText = "";
            this.txtNombreArchivo.Size = new System.Drawing.Size(328, 35);
            this.txtNombreArchivo.TabIndex = 2;
            this.txtNombreArchivo.Texts = "Nombre del archivo";
            this.txtNombreArchivo.UnderlinedStyle = false;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRutaArchivo.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRutaArchivo.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRutaArchivo.BorderRadius = 15;
            this.txtRutaArchivo.BorderSize = 2;
            this.txtRutaArchivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRutaArchivo.Location = new System.Drawing.Point(61, 80);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaArchivo.Multiline = false;
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRutaArchivo.PasswordChar = false;
            this.txtRutaArchivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRutaArchivo.PlaceholderText = "";
            this.txtRutaArchivo.Size = new System.Drawing.Size(328, 35);
            this.txtRutaArchivo.TabIndex = 2;
            this.txtRutaArchivo.Texts = "Ruta del archivo";
            this.txtRutaArchivo.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 17;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(61, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 17;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(228, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnBuscarDoc
            // 
            this.btnBuscarDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnBuscarDoc.BackgroundColor = System.Drawing.Color.Indigo;
            this.btnBuscarDoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarDoc.BorderRadius = 17;
            this.btnBuscarDoc.BorderSize = 0;
            this.btnBuscarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDoc.FlatAppearance.BorderSize = 0;
            this.btnBuscarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDoc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDoc.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDoc.Image = global::Sistema_de_liquidacion.Properties.Resources.busqueda;
            this.btnBuscarDoc.Location = new System.Drawing.Point(396, 80);
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.Size = new System.Drawing.Size(38, 35);
            this.btnBuscarDoc.TabIndex = 1;
            this.btnBuscarDoc.TextColor = System.Drawing.Color.White;
            this.btnBuscarDoc.UseVisualStyleBackColor = false;
            this.btnBuscarDoc.Click += new System.EventHandler(this.btnBuscarDoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar archivo y subir documentos";
            // 
            // mdArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 267);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdArchivo";
            this.Text = "Busqueda de archivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJTextBox txtRutaArchivo;
        private RJCodeAdvance.RJControls.RJButton btnBuscarDoc;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtNombreArchivo;
        private RJCodeAdvance.RJControls.RJButton btnGuardar;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
    }
}