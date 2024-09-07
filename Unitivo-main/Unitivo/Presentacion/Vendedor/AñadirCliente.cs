using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Modelos;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class AñadirCliente : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public AñadirCliente()
        {
            InitializeComponent();
            CargarClientes();
        }


        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = TBNombreCliente.Text.Trim();
                    cliente.Apellido = TBApellidoCliente.Text.Trim();
                    cliente.Dni = int.Parse(TBDniCliente.Text.Trim());
                    cliente.Telefono = TBTelCliente.Text.Trim();
                    cliente.Direccion = TBDireccionCliente.Text.Trim();
                    cliente.Correo = TBCorreoCliente.Text.Trim();

                    if (clienteRepositorio.AgregarCliente(cliente))
                    {
                        MessageBox.Show("Cliente agregado correctamente");
                        LimpiarTextBox();
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar cliente");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en clienteRepositorio.AgregarCliente(cliente)
                    MessageBox.Show("Error al agregar cliente: " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LimpiarTextBox()
        {
            TBNombreCliente.Text = "";
            TBApellidoCliente.Text = "";
            TBDniCliente.Text = "";
            TBTelCliente.Text = "";
            TBDireccionCliente.Text = "";
            TBCorreoCliente.Text = "";
        }
        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientesActivos();
            DataGridViewListarClientes.Rows.Clear();
            DataGridViewListarClientes.Refresh();
            foreach (Cliente cliente in clientes)
            {
                if (true)
                {
                    DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                }

            }
        }


        private void AñadirCliente_Load_1(object sender, EventArgs e)
        {
        }
    }
}

