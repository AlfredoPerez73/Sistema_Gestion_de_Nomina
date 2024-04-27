using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionUsuario : Form
    {
        UsuarioService usuarioService = new UsuarioService();

        public FrmGestionUsuario()
        {
            InitializeComponent();
        }

        private Usuario RegistrarUsuario()
        {
            Rol RoleIndex = (Rol)cboRoles.SelectedItem;
            Usuario usuario = new Usuario
            {
                Documento = txtDocumento.Texts,
                NombreUsuario = txtNombreUsuario.Texts,
                Rol = RoleIndex,
                Contraseña = txtContraseña.Texts,
                Correo = txtCorreo.Texts,
            };
            return usuario;
        } 

        private void GuardarRegistro()
        {

        }

        private bool ValidarCampos()
        {
            if (txtDocumento.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de documento", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreUsuario.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de usuario", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCorreo.Texts == "")
            {
                MessageBox.Show("Por favor llenar el campo de correo", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDocumento.Texts == "Documento")
            {
                MessageBox.Show("Por favor llenar el campo de documento", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNombreUsuario.Texts == "Usuario")
            {
                MessageBox.Show("Por favor llenar el campo de usuario", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCorreo.Texts == "Correo")
            {
                MessageBox.Show("Por favor llenar el campo de correo", "Gestion de usuario",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public void EliminarRegistro()
        {

        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel1, 20);
            BorderRadiusPanel(panel2, 20);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel9, 20);

            CargarRoles();

        }

        private void Nuevo()
        {
            txtDocumento.Texts = "Documento";
            txtNombreUsuario.Texts = "Usuario";
            txtContraseña.Texts = "Contraseña";
            txtCorreo.Texts = "Correo";
            cboRoles.Texts = "Roles desempeñados";
            btnGuardar.Enabled = true;
            txtContraseña.PasswordChar = false;

        }

        private void EnabledUpdate()
        {
            btnGuardar.Enabled = true;
        }

        private void PasswordChar()
        {
            if(txtContraseña.PasswordChar == true)
            {
                txtContraseña.PasswordChar = false;
            }
            else
            {
                txtContraseña.PasswordChar = true;
            }
        }

        private void CargarRegistroUsuario(List<Usuario> lista)
        {
            tblRegistro.Rows.Clear();

            if (lista != null)
            {
                foreach (var producto in lista)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdUsuario"].Value = producto.IdUsuario;
                    row.Cells["Documento"].Value = producto.Documento;
                    row.Cells["Usuario"].Value = producto.NombreUsuario;
                    row.Cells["Contraseña"].Value = producto.Contraseña;
                    row.Cells["IdRol"].Value = producto.Rol.IdRol;
                    row.Cells["Rol"].Value = producto.Rol.NRol;
                    row.Cells["Correo"].Value = producto.Correo;
                    row.Cells["FechaRegistro"].Value = producto.FechaRegistro.ToString("d");

                }
            }
        }

        private void FiltroUsuario()
        {

        }

        private void FiltroUsuarioRol()
        {

        }

        private void CargarRoles()
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void BorderRadiusPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel.Width - radio, 0);
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);
            path.AddArc(0, panel.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    btnGuardar.Enabled = false;
                    txtIdUsuario.Texts = tblRegistro.Rows[index].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Texts = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreUsuario.Texts = tblRegistro.Rows[index].Cells["Usuario"].Value.ToString();
                    txtCorreo.Texts = tblRegistro.Rows[index].Cells["Correo"].Value.ToString();
                    cboRoles.Texts = tblRegistro.Rows[index].Cells["Rol"].Value.ToString();
                    txtContraseña.Texts = tblRegistro.Rows[index].Cells["Contraseña"].Value.ToString();
                    txtContraseña.PasswordChar = true;
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_circle.Width;
                var h = Properties.Resources.check_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void cboFiltroRol_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroUsuarioRol();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            {
                txtBuscar.Texts = "";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "")
            {
                txtBuscar.Texts = "Buscar:";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "Documento")
            {
                txtDocumento.Texts = "";
                txtDocumento.ForeColor = Color.LightGray;
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "")
            {
                txtDocumento.Texts = "Documento";
                txtDocumento.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Texts == "Usuario")
            {
                txtNombreUsuario.Texts = "";
                txtNombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Texts == "")
            {
                txtNombreUsuario.Texts = "Usuario";
                txtNombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "Correo")
            {
                txtCorreo.Texts = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "")
            {
                txtCorreo.Texts = "Correo";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Texts == "Contraseña")
            {
                txtContraseña.Texts = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.PasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Texts == "")
            {
                txtContraseña.Texts = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.PasswordChar = false;
            }
        }

        private void txtDocumento__TextChanged(object sender, EventArgs e)
        {

        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            PasswordChar();
        }
    }
}
