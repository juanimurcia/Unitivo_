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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;


namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirTalle : Form
    {
        TalleRepositorio talleRepositorio = new TalleRepositorio();
        TipoTalleRepositorio tipoTalleRepositorio = new TipoTalleRepositorio(); // Repositorio para tipoTalle
        private string tipoDeTalle = "";

        public AñadirTalle()
        {
            InitializeComponent();
            CargarTalles();
            CargarTipoTalles();

            // Inicialmente deshabilitar el TextBox de nombre de talle
            TBNombreTalle.Enabled = false;
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeTalle == "Numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeTalle == "Letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }
        }

        private void BRegistrarTalle_Click(object sender, EventArgs e)
        {
            if (CBTipoTalle.SelectedIndex > 0 && CommonFunctions.ValidarCamposNoVacios(this)) // Verificar que se seleccionó un tipo de talle válido
            {
                try
                {
                    Talle talle = new Talle();
                    talle.Descripcion = TBNombreTalle.Text.Trim();
                    talle.TipoTalleId = ((TipoTalle)CBTipoTalle.SelectedItem).Id; // Asignar el ID del tipo de talle seleccionado

                    if (talleRepositorio.AgregarTalle(talle))
                    {
                        MessageBox.Show("Talle agregado correctamente");
                        LimpiarTextBoxs();
                        CargarTalles();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Talle");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en talleRepositorio.AgregarTalle(talle)
                    MessageBox.Show("Error al agregar talle: " + ex.Message, "Talle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y seleccionar un tipo de talle válido", "Talle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarTalles()
        {
            List<Talle> talles = talleRepositorio.ListarTallesActivos();
            DataGridViewListarTalles.Rows.Clear();
            DataGridViewListarTalles.Refresh();

            foreach (Talle talle in talles)
            {
                if (talle.Estado == true)
                {
                    DataGridViewListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado, talle.TipoTalleIdNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarTalles.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombreTalle.Clear();
            CBTipoTalle.SelectedIndex = 0; // Reiniciar el ComboBox al texto inicial
            TBNombreTalle.Enabled = false; // Deshabilitar el TextBox hasta que se seleccione un tipo de talle
        }

        private void AñadirTalle_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites al cargar el formulario
        }

        private void TBNombreTalle_TextChanged(object sender, EventArgs e)
        {
        }

        private void CargarTipoTalles()
        {
            var tipoTalles = tipoTalleRepositorio.ListarTipoTalles();

            CBTipoTalle.Items.Clear();
            CBTipoTalle.Items.Add("Seleccione un tipo de talle");
            CBTipoTalle.Items.AddRange(tipoTalles.ToArray());
            CBTipoTalle.ValueMember = "Id";
            CBTipoTalle.DisplayMember = "Descripcion";
            CBTipoTalle.SelectedIndex = 0; // Seleccionar el texto inicial
        }


        private void CBTipoTalle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TBNombreTalle.Clear();
            if (CBTipoTalle.SelectedIndex > 0)
            {
                TBNombreTalle.Enabled = true; // Habilitar el TextBox si se selecciona un tipo de talle válido
                tipoDeTalle = ((TipoTalle)CBTipoTalle.SelectedItem).Descripcion; // Guardar la descripcion de tipoTalle
            }
            else
            {
                TBNombreTalle.Enabled = false; // Deshabilitar el TextBox si no se selecciona un tipo de talle válido
                TBNombreTalle.Clear(); // Limpiar el TextBox
            }
        }
    }
}

