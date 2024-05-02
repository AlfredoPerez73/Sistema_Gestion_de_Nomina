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
using Logica;

namespace Sistema_de_liquidacion
{
    public partial class FrmGestionCargo : Form
    {
        CargoService cargoService = new CargoService();

        public FrmGestionCargo()
        {
            InitializeComponent();
        }

        private void CargarRegistro()
        {
            Visualizer(cargoService.CargarRegistro());
        }

        private void Visualizer(List<Cargo> lista)
        {
            tblRegistroCargo.Rows.Clear();

            if (lista != null)
            {
                foreach (var producto in lista)
                {
                    int index = tblRegistroCargo.Rows.Add();
                    DataGridViewRow row = tblRegistroCargo.Rows[index];
                    row.Cells["IdCargo"].Value = producto.IdCargo;
                    row.Cells["Cargo"].Value = producto.CargoDesempeñado;
                    row.Cells["FechaRegistro"].Value = producto.FechaRegistro.ToString("d");
                }
            }
        }

        private void FrmGestionCargo_Load(object sender, EventArgs e)
        {
            CargarRegistro();
        }
    }
}
