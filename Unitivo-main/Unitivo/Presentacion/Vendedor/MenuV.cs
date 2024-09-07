using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Formularios.Vendedor;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class MenuV : Form
    {
        private int state;
        private int px, py;
        private bool mover;
        private Usuario vendedor;

        public MenuV(Usuario user)
        {
            InitializeComponent();
            vendedor = user;
        }

        private void MenuV_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PanelSubMenuClientes.Visible = false;
            PanelSubMenuProductos.Visible = false;
            PanelSubMenuFacturación.Visible = false;
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

        private void BClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuClientes);
        }

        private void BAñadirClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new AñadirCliente());
        }

        private void BListaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new ListarClientes());
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuProductos);
        }

        private void BListProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new ListarProductos());
        }
        private void BFacturación_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuFacturación);
        }

        private void BNuevaVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new AñadirVentas(vendedor));
        }

        private void BListarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new ListarVentas());
        }
        private void BListarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosVendedor(new ListarProductos());
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que quiere cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
                loginForm.TBUsuario.Clear();
                loginForm.TBContraseña.Clear();
            }
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

        private void AbrirFormulariosVendedor(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo actual
            }

            // Configurar el formulario hijo como el formulario activo
            formularioActivo = formHijo;

            PanelFormVendedor.Controls.Clear();
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
            PanelFormVendedor.Controls.Add(formHijo);
            PanelFormVendedor.Tag = formHijo;
            PanelFormVendedor.BringToFront();
            PanelFormVendedor.AutoScroll = true;
            formHijo.Show();
            hideSubMenu();

        }

        private void BCerrarMenu_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = Interaction.MsgBox("¿Esta seguro de que quiere cerrar la Aplicación?", (MsgBoxStyle)((int)Constants.vbExclamation + (int)Constants.vbYesNo), "Cerrar Aplicación");
            if (ask == Constants.vbYes)
            {
                Application.Exit();
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
