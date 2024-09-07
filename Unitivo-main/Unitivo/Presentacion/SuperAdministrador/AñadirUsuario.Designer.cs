

namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            GroupBox3 = new GroupBox();
            TBEmpleado = new TextBox();
            Label1 = new Label();
            Label11 = new Label();
            TBNombreUsuario = new TextBox();
            CBPerfil = new ComboBox();
            Label8 = new Label();
            TBContraseñaUsuario = new TextBox();
            TBConfirmarPass = new TextBox();
            Label9 = new Label();
            Label10 = new Label();
            TabControlRegUsuarios = new TabControl();
            TabPageListaUsuarios = new TabPage();
            dgvListaUsuarios = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            BRegistrarUsuario = new Button();
            LRegistroUsuario = new Label();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            GroupBox3.SuspendLayout();
            TabControlRegUsuarios.SuspendLayout();
            TabPageListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // GroupBox3
            // 
            GroupBox3.BackColor = Color.Cornsilk;
            GroupBox3.Controls.Add(TBEmpleado);
            GroupBox3.Controls.Add(Label1);
            GroupBox3.Controls.Add(Label11);
            GroupBox3.Controls.Add(TBNombreUsuario);
            GroupBox3.Controls.Add(CBPerfil);
            GroupBox3.Controls.Add(Label8);
            GroupBox3.Controls.Add(TBContraseñaUsuario);
            GroupBox3.Controls.Add(TBConfirmarPass);
            GroupBox3.Controls.Add(Label9);
            GroupBox3.Controls.Add(Label10);
            GroupBox3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox3.ForeColor = Color.DarkOliveGreen;
            GroupBox3.Location = new Point(38, 96);
            GroupBox3.Margin = new Padding(3, 2, 3, 2);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(3, 2, 3, 2);
            GroupBox3.Size = new Size(351, 268);
            GroupBox3.TabIndex = 35;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Nuevo Usuario";
            // 
            // TBEmpleado
            // 
            TBEmpleado.Enabled = false;
            TBEmpleado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBEmpleado.Location = new Point(199, 218);
            TBEmpleado.Margin = new Padding(4);
            TBEmpleado.Name = "TBEmpleado";
            TBEmpleado.Size = new Size(133, 24);
            TBEmpleado.TabIndex = 24;
            TBEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.SaddleBrown;
            Label1.Location = new Point(15, 221);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(117, 18);
            Label1.TabIndex = 23;
            Label1.Text = "ID de Empleado:";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label11.ForeColor = Color.SaddleBrown;
            Label11.Location = new Point(15, 135);
            Label11.Margin = new Padding(4, 0, 4, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(159, 18);
            Label11.TabIndex = 22;
            Label11.Text = "Confirmar Contraseña:";
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Enabled = false;
            TBNombreUsuario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreUsuario.Location = new Point(199, 39);
            TBNombreUsuario.Margin = new Padding(4);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(133, 24);
            TBNombreUsuario.TabIndex = 20;
            TBNombreUsuario.KeyPress += Email_KeyPress;
            // 
            // CBPerfil
            // 
            CBPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPerfil.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(199, 176);
            CBPerfil.Margin = new Padding(3, 2, 3, 2);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(133, 25);
            CBPerfil.TabIndex = 18;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label8.ForeColor = Color.SaddleBrown;
            Label8.Location = new Point(15, 43);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(142, 18);
            Label8.TabIndex = 0;
            Label8.Text = "Nombre de Usuario:";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBContraseñaUsuario.Location = new Point(199, 83);
            TBContraseñaUsuario.Margin = new Padding(4);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(133, 24);
            TBContraseñaUsuario.TabIndex = 6;
            TBContraseñaUsuario.KeyPress += Contraseña_KeyPress;
            // 
            // TBConfirmarPass
            // 
            TBConfirmarPass.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBConfirmarPass.Location = new Point(199, 133);
            TBConfirmarPass.Margin = new Padding(4);
            TBConfirmarPass.Name = "TBConfirmarPass";
            TBConfirmarPass.Size = new Size(133, 24);
            TBConfirmarPass.TabIndex = 8;
            TBConfirmarPass.KeyPress += Contraseña_KeyPress;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label9.ForeColor = Color.SaddleBrown;
            Label9.Location = new Point(15, 178);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(59, 18);
            Label9.TabIndex = 1;
            Label9.Text = "Puesto:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label10.ForeColor = Color.SaddleBrown;
            Label10.Location = new Point(15, 86);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(89, 18);
            Label10.TabIndex = 4;
            Label10.Text = "Contraseña:";
            // 
            // TabControlRegUsuarios
            // 
            TabControlRegUsuarios.Controls.Add(TabPageListaUsuarios);
            TabControlRegUsuarios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegUsuarios.Location = new Point(38, 391);
            TabControlRegUsuarios.Margin = new Padding(3, 2, 3, 2);
            TabControlRegUsuarios.Name = "TabControlRegUsuarios";
            TabControlRegUsuarios.SelectedIndex = 0;
            TabControlRegUsuarios.Size = new Size(699, 216);
            TabControlRegUsuarios.TabIndex = 32;
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
            TabPageListaUsuarios.Size = new Size(691, 186);
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
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column8, Column14, NombreUsuario, Column13, Apellido, Column11 });
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
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.RowHeadersWidth = 51;
            dgvListaUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaUsuarios.Size = new Size(685, 182);
            dgvListaUsuarios.TabIndex = 2;
            dgvListaUsuarios.CellContentClick += dgvListaUsuarios_CellContentClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Perfil";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Nombre";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Estado";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // BRegistrarUsuario
            // 
            BRegistrarUsuario.BackColor = Color.DarkOliveGreen;
            BRegistrarUsuario.FlatAppearance.BorderColor = Color.White;
            BRegistrarUsuario.FlatAppearance.BorderSize = 2;
            BRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            BRegistrarUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarUsuario.ForeColor = Color.White;
            BRegistrarUsuario.Location = new Point(777, 496);
            BRegistrarUsuario.Margin = new Padding(4);
            BRegistrarUsuario.Name = "BRegistrarUsuario";
            BRegistrarUsuario.Size = new Size(116, 47);
            BRegistrarUsuario.TabIndex = 33;
            BRegistrarUsuario.Text = "Registrar";
            BRegistrarUsuario.UseVisualStyleBackColor = false;
            BRegistrarUsuario.Click += BRegistrarUsuario_Click;
            // 
            // LRegistroUsuario
            // 
            LRegistroUsuario.AutoSize = true;
            LRegistroUsuario.BackColor = Color.Cornsilk;
            LRegistroUsuario.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LRegistroUsuario.ForeColor = Color.DarkOliveGreen;
            LRegistroUsuario.Location = new Point(354, 13);
            LRegistroUsuario.Margin = new Padding(4, 0, 4, 0);
            LRegistroUsuario.Name = "LRegistroUsuario";
            LRegistroUsuario.Size = new Size(243, 33);
            LRegistroUsuario.TabIndex = 31;
            LRegistroUsuario.Text = "Registrar Usuario";
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaEmpleados.Location = new Point(435, 80);
            TabControlListaEmpleados.Margin = new Padding(4, 2, 4, 2);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(488, 293);
            TabControlListaEmpleados.TabIndex = 36;
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
            TabPageListaEmpleados.Size = new Size(480, 263);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Email });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(4, 2);
            dgvEmpleados.Margin = new Padding(4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvEmpleados.Size = new Size(472, 259);
            dgvEmpleados.TabIndex = 2;
            dgvEmpleados.RowHeaderMouseDoubleClick += dgvEmpleados_CellContentDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 179;
            // 
            // AñadirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 681);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(GroupBox3);
            Controls.Add(TabControlRegUsuarios);
            Controls.Add(BRegistrarUsuario);
            Controls.Add(LRegistroUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AñadirUsuario";
            Text = "Form1";
            Load += AñadirUsuario_Load;
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            TabControlRegUsuarios.ResumeLayout(false);
            TabPageListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal GroupBox GroupBox3;
        internal TextBox TBEmpleado;
        internal Label Label1;
        internal Label Label11;
        internal TextBox TBNombreUsuario;
        internal ComboBox CBPerfil;
        internal Label Label8;
        internal TextBox TBContraseñaUsuario;
        internal TextBox TBConfirmarPass;
        internal Label Label9;
        internal Label Label10;
        internal TabControl TabControlRegUsuarios;
        internal TabPage TabPageListaUsuarios;
        internal DataGridView dgvListaUsuarios;
        internal Button BRegistrarUsuario;
        internal Label LRegistroUsuario;

        #endregion
        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Column11;
    }
}