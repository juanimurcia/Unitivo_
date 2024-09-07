namespace Unitivo.Presentacion.Vendedor
{
    partial class ListarClientes
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            GroupBoxClientes = new GroupBox();
            Label2 = new Label();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscar = new ComboBox();
            BEditarCliente = new Button();
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
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(Label2);
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscar);
            GroupBoxClientes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(182, 38);
            GroupBoxClientes.Margin = new Padding(4, 3, 4, 3);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4, 3, 4, 3);
            GroupBoxClientes.Size = new Size(540, 115);
            GroupBoxClientes.TabIndex = 0;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(43, 34);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 20);
            Label2.TabIndex = 32;
            Label2.Text = "Buscar por :";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(453, 47);
            BBuscar.Margin = new Padding(4, 3, 4, 3);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(52, 46);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(228, 52);
            TBBuscar.Margin = new Padding(4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(193, 31);
            TBBuscar.TabIndex = 1;
            TBBuscar.KeyPress += BuscarPorComboBox;
            // 
            // ComboBoxBuscar
            // 
            ComboBoxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscar.ForeColor = Color.SaddleBrown;
            ComboBoxBuscar.FormattingEnabled = true;
            ComboBoxBuscar.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscar.Location = new Point(43, 56);
            ComboBoxBuscar.Margin = new Padding(4);
            ComboBoxBuscar.Name = "ComboBoxBuscar";
            ComboBoxBuscar.Size = new Size(147, 28);
            ComboBoxBuscar.TabIndex = 0;
            ComboBoxBuscar.SelectedValueChanged += ComboBoxBuscar_SelectedValueChanged;
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.SteelBlue;
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCliente.Location = new Point(830, 303);
            BEditarCliente.Margin = new Padding(4);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Size = new Size(59, 52);
            BEditarCliente.TabIndex = 4;
            BEditarCliente.UseVisualStyleBackColor = false;
            BEditarCliente.Click += BEditarCliente_Click;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(69, 200);
            TabControlListaClientes.Margin = new Padding(3, 2, 3, 2);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(710, 230);
            TabControlListaClientes.TabIndex = 70;
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
            TabPageListaCliente.Size = new Size(702, 200);
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
            DataGridViewListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewListarClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewListarClientes.BorderStyle = BorderStyle.None;
            DataGridViewListarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarClientes.ColumnHeadersHeight = 20;
            DataGridViewListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Dni, Telefono, Direccion, Email });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DataGridViewListarClientes.DefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 2);
            DataGridViewListarClientes.Margin = new Padding(4);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.ReadOnly = true;
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarClientes.Size = new Size(696, 196);
            DataGridViewListarClientes.TabIndex = 6;
            // 
            // ID
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Apellido.DefaultCellStyle = dataGridViewCellStyle4;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Dni
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Dni.DefaultCellStyle = dataGridViewCellStyle5;
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Telefono
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Telefono.DefaultCellStyle = dataGridViewCellStyle6;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Direccion.DefaultCellStyle = dataGridViewCellStyle7;
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Email
            // 
            dataGridViewCellStyle8.ForeColor = Color.Black;
            Email.DefaultCellStyle = dataGridViewCellStyle8;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(933, 519);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BEditarCliente);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListarClientes";
            Text = "Form1";
            Load += ListarClientes_Load;
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscar;
        internal TabPage TabPageListaClientes;
        internal DataGridView DgvListarClientes;
        internal Button BEditarCliente;
        internal Button BVolver;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaCliente;
        internal DataGridView DataGridViewListarClientes;
        internal Label Label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
    }

    #endregion
}
