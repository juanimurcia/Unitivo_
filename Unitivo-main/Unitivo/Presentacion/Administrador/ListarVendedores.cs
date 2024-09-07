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
using Color = System.Drawing.Color;

namespace Unitivo.Presentacion.Administrador
{
    public partial class ListarVendedores : Form
    {
        private UsuariosRepositorio usuariosRepositorios = new UsuariosRepositorio();

        public ListarVendedores()
        {
            InitializeComponent();
        }

        private void StrNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void ListarVendedores_Load(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void CargarVendedores()
        {
            List<Usuario> vendedores = usuariosRepositorios.listarVendedoresActivos();
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();

            foreach (Usuario vendedor in vendedores)
            {
                if (vendedor.Estado == true)
                {
                    dgvEmpleados.Rows.Add(vendedor.Id, vendedor.IdEmpleadoNavigation.Nombre, vendedor.IdEmpleadoNavigation.Apellido, vendedor.IdEmpleadoNavigation.Dni, vendedor.IdEmpleadoNavigation.Telefono, vendedor.IdEmpleadoNavigation.Direccion, vendedor.IdEmpleadoNavigation.Correo);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(vendedor.Id, vendedor.IdEmpleadoNavigation.Nombre, vendedor.IdEmpleadoNavigation.Apellido, vendedor.IdEmpleadoNavigation.Dni, vendedor.IdEmpleadoNavigation.Telefono, vendedor.IdEmpleadoNavigation.Direccion, vendedor.IdEmpleadoNavigation.Correo);


                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BBuscarVendedor_Click(object sender, EventArgs e)
        {
            
            List<Usuario> vendedores = usuariosRepositorios.buscarVendedores(TBBuscarVendedor.Text);
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();

            foreach (Usuario vendedor in vendedores)
            {
                if (vendedor.Estado == true)
                {
                    dgvEmpleados.Rows.Add(vendedor.Id, vendedor.IdEmpleadoNavigation.Nombre , vendedor.IdEmpleadoNavigation.Apellido, vendedor.IdEmpleadoNavigation.Dni, vendedor.IdEmpleadoNavigation.Telefono, vendedor.IdEmpleadoNavigation.Direccion, vendedor.IdEmpleadoNavigation.Correo);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(vendedor.Id, vendedor.IdEmpleadoNavigation.Nombre, vendedor.IdEmpleadoNavigation.Apellido, vendedor.IdEmpleadoNavigation.Dni, vendedor.IdEmpleadoNavigation.Telefono, vendedor.IdEmpleadoNavigation.Direccion, vendedor.IdEmpleadoNavigation.Correo);


                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
