namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarEmpleados
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
            GroupBoxGestionUsuarios = new GroupBox();
            Label2 = new Label();
            ComboBoxBuscarDni = new ComboBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            BModificarEmpleado = new Button();
            BEliminarEmpleado = new Button();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            BReactivar = new Button();
            GroupBoxGestionUsuarios.SuspendLayout();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(Label2);
            GroupBoxGestionUsuarios.Controls.Add(ComboBoxBuscarDni);
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(184, 28);
            GroupBoxGestionUsuarios.Margin = new Padding(4);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Padding = new Padding(4);
            GroupBoxGestionUsuarios.Size = new Size(525, 108);
            GroupBoxGestionUsuarios.TabIndex = 78;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Empleados";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(46, 36);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 20);
            Label2.TabIndex = 16;
            Label2.Text = "Buscar por:";
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBuscarDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscarDni.Location = new Point(49, 58);
            ComboBoxBuscarDni.Margin = new Padding(4);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(140, 28);
            ComboBoxBuscarDni.TabIndex = 15;
            ComboBoxBuscarDni.SelectedValueChanged += ComboBoxBuscarDni_SelectedValueChanged;
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
            BBuscarUsuario.Location = new Point(426, 36);
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
            TBGestionUsuario.Location = new Point(242, 56);
            TBGestionUsuario.Margin = new Padding(4);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(152, 26);
            TBGestionUsuario.TabIndex = 6;
            TBGestionUsuario.KeyPress += NumStr_KeyPress;
            // 
            // BModificarEmpleado
            // 
            BModificarEmpleado.BackColor = Color.SteelBlue;
            BModificarEmpleado.ForeColor = Color.White;
            BModificarEmpleado.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarEmpleado.Location = new Point(864, 270);
            BModificarEmpleado.Margin = new Padding(4);
            BModificarEmpleado.Name = "BModificarEmpleado";
            BModificarEmpleado.Size = new Size(59, 52);
            BModificarEmpleado.TabIndex = 76;
            BModificarEmpleado.UseVisualStyleBackColor = false;
            BModificarEmpleado.Click += BModificarEmpleado_Click;
            // 
            // BEliminarEmpleado
            // 
            BEliminarEmpleado.BackColor = Color.Brown;
            BEliminarEmpleado.ForeColor = Color.White;
            BEliminarEmpleado.Image = Properties.Resources.icons8_basura_26;
            BEliminarEmpleado.Location = new Point(864, 357);
            BEliminarEmpleado.Margin = new Padding(4);
            BEliminarEmpleado.Name = "BEliminarEmpleado";
            BEliminarEmpleado.Size = new Size(59, 52);
            BEliminarEmpleado.TabIndex = 75;
            BEliminarEmpleado.UseVisualStyleBackColor = false;
            BEliminarEmpleado.Click += BEliminarEmpleado_Click;
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaEmpleados.Location = new Point(26, 164);
            TabControlListaEmpleados.Margin = new Padding(4, 2, 4, 2);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(826, 309);
            TabControlListaEmpleados.TabIndex = 81;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(dgvEmpleados);
            TabPageListaEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 26);
            TabPageListaEmpleados.Margin = new Padding(4, 2, 4, 2);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(4, 2, 4, 2);
            TabPageListaEmpleados.Size = new Size(818, 279);
            TabPageListaEmpleados.TabIndex = 0;
            TabPageListaEmpleados.Text = "Lista de Empleados";
            TabPageListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.BackgroundColor = Color.RosyBrown;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 20;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Dni, Telefono, Direccion, Email, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(4, 2);
            dgvEmpleados.Margin = new Padding(4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.Size = new Size(810, 275);
            dgvEmpleados.TabIndex = 2;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            dgvEmpleados.RowHeaderMouseClick += dgvEmpleados_RowHeaderMouseClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(864, 356);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 93;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += BReactivar_Click;
            // 
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 681);
            Controls.Add(BReactivar);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(BModificarEmpleado);
            Controls.Add(BEliminarEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarEmpleados";
            Text = "Form1";
            Load += GestionarEmpleados_Load;
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;
        internal Button BModificarEmpleado;
        internal Button BEliminarEmpleado;

        #endregion

        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView dgvEmpleados;
        internal Label Label2;
        internal ComboBox ComboBoxBuscarDni;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Estado;
        internal Button BReactivar;
    }
}