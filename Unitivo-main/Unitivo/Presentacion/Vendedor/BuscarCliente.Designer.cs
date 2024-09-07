namespace Unitivo.Presentacion.Vendedor
{
    partial class BuscarCliente
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
            GroupBoxClientes = new GroupBox();
            Label2 = new Label();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            BSeleccionar = new Button();
            BCancelar = new Button();
            TabControlListaClientes = new TabControl();
            TabPageListaCliente = new TabPage();
            DataGridViewListarClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
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
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(92, 22);
            GroupBoxClientes.Margin = new Padding(4);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4);
            GroupBoxClientes.Size = new Size(540, 116);
            GroupBoxClientes.TabIndex = 2;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(39, 38);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 20);
            Label2.TabIndex = 6;
            Label2.Text = "Buscar por:";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(452, 46);
            BBuscar.Margin = new Padding(4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(52, 46);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(259, 56);
            TBBuscar.Margin = new Padding(4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(162, 31);
            TBBuscar.TabIndex = 1;
            TBBuscar.KeyPress += BuscarPorComboBox;
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.BackColor = SystemColors.Window;
            ComboBoxBuscarDni.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBuscarDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscarDni.Location = new Point(43, 58);
            ComboBoxBuscarDni.Margin = new Padding(4);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(174, 28);
            ComboBoxBuscarDni.TabIndex = 0;
            ComboBoxBuscarDni.SelectedValueChanged += ComboBoxBuscarDni_SelectedValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Location = new Point(0, 7);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 468);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Location = new Point(727, 6);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(9, 466);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOliveGreen;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 8);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOliveGreen;
            panel4.Location = new Point(0, 467);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 8);
            panel4.TabIndex = 7;
            // 
            // BSeleccionar
            // 
            BSeleccionar.BackColor = Color.DarkOliveGreen;
            BSeleccionar.FlatAppearance.BorderSize = 2;
            BSeleccionar.FlatStyle = FlatStyle.Flat;
            BSeleccionar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BSeleccionar.ForeColor = Color.Cornsilk;
            BSeleccionar.Location = new Point(389, 419);
            BSeleccionar.Margin = new Padding(4);
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.Size = new Size(158, 31);
            BSeleccionar.TabIndex = 67;
            BSeleccionar.Text = "Seleccionar";
            BSeleccionar.UseVisualStyleBackColor = false;
            BSeleccionar.Click += BSeleccionar_Click;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.Cornsilk;
            BCancelar.Location = new Point(190, 419);
            BCancelar.Margin = new Padding(4);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(158, 31);
            BCancelar.TabIndex = 68;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(35, 156);
            TabControlListaClientes.Margin = new Padding(3, 2, 3, 2);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(656, 230);
            TabControlListaClientes.TabIndex = 69;
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
            TabPageListaCliente.Size = new Size(648, 200);
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
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarClientes.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 2);
            DataGridViewListarClientes.Margin = new Padding(4);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.ReadOnly = true;
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarClientes.Size = new Size(642, 196);
            DataGridViewListarClientes.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(735, 476);
            ControlBox = false;
            Controls.Add(TabControlListaClientes);
            Controls.Add(BCancelar);
            Controls.Add(BSeleccionar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += BuscarCliente_Load;
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        internal Button BSeleccionar;
        internal Button BCancelar;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaCliente;
        internal DataGridView DataGridViewListarClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        internal Label Label2;
        private DataGridViewTextBoxColumn ID;
    }
}