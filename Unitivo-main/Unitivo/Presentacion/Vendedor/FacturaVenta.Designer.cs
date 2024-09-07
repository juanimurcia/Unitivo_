namespace Unitivo.Presentacion.Vendedor
{
    partial class FacturaVenta
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            TabDetalleVenta = new TabControl();
            TabPageDetalleVenta = new TabPage();
            dgvListaVentas = new DataGridView();
            panel2 = new Panel();
            ltotal = new Label();
            label10 = new Label();
            label9 = new Label();
            ldniVendedor = new Label();
            ldniCliente = new Label();
            label8 = new Label();
            label7 = new Label();
            lcliente = new Label();
            label6 = new Label();
            lvendedor = new Label();
            lfecha = new Label();
            nFactura = new Label();
            BImprimir = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            Label5 = new Label();
            label1 = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            DGColor = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
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
            TabDetalleVenta.Location = new Point(28, 226);
            TabDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabDetalleVenta.Name = "TabDetalleVenta";
            TabDetalleVenta.SelectedIndex = 0;
            TabDetalleVenta.Size = new Size(697, 256);
            TabDetalleVenta.TabIndex = 60;
            // 
            // TabPageDetalleVenta
            // 
            TabPageDetalleVenta.Controls.Add(dgvListaVentas);
            TabPageDetalleVenta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageDetalleVenta.Location = new Point(4, 26);
            TabPageDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Name = "TabPageDetalleVenta";
            TabPageDetalleVenta.Padding = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Size = new Size(689, 226);
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
            dgvListaVentas.BackgroundColor = Color.WhiteSmoke;
            dgvListaVentas.BorderStyle = BorderStyle.None;
            dgvListaVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Cantidad, Talle, DGColor, Subtotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = Color.SeaGreen;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvListaVentas.DefaultCellStyle = dataGridViewCellStyle8;
            dgvListaVentas.Dock = DockStyle.Fill;
            dgvListaVentas.Enabled = false;
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(3, 2);
            dgvListaVentas.Margin = new Padding(4, 2, 4, 2);
            dgvListaVentas.MultiSelect = false;
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvListaVentas.RowHeadersVisible = false;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dgvListaVentas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.ShowCellErrors = false;
            dgvListaVentas.ShowCellToolTips = false;
            dgvListaVentas.ShowEditingIcon = false;
            dgvListaVentas.ShowRowErrors = false;
            dgvListaVentas.Size = new Size(683, 222);
            dgvListaVentas.TabIndex = 56;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ltotal);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(ldniVendedor);
            panel2.Controls.Add(ldniCliente);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lcliente);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lvendedor);
            panel2.Controls.Add(lfecha);
            panel2.Controls.Add(nFactura);
            panel2.Controls.Add(BImprimir);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TabDetalleVenta);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 556);
            panel2.TabIndex = 61;
            panel2.Paint += panel2_Paint;
            // 
            // ltotal
            // 
            ltotal.AutoSize = true;
            ltotal.ForeColor = Color.Black;
            ltotal.Location = new Point(516, 514);
            ltotal.Name = "ltotal";
            ltotal.Size = new Size(34, 15);
            ltotal.TabIndex = 79;
            ltotal.Text = "ltotal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(574, 209);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 85;
            label10.Text = "dni:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(390, 209);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 84;
            label9.Text = "dni:";
            // 
            // ldniVendedor
            // 
            ldniVendedor.AutoSize = true;
            ldniVendedor.ForeColor = Color.Black;
            ldniVendedor.Location = new Point(417, 209);
            ldniVendedor.Name = "ldniVendedor";
            ldniVendedor.Size = new Size(77, 15);
            ldniVendedor.TabIndex = 83;
            ldniVendedor.Text = "ldniVendedor";
            // 
            // ldniCliente
            // 
            ldniCliente.AutoSize = true;
            ldniCliente.ForeColor = Color.Black;
            ldniCliente.Location = new Point(601, 209);
            ldniCliente.Name = "ldniCliente";
            ldniCliente.Size = new Size(64, 15);
            ldniCliente.TabIndex = 82;
            ldniCliente.Text = "ldniCliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(234, 90);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(182, 20);
            label8.TabIndex = 81;
            label8.Text = "Dirección: San Juan 596";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(234, 18);
            label7.Name = "label7";
            label7.Size = new Size(108, 36);
            label7.TabIndex = 80;
            label7.Text = "Unitivo";
            // 
            // lcliente
            // 
            lcliente.AutoSize = true;
            lcliente.ForeColor = Color.Black;
            lcliente.Location = new Point(573, 183);
            lcliente.Name = "lcliente";
            lcliente.Size = new Size(45, 15);
            lcliente.TabIndex = 78;
            lcliente.Text = "lcliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(573, 152);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 77;
            label6.Text = "Cliente:";
            // 
            // lvendedor
            // 
            lvendedor.AutoSize = true;
            lvendedor.ForeColor = Color.Black;
            lvendedor.Location = new Point(389, 184);
            lvendedor.Name = "lvendedor";
            lvendedor.Size = new Size(60, 15);
            lvendedor.TabIndex = 76;
            lvendedor.Text = "lvendedor";
            // 
            // lfecha
            // 
            lfecha.AutoSize = true;
            lfecha.ForeColor = Color.Black;
            lfecha.Location = new Point(234, 183);
            lfecha.Name = "lfecha";
            lfecha.Size = new Size(39, 15);
            lfecha.TabIndex = 75;
            lfecha.Text = "lfecha";
            // 
            // nFactura
            // 
            nFactura.AutoSize = true;
            nFactura.ForeColor = Color.Black;
            nFactura.Location = new Point(80, 183);
            nFactura.Name = "nFactura";
            nFactura.Size = new Size(53, 15);
            nFactura.TabIndex = 74;
            nFactura.Text = "nFactura";
            // 
            // BImprimir
            // 
            BImprimir.BackColor = Color.DimGray;
            BImprimir.ForeColor = Color.White;
            BImprimir.Image = Properties.Resources.icons8_imprimir_26;
            BImprimir.Location = new Point(32, 501);
            BImprimir.Margin = new Padding(4);
            BImprimir.Name = "BImprimir";
            BImprimir.Size = new Size(41, 37);
            BImprimir.TabIndex = 73;
            BImprimir.UseVisualStyleBackColor = false;
            BImprimir.Click += BImprimir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(389, 153);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 71;
            label4.Text = "Vendedor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(234, 153);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 69;
            label3.Text = "Fecha: ";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logounitivo;
            panel1.Location = new Point(37, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 100);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 152);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 67;
            label2.Text = "N° Factura: ";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.Black;
            Label5.Location = new Point(452, 509);
            Label5.Margin = new Padding(7, 0, 7, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(61, 24);
            Label5.TabIndex = 65;
            Label5.Text = "Total: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(234, 54);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 61;
            label1.Text = "FACTURA";
            // 
            // Codigo
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
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
            // Precio
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Precio.DefaultCellStyle = dataGridViewCellStyle4;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Talle
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Talle.DefaultCellStyle = dataGridViewCellStyle6;
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
            // Subtotal
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Subtotal.DefaultCellStyle = dataGridViewCellStyle7;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // FacturaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(771, 574);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FacturaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TabDetalleVenta.ResumeLayout(false);
            TabPageDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        internal TabControl TabDetalleVenta;
        internal TabPage TabPageDetalleVenta;
        internal DataGridView dgvListaVentas;
        private Panel panel2;
        private Label label1;
        internal Label Label5;
        internal Label label2;
        internal Label label4;
        internal Label label3;
        private Panel panel1;
        internal Button BImprimir;
        private Label lcliente;
        internal Label label6;
        private Label lvendedor;
        private Label lfecha;
        private Label nFactura;
        private Label ltotal;
        internal Label label8;
        private Label label7;
        private Label ldniVendedor;
        private Label ldniCliente;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn DGColor;
        private DataGridViewTextBoxColumn Subtotal;
    }
}