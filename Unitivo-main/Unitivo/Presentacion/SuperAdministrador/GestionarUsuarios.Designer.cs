namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BModificarUsuario = new Button();
            BEliminarUsuario = new Button();
            GroupBoxGestionUsuarios = new GroupBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            TabControlRegUsuarios = new TabControl();
            TabPageListaUsuarios = new TabPage();
            dgvListaUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechaModificacion = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Perfil = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            GroupBoxDatosCliente = new GroupBox();
            BCancelar = new Button();
            button1 = new Button();
            ComboBoxPerfil = new ComboBox();
            LDni = new Label();
            TBContraseñaUsuario = new TextBox();
            TBNombreUsuario = new TextBox();
            LNombreCliente = new Label();
            LApellidoCliente = new Label();
            BReactivar = new Button();
            GroupBoxGestionUsuarios.SuspendLayout();
            TabControlRegUsuarios.SuspendLayout();
            TabPageListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            GroupBoxDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // BModificarUsuario
            // 
            BModificarUsuario.BackColor = Color.SteelBlue;
            BModificarUsuario.ForeColor = Color.White;
            BModificarUsuario.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarUsuario.Location = new Point(839, 213);
            BModificarUsuario.Margin = new Padding(4);
            BModificarUsuario.Name = "BModificarUsuario";
            BModificarUsuario.Size = new Size(59, 52);
            BModificarUsuario.TabIndex = 71;
            BModificarUsuario.UseVisualStyleBackColor = false;
            BModificarUsuario.Click += BModificarUsuario_Click;
            // 
            // BEliminarUsuario
            // 
            BEliminarUsuario.BackColor = Color.Brown;
            BEliminarUsuario.ForeColor = Color.White;
            BEliminarUsuario.Image = Properties.Resources.icons8_basura_26;
            BEliminarUsuario.Location = new Point(839, 299);
            BEliminarUsuario.Margin = new Padding(4);
            BEliminarUsuario.Name = "BEliminarUsuario";
            BEliminarUsuario.Size = new Size(59, 52);
            BEliminarUsuario.TabIndex = 70;
            BEliminarUsuario.UseVisualStyleBackColor = false;
            BEliminarUsuario.Click += BEliminarUsuario_Click;
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(298, 18);
            GroupBoxGestionUsuarios.Margin = new Padding(4);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Padding = new Padding(4);
            GroupBoxGestionUsuarios.Size = new Size(304, 88);
            GroupBoxGestionUsuarios.TabIndex = 73;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Usuarios";
            // 
            // BBuscarUsuario
            // 
            BBuscarUsuario.BackColor = Color.DarkOliveGreen;
            BBuscarUsuario.FlatAppearance.BorderColor = Color.White;
            BBuscarUsuario.FlatAppearance.BorderSize = 2;
            BBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BBuscarUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarUsuario.ForeColor = Color.White;
            BBuscarUsuario.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarUsuario.Location = new Point(217, 30);
            BBuscarUsuario.Margin = new Padding(4);
            BBuscarUsuario.Name = "BBuscarUsuario";
            BBuscarUsuario.Size = new Size(52, 47);
            BBuscarUsuario.TabIndex = 14;
            BBuscarUsuario.UseVisualStyleBackColor = false;
            BBuscarUsuario.Click += BBuscarUsuario_Click;
            // 
            // TBGestionUsuario
            // 
            TBGestionUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionUsuario.Location = new Point(36, 40);
            TBGestionUsuario.Margin = new Padding(4);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(152, 26);
            TBGestionUsuario.TabIndex = 6;
            TBGestionUsuario.KeyPress += String_KeyPress;
            // 
            // TabControlRegUsuarios
            // 
            TabControlRegUsuarios.Controls.Add(TabPageListaUsuarios);
            TabControlRegUsuarios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegUsuarios.Location = new Point(56, 136);
            TabControlRegUsuarios.Margin = new Padding(3, 2, 3, 2);
            TabControlRegUsuarios.Name = "TabControlRegUsuarios";
            TabControlRegUsuarios.SelectedIndex = 0;
            TabControlRegUsuarios.Size = new Size(738, 242);
            TabControlRegUsuarios.TabIndex = 75;
            // 
            // TabPageListaUsuarios
            // 
            TabPageListaUsuarios.Controls.Add(dgvListaUsuarios);
            TabPageListaUsuarios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaUsuarios.ForeColor = Color.White;
            TabPageListaUsuarios.Location = new Point(4, 26);
            TabPageListaUsuarios.Margin = new Padding(3, 2, 3, 2);
            TabPageListaUsuarios.Name = "TabPageListaUsuarios";
            TabPageListaUsuarios.Padding = new Padding(3, 2, 3, 2);
            TabPageListaUsuarios.Size = new Size(730, 212);
            TabPageListaUsuarios.TabIndex = 0;
            TabPageListaUsuarios.Text = "Lista de Usuarios";
            TabPageListaUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AllowUserToResizeColumns = false;
            dgvListaUsuarios.AllowUserToResizeRows = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.BackgroundColor = Color.RosyBrown;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaUsuarios.ColumnHeadersHeight = 20;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Estado, FechaModificacion, FechaCreacion, Perfil, Empleado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaUsuarios.Dock = DockStyle.Fill;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;
            dgvListaUsuarios.Location = new Point(3, 2);
            dgvListaUsuarios.Margin = new Padding(4);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaUsuarios.RowHeadersWidth = 51;
            dgvListaUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaUsuarios.Size = new Size(724, 208);
            dgvListaUsuarios.TabIndex = 2;
            dgvListaUsuarios.CellContentClick += dgvListaUsuarios_CellContentClick;
            dgvListaUsuarios.RowHeaderMouseClick += dgvListaUsuarios_RowHeaderMouseClick;
            dgvListaUsuarios.RowHeaderMouseDoubleClick += dgvListaUsuarios_RowHeaderMouseDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FechaModificacion
            // 
            FechaModificacion.HeaderText = "FechaModificacion";
            FechaModificacion.MinimumWidth = 6;
            FechaModificacion.Name = "FechaModificacion";
            FechaModificacion.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.MinimumWidth = 6;
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // Perfil
            // 
            Perfil.HeaderText = "Perfil";
            Perfil.MinimumWidth = 6;
            Perfil.Name = "Perfil";
            Perfil.ReadOnly = true;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 6;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.BackColor = Color.RosyBrown;
            GroupBoxDatosCliente.Controls.Add(BCancelar);
            GroupBoxDatosCliente.Controls.Add(button1);
            GroupBoxDatosCliente.Controls.Add(ComboBoxPerfil);
            GroupBoxDatosCliente.Controls.Add(LDni);
            GroupBoxDatosCliente.Controls.Add(TBContraseñaUsuario);
            GroupBoxDatosCliente.Controls.Add(TBNombreUsuario);
            GroupBoxDatosCliente.Controls.Add(LNombreCliente);
            GroupBoxDatosCliente.Controls.Add(LApellidoCliente);
            GroupBoxDatosCliente.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(150, 431);
            GroupBoxDatosCliente.Margin = new Padding(4);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4);
            GroupBoxDatosCliente.Size = new Size(584, 218);
            GroupBoxDatosCliente.TabIndex = 76;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Usuario";
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.White;
            BCancelar.Location = new Point(453, 142);
            BCancelar.Margin = new Padding(4);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(123, 39);
            BCancelar.TabIndex = 90;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(320, 142);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 21;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Location = new Point(320, 73);
            ComboBoxPerfil.Margin = new Padding(3, 2, 3, 2);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(187, 39);
            ComboBoxPerfil.TabIndex = 20;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(318, 51);
            LDni.Margin = new Padding(4, 0, 4, 0);
            LDni.Name = "LDni";
            LDni.Size = new Size(44, 20);
            LDni.TabIndex = 19;
            LDni.Text = "Perfil";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(80, 148);
            TBContraseñaUsuario.Margin = new Padding(4);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(187, 38);
            TBContraseñaUsuario.TabIndex = 8;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(80, 74);
            TBNombreUsuario.Margin = new Padding(4);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(187, 38);
            TBNombreUsuario.TabIndex = 6;
            // 
            // LNombreCliente
            // 
            LNombreCliente.AutoSize = true;
            LNombreCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCliente.ForeColor = Color.White;
            LNombreCliente.Location = new Point(78, 50);
            LNombreCliente.Margin = new Padding(4, 0, 4, 0);
            LNombreCliente.Name = "LNombreCliente";
            LNombreCliente.Size = new Size(69, 20);
            LNombreCliente.TabIndex = 0;
            LNombreCliente.Text = "Nombre:";
            // 
            // LApellidoCliente
            // 
            LApellidoCliente.AutoSize = true;
            LApellidoCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellidoCliente.ForeColor = Color.White;
            LApellidoCliente.Location = new Point(78, 125);
            LApellidoCliente.Margin = new Padding(4, 0, 4, 0);
            LApellidoCliente.Name = "LApellidoCliente";
            LApellidoCliente.Size = new Size(96, 20);
            LApellidoCliente.TabIndex = 4;
            LApellidoCliente.Text = "Contraseña:";
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(839, 298);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 95;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += BReactivar_Click;
            // 
            // GestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 681);
            Controls.Add(BReactivar);
            Controls.Add(GroupBoxDatosCliente);
            Controls.Add(TabControlRegUsuarios);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(BModificarUsuario);
            Controls.Add(BEliminarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarUsuarios";
            Text = "Form1";
            Load += GestionarUsuarios_Load;
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabControlRegUsuarios.ResumeLayout(false);
            TabPageListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            GroupBoxDatosCliente.ResumeLayout(false);
            GroupBoxDatosCliente.PerformLayout();
            ResumeLayout(false);
        }

        internal Button BModificarUsuario;
        internal Button BEliminarUsuario;
        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;

        #endregion

        internal TabControl TabControlRegUsuarios;
        internal TabPage TabPageListaUsuarios;
        internal DataGridView dgvListaUsuarios;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        internal GroupBox GroupBoxDatosCliente;
        internal ComboBox ComboBoxPerfil;
        internal Label LDni;
        internal TextBox TBContraseñaUsuario;
        internal TextBox TBNombreUsuario;
        internal Label LNombreCliente;
        internal Label LApellidoCliente;
        internal Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaModificacion;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Perfil;
        private DataGridViewTextBoxColumn Empleado;
        internal Button BCancelar;
        internal Button BReactivar;
    }
}