using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class MenuSA : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        public MenuSA()
        {
            InitializeComponent();
        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PanelSubMenuUsuarios.Visible = false;
            PanelSubMenuEmpleados.Visible = false;
            PanelSubMenuPerfiles.Visible = false;
            PanelSubMenuBD.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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



        private void BCerrarMenuSA_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = Interaction.MsgBox("¿Esta seguro de que quiere cerrar sesión?", (MsgBoxStyle)((int)Constants.vbExclamation + (int)Constants.vbYesNo), "Cerrar Sesión");
            if (ask == Constants.vbYes)
            {
                Application.Exit();
            }
        }

        private void BMaximizarMenuSA_Click(object sender, EventArgs e)
        {
            BMaximizarMenuSA.Visible = false;
            BRestaurarMenuSA.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenuSA_Click(object sender, EventArgs e)
        {
            BRestaurarMenuSA.Visible = false;
            BMaximizarMenuSA.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void BMinimizarMenuSA_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraMenuAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenuAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void PanelBarraMenuAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }

        private void BBaseDeDatos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuBD);
        }

        private void BFunciones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new ManejoBD());
        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuUsuarios);
        }

        private void BAñadirUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new AñadirUsuario());
        }

        private void BGestionarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new GestionarUsuarios());
        }


        private void BEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuEmpleados);
        }

        private void BAñadirEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new AñadirEmpleado());
        }


        private void BGestionarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new GestionarEmpleados());
        }

        private void BPerfiles_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuPerfiles);
        }

        private void BAñadirPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new AñadirPuesto());
        }

        private void BGestionarPerfiles_Click(object sender, EventArgs e)
        {
            AbrirFormulariosSuperAdministrador(new GestionarPuestos());
        }



        // Variable para el formulario activo
        private Form? formularioActivo;

        private void BVolver_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario activo
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo
                formularioActivo = null;  // Establecer que no hay formulario activo
            }
        }

        private void AbrirFormulariosSuperAdministrador(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo actual
            }

            // Configurar el formulario hijo como el formulario activo
            formularioActivo = formHijo;

            PanelFormSuperAdministrador.Controls.Clear();
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
            PanelFormSuperAdministrador.Controls.Add(formHijo);
            PanelFormSuperAdministrador.Tag = formHijo;
            PanelFormSuperAdministrador.BringToFront();
            PanelFormSuperAdministrador.AutoScroll = true;

            formHijo.Show();
            hideSubMenu();

        }
    }
}
