using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using System.Drawing.Drawing2D;

namespace Sistema_de_liquidacion.Modales
{
    public partial class mdProducto : Form
    {
        private ProductoService productoService = new ProductoService();
        public Producto producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        public void CargarRegistroProducto(List<Producto> lista)
        {
            tblRegistro.Rows.Clear();

            if (lista != null)
            {
                foreach (var producto in lista)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdProducto"].Value = producto.IdProducto;
                    row.Cells["Documento"].Value = producto.Documento;
                    row.Cells["Nombre"].Value = producto.Nombre;
                    row.Cells["IdCargo"].Value = producto.Cargo.IdCargo;
                    row.Cells["Cargo"].Value = producto.Cargo.CargoDesempeñado;
                    row.Cells["FechaRegistro"].Value = producto.Cargo.FechaRegistro.ToString("d");
                    row.Cells["Salario"].Value = producto.Contrato.Salario;
                    row.Cells["Estado"].Value = producto.Estado;
                    row.Cells["FechaRegistroProducto"].Value = producto.FechaRegistro.ToString("d");
                }
            }
        }
        private void FiltroProducto()
        {
        }

        private void FrmModalProductos_Load(object sender, EventArgs e)
        {
            CargarRegistroProducto(productoService.CargarRegistro());
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    producto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(tblRegistro.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Documento = tblRegistro.Rows[index].Cells["Documento"].Value.ToString(),
                        Nombre = tblRegistro.Rows[index].Cells["Nombre"].Value.ToString(),
                        Cargo = new Cargo
                        {
                            IdCargo = Convert.ToInt32(tblRegistro.Rows[index].Cells["IdCargo"].Value.ToString()),
                            CargoDesempeñado = tblRegistro.Rows[index].Cells["Cargo"].Value.ToString(),
                            FechaRegistro = Convert.ToDateTime(tblRegistro.Rows[index].Cells["FechaRegistro"].Value.ToString()),
                        },
                        Contrato = new Contrato
                        {

                            Salario = Convert.ToDecimal(tblRegistro.Rows[index].Cells["Salario"].Value.ToString()),
                        },
                        Estado = tblRegistro.Rows[index].Cells["Estado"].Value.ToString(),
                        FechaRegistro = Convert.ToDateTime(tblRegistro.Rows[index].Cells["FechaRegistroProducto"].Value.ToString())
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            { CargarRegistroProducto(productoService.CargarRegistro()); }
            else
            { FiltroProducto(); }
        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar:")
            {
                txtBuscar.Texts = "";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void rjTextBox1_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "")
            {
                txtBuscar.Texts = "Buscar:";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }
    }
}
