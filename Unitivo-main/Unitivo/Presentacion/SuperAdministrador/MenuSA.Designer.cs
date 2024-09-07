namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class MenuSA
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
            BSalir = new Button();
            PanelMenuLateral = new Panel();
            PanelSubMenuBD = new Panel();
            BFunciones = new Button();
            BBaseDeDatos = new Button();
            BVolver = new Button();
            PanelSubMenuPerfiles = new Panel();
            BGestionarPerfiles = new Button();
            BAñadirPerfil = new Button();
            BPerfiles = new Button();
            PanelSubMenuEmpleados = new Panel();
            BGestionarEmpleados = new Button();
            BAñadirEmpleado = new Button();
            BEmpleados = new Button();
            PanelSubMenuUsuarios = new Panel();
            BGestionarUsuarios = new Button();
            BAñadirUsuario = new Button();
            BUsuarios = new Button();
            PanelBarraMenu = new Panel();
            BMaximizarMenuSA = new Button();
            BCerrarMenuSA = new Button();
            BRestaurarMenuSA = new Button();
            BMinimizarMenuSA = new Button();
            PanelFormSuperAdministrador = new Panel();
            Label1 = new Label();
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuBD.SuspendLayout();
            PanelSubMenuPerfiles.SuspendLayout();
            PanelSubMenuEmpleados.SuspendLayout();
            PanelSubMenuUsuarios.SuspendLayout();
            PanelBarraMenu.SuspendLayout();
            PanelFormSuperAdministrador.SuspendLayout();
            SuspendLayout();
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
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(PanelSubMenuBD);
            PanelMenuLateral.Controls.Add(BBaseDeDatos);
            PanelMenuLateral.Controls.Add(BVolver);
            PanelMenuLateral.Controls.Add(PanelSubMenuPerfiles);
            PanelMenuLateral.Controls.Add(BPerfiles);
            PanelMenuLateral.Controls.Add(PanelSubMenuEmpleados);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(BEmpleados);
            PanelMenuLateral.Controls.Add(PanelSubMenuUsuarios);
            PanelMenuLateral.Controls.Add(BUsuarios);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 92);
            PanelMenuLateral.Margin = new Padding(4, 5, 4, 5);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(307, 908);
            PanelMenuLateral.TabIndex = 5;
            // 
            // PanelSubMenuBD
            // 
            PanelSubMenuBD.BackColor = Color.FloralWhite;
            PanelSubMenuBD.Controls.Add(BFunciones);
            PanelSubMenuBD.Dock = DockStyle.Top;
            PanelSubMenuBD.Location = new Point(0, 716);
            PanelSubMenuBD.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuBD.Name = "PanelSubMenuBD";
            PanelSubMenuBD.Size = new Size(307, 75);
            PanelSubMenuBD.TabIndex = 17;
            // 
            // BFunciones
            // 
            BFunciones.BackColor = Color.FloralWhite;
            BFunciones.Dock = DockStyle.Top;
            BFunciones.FlatAppearance.BorderSize = 0;
            BFunciones.FlatStyle = FlatStyle.Flat;
            BFunciones.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BFunciones.ForeColor = Color.Sienna;
            BFunciones.Location = new Point(0, 0);
            BFunciones.Margin = new Padding(4, 5, 4, 5);
            BFunciones.Name = "BFunciones";
            BFunciones.Size = new Size(307, 62);
            BFunciones.TabIndex = 1;
            BFunciones.Text = "Funciones";
            BFunciones.UseVisualStyleBackColor = false;
            BFunciones.Click += BFunciones_Click;
            // 
            // BBaseDeDatos
            // 
            BBaseDeDatos.BackColor = Color.RosyBrown;
            BBaseDeDatos.Dock = DockStyle.Top;
            BBaseDeDatos.FlatAppearance.BorderSize = 0;
            BBaseDeDatos.FlatStyle = FlatStyle.Flat;
            BBaseDeDatos.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BBaseDeDatos.ForeColor = Color.Cornsilk;
            BBaseDeDatos.Image = Properties.Resources.icons8_base_de_datos_50;
            BBaseDeDatos.ImageAlign = ContentAlignment.MiddleLeft;
            BBaseDeDatos.Location = new Point(0, 636);
            BBaseDeDatos.Margin = new Padding(4, 5, 4, 5);
            BBaseDeDatos.Name = "BBaseDeDatos";
            BBaseDeDatos.Size = new Size(307, 80);
            BBaseDeDatos.TabIndex = 16;
            BBaseDeDatos.Text = "Base de Datos";
            BBaseDeDatos.TextAlign = ContentAlignment.MiddleLeft;
            BBaseDeDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBaseDeDatos.UseVisualStyleBackColor = false;
            BBaseDeDatos.Click += BBaseDeDatos_Click;
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
            BVolver.TabIndex = 15;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            BVolver.Click += BVolver_Click;
            // 
            // PanelSubMenuPerfiles
            // 
            PanelSubMenuPerfiles.BackColor = Color.FloralWhite;
            PanelSubMenuPerfiles.Controls.Add(BGestionarPerfiles);
            PanelSubMenuPerfiles.Controls.Add(BAñadirPerfil);
            PanelSubMenuPerfiles.Dock = DockStyle.Top;
            PanelSubMenuPerfiles.Location = new Point(0, 502);
            PanelSubMenuPerfiles.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuPerfiles.Name = "PanelSubMenuPerfiles";
            PanelSubMenuPerfiles.Size = new Size(307, 134);
            PanelSubMenuPerfiles.TabIndex = 13;
            // 
            // BGestionarPerfiles
            // 
            BGestionarPerfiles.BackColor = Color.FloralWhite;
            BGestionarPerfiles.Dock = DockStyle.Top;
            BGestionarPerfiles.FlatAppearance.BorderSize = 0;
            BGestionarPerfiles.FlatStyle = FlatStyle.Flat;
            BGestionarPerfiles.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BGestionarPerfiles.ForeColor = Color.Sienna;
            BGestionarPerfiles.Location = new Point(0, 62);
            BGestionarPerfiles.Margin = new Padding(4, 5, 4, 5);
            BGestionarPerfiles.Name = "BGestionarPerfiles";
            BGestionarPerfiles.Size = new Size(307, 62);
            BGestionarPerfiles.TabIndex = 2;
            BGestionarPerfiles.Text = "Gestionar Puestos";
            BGestionarPerfiles.UseVisualStyleBackColor = false;
            BGestionarPerfiles.Click += BGestionarPerfiles_Click;
            // 
            // BAñadirPerfil
            // 
            BAñadirPerfil.BackColor = Color.FloralWhite;
            BAñadirPerfil.Dock = DockStyle.Top;
            BAñadirPerfil.FlatAppearance.BorderSize = 0;
            BAñadirPerfil.FlatStyle = FlatStyle.Flat;
            BAñadirPerfil.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirPerfil.ForeColor = Color.Sienna;
            BAñadirPerfil.Location = new Point(0, 0);
            BAñadirPerfil.Margin = new Padding(4, 5, 4, 5);
            BAñadirPerfil.Name = "BAñadirPerfil";
            BAñadirPerfil.Size = new Size(307, 62);
            BAñadirPerfil.TabIndex = 1;
            BAñadirPerfil.Text = "Añadir Puesto";
            BAñadirPerfil.UseVisualStyleBackColor = false;
            BAñadirPerfil.Click += BAñadirPerfil_Click;
            // 
            // BPerfiles
            // 
            BPerfiles.BackColor = Color.RosyBrown;
            BPerfiles.Dock = DockStyle.Top;
            BPerfiles.FlatAppearance.BorderSize = 0;
            BPerfiles.FlatStyle = FlatStyle.Flat;
            BPerfiles.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BPerfiles.ForeColor = Color.Cornsilk;
            BPerfiles.Image = Properties.Resources.icons8_contactos_60;
            BPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            BPerfiles.Location = new Point(0, 422);
            BPerfiles.Margin = new Padding(4, 5, 4, 5);
            BPerfiles.Name = "BPerfiles";
            BPerfiles.Size = new Size(307, 80);
            BPerfiles.TabIndex = 12;
            BPerfiles.Text = "Puestos";
            BPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            BPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            BPerfiles.UseVisualStyleBackColor = false;
            BPerfiles.Click += BPerfiles_Click;
            // 
            // PanelSubMenuEmpleados
            // 
            PanelSubMenuEmpleados.BackColor = Color.FloralWhite;
            PanelSubMenuEmpleados.Controls.Add(BGestionarEmpleados);
            PanelSubMenuEmpleados.Controls.Add(BAñadirEmpleado);
            PanelSubMenuEmpleados.Dock = DockStyle.Top;
            PanelSubMenuEmpleados.Location = new Point(0, 291);
            PanelSubMenuEmpleados.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuEmpleados.Name = "PanelSubMenuEmpleados";
            PanelSubMenuEmpleados.Size = new Size(307, 131);
            PanelSubMenuEmpleados.TabIndex = 11;
            // 
            // BGestionarEmpleados
            // 
            BGestionarEmpleados.BackColor = Color.FloralWhite;
            BGestionarEmpleados.Dock = DockStyle.Top;
            BGestionarEmpleados.FlatAppearance.BorderSize = 0;
            BGestionarEmpleados.FlatStyle = FlatStyle.Flat;
            BGestionarEmpleados.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BGestionarEmpleados.ForeColor = Color.Sienna;
            BGestionarEmpleados.Location = new Point(0, 62);
            BGestionarEmpleados.Margin = new Padding(4, 5, 4, 5);
            BGestionarEmpleados.Name = "BGestionarEmpleados";
            BGestionarEmpleados.Size = new Size(307, 62);
            BGestionarEmpleados.TabIndex = 2;
            BGestionarEmpleados.Text = "Gestionar Empleados";
            BGestionarEmpleados.UseVisualStyleBackColor = false;
            BGestionarEmpleados.Click += BGestionarEmpleados_Click;
            // 
            // BAñadirEmpleado
            // 
            BAñadirEmpleado.BackColor = Color.FloralWhite;
            BAñadirEmpleado.Dock = DockStyle.Top;
            BAñadirEmpleado.FlatAppearance.BorderSize = 0;
            BAñadirEmpleado.FlatStyle = FlatStyle.Flat;
            BAñadirEmpleado.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirEmpleado.ForeColor = Color.Sienna;
            BAñadirEmpleado.Location = new Point(0, 0);
            BAñadirEmpleado.Margin = new Padding(4, 5, 4, 5);
            BAñadirEmpleado.Name = "BAñadirEmpleado";
            BAñadirEmpleado.Size = new Size(307, 62);
            BAñadirEmpleado.TabIndex = 1;
            BAñadirEmpleado.Text = "Añadir Empleado";
            BAñadirEmpleado.UseVisualStyleBackColor = false;
            BAñadirEmpleado.Click += BAñadirEmpleado_Click;
            // 
            // BEmpleados
            // 
            BEmpleados.BackColor = Color.RosyBrown;
            BEmpleados.Dock = DockStyle.Top;
            BEmpleados.FlatAppearance.BorderSize = 0;
            BEmpleados.FlatStyle = FlatStyle.Flat;
            BEmpleados.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BEmpleados.ForeColor = Color.Cornsilk;
            BEmpleados.Image = Properties.Resources.icons8_contactos_50__2_;
            BEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            BEmpleados.Location = new Point(0, 211);
            BEmpleados.Margin = new Padding(4, 5, 4, 5);
            BEmpleados.Name = "BEmpleados";
            BEmpleados.Size = new Size(307, 80);
            BEmpleados.TabIndex = 10;
            BEmpleados.Text = "Empleados";
            BEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            BEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEmpleados.UseVisualStyleBackColor = false;
            BEmpleados.Click += BEmpleados_Click;
            // 
            // PanelSubMenuUsuarios
            // 
            PanelSubMenuUsuarios.BackColor = Color.FloralWhite;
            PanelSubMenuUsuarios.Controls.Add(BGestionarUsuarios);
            PanelSubMenuUsuarios.Controls.Add(BAñadirUsuario);
            PanelSubMenuUsuarios.Dock = DockStyle.Top;
            PanelSubMenuUsuarios.Location = new Point(0, 80);
            PanelSubMenuUsuarios.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuUsuarios.Name = "PanelSubMenuUsuarios";
            PanelSubMenuUsuarios.Size = new Size(307, 131);
            PanelSubMenuUsuarios.TabIndex = 9;
            // 
            // BGestionarUsuarios
            // 
            BGestionarUsuarios.BackColor = Color.FloralWhite;
            BGestionarUsuarios.Dock = DockStyle.Top;
            BGestionarUsuarios.FlatAppearance.BorderSize = 0;
            BGestionarUsuarios.FlatStyle = FlatStyle.Flat;
            BGestionarUsuarios.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BGestionarUsuarios.ForeColor = Color.Sienna;
            BGestionarUsuarios.Location = new Point(0, 62);
            BGestionarUsuarios.Margin = new Padding(4, 5, 4, 5);
            BGestionarUsuarios.Name = "BGestionarUsuarios";
            BGestionarUsuarios.Size = new Size(307, 62);
            BGestionarUsuarios.TabIndex = 2;
            BGestionarUsuarios.Text = "Gestionar Usuarios";
            BGestionarUsuarios.UseVisualStyleBackColor = false;
            BGestionarUsuarios.Click += BGestionarUsuarios_Click;
            // 
            // BAñadirUsuario
            // 
            BAñadirUsuario.BackColor = Color.FloralWhite;
            BAñadirUsuario.Dock = DockStyle.Top;
            BAñadirUsuario.FlatAppearance.BorderSize = 0;
            BAñadirUsuario.FlatStyle = FlatStyle.Flat;
            BAñadirUsuario.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirUsuario.ForeColor = Color.Sienna;
            BAñadirUsuario.Location = new Point(0, 0);
            BAñadirUsuario.Margin = new Padding(4, 5, 4, 5);
            BAñadirUsuario.Name = "BAñadirUsuario";
            BAñadirUsuario.Size = new Size(307, 62);
            BAñadirUsuario.TabIndex = 1;
            BAñadirUsuario.Text = "Añadir Usuario";
            BAñadirUsuario.UseVisualStyleBackColor = false;
            BAñadirUsuario.Click += BAñadirUsuario_Click;
            // 
            // BUsuarios
            // 
            BUsuarios.BackColor = Color.RosyBrown;
            BUsuarios.Dock = DockStyle.Top;
            BUsuarios.FlatAppearance.BorderSize = 0;
            BUsuarios.FlatStyle = FlatStyle.Flat;
            BUsuarios.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BUsuarios.ForeColor = Color.Cornsilk;
            BUsuarios.Image = Properties.Resources.icons8_contactos_50__1_;
            BUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            BUsuarios.Location = new Point(0, 0);
            BUsuarios.Margin = new Padding(4, 5, 4, 5);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new Size(307, 80);
            BUsuarios.TabIndex = 0;
            BUsuarios.Text = "Usuarios";
            BUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            BUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BUsuarios.UseVisualStyleBackColor = false;
            BUsuarios.Click += BUsuarios_Click;
            // 
            // PanelBarraMenu
            // 
            PanelBarraMenu.BackColor = Color.Tan;
            PanelBarraMenu.Controls.Add(BMaximizarMenuSA);
            PanelBarraMenu.Controls.Add(BCerrarMenuSA);
            PanelBarraMenu.Controls.Add(BRestaurarMenuSA);
            PanelBarraMenu.Controls.Add(BMinimizarMenuSA);
            PanelBarraMenu.Dock = DockStyle.Top;
            PanelBarraMenu.Location = new Point(0, 0);
            PanelBarraMenu.Margin = new Padding(4, 5, 4, 5);
            PanelBarraMenu.Name = "PanelBarraMenu";
            PanelBarraMenu.Size = new Size(1387, 92);
            PanelBarraMenu.TabIndex = 4;
            PanelBarraMenu.MouseDown += PanelBarraMenuAdmin_MouseDown;
            PanelBarraMenu.MouseMove += PanelBarraMenuAdmin_MouseMove;
            PanelBarraMenu.MouseUp += PanelBarraMenuAdmin_MouseUp;
            // 
            // BMaximizarMenuSA
            // 
            BMaximizarMenuSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenuSA.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenuSA.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenuSA.FlatAppearance.BorderSize = 0;
            BMaximizarMenuSA.FlatStyle = FlatStyle.Flat;
            BMaximizarMenuSA.Location = new Point(1264, 26);
            BMaximizarMenuSA.Margin = new Padding(4, 5, 4, 5);
            BMaximizarMenuSA.Name = "BMaximizarMenuSA";
            BMaximizarMenuSA.Size = new Size(40, 46);
            BMaximizarMenuSA.TabIndex = 3;
            BMaximizarMenuSA.UseVisualStyleBackColor = true;
            BMaximizarMenuSA.Click += BMaximizarMenuSA_Click;
            // 
            // BCerrarMenuSA
            // 
            BCerrarMenuSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenuSA.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenuSA.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenuSA.FlatAppearance.BorderSize = 0;
            BCerrarMenuSA.FlatStyle = FlatStyle.Flat;
            BCerrarMenuSA.Location = new Point(1320, 26);
            BCerrarMenuSA.Margin = new Padding(4, 5, 4, 5);
            BCerrarMenuSA.Name = "BCerrarMenuSA";
            BCerrarMenuSA.Size = new Size(40, 46);
            BCerrarMenuSA.TabIndex = 2;
            BCerrarMenuSA.UseVisualStyleBackColor = true;
            BCerrarMenuSA.Click += BCerrarMenuSA_Click;
            // 
            // BRestaurarMenuSA
            // 
            BRestaurarMenuSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenuSA.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenuSA.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenuSA.FlatAppearance.BorderSize = 0;
            BRestaurarMenuSA.FlatStyle = FlatStyle.Flat;
            BRestaurarMenuSA.Location = new Point(1267, 26);
            BRestaurarMenuSA.Margin = new Padding(4, 5, 4, 5);
            BRestaurarMenuSA.Name = "BRestaurarMenuSA";
            BRestaurarMenuSA.Size = new Size(40, 46);
            BRestaurarMenuSA.TabIndex = 1;
            BRestaurarMenuSA.UseVisualStyleBackColor = true;
            BRestaurarMenuSA.Click += BRestaurarMenuSA_Click;
            // 
            // BMinimizarMenuSA
            // 
            BMinimizarMenuSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenuSA.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenuSA.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenuSA.FlatAppearance.BorderSize = 0;
            BMinimizarMenuSA.FlatStyle = FlatStyle.Flat;
            BMinimizarMenuSA.Location = new Point(1213, 26);
            BMinimizarMenuSA.Margin = new Padding(4, 5, 4, 5);
            BMinimizarMenuSA.Name = "BMinimizarMenuSA";
            BMinimizarMenuSA.Size = new Size(40, 46);
            BMinimizarMenuSA.TabIndex = 0;
            BMinimizarMenuSA.UseVisualStyleBackColor = true;
            BMinimizarMenuSA.Click += BMinimizarMenuSA_Click;
            // 
            // PanelFormSuperAdministrador
            // 
            PanelFormSuperAdministrador.Anchor = AnchorStyles.None;
            PanelFormSuperAdministrador.BackgroundImage = Properties.Resources.duenos1;
            PanelFormSuperAdministrador.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormSuperAdministrador.Controls.Add(Label1);
            PanelFormSuperAdministrador.Location = new Point(307, 92);
            PanelFormSuperAdministrador.Margin = new Padding(4, 5, 4, 5);
            PanelFormSuperAdministrador.Name = "PanelFormSuperAdministrador";
            PanelFormSuperAdministrador.Size = new Size(1080, 908);
            PanelFormSuperAdministrador.TabIndex = 6;
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
            // MenuSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 1000);
            Controls.Add(PanelFormSuperAdministrador);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuSA";
            Text = "Form1";
            Load += MenuA_Load;
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuBD.ResumeLayout(false);
            PanelSubMenuPerfiles.ResumeLayout(false);
            PanelSubMenuEmpleados.ResumeLayout(false);
            PanelSubMenuUsuarios.ResumeLayout(false);
            PanelBarraMenu.ResumeLayout(false);
            PanelFormSuperAdministrador.ResumeLayout(false);
            PanelFormSuperAdministrador.PerformLayout();
            ResumeLayout(false);
        }

        internal Button BSalir;
        internal Panel PanelFormSuperAdministrador;
        internal Label Label1;
        internal Panel PanelMenuLateral;
        internal Panel PanelSubMenuPerfiles;
        internal Button BAñadirPerfil;
        internal Button BPerfiles;
        internal Panel PanelSubMenuEmpleados;
        internal Button BGestionarEmpleados;
        internal Button BAñadirEmpleado;
        internal Button BEmpleados;
        internal Panel PanelSubMenuUsuarios;
        internal Button BGestionarUsuarios;
        internal Button BAñadirUsuario;
        internal Button BUsuarios;
        internal Panel PanelBarraMenu;
        internal Button BMaximizarMenuSA;
        internal Button BCerrarMenuSA;
        internal Button BRestaurarMenuSA;
        internal Button BMinimizarMenuSA;
        internal Button BGestionarPerfiles;

        #endregion

        internal Button BVolver;
        internal Panel PanelSubMenuBD;
        internal Button BFunciones;
        internal Button BBaseDeDatos;
    }
}