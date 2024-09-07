using System.Windows.Forms;

namespace Unitivo.Presentacion.Logica
{
    static class CommonFunctions
    {

        public static void ValidarStringKeyPress(object textBox, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra o un espacio.
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back))
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("Solo se aceptan letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ValidarNumerosSinEspacios(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un dígito o es un espacio en blanco
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un dígito o es un espacio en blanco, se bloquea el carácter
                e.Handled = true;
            }
        }

        public static void ValidarLetrasSinEspacios(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es una letra o es un espacio en blanco
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra o es un espacio en blanco, se bloquea el carácter
                e.Handled = true;
            }
        }

        public static void ValidarPassword(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un espacio en blanco.
            if (e.KeyChar == ' ')
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("No se permiten espacios en la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ValidarNoEspacioKeyPress(object textBox, KeyPressEventArgs e)
        {

            // Verifica que la tecla presionada sea un número o una tecla de borrado.
            if (e.KeyChar == ' ')
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
            }
        }

        public static void ValidarNumberKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea un número o una tecla de borrado.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("Solo se aceptan números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ValidarDecimalKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea un número o una tecla de borrado.
            if (e.KeyChar == '.')
            {
                // Verifica si ya hay un punto en el texto.
                if (textBox.Text.Contains('.'))
                {
                    // Si ya hay un punto, no permite ingresar otro.
                    e.Handled = true;
                    MessageBox.Show("Solo se permite un punto decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Verifica si la tecla presionada no es un número, una tecla de borrado o una tecla de control.
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, no permite ingresar la tecla presionada.
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números enteros o decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void ValidarKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada sea una letra, un número o un espacio.
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                // No permite ingresar la tecla presionada.
                e.Handled = true;
                // Muestra un mensaje de error.
                MessageBox.Show("No se aceptan caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void ValidarEmailKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            // Define los caracteres permitidos en un correo electrónico.
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            // Verifica si la tecla presionada no es válida para un correo electrónico, excepto si es la tecla "Retroceso".
            if (e.KeyChar != (char)Keys.Back && !validChars.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool ValidarCamposNoVacios(Form formulario)
        {
            List<TextBox> textBoxes = ObtenerTextBoxes(formulario.Controls);

            // Mostrar los nombres de todos los TextBox en un MessageBox

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private static List<TextBox> ObtenerTextBoxes(Control.ControlCollection controls)
        {
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    textBoxes.Add((TextBox)control);
                }
                else if (control.HasChildren)
                {
                    textBoxes.AddRange(ObtenerTextBoxes(control.Controls));
                }
            }

            return textBoxes;
        }


        public static bool ValidarCamposNoVacios(Control control)
        {
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"Debes completar todos campos obligatorios(*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (control is ComboBox comboBox && comboBox.SelectedItem == null)
            {
                MessageBox.Show($"No pueden quedar campos vacios!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
