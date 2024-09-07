using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Formularios.Vendedor;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class BuscarCliente : Form
    {
        private AñadirVentas AddVenta;
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public BuscarCliente(AñadirVentas AVenta)
        {
            InitializeComponent();

            // Establecer la selección inicial en la primera opción.
            ComboBoxBuscarDni.SelectedIndex = 0;
            AddVenta = AVenta;
        }

        private void BuscarPorComboBox(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxBuscarDni.Text == "DNI")
            {
                CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
            }
            else
            {
                CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BSeleccionar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarClientes.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
            else
            {
                // Obtén el ID del cliente seleccionado
                int idSeleccionado = Convert.ToInt32(DataGridViewListarClientes.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea utilizar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cliente cli = clienteRepositorio.BuscarClientPorId(idSeleccionado);
                    AddVenta.UtilizarCliente(cli);
                    Close();
                    return;
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            object parametro = TBBuscar.Text;
            if (parametro != null)
            {
                List<Cliente> clientes = clienteRepositorio.BuscarClienteActivos(parametro);
                if (clientes != null)
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                    foreach (Cliente cliente in clientes)
                    {
                        DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                    }
                }
                else
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                }
            }
            else
            {
                CargarClientes();
            }
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientesActivos();
            DataGridViewListarClientes.Rows.Clear();
            DataGridViewListarClientes.Refresh();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Estado == true)
                {
                    DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                }
                else
                {
                    int rowIndex = DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);

                    DataGridViewListarClientes.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void ComboBoxBuscarDni_SelectedValueChanged(object sender, EventArgs e)
        {
            TBBuscar.Clear();
        }
    }
}
