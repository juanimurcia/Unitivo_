using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using System.Drawing;
using Color = Unitivo.Modelos.Color;

namespace Unitivo.Presentacion.Administrador
{

    public partial class AñadirColor : Form
    {
        ColorRepositorio colorRepositorio = new ColorRepositorio();

        public AñadirColor()
        {
            InitializeComponent();
            CargarColores();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BRegistrarColor_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                try
                {
                    Color color = new Color();
                    color.Descripcion = TBNombreColor.Text.Trim();


                    if (colorRepositorio.AgregarColor(color))
                    {
                        MessageBox.Show("Color agregado correctamente");
                        LimpiarTextBoxs();
                        CargarColores();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Color");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en colorRepositorio.AgregarColor(color)
                    MessageBox.Show("Error al agregar color: " + ex.Message, "Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y seleccionar un tipo de color válido", "Color", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void CargarColores()
        {
            List<Color> colores = colorRepositorio.ListarColoresActivos();
            DataGridViewListarColor.Rows.Clear();
            DataGridViewListarColor.Refresh();

            foreach (Color color in colores)
            {
                if (color.Estado == true)
                {
                    DataGridViewListarColor.Rows.Add(color.Id, color.Descripcion, color.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarColor.Rows.Add(color.Id, color.Descripcion, color.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarColor.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombreColor.Clear();
        }

        private void AñadirColor_Load(object sender, EventArgs e)
        {

        }

        private void CBTipoColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelRegColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewListarColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
