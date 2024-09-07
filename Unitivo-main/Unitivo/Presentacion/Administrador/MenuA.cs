using System;
using System.Drawing;
using System.Windows.Forms;
using Unitivo.Presentacion.Administrador;
using Unitivo.Presentacion.SuperAdministrador;

namespace Unitivo.Presentacion.Administrador
{
    public partial class MenuA : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        public MenuA()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
        }

        private void hideSubMenu()
        {
            PanelSubMenuProductos.Visible = false;
            PanelSubMenuCategorias.Visible = false;
            PanelSubMenuVentas.Visible = false;
            PanelSubMenuTalles.Visible = false;
            PanelSubMenuClientes.Visible = false;
            PanelSubMenuReportes.Visible = false;
            SubMenuColores.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BProductosAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuProductos);
        }

        private void BAñadirProductosAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirProducto());
        }

        private void BGestionarProductosAdmin_Click(object sender, EventArgs e)
        {
            GestionarProductos gestion = new();
            AbrirFormulariosAdmin(gestion);
        }

        private void BVentasAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuVentas);
        }

        private void BListarVentasAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new ListarVentasAdmin());
        }

        private void BListarVendedoresAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new ListarVendedores());
        }

        private void BCategoriasAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuCategorias);
        }

        private void BAñadirCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirCategoria());
        }

        private void BGestionarCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarCategorias());
        }

        private void BTalles_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuTalles);
        }

        private void BAñadirTalle_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirTalle());
        }

        private void BGestionarTalles_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarTalles());
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuClientes);
        }

        private void BGestionarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarClientes());
        }

        private void BReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuReportes);
        }

        private void BVentasCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new VentasPorCategoria());
        }

        // Variable para el formulario activo
        private Form? formularioActivo;

        public Panel PanelSubMenuColores { get; private set; }

        private void BVolver_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario activo
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo
                formularioActivo = null;  // Establecer que no hay formulario activo
            }
        }

        private void AbrirFormulariosAdmin(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo actual
            }

            // Configurar el formulario hijo como el formulario activo
            formularioActivo = formHijo;

            PanelFormAdmin.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Visible = true;
            formHijo.AutoScroll = true;
            formHijo.VerticalScroll.Value = 0;
            formHijo.VerticalScroll.Minimum = 0;
            formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100;
            formHijo.HorizontalScroll.Value = 0;
            formHijo.HorizontalScroll.Minimum = 0;
            formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100;
            PanelFormAdmin.Controls.Add(formHijo);
            PanelFormAdmin.Tag = formHijo;
            PanelFormAdmin.BringToFront();
            PanelFormAdmin.AutoScroll = true;
            formHijo.Show();
            hideSubMenu();

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = MessageBox.Show("¿Está seguro de que quiere cerrar sesión?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ask == DialogResult.Yes)
            {
                Close();

                // Reemplaza "LoginForm" con el nombre de tu formulario de inicio de sesión
                Login loginForm = new Login();
                loginForm.Show();

                // Limpia los campos de usuario y contraseña si es necesario
                loginForm.TBUsuario.Clear();
                loginForm.TBContraseña.Clear();
            }
        }

        private void BCerrarMenuAdmin_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ask == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BMaximizarMenuAdmin_Click(object sender, EventArgs e)
        {
            BMaximizarMenuAdmin.Visible = false;
            BRestaurarMenuAdmin.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenuAdmin_Click(object sender, EventArgs e)
        {
            BRestaurarMenuAdmin.Visible = false;
            BMaximizarMenuAdmin.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void BMinimizarMenuAdmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void PanelBarraMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new MasVendidos());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(SubMenuColores);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirColor());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarColores());
        }

        private void PanelFormAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
