namespace Unitivo.Presentacion.Vendedor
{
    partial class DetalleVenta
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TabDetalleVenta = new TabControl();
            TabPageDetalleVenta = new TabPage();
            dgvListaVentas = new DataGridView();
            BVolver = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            DGColor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            TabDetalleVenta.SuspendLayout();
            TabPageDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TabDetalleVenta
            // 
            TabDetalleVenta.Controls.Add(TabPageDetalleVenta);
            TabDetalleVenta.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabDetalleVenta.Location = new Point(32, 28);
            TabDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabDetalleVenta.Name = "TabDetalleVenta";
            TabDetalleVenta.SelectedIndex = 0;
            TabDetalleVenta.Size = new Size(900, 315);
            TabDetalleVenta.TabIndex = 59;
            // 
            // TabPageDetalleVenta
            // 
            TabPageDetalleVenta.Controls.Add(dgvListaVentas);
            TabPageDetalleVenta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageDetalleVenta.Location = new Point(4, 26);
            TabPageDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Name = "TabPageDetalleVenta";
            TabPageDetalleVenta.Padding = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Size = new Size(892, 285);
            TabPageDetalleVenta.TabIndex = 0;
            TabPageDetalleVenta.Text = "Detalle de Venta";
            TabPageDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.AllowUserToAddRows = false;
            dgvListaVentas.AllowUserToDeleteRows = false;
            dgvListaVentas.AllowUserToResizeColumns = false;
            dgvListaVentas.AllowUserToResizeRows = false;
            dgvListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaVentas.BackgroundColor = Color.RosyBrown;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Cantidad, Talle, DGColor, Categoria });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaVentas.Dock = DockStyle.Fill;
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(3, 2);
            dgvListaVentas.Margin = new Padding(4, 2, 4, 2);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(886, 281);
            dgvListaVentas.TabIndex = 56;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(405, 358);
            BVolver.Margin = new Padding(4);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(158, 31);
            BVolver.TabIndex = 71;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            BVolver.Click += BVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(957, 8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 400);
            panel1.TabIndex = 72;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 8);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(9, 400);
            panel2.TabIndex = 73;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Location = new Point(0, 464);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(966, 8);
            panel4.TabIndex = 75;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 8);
            panel3.TabIndex = 74;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(0, 403);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(966, 8);
            panel5.TabIndex = 75;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // DGColor
            // 
            DGColor.HeaderText = "Color";
            DGColor.Name = "DGColor";
            DGColor.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(967, 410);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BVolver);
            Controls.Add(TabDetalleVenta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += DetalleVenta_Load;
            TabDetalleVenta.ResumeLayout(false);
            TabPageDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal TabControl TabDetalleVenta;
        internal TabPage TabPageDetalleVenta;
        internal DataGridView dgvListaVentas;

        #endregion

        internal Button BVolver;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn DGColor;
        private DataGridViewTextBoxColumn Categoria;
    }
}