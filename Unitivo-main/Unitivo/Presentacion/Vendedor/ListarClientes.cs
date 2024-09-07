using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ListarClientes : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public ListarClientes()
        {
            InitializeComponent();
            CargarClientes();
            ComboBoxBuscar.SelectedIndex = 0;
        }

        private void BuscarPorComboBox(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxBuscar.Text == "DNI")
            {
                CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
            }
            else
            {
                CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
            }
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridViewListarClientes.SelectedRows.Count > 0)
            {
                // Obtén el ID del cliente seleccionado

                int idSeleccionado = Convert.ToInt32(DataGridViewListarClientes.SelectedRows[0].Cells["ID"].Value);

                // Crea una instancia del formulario ModificarCliente y pasa los detalles del cliente como parámetros
                ModificarCliente modificarClienteForm = new ModificarCliente(idSeleccionado);

                // Muestra el formulario ModificarCliente como cuadro de diálogo modal
                DialogResult result = modificarClienteForm.ShowDialog();

                // Puedes realizar acciones después de que se cierre el formulario ModificarCliente si es necesario
                if (result == DialogResult.OK)
                {
                    // Realiza acciones si se cerró el formulario con DialogResult.OK
                    CargarClientes();
                }
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Selecciona un elemento en el DataGridView antes de modificarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientesActivos();
            DataGridViewListarClientes.Rows.Clear();
            DataGridViewListarClientes.Refresh();
            foreach (Cliente cliente in clienteRepositorio.ListarClientes())
            {
                DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
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

        private void ListarClientes_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            TBBuscar.Clear();
        }

        private void BImprimirClientes_Click(object sender, EventArgs e)
        {

        }
    }


}

