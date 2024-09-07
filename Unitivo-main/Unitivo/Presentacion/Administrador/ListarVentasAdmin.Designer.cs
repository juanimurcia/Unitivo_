namespace Unitivo.Presentacion.Administrador
{
    partial class ListarVentasAdmin
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
            GroupBoxBuscarProducto = new GroupBox();
            label3 = new Label();
            DateTimeHasta = new DateTimePicker();
            Label2 = new Label();
            BVerDetalle = new Button();
            Label1 = new Label();
            BBuscarVenta = new Button();
            DateTimeDesde = new DateTimePicker();
            TBBuscar = new TextBox();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaVentas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(label3);
            GroupBoxBuscarProducto.Controls.Add(DateTimeHasta);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(BVerDetalle);
            GroupBoxBuscarProducto.Controls.Add(Label1);
            GroupBoxBuscarProducto.Controls.Add(BBuscarVenta);
            GroupBoxBuscarProducto.Controls.Add(DateTimeDesde);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(42, 21);
            GroupBoxBuscarProducto.Margin = new Padding(4);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4);
            GroupBoxBuscarProducto.Size = new Size(861, 103);
            GroupBoxBuscarProducto.TabIndex = 70;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(409, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 18);
            label3.TabIndex = 34;
            label3.Text = "Buscar Por Vendedor:";
            // 
            // DateTimeHasta
            // 
            DateTimeHasta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeHasta.Format = DateTimePickerFormat.Short;
            DateTimeHasta.Location = new Point(239, 51);
            DateTimeHasta.Margin = new Padding(4);
            DateTimeHasta.Name = "DateTimeHasta";
            DateTimeHasta.Size = new Size(123, 24);
            DateTimeHasta.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(235, 28);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 18);
            Label2.TabIndex = 32;
            Label2.Text = "Fecha Fin:";
            // 
            // BVerDetalle
            // 
            BVerDetalle.BackColor = Color.Sienna;
            BVerDetalle.FlatAppearance.BorderSize = 2;
            BVerDetalle.FlatStyle = FlatStyle.Flat;
            BVerDetalle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BVerDetalle.ForeColor = Color.White;
            BVerDetalle.Location = new Point(685, 37);
            BVerDetalle.Margin = new Padding(4);
            BVerDetalle.Name = "BVerDetalle";
            BVerDetalle.Size = new Size(130, 49);
            BVerDetalle.TabIndex = 27;
            BVerDetalle.Text = "Ver Detalle";
            BVerDetalle.TextImageRelation = TextImageRelation.TextBeforeImage;
            BVerDetalle.UseVisualStyleBackColor = false;
            BVerDetalle.Click += BVerDetalle_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(87, 28);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(91, 18);
            Label1.TabIndex = 31;
            Label1.Text = "Fecha Inicio:";
            // 
            // BBuscarVenta
            // 
            BBuscarVenta.BackColor = Color.DarkOliveGreen;
            BBuscarVenta.FlatAppearance.BorderColor = Color.White;
            BBuscarVenta.FlatAppearance.BorderSize = 2;
            BBuscarVenta.FlatStyle = FlatStyle.Flat;
            BBuscarVenta.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarVenta.ForeColor = Color.White;
            BBuscarVenta.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarVenta.Location = new Point(582, 40);
            BBuscarVenta.Margin = new Padding(4);
            BBuscarVenta.Name = "BBuscarVenta";
            BBuscarVenta.Size = new Size(59, 44);
            BBuscarVenta.TabIndex = 14;
            BBuscarVenta.UseVisualStyleBackColor = false;
            BBuscarVenta.Click += BBuscarVenta_Click;
            // 
            // DateTimeDesde
            // 
            DateTimeDesde.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeDesde.Format = DateTimePickerFormat.Short;
            DateTimeDesde.Location = new Point(90, 51);
            DateTimeDesde.Margin = new Padding(4);
            DateTimeDesde.Name = "DateTimeDesde";
            DateTimeDesde.Size = new Size(120, 24);
            DateTimeDesde.TabIndex = 30;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(409, 47);
            TBBuscar.Margin = new Padding(4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(152, 27);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += NumStr_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(42, 146);
            TabControlListaProductos.Margin = new Padding(3, 2, 3, 2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(861, 337);
            TabControlListaProductos.TabIndex = 69;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaVentas);
            TabPageListaProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 26);
            TabPageListaProducto.Margin = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Size = new Size(853, 307);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Ventas";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaVentas
            // 
            DataGridViewListaVentas.AllowUserToAddRows = false;
            DataGridViewListaVentas.AllowUserToDeleteRows = false;
            DataGridViewListaVentas.AllowUserToResizeColumns = false;
            DataGridViewListaVentas.AllowUserToResizeRows = false;
            DataGridViewListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaVentas.BackgroundColor = Color.RosyBrown;
            DataGridViewListaVentas.BorderStyle = BorderStyle.None;
            DataGridViewListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListaVentas.ColumnHeadersHeight = 20;
            DataGridViewListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaVentas.Columns.AddRange(new DataGridViewColumn[] { ID, Fecha, Cliente, Vendedor, Total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListaVentas.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListaVentas.Dock = DockStyle.Fill;
            DataGridViewListaVentas.EnableHeadersVisualStyles = false;
            DataGridViewListaVentas.Location = new Point(3, 2);
            DataGridViewListaVentas.Margin = new Padding(4);
            DataGridViewListaVentas.Name = "DataGridViewListaVentas";
            DataGridViewListaVentas.ReadOnly = true;
            DataGridViewListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListaVentas.RowHeadersWidth = 51;
            DataGridViewListaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListaVentas.Size = new Size(847, 303);
            DataGridViewListaVentas.TabIndex = 5;
            DataGridViewListaVentas.CellContentClick += DataGridViewListaVentas_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "N° Factura";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // ListarVentasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 577);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ListarVentasAdmin";
            Text = "Form1";
            Load += ListarVentasAdmin_Load;
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxBuscarProducto;
        internal DateTimePicker DateTimeHasta;
        internal Label Label2;
        internal Button BVerDetalle;
        internal Label Label1;
        internal Button BBuscarVenta;
        internal DateTimePicker DateTimeDesde;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaVentas;

        #endregion

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Total;
        internal Label label3;
    }
}