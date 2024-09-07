using Unitivo.Modelos;
using Unitivo.Presentacion.Administrador;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.SuperAdministrador;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorios.Implementaciones;


namespace Unitivo.Presentacion
{
    public partial class Login : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();

        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true; // Establecer KeyPreview en true para manejar eventos clave en el formulario.
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void BLogin_Click(object sender, EventArgs e)
        {

            if (!EspacioEnBlanco())
            {
                MessageBox.Show("No se permiten espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreUsuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;

            Usuario user = usuariosRepositorio.LoggUser(nombreUsuario, contraseña);

            if (user != null) 
            {

                if (user.IdPerfilNavigation.DescripcionPerfil.ToString() == "Vendedor")
                {
                    MenuV menuVForm = new(user);
                    menuVForm.Show();
                    this.Hide();
                }
                else if (user.IdPerfilNavigation.DescripcionPerfil.ToString() == "Administrador")
                {
                    MenuA menuAForm = new();
                    menuAForm.Show();
                    this.Hide();
                }
                else if (user.IdPerfilNavigation.DescripcionPerfil.ToString() == "SuperAdmin")
                {

                    MenuSA menuSAForm = new();
                    menuSAForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se ha podido iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nombre de Usuario y/o Contraseña no válidos", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBUsuario.Clear();
                TBContraseña.Clear();
                TBUsuario.Focus();
            }
        }

        public bool EspacioEnBlanco()
        {
            if (CommonFunctions.ValidarCamposNoVacios(TBUsuario) ||
                CommonFunctions.ValidarCamposNoVacios(TBContraseña))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PictureBoxContraseña_Click(object sender, EventArgs e)
        {
            if (PictureBoxContraseña.Tag != null && PictureBoxContraseña.Tag.ToString() == "cerrado")
            {
                PictureBoxContraseña.Tag = "abierto";
                TBContraseña.UseSystemPasswordChar = false; // Mostrar caracteres normales en lugar de *
                PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_abierto;
            }
            else
            {
                PictureBoxContraseña.Tag = "cerrado";
                TBContraseña.UseSystemPasswordChar = true; // Utilizar el sistema de caracteres de contraseña (normalmente asteriscos)
                PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_cerrado;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TBUsuario.Focus(); // Establecer el foco en el TextBox TBUsuario al cargar el formulario.
            TBContraseña.UseSystemPasswordChar = true; // Establecer el TextBox para mostrar asteriscos por defecto.
            PictureBoxContraseña.Tag = "cerrado"; // Establecer el PictureBox en el estado "cerrado" por defecto.
            PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_cerrado;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLogin.PerformClick();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            TBUsuario.Focus();
        }

        private void PanelBarraMenuLogin_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenuLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void PanelBarraMenuLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }

        private void BCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMaximizarMenu_Click(object sender, EventArgs e)
        {
            BMaximizarMenu.Visible = false;
            BRestaurarMenu.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenu_Click(object sender, EventArgs e)
        {
            BRestaurarMenu.Visible = false;
            BMaximizarMenu.Visible = true;
            WindowState = FormWindowState.Normal;
        }



        private void BMinimizarMenu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

