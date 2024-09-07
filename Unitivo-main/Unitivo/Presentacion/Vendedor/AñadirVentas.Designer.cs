using Unitivo.Properties;

namespace Unitivo.Formularios.Vendedor
{
    partial class AñadirVentas
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
            Label1 = new Label();
            TBVendedor = new TextBox();
            LVendedor = new Label();
            Fecha = new DateTimePicker();
            LFecha = new Label();
            LNumeroFactura = new Label();
            TBNroFactura = new TextBox();
            GroupBoxClientes = new GroupBox();
            Label5 = new Label();
            TBTelCliVenta = new TextBox();
            Label4 = new Label();
            TBApellidoCliVenta = new TextBox();
            Label3 = new Label();
            TBNombreCliVenta = new TextBox();
            Label2 = new Label();
            BBuscarCliente = new Button();
            TBDniCliVenta = new TextBox();
            GroupBoxArticulos = new GroupBox();
            BAñadir = new Button();
            Label10 = new Label();
            TBCantidad = new TextBox();
            Label6 = new Label();
            TBTalle = new TextBox();
            Label7 = new Label();
            TBStock = new TextBox();
            Label8 = new Label();
            TBPrecio = new TextBox();
            Label9 = new Label();
            BBuscarProducto = new Button();
            TBProductoVenta = new TextBox();
            dgvListaVentas = new DataGridView();
            LTotalVenta = new Label();
            TBTotal = new TextBox();
            BConfirmar = new Button();
            BModificarProducto = new Button();
            BEliminarProducto = new Button();
            label11 = new Label();
            label12 = new Label();
            TBColor = new TextBox();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            DGColor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            GroupBoxClientes.SuspendLayout();
            GroupBoxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.DarkOliveGreen;
            Label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.SeaShell;
            Label1.Location = new Point(318, 10);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(202, 37);
            Label1.TabIndex = 2;
            Label1.Text = "Nueva Venta";
            // 
            // TBVendedor
            // 
            TBVendedor.Enabled = false;
            TBVendedor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TBVendedor.Location = new Point(700, 83);
            TBVendedor.Margin = new Padding(6);
            TBVendedor.Name = "TBVendedor";
            TBVendedor.Size = new Size(152, 23);
            TBVendedor.TabIndex = 57;
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.BackColor = Color.SaddleBrown;
            LVendedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LVendedor.ForeColor = Color.White;
            LVendedor.Location = new Point(596, 86);
            LVendedor.Margin = new Padding(6, 0, 6, 0);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(83, 20);
            LVendedor.TabIndex = 60;
            LVendedor.Text = "Vendedor:";
            // 
            // Fecha
            // 
            Fecha.Enabled = false;
            Fecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Fecha.Format = DateTimePickerFormat.Short;
            Fecha.Location = new Point(423, 82);
            Fecha.Margin = new Padding(4);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(150, 23);
            Fecha.TabIndex = 59;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.SaddleBrown;
            LFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LFecha.ForeColor = Color.White;
            LFecha.Location = new Point(347, 86);
            LFecha.Margin = new Padding(6, 0, 6, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(58, 20);
            LFecha.TabIndex = 58;
            LFecha.Text = "Fecha:";
            // 
            // LNumeroFactura
            // 
            LNumeroFactura.AutoSize = true;
            LNumeroFactura.BackColor = Color.SaddleBrown;
            LNumeroFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNumeroFactura.ForeColor = Color.White;
            LNumeroFactura.Location = new Point(70, 84);
            LNumeroFactura.Margin = new Padding(6, 0, 6, 0);
            LNumeroFactura.Name = "LNumeroFactura";
            LNumeroFactura.Size = new Size(88, 20);
            LNumeroFactura.TabIndex = 55;
            LNumeroFactura.Text = "N° Factura:";
            // 
            // TBNroFactura
            // 
            TBNroFactura.CausesValidation = false;
            TBNroFactura.Enabled = false;
            TBNroFactura.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TBNroFactura.Location = new Point(182, 82);
            TBNroFactura.Margin = new Padding(6);
            TBNroFactura.Name = "TBNroFactura";
            TBNroFactura.Size = new Size(143, 23);
            TBNroFactura.TabIndex = 56;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.Cornsilk;
            GroupBoxClientes.Controls.Add(Label5);
            GroupBoxClientes.Controls.Add(TBTelCliVenta);
            GroupBoxClientes.Controls.Add(Label4);
            GroupBoxClientes.Controls.Add(TBApellidoCliVenta);
            GroupBoxClientes.Controls.Add(Label3);
            GroupBoxClientes.Controls.Add(TBNombreCliVenta);
            GroupBoxClientes.Controls.Add(Label2);
            GroupBoxClientes.Controls.Add(BBuscarCliente);
            GroupBoxClientes.Controls.Add(TBDniCliVenta);
            GroupBoxClientes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.SaddleBrown;
            GroupBoxClientes.Location = new Point(24, 140);
            GroupBoxClientes.Margin = new Padding(4);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4);
            GroupBoxClientes.Size = new Size(893, 122);
            GroupBoxClientes.TabIndex = 61;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(679, 39);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(79, 20);
            Label5.TabIndex = 9;
            Label5.Text = "Telefono :";
            // 
            // TBTelCliVenta
            // 
            TBTelCliVenta.Enabled = false;
            TBTelCliVenta.Location = new Point(683, 66);
            TBTelCliVenta.Margin = new Padding(4);
            TBTelCliVenta.Name = "TBTelCliVenta";
            TBTelCliVenta.Size = new Size(137, 31);
            TBTelCliVenta.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(510, 39);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(73, 20);
            Label4.TabIndex = 7;
            Label4.Text = "Apellido :";
            // 
            // TBApellidoCliVenta
            // 
            TBApellidoCliVenta.Enabled = false;
            TBApellidoCliVenta.Location = new Point(514, 66);
            TBApellidoCliVenta.Margin = new Padding(4);
            TBApellidoCliVenta.Name = "TBApellidoCliVenta";
            TBApellidoCliVenta.Size = new Size(137, 31);
            TBApellidoCliVenta.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(340, 39);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(73, 20);
            Label3.TabIndex = 5;
            Label3.Text = "Nombre :";
            // 
            // TBNombreCliVenta
            // 
            TBNombreCliVenta.Enabled = false;
            TBNombreCliVenta.Location = new Point(346, 66);
            TBNombreCliVenta.Margin = new Padding(4);
            TBNombreCliVenta.Name = "TBNombreCliVenta";
            TBNombreCliVenta.Size = new Size(137, 31);
            TBNombreCliVenta.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(78, 39);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(45, 20);
            Label2.TabIndex = 3;
            Label2.Text = "DNI :";
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.BackColor = Color.DarkOliveGreen;
            BBuscarCliente.ForeColor = Color.White;
            BBuscarCliente.Image = Resources.icons8_búsqueda_26;
            BBuscarCliente.Location = new Point(255, 58);
            BBuscarCliente.Margin = new Padding(4);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(52, 46);
            BBuscarCliente.TabIndex = 2;
            BBuscarCliente.UseVisualStyleBackColor = false;
            BBuscarCliente.Click += BBuscarCliente_Click;
            // 
            // TBDniCliVenta
            // 
            TBDniCliVenta.Enabled = false;
            TBDniCliVenta.Location = new Point(83, 66);
            TBDniCliVenta.Margin = new Padding(4);
            TBDniCliVenta.Name = "TBDniCliVenta";
            TBDniCliVenta.Size = new Size(137, 31);
            TBDniCliVenta.TabIndex = 1;
            TBDniCliVenta.KeyPress += Num_KeyPress;
            // 
            // GroupBoxArticulos
            // 
            GroupBoxArticulos.BackColor = Color.Cornsilk;
            GroupBoxArticulos.Controls.Add(TBColor);
            GroupBoxArticulos.Controls.Add(label12);
            GroupBoxArticulos.Controls.Add(BAñadir);
            GroupBoxArticulos.Controls.Add(Label10);
            GroupBoxArticulos.Controls.Add(TBCantidad);
            GroupBoxArticulos.Controls.Add(Label6);
            GroupBoxArticulos.Controls.Add(TBTalle);
            GroupBoxArticulos.Controls.Add(Label7);
            GroupBoxArticulos.Controls.Add(TBStock);
            GroupBoxArticulos.Controls.Add(Label8);
            GroupBoxArticulos.Controls.Add(TBPrecio);
            GroupBoxArticulos.Controls.Add(Label9);
            GroupBoxArticulos.Controls.Add(BBuscarProducto);
            GroupBoxArticulos.Controls.Add(TBProductoVenta);
            GroupBoxArticulos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxArticulos.ForeColor = Color.SaddleBrown;
            GroupBoxArticulos.Location = new Point(24, 283);
            GroupBoxArticulos.Margin = new Padding(4);
            GroupBoxArticulos.Name = "GroupBoxArticulos";
            GroupBoxArticulos.Padding = new Padding(4);
            GroupBoxArticulos.Size = new Size(893, 122);
            GroupBoxArticulos.TabIndex = 62;
            GroupBoxArticulos.TabStop = false;
            GroupBoxArticulos.Text = "Articulos";
            // 
            // BAñadir
            // 
            BAñadir.BackColor = Color.DarkOliveGreen;
            BAñadir.ForeColor = Color.White;
            BAñadir.Image = Resources.add_32;
            BAñadir.Location = new Point(824, 55);
            BAñadir.Margin = new Padding(4);
            BAñadir.Name = "BAñadir";
            BAñadir.Size = new Size(52, 46);
            BAñadir.TabIndex = 12;
            BAñadir.UseVisualStyleBackColor = false;
            BAñadir.Click += BAñadir_Click;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label10.ForeColor = Color.SaddleBrown;
            Label10.Location = new Point(704, 40);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(81, 20);
            Label10.TabIndex = 11;
            Label10.Text = "Cantidad :";
            // 
            // TBCantidad
            // 
            TBCantidad.Enabled = false;
            TBCantidad.Location = new Point(704, 67);
            TBCantidad.Margin = new Padding(4);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(93, 31);
            TBCantidad.TabIndex = 10;
            TBCantidad.KeyPress += Num_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(480, 40);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(50, 20);
            Label6.TabIndex = 9;
            Label6.Text = "Talle :";
            // 
            // TBTalle
            // 
            TBTalle.Enabled = false;
            TBTalle.Location = new Point(480, 67);
            TBTalle.Margin = new Padding(4);
            TBTalle.Name = "TBTalle";
            TBTalle.Size = new Size(93, 31);
            TBTalle.TabIndex = 8;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.SaddleBrown;
            Label7.Location = new Point(364, 40);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(58, 20);
            Label7.TabIndex = 7;
            Label7.Text = "Stock :";
            // 
            // TBStock
            // 
            TBStock.Enabled = false;
            TBStock.Location = new Point(364, 67);
            TBStock.Margin = new Padding(4);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(93, 31);
            TBStock.TabIndex = 6;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label8.ForeColor = Color.SaddleBrown;
            Label8.Location = new Point(247, 40);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(61, 20);
            Label8.TabIndex = 5;
            Label8.Text = "Precio :";
            // 
            // TBPrecio
            // 
            TBPrecio.Enabled = false;
            TBPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecio.Location = new Point(247, 67);
            TBPrecio.Margin = new Padding(4);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(96, 26);
            TBPrecio.TabIndex = 4;
            TBPrecio.Text = "$";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label9.ForeColor = Color.SaddleBrown;
            Label9.Location = new Point(17, 39);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(67, 20);
            Label9.TabIndex = 3;
            Label9.Text = "Codigo :";
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(178, 52);
            BBuscarProducto.Margin = new Padding(4);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(52, 46);
            BBuscarProducto.TabIndex = 2;
            BBuscarProducto.UseVisualStyleBackColor = false;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TBProductoVenta
            // 
            TBProductoVenta.Enabled = false;
            TBProductoVenta.Location = new Point(17, 64);
            TBProductoVenta.Margin = new Padding(4);
            TBProductoVenta.Name = "TBProductoVenta";
            TBProductoVenta.Size = new Size(137, 31);
            TBProductoVenta.TabIndex = 1;
            TBProductoVenta.KeyPress += Num_KeyPress;
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.AllowUserToAddRows = false;
            dgvListaVentas.AllowUserToDeleteRows = false;
            dgvListaVentas.AllowUserToResizeColumns = false;
            dgvListaVentas.AllowUserToResizeRows = false;
            dgvListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaVentas.BackgroundColor = Color.Tan;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Talle, DGColor, Cantidad });
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(24, 428);
            dgvListaVentas.Margin = new Padding(4, 2, 4, 2);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(804, 161);
            dgvListaVentas.TabIndex = 63;
            // 
            // LTotalVenta
            // 
            LTotalVenta.AutoSize = true;
            LTotalVenta.BackColor = Color.Cornsilk;
            LTotalVenta.FlatStyle = FlatStyle.Flat;
            LTotalVenta.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LTotalVenta.ForeColor = Color.SaddleBrown;
            LTotalVenta.Location = new Point(59, 614);
            LTotalVenta.Margin = new Padding(6, 0, 6, 0);
            LTotalVenta.Name = "LTotalVenta";
            LTotalVenta.Size = new Size(66, 25);
            LTotalVenta.TabIndex = 64;
            LTotalVenta.Text = "Total:";
            // 
            // TBTotal
            // 
            TBTotal.BackColor = Color.Cornsilk;
            TBTotal.Enabled = false;
            TBTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBTotal.Location = new Point(166, 615);
            TBTotal.Margin = new Padding(6);
            TBTotal.Name = "TBTotal";
            TBTotal.Size = new Size(99, 26);
            TBTotal.TabIndex = 65;
            // 
            // BConfirmar
            // 
            BConfirmar.BackColor = Color.DarkOliveGreen;
            BConfirmar.FlatAppearance.BorderSize = 2;
            BConfirmar.FlatStyle = FlatStyle.Flat;
            BConfirmar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BConfirmar.ForeColor = Color.Cornsilk;
            BConfirmar.Location = new Point(618, 614);
            BConfirmar.Margin = new Padding(4);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(158, 44);
            BConfirmar.TabIndex = 66;
            BConfirmar.Text = "Confirmar";
            BConfirmar.UseVisualStyleBackColor = false;
            BConfirmar.Click += BConfirmar_Click;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.SteelBlue;
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(848, 454);
            BModificarProducto.Margin = new Padding(4);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(59, 52);
            BModificarProducto.TabIndex = 69;
            BModificarProducto.UseVisualStyleBackColor = false;
            BModificarProducto.Click += BModificarProducto_Click;
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(848, 524);
            BEliminarProducto.Margin = new Padding(4);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(59, 52);
            BEliminarProducto.TabIndex = 68;
            BEliminarProducto.UseVisualStyleBackColor = false;
            BEliminarProducto.Click += BEliminarProducto_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(134, 606);
            label11.Name = "label11";
            label11.Size = new Size(32, 37);
            label11.TabIndex = 70;
            label11.Text = "$";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.SaddleBrown;
            label12.Location = new Point(596, 39);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 13;
            label12.Text = "Color :";
            label12.Click += label12_Click;
            // 
            // TBColor
            // 
            TBColor.Enabled = false;
            TBColor.Location = new Point(594, 67);
            TBColor.Margin = new Padding(4);
            TBColor.Name = "TBColor";
            TBColor.Size = new Size(93, 31);
            TBColor.TabIndex = 14;
            //TBColor.TextChanged += this.TBColor_TextChanged;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
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
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // AñadirVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(945, 681);
            Controls.Add(TBTotal);
            Controls.Add(label11);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            Controls.Add(BConfirmar);
            Controls.Add(LTotalVenta);
            Controls.Add(dgvListaVentas);
            Controls.Add(GroupBoxArticulos);
            Controls.Add(GroupBoxClientes);
            Controls.Add(TBVendedor);
            Controls.Add(LVendedor);
            Controls.Add(Fecha);
            Controls.Add(LFecha);
            Controls.Add(LNumeroFactura);
            Controls.Add(TBNroFactura);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AñadirVentas";
            Text = "Form1";
            Load += AñadirVentas_Load;
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            GroupBoxArticulos.ResumeLayout(false);
            GroupBoxArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal TextBox TBVendedor;
        internal Label LVendedor;
        internal DateTimePicker Fecha;
        internal Label LFecha;
        internal Label LNumeroFactura;
        internal TextBox TBNroFactura;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscarCliente;
        internal TextBox TBDniCliVenta;
        internal Label Label2;
        internal Label Label5;
        internal TextBox TBTelCliVenta;
        internal Label Label4;
        internal TextBox TBApellidoCliVenta;
        internal Label Label3;
        internal TextBox TBNombreCliVenta;
        internal GroupBox GroupBoxArticulos;
        internal Label Label10;
        internal TextBox TBCantidad;
        internal Label Label6;
        internal TextBox TBTalle;
        internal Label Label7;
        internal TextBox TBStock;
        internal Label Label8;
        internal TextBox TBPrecio;
        internal Label Label9;
        internal Button BBuscarProducto;
        internal TextBox TBProductoVenta;
        internal DataGridView dgvListaVentas;
        internal Label LTotalVenta;
        internal TextBox TBTotal;
        internal Button BConfirmar;
        internal Button BModificarProducto;
        internal Button BEliminarProducto;
        internal Button BAñadir;
        private Label label11;
        internal TextBox TBColor;
        internal Label label12;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn DGColor;
        private DataGridViewTextBoxColumn Cantidad;
    }

    #endregion
}