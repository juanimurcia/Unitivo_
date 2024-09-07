using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ModificarCliente : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private int idCliente = -1;
        //Valores del cliente
        private string? nombreOriginal;
        private string? apellidoOriginal;
        private int? dniOriginal;
        private string? telefonoOriginal;
        private string? direccionOriginal;
        private string? correoOriginal;


        public ModificarCliente(int id)
        {
            InitializeComponent();
            MostrarCliente(clienteRepositorio.BuscarClientPorId(id));
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Private Sub BModCliente_Click(sender As Object, e As EventArgs) Handles BModCliente.Click 
        //End Sub

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

        //necesito una funcion que tome por parametro el cliente instanciado en el constructor y que muestre los datos del cliente en los textbox
        private void MostrarCliente(Cliente cliente)
        {
            idCliente = cliente.Id;
            // Cargar los datos del cliente en los TextBox
            TBNombreCliente.Text = cliente.Nombre;
            nombreOriginal = cliente.Nombre;

            TBApellidoCliente.Text = cliente.Apellido;
            apellidoOriginal = cliente.Apellido;

            TBDniCliente.Text = cliente.Dni.ToString();
            dniOriginal = cliente.Dni;

            TBTelCliente.Text = cliente.Telefono;
            telefonoOriginal = cliente.Telefono;

            TBDireccion.Text = cliente.Direccion;
            direccionOriginal = cliente.Direccion!;

            TBCorreoCliente.Text = cliente.Correo;
            correoOriginal = cliente.Correo;

        }

        private void BModCliente_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                // Obtén los nuevos valores de los TextBox
                string nuevoNombre = TBNombreCliente.Text.Trim();
                string nuevoApellido = TBApellidoCliente.Text.Trim();
                int nuevoDni = int.Parse(TBDniCliente.Text.Trim());
                string nuevoTelefono = TBTelCliente.Text.Trim();
                string nuevaDireccion = TBDireccion.Text.Trim();
                string nuevoCorreo = TBCorreoCliente.Text.Trim();


                // Compara los nuevos valores con los originales
                if (nuevoNombre != nombreOriginal || nuevoApellido != apellidoOriginal || nuevoDni != dniOriginal ||
                    nuevoTelefono != telefonoOriginal || nuevaDireccion != direccionOriginal || nuevoCorreo != correoOriginal)
                {
                    Cliente cliente = new Cliente();
                    //asigna los campos a cliente.
                    cliente.Id = idCliente;
                    cliente.Nombre = nuevoNombre;
                    cliente.Apellido = nuevoApellido;
                    cliente.Dni = nuevoDni;
                    cliente.Telefono = nuevoTelefono;
                    cliente.Direccion = nuevaDireccion;
                    cliente.Correo = nuevoCorreo;

                    if (clienteRepositorio.ModificarCliente(cliente))
                    {
                        MessageBox.Show("Cliente modificado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("No se han realizado cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ningun campo debe quedar vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
