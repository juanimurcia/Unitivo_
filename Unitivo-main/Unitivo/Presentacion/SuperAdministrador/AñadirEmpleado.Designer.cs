namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirEmpleado
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
            Label1 = new Label();
            Panel1 = new Panel();
            DateTimePickerFechaNacimiento = new DateTimePicker();
            label8 = new Label();
            BRegistrarEmpleado = new Button();
            TBCorreoEmpleado = new TextBox();
            Label7 = new Label();
            TBDireccionEmpleado = new TextBox();
            Label6 = new Label();
            TBTelEmpleado = new TextBox();
            Label5 = new Label();
            TBDniEmpleado = new TextBox();
            Label4 = new Label();
            TBApellidoEmpleado = new TextBox();
            Label3 = new Label();
            TBNombreEmpleado = new TextBox();
            Label2 = new Label();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            DataGridViewListarEmpleados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Panel1.SuspendLayout();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarEmpleados).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(48, 28);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(299, 37);
            Label1.TabIndex = 4;
            Label1.Text = "Registrar Empleado";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(DateTimePickerFechaNacimiento);
            Panel1.Controls.Add(label8);
            Panel1.Controls.Add(BRegistrarEmpleado);
            Panel1.Controls.Add(TBCorreoEmpleado);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccionEmpleado);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelEmpleado);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniEmpleado);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoEmpleado);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreEmpleado);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(46, 94);
            Panel1.Margin = new Padding(4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(377, 406);
            Panel1.TabIndex = 3;
            // 
            // DateTimePickerFechaNacimiento
            // 
            DateTimePickerFechaNacimiento.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            DateTimePickerFechaNacimiento.Location = new Point(186, 298);
            DateTimePickerFechaNacimiento.Margin = new Padding(4);
            DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento";
            DateTimePickerFechaNacimiento.Size = new Size(148, 24);
            DateTimePickerFechaNacimiento.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(40, 265);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 25);
            label8.TabIndex = 18;
            label8.Text = "Fecha Nacimiento :";
            // 
            // BRegistrarEmpleado
            // 
            BRegistrarEmpleado.BackColor = Color.DarkOliveGreen;
            BRegistrarEmpleado.FlatAppearance.BorderSize = 2;
            BRegistrarEmpleado.FlatStyle = FlatStyle.Flat;
            BRegistrarEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarEmpleado.ForeColor = Color.Cornsilk;
            BRegistrarEmpleado.Location = new Point(108, 349);
            BRegistrarEmpleado.Margin = new Padding(4);
            BRegistrarEmpleado.Name = "BRegistrarEmpleado";
            BRegistrarEmpleado.Size = new Size(155, 44);
            BRegistrarEmpleado.TabIndex = 17;
            BRegistrarEmpleado.Text = "Añadir";
            BRegistrarEmpleado.UseVisualStyleBackColor = false;
            BRegistrarEmpleado.Click += BRegistrarEmpleado_Click;
            // 
            // TBCorreoEmpleado
            // 
            TBCorreoEmpleado.Location = new Point(186, 227);
            TBCorreoEmpleado.Margin = new Padding(4);
            TBCorreoEmpleado.Name = "TBCorreoEmpleado";
            TBCorreoEmpleado.Size = new Size(148, 23);
            TBCorreoEmpleado.TabIndex = 16;
            TBCorreoEmpleado.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(40, 224);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(78, 25);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionEmpleado
            // 
            TBDireccionEmpleado.Location = new Point(186, 184);
            TBDireccionEmpleado.Margin = new Padding(4);
            TBDireccionEmpleado.Name = "TBDireccionEmpleado";
            TBDireccionEmpleado.Size = new Size(148, 23);
            TBDireccionEmpleado.TabIndex = 14;
            TBDireccionEmpleado.KeyPress += NumStr_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(40, 182);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 25);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelEmpleado
            // 
            TBTelEmpleado.Location = new Point(186, 143);
            TBTelEmpleado.Margin = new Padding(4);
            TBTelEmpleado.Name = "TBTelEmpleado";
            TBTelEmpleado.Size = new Size(148, 23);
            TBTelEmpleado.TabIndex = 12;
            TBTelEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(40, 140);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(100, 25);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniEmpleado
            // 
            TBDniEmpleado.Location = new Point(186, 102);
            TBDniEmpleado.Margin = new Padding(4);
            TBDniEmpleado.Name = "TBDniEmpleado";
            TBDniEmpleado.Size = new Size(148, 23);
            TBDniEmpleado.TabIndex = 10;
            TBDniEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(40, 98);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(56, 25);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoEmpleado
            // 
            TBApellidoEmpleado.Location = new Point(186, 60);
            TBApellidoEmpleado.Margin = new Padding(4);
            TBApellidoEmpleado.Name = "TBApellidoEmpleado";
            TBApellidoEmpleado.Size = new Size(148, 23);
            TBApellidoEmpleado.TabIndex = 8;
            TBApellidoEmpleado.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(40, 56);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(93, 25);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreEmpleado
            // 
            TBNombreEmpleado.Location = new Point(186, 16);
            TBNombreEmpleado.Margin = new Padding(4);
            TBNombreEmpleado.Name = "TBNombreEmpleado";
            TBNombreEmpleado.Size = new Size(148, 23);
            TBNombreEmpleado.TabIndex = 6;
            TBNombreEmpleado.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(40, 12);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(92, 25);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaEmpleados.Location = new Point(466, 64);
            TabControlListaEmpleados.Margin = new Padding(4, 2, 4, 2);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(449, 422);
            TabControlListaEmpleados.TabIndex = 13;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(DataGridViewListarEmpleados);
            TabPageListaEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 26);
            TabPageListaEmpleados.Margin = new Padding(4, 2, 4, 2);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(4, 2, 4, 2);
            TabPageListaEmpleados.Size = new Size(441, 392);
            TabPageListaEmpleados.TabIndex = 0;
            TabPageListaEmpleados.Text = "Lista de Empleados";
            TabPageListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarEmpleados
            // 
            DataGridViewListarEmpleados.AllowUserToAddRows = false;
            DataGridViewListarEmpleados.AllowUserToDeleteRows = false;
            DataGridViewListarEmpleados.AllowUserToResizeColumns = false;
            DataGridViewListarEmpleados.AllowUserToResizeRows = false;
            DataGridViewListarEmpleados.BackgroundColor = Color.RosyBrown;
            DataGridViewListarEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarEmpleados.ColumnHeadersHeight = 20;
            DataGridViewListarEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarEmpleados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarEmpleados.Dock = DockStyle.Fill;
            DataGridViewListarEmpleados.EnableHeadersVisualStyles = false;
            DataGridViewListarEmpleados.Location = new Point(4, 2);
            DataGridViewListarEmpleados.Margin = new Padding(4);
            DataGridViewListarEmpleados.Name = "DataGridViewListarEmpleados";
            DataGridViewListarEmpleados.ReadOnly = true;
            DataGridViewListarEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarEmpleados.RowHeadersWidth = 51;
            DataGridViewListarEmpleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewListarEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewListarEmpleados.Size = new Size(433, 388);
            DataGridViewListarEmpleados.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
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
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // AñadirEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 519);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AñadirEmpleado";
            Text = "Form1";
            Load += AñadirEmpleado_Load;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Panel Panel1;
        internal Button BRegistrarEmpleado;
        internal TextBox TBCorreoEmpleado;
        internal Label Label7;
        internal TextBox TBDireccionEmpleado;
        internal Label Label6;
        internal TextBox TBTelEmpleado;
        internal Label Label5;
        internal TextBox TBDniEmpleado;
        internal Label Label4;
        internal TextBox TBApellidoEmpleado;
        internal Label Label3;
        internal TextBox TBNombreEmpleado;
        internal Label Label2;
        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView DataGridViewListarEmpleados;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        internal Label label8;
        internal DateTimePicker DateTimePickerFechaNacimiento;
    }
}