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
            try
            {
                Rol RoleIndex = (Rol)cboRoles.SelectedItem;
                Usuario usuario = new Usuario
                {
                    Documento = txtDocumento.Texts,
                    Nombre = txtNombreUsuario.Texts,
                    Rol = RoleIndex,
                    Contraseña = txtContraseña.Texts,
                    Correo = txtCorreo.Texts,
                };
                return usuario;
            }
            catch (FormatException)
            {
                return null;
            }
        } 

        private void GuardarRegistro()
        {
            if (!ValidarCampos()) { return; }

            var usuario = RegistrarUsuario();

            var ID = usuarioService.BuscarId(txtDocumento.Texts);
            if (ID != true)
            {
                var msg = usuarioService.Guardar(usuario);
                MessageBox.Show(msg, "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRegistro();
                Nuevo();
            }
            else
            {
                MessageBox.Show($"El registro con la ID {txtDocumento.Texts} " +
                    $"ya existe!", "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            if (Convert.ToInt32(txtIdUsuario.Texts) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usuario usuario = new Usuario
                    {
                        IdPersona = Convert.ToInt32(txtIdUsuario.Texts)
                    };
                    if (usuario != null)
                    {
                        var msg = usuarioService.EliminarRegistros(usuario);
                        MessageBox.Show(msg, "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRegistro();
                        Nuevo();
                        EnabledUpdate();
                    }
                    else
                    {
                        var msg = usuarioService.EliminarRegistros(usuario);
                        MessageBox.Show(msg, "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nuevo();
                        EnabledUpdate();
                    }
                }
            }

        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel1, 30);
            BorderRadiusPanel(panel2, 30);
            BorderRadiusPanel(panel3, 15);
            BorderRadiusPanel(panel5, 20);
            BorderRadiusPanel(panel9, 20);

            Nuevo();
            CargarRoles();
            MessageTable();
            CargarRegistro();
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

        private void CargarRegistro()
        {
            Visualizer(usuarioService.CargarRegistro());
        }

        private void Visualizer(List<Usuario> lista)
        {
            tblRegistro.Rows.Clear();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdUsuario"].Value = item.IdPersona;
                    row.Cells["Documento"].Value = item.Documento;
                    row.Cells["Usuario"].Value = item.Nombre;
                    row.Cells["Contraseña"].Value = item.Contraseña;
                    row.Cells["IdRol"].Value = item.Rol.IdRol;
                    row.Cells["Rol"].Value = item.Rol.NRol;
                    row.Cells["Correo"].Value = item.Correo;
                    row.Cells["FechaRegistro"].Value = item.FechaRegistro.ToString("d");

                }
            }
        }

        private void MessageTable()
        {
            if (tblRegistro.Rows.Count > 0)
            {
                lbltbl.Visible = false;
            }
            else
            {
                lbltbl.Visible = true;
            }

        }

        private void FiltroUsuario()
        {
            var filtro = txtBuscar.Texts;
            var lista = usuarioService.BuscarX(filtro);
            Visualizer(lista);
        }

        private void FiltroUsuarioRol()
        {
            if (cboFiltroRol.SelectedIndex > 0)
            {
                Rol rolSeleccionado = (Rol)cboFiltroRol.SelectedItem; // Obtener el objeto Rol seleccionado
                string nombreRolSeleccionado = rolSeleccionado.NRol; // Obtener el nombre del rol del objeto Rol
                var lista = usuarioService.FiltroRol(nombreRolSeleccionado.ToUpper());
                Visualizer(lista);
            }
            else if (cboFiltroRol.SelectedIndex == 0)
            {
                Visualizer(usuarioService.CargarRegistro());
            }
        }

        private void CargarRoles()
        {
            RolService rolService = new RolService();
            var roles = rolService.CargarRegistro();

            // Crear una copia de la lista de roles para cada ComboBox
            var rolesCbo1 = new List<Rol>(roles);
            var rolesCbo2 = new List<Rol>(roles);

            // Agregar un índice adicional a cada lista
            rolesCbo1.Insert(0, new Rol { IdRol = -1, NRol = " " });
            rolesCbo2.Insert(0, new Rol { IdRol = -1, NRol = " " });

            cboRoles.DataSource = rolesCbo1;
            cboFiltroRol.DataSource = rolesCbo2;

            cboRoles.DisplayMember = "NRol";
            cboRoles.ValueMember = "IdRol";

            cboFiltroRol.DisplayMember = "NRol";
            cboFiltroRol.ValueMember = "IdRol";

            cboRoles.SelectedIndex = -1;
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;

            cboFiltroRol.SelectedIndex = -1;
            cboFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
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

            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int IdPersona = Convert.ToInt32(tblRegistro.Rows[index].Cells["IdUsuario"].Value);

                        Usuario usuario = new Usuario
                        {
                            IdPersona = IdPersona
                        };

                        var msg = usuarioService.EliminarRegistros(usuario);
                        MessageBox.Show(msg, "Gestion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tblRegistro.Rows.RemoveAt(index);
                    }
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
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.circulo_marca_x_sin_findo.Width;
                var h = Properties.Resources.circulo_marca_x_sin_findo.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.circulo_marca_x_sin_findo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void cboFiltroRol_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroUsuarioRol();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { Visualizer(usuarioService.CargarRegistro()); }
            else if (txtBuscar.Texts == "") { Visualizer(usuarioService.CargarRegistro()); }
            else
            { FiltroUsuario(); }
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
                txtDocumento.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Texts == "")
            {
                txtDocumento.Texts = "Documento";
                txtDocumento.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Texts == "Usuario")
            {
                txtNombreUsuario.Texts = "";
                txtNombreUsuario.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Texts == "")
            {
                txtNombreUsuario.Texts = "Usuario";
                txtNombreUsuario.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "Correo")
            {
                txtCorreo.Texts = "";
                txtCorreo.ForeColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "")
            {
                txtCorreo.Texts = "Correo";
                txtCorreo.ForeColor = Color.FromArgb(31, 30, 68);
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
