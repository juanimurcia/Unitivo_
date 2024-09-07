namespace Unitivo.Presentacion.Vendedor
{
    partial class MenuV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelBarraMenu = new Panel();
            BMaximizarMenu = new Button();
            BCerrarMenu = new Button();
            BRestaurarMenu = new Button();
            BMinimizarMenu = new Button();
            PanelMenuLateral = new Panel();
            BVolver = new Button();
            PanelSubMenuProductos = new Panel();
            BListarProductos = new Button();
            BProductos = new Button();
            PanelSubMenuFacturación = new Panel();
            BListarVentas = new Button();
            BNuevaVenta = new Button();
            BSalir = new Button();
            BFacturación = new Button();
            PanelSubMenuClientes = new Panel();
            BListaClientes = new Button();
            BAñadirClientes = new Button();
            BClientes = new Button();
            PanelFormVendedor = new Panel();
            Label1 = new Label();
            PanelBarraMenu.SuspendLayout();
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuProductos.SuspendLayout();
            PanelSubMenuFacturación.SuspendLayout();
            PanelSubMenuClientes.SuspendLayout();
            PanelFormVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBarraMenu
            // 
            PanelBarraMenu.BackColor = Color.Tan;
            PanelBarraMenu.Controls.Add(BMaximizarMenu);
            PanelBarraMenu.Controls.Add(BCerrarMenu);
            PanelBarraMenu.Controls.Add(BRestaurarMenu);
            PanelBarraMenu.Controls.Add(BMinimizarMenu);
            PanelBarraMenu.Dock = DockStyle.Top;
            PanelBarraMenu.Location = new Point(0, 0);
            PanelBarraMenu.Margin = new Padding(4, 5, 4, 5);
            PanelBarraMenu.Name = "PanelBarraMenu";
            PanelBarraMenu.Size = new Size(1387, 92);
            PanelBarraMenu.TabIndex = 1;
            PanelBarraMenu.MouseDown += PanelBarraMenu_MouseDown;
            PanelBarraMenu.MouseMove += PanelBarraMenu_MouseMove;
            PanelBarraMenu.MouseUp += PanelBarraMenu_MouseUp;
            // 
            // BMaximizarMenu
            // 
            BMaximizarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenu.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenu.FlatAppearance.BorderSize = 0;
            BMaximizarMenu.FlatStyle = FlatStyle.Flat;
            BMaximizarMenu.Location = new Point(1267, 26);
            BMaximizarMenu.Margin = new Padding(4, 5, 4, 5);
            BMaximizarMenu.Name = "BMaximizarMenu";
            BMaximizarMenu.Size = new Size(40, 46);
            BMaximizarMenu.TabIndex = 3;
            BMaximizarMenu.UseVisualStyleBackColor = true;
            BMaximizarMenu.Click += BMaximizarMenu_Click;
            // 
            // BCerrarMenu
            // 
            BCerrarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenu.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenu.FlatAppearance.BorderSize = 0;
            BCerrarMenu.FlatStyle = FlatStyle.Flat;
            BCerrarMenu.Location = new Point(1320, 26);
            BCerrarMenu.Margin = new Padding(4, 5, 4, 5);
            BCerrarMenu.Name = "BCerrarMenu";
            BCerrarMenu.Size = new Size(40, 46);
            BCerrarMenu.TabIndex = 2;
            BCerrarMenu.UseVisualStyleBackColor = true;
            BCerrarMenu.Click += BCerrarMenu_Click;
            // 
            // BRestaurarMenu
            // 
            BRestaurarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenu.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenu.FlatAppearance.BorderSize = 0;
            BRestaurarMenu.FlatStyle = FlatStyle.Flat;
            BRestaurarMenu.Location = new Point(1267, 26);
            BRestaurarMenu.Margin = new Padding(4, 5, 4, 5);
            BRestaurarMenu.Name = "BRestaurarMenu";
            BRestaurarMenu.Size = new Size(40, 46);
            BRestaurarMenu.TabIndex = 1;
            BRestaurarMenu.UseVisualStyleBackColor = true;
            BRestaurarMenu.Click += BRestaurarMenu_Click;
            // 
            // BMinimizarMenu
            // 
            BMinimizarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenu.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenu.FlatAppearance.BorderSize = 0;
            BMinimizarMenu.FlatStyle = FlatStyle.Flat;
            BMinimizarMenu.Location = new Point(1213, 26);
            BMinimizarMenu.Margin = new Padding(4, 5, 4, 5);
            BMinimizarMenu.Name = "BMinimizarMenu";
            BMinimizarMenu.Size = new Size(40, 46);
            BMinimizarMenu.TabIndex = 0;
            BMinimizarMenu.UseVisualStyleBackColor = true;
            BMinimizarMenu.Click += BMinimizarMenu_Click;
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(BVolver);
            PanelMenuLateral.Controls.Add(PanelSubMenuProductos);
            PanelMenuLateral.Controls.Add(BProductos);
            PanelMenuLateral.Controls.Add(PanelSubMenuFacturación);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(BFacturación);
            PanelMenuLateral.Controls.Add(PanelSubMenuClientes);
            PanelMenuLateral.Controls.Add(BClientes);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 92);
            PanelMenuLateral.Margin = new Padding(4, 5, 4, 5);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(307, 908);
            PanelMenuLateral.TabIndex = 2;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Cornsilk;
            BVolver.Dock = DockStyle.Bottom;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Sienna;
            BVolver.Location = new Point(0, 806);
            BVolver.Margin = new Padding(4, 5, 4, 5);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(307, 51);
            BVolver.TabIndex = 14;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            BVolver.Click += BVolver_Click;
            // 
            // PanelSubMenuProductos
            // 
            PanelSubMenuProductos.BackColor = Color.FloralWhite;
            PanelSubMenuProductos.Controls.Add(BListarProductos);
            PanelSubMenuProductos.Dock = DockStyle.Top;
            PanelSubMenuProductos.Location = new Point(0, 502);
            PanelSubMenuProductos.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuProductos.Name = "PanelSubMenuProductos";
            PanelSubMenuProductos.Size = new Size(307, 69);
            PanelSubMenuProductos.TabIndex = 13;
            // 
            // BListarProductos
            // 
            BListarProductos.BackColor = Color.FloralWhite;
            BListarProductos.Dock = DockStyle.Top;
            BListarProductos.FlatAppearance.BorderSize = 0;
            BListarProductos.FlatStyle = FlatStyle.Flat;
            BListarProductos.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BListarProductos.ForeColor = Color.Sienna;
            BListarProductos.Location = new Point(0, 0);
            BListarProductos.Margin = new Padding(4, 5, 4, 5);
            BListarProductos.Name = "BListarProductos";
            BListarProductos.Size = new Size(307, 62);
            BListarProductos.TabIndex = 1;
            BListarProductos.Text = "Listar Productos";
            BListarProductos.UseVisualStyleBackColor = false;
            BListarProductos.Click += BListarProductos_Click;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.RosyBrown;
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BProductos.ForeColor = Color.Cornsilk;
            BProductos.Image = Properties.Resources.icons8_camiseta_48;
            BProductos.ImageAlign = ContentAlignment.MiddleLeft;
            BProductos.Location = new Point(0, 422);
            BProductos.Margin = new Padding(4, 5, 4, 5);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(307, 80);
            BProductos.TabIndex = 12;
            BProductos.Text = "Productos";
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click;
            // 
            // PanelSubMenuFacturación
            // 
            PanelSubMenuFacturación.BackColor = Color.FloralWhite;
            PanelSubMenuFacturación.Controls.Add(BListarVentas);
            PanelSubMenuFacturación.Controls.Add(BNuevaVenta);
            PanelSubMenuFacturación.Dock = DockStyle.Top;
            PanelSubMenuFacturación.Location = new Point(0, 291);
            PanelSubMenuFacturación.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuFacturación.Name = "PanelSubMenuFacturación";
            PanelSubMenuFacturación.Size = new Size(307, 131);
            PanelSubMenuFacturación.TabIndex = 11;
            // 
            // BListarVentas
            // 
            BListarVentas.BackColor = Color.FloralWhite;
            BListarVentas.Dock = DockStyle.Top;
            BListarVentas.FlatAppearance.BorderSize = 0;
            BListarVentas.FlatStyle = FlatStyle.Flat;
            BListarVentas.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BListarVentas.ForeColor = Color.Sienna;
            BListarVentas.Location = new Point(0, 62);
            BListarVentas.Margin = new Padding(4, 5, 4, 5);
            BListarVentas.Name = "BListarVentas";
            BListarVentas.Size = new Size(307, 62);
            BListarVentas.TabIndex = 2;
            BListarVentas.Text = "Listar Ventas";
            BListarVentas.UseVisualStyleBackColor = false;
            BListarVentas.Click += BListarVentas_Click;
            // 
            // BNuevaVenta
            // 
            BNuevaVenta.BackColor = Color.FloralWhite;
            BNuevaVenta.Dock = DockStyle.Top;
            BNuevaVenta.FlatAppearance.BorderSize = 0;
            BNuevaVenta.FlatStyle = FlatStyle.Flat;
            BNuevaVenta.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BNuevaVenta.ForeColor = Color.Sienna;
            BNuevaVenta.Location = new Point(0, 0);
            BNuevaVenta.Margin = new Padding(4, 5, 4, 5);
            BNuevaVenta.Name = "BNuevaVenta";
            BNuevaVenta.Size = new Size(307, 62);
            BNuevaVenta.TabIndex = 1;
            BNuevaVenta.Text = "Nueva Venta";
            BNuevaVenta.UseVisualStyleBackColor = false;
            BNuevaVenta.Click += BNuevaVenta_Click;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Sienna;
            BSalir.Dock = DockStyle.Bottom;
            BSalir.FlatAppearance.BorderSize = 2;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BSalir.ForeColor = Color.Cornsilk;
            BSalir.Location = new Point(0, 857);
            BSalir.Margin = new Padding(4, 5, 4, 5);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(307, 51);
            BSalir.TabIndex = 8;
            BSalir.Text = "Cerrar Sesión";
            BSalir.TextAlign = ContentAlignment.TopCenter;
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += BSalir_Click;
            // 
            // BFacturación
            // 
            BFacturación.BackColor = Color.RosyBrown;
            BFacturación.Dock = DockStyle.Top;
            BFacturación.FlatAppearance.BorderSize = 0;
            BFacturación.FlatStyle = FlatStyle.Flat;
            BFacturación.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BFacturación.ForeColor = Color.Cornsilk;
            BFacturación.Image = Properties.Resources.icons8_cuenta_50;
            BFacturación.ImageAlign = ContentAlignment.MiddleLeft;
            BFacturación.Location = new Point(0, 211);
            BFacturación.Margin = new Padding(4, 5, 4, 5);
            BFacturación.Name = "BFacturación";
            BFacturación.Size = new Size(307, 80);
            BFacturación.TabIndex = 10;
            BFacturación.Text = "    Facturación";
            BFacturación.UseVisualStyleBackColor = false;
            BFacturación.Click += BFacturación_Click;
            // 
            // PanelSubMenuClientes
            // 
            PanelSubMenuClientes.BackColor = Color.FloralWhite;
            PanelSubMenuClientes.Controls.Add(BListaClientes);
            PanelSubMenuClientes.Controls.Add(BAñadirClientes);
            PanelSubMenuClientes.Dock = DockStyle.Top;
            PanelSubMenuClientes.Location = new Point(0, 80);
            PanelSubMenuClientes.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuClientes.Name = "PanelSubMenuClientes";
            PanelSubMenuClientes.Size = new Size(307, 131);
            PanelSubMenuClientes.TabIndex = 9;
            // 
            // BListaClientes
            // 
            BListaClientes.BackColor = Color.FloralWhite;
            BListaClientes.Dock = DockStyle.Top;
            BListaClientes.FlatAppearance.BorderSize = 0;
            BListaClientes.FlatStyle = FlatStyle.Flat;
            BListaClientes.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BListaClientes.ForeColor = Color.Sienna;
            BListaClientes.Location = new Point(0, 62);
            BListaClientes.Margin = new Padding(4, 5, 4, 5);
            BListaClientes.Name = "BListaClientes";
            BListaClientes.Size = new Size(307, 62);
            BListaClientes.TabIndex = 2;
            BListaClientes.Text = "Listar Clientes";
            BListaClientes.UseVisualStyleBackColor = false;
            BListaClientes.Click += BListaClientes_Click;
            // 
            // BAñadirClientes
            // 
            BAñadirClientes.BackColor = Color.FloralWhite;
            BAñadirClientes.Dock = DockStyle.Top;
            BAñadirClientes.FlatAppearance.BorderSize = 0;
            BAñadirClientes.FlatStyle = FlatStyle.Flat;
            BAñadirClientes.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirClientes.ForeColor = Color.Sienna;
            BAñadirClientes.Location = new Point(0, 0);
            BAñadirClientes.Margin = new Padding(4, 5, 4, 5);
            BAñadirClientes.Name = "BAñadirClientes";
            BAñadirClientes.Size = new Size(307, 62);
            BAñadirClientes.TabIndex = 1;
            BAñadirClientes.Text = "Añadir Clientes";
            BAñadirClientes.UseVisualStyleBackColor = false;
            BAñadirClientes.Click += BAñadirClientes_Click;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.RosyBrown;
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BClientes.ForeColor = Color.Cornsilk;
            BClientes.Image = Properties.Resources.icons8_contactos_50__1_;
            BClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BClientes.Location = new Point(0, 0);
            BClientes.Margin = new Padding(4, 5, 4, 5);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(307, 80);
            BClientes.TabIndex = 0;
            BClientes.Text = "Clientes";
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // PanelFormVendedor
            // 
            PanelFormVendedor.Anchor = AnchorStyles.None;
            PanelFormVendedor.BackgroundImage = Properties.Resources.ImagenGrandeVendedor;
            PanelFormVendedor.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormVendedor.Controls.Add(Label1);
            PanelFormVendedor.Location = new Point(307, 92);
            PanelFormVendedor.Margin = new Padding(4, 5, 4, 5);
            PanelFormVendedor.Name = "PanelFormVendedor";
            PanelFormVendedor.Size = new Size(1080, 908);
            PanelFormVendedor.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.LightSteelBlue;
            Label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkRed;
            Label1.Location = new Point(340, 257);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 69);
            Label1.TabIndex = 4;
            // 
            // MenuV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 1000);
            Controls.Add(PanelFormVendedor);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuV";
            Text = "Form1";
            Load += MenuV_Load;
            PanelBarraMenu.ResumeLayout(false);
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuProductos.ResumeLayout(false);
            PanelSubMenuFacturación.ResumeLayout(false);
            PanelSubMenuClientes.ResumeLayout(false);
            PanelFormVendedor.ResumeLayout(false);
            PanelFormVendedor.PerformLayout();
            ResumeLayout(false);
        }

        internal Panel PanelBarraMenu;
        internal Button BMaximizarMenu;
        internal Button BCerrarMenu;
        internal Button BRestaurarMenu;
        internal Button BMinimizarMenu;
        internal Panel PanelMenuLateral;
        internal Button BClientes;
        internal Button BSalir;
        internal Button BAñadirClientes;
        internal Panel PanelSubMenuProductos;
        internal Button BListarProductos;
        internal Button BProductos;
        internal Panel PanelSubMenuFacturación;
        internal Button BListarVentas;
        internal Button BNuevaVenta;
        internal Button BFacturación;
        internal Panel PanelSubMenuClientes;
        internal Button BListaClientes;
        internal Label Label1;
        internal Panel PanelFormVendedor;

        #endregion

        internal Button BVolver;
    }
}