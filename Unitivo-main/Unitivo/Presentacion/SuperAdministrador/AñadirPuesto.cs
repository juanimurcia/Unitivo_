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

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class AñadirPuesto : Form
    {
        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();
        public AñadirPuesto()
        {
            InitializeComponent();
            CargarPerfiles();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BRegistrarPerfil_Click(object sender, EventArgs e)
        {
            if (TBNombrePerfil.Text.Trim() != "")
            {
                try
                {
                    Perfile perfile = new Perfile();
                    perfile.DescripcionPerfil = TBNombrePerfil.Text;


                    if (perfilRepositorio.AgregarPerfil(perfile))
                    {
                        MessageBox.Show("Puesto agregado correctamente");
                        LimpiarTextBoxs();
                        CargarPerfiles();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar puesto");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en perfilRepositorio.AgregarPerfil(perfil)
                    MessageBox.Show("Error al agregar puesto: " + ex.Message, "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarPerfiles()
        {
            List<Perfile> perfiles = perfilRepositorio.ListarPerfilesActivos();       

            DataGridViewListarPerfiles.Rows.Clear();
            DataGridViewListarPerfiles.Refresh();

            foreach (Perfile perfile in perfiles)
            {
                if (perfile.EstadoPerfil == true)
                {
                    DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil); ;

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarPerfiles.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombrePerfil.Clear();
        }

        private void AñadirPuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
