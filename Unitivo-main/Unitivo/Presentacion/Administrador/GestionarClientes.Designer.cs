namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarClientes
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            BModificarCliente = new Button();
            GroupBoxClientes = new GroupBox();
            Label2 = new Label();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            BEliminarClientes = new Button();
            TabControlListaClientes = new TabControl();
            TabPageListaCliente = new TabPage();
            DataGridViewListarClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            BReactivar = new Button();
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).BeginInit();
            SuspendLayout();
            // 
            // BModificarCliente
            // 
            BModificarCliente.BackColor = Color.SteelBlue;
            BModificarCliente.ForeColor = Color.White;
            BModificarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarCliente.Location = new Point(841, 311);
            BModificarCliente.Margin = new Padding(4);
            BModificarCliente.Name = "BModificarCliente";
            BModificarCliente.Size = new Size(59, 52);
            BModificarCliente.TabIndex = 23;
            BModificarCliente.UseVisualStyleBackColor = false;
            BModificarCliente.Click += BModificarCliente_Click;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(Label2);
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(186, 41);
            GroupBoxClientes.Margin = new Padding(4);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4);
            GroupBoxClientes.Size = new Size(540, 116);
            GroupBoxClientes.TabIndex = 20;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(58, 35);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 20);
            Label2.TabIndex = 7;
            Label2.Text = "Buscar por:";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(452, 47);
            BBuscar.Margin = new Padding(4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(52, 46);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(237, 55);
            TBBuscar.Margin = new Padding(4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(193, 31);
            TBBuscar.TabIndex = 1;
            TBBuscar.KeyPress += BuscarPorComboBox;
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBuscarDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscarDni.Location = new Point(61, 57);
            ComboBoxBuscarDni.Margin = new Padding(4);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(140, 28);
            ComboBoxBuscarDni.TabIndex = 0;
            ComboBoxBuscarDni.SelectedValueChanged += ComboBoxBuscarDni_SelectedValueChanged;
            // 
            // BEliminarClientes
            // 
            BEliminarClientes.BackColor = Color.Brown;
            BEliminarClientes.FlatAppearance.BorderSize = 2;
            BEliminarClientes.FlatStyle = FlatStyle.Flat;
            BEliminarClientes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarClientes.ForeColor = Color.White;
            BEliminarClientes.Image = Properties.Resources.icons8_basura_26;
            BEliminarClientes.Location = new Point(841, 394);
            BEliminarClientes.Margin = new Padding(4);
            BEliminarClientes.Name = "BEliminarClientes";
            BEliminarClientes.Size = new Size(59, 52);
            BEliminarClientes.TabIndex = 25;
            BEliminarClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarClientes.UseVisualStyleBackColor = false;
            BEliminarClientes.Click += BEliminarClientes_Click;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(78, 209);
            TabControlListaClientes.Margin = new Padding(3, 2, 3, 2);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(710, 331);
            TabControlListaClientes.TabIndex = 71;
            // 
            // TabPageListaCliente
            // 
            TabPageListaCliente.Controls.Add(DataGridViewListarClientes);
            TabPageListaCliente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCliente.ForeColor = Color.White;
            TabPageListaCliente.Location = new Point(4, 26);
            TabPageListaCliente.Margin = new Padding(3, 2, 3, 2);
            TabPageListaCliente.Name = "TabPageListaCliente";
            TabPageListaCliente.Padding = new Padding(3, 2, 3, 2);
            TabPageListaCliente.Size = new Size(702, 301);
            TabPageListaCliente.TabIndex = 0;
            TabPageListaCliente.Text = "Lista de Clientes";
            TabPageListaCliente.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarClientes
            // 
            DataGridViewListarClientes.AllowUserToAddRows = false;
            DataGridViewListarClientes.AllowUserToDeleteRows = false;
            DataGridViewListarClientes.AllowUserToResizeColumns = false;
            DataGridViewListarClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewListarClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewListarClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewListarClientes.BorderStyle = BorderStyle.None;
            DataGridViewListarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarClientes.ColumnHeadersHeight = 20;
            DataGridViewListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Dni, Telefono, Direccion, Email, Estado });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DataGridViewListarClientes.DefaultCellStyle = dataGridViewCellStyle11;
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 2);
            DataGridViewListarClientes.Margin = new Padding(4);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.ReadOnly = true;
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarClientes.Size = new Size(696, 297);
            DataGridViewListarClientes.TabIndex = 6;
            DataGridViewListarClientes.RowHeaderMouseClick += DataGridViewListarClientes_RowHeaderMouseClick_1;
            // 
            // ID
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            ID.DefaultCellStyle = dataGridViewCellStyle3;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Dni
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Dni.DefaultCellStyle = dataGridViewCellStyle6;
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Telefono
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Telefono.DefaultCellStyle = dataGridViewCellStyle7;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            dataGridViewCellStyle8.ForeColor = Color.Black;
            Direccion.DefaultCellStyle = dataGridViewCellStyle8;
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Email
            // 
            dataGridViewCellStyle9.ForeColor = Color.Black;
            Email.DefaultCellStyle = dataGridViewCellStyle9;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Estado
            // 
            dataGridViewCellStyle10.ForeColor = Color.Black;
            Estado.DefaultCellStyle = dataGridViewCellStyle10;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(841, 394);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 92;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += BReactivar_Click;
            // 
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 577);
            Controls.Add(BReactivar);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BEliminarClientes);
            Controls.Add(BModificarCliente);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarClientes";
            Text = "Form1";
            Load += GestionarClientes_Load;
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
        }

        internal Button BModificarCliente;
        internal Button BImprimirClientes;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        internal Button BEliminarClientes;

        #endregion
        internal Label Label2;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaCliente;
        internal DataGridView DataGridViewListarClientes;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        internal Button BReactivar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Estado;
    }
}