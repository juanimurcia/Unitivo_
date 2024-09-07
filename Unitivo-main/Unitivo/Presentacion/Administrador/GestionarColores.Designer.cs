namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarColores
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
            GroupBoxGestionColores = new GroupBox();
            BBuscarColor = new Button();
            TBBuscarColor = new TextBox();
            BModificarColor = new Button();
            BEliminarColor = new Button();
            TabListaColores = new TabControl();
            TabPageListaColores = new TabPage();
            dgvListarColores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GroupBoxDatosColores = new GroupBox();
            TBModColor = new TextBox();
            button1 = new Button();
            LModColor = new Label();
            BReactivar = new Button();
            GroupBoxGestionColores.SuspendLayout();
            TabListaColores.SuspendLayout();
            TabPageListaColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarColores).BeginInit();
            GroupBoxDatosColores.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionColores
            // 
            GroupBoxGestionColores.BackColor = Color.Cornsilk;
            GroupBoxGestionColores.Controls.Add(BBuscarColor);
            GroupBoxGestionColores.Controls.Add(TBBuscarColor);
            GroupBoxGestionColores.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionColores.ForeColor = Color.SaddleBrown;
            GroupBoxGestionColores.Location = new Point(291, 25);
            GroupBoxGestionColores.Margin = new Padding(4);
            GroupBoxGestionColores.Name = "GroupBoxGestionColores";
            GroupBoxGestionColores.Padding = new Padding(4);
            GroupBoxGestionColores.Size = new Size(372, 114);
            GroupBoxGestionColores.TabIndex = 91;
            GroupBoxGestionColores.TabStop = false;
            GroupBoxGestionColores.Text = "Gestión de Colores";
            // 
            // BBuscarColor
            // 
            BBuscarColor.BackColor = Color.DarkOliveGreen;
            BBuscarColor.FlatAppearance.BorderColor = Color.White;
            BBuscarColor.FlatAppearance.BorderSize = 2;
            BBuscarColor.FlatStyle = FlatStyle.Flat;
            BBuscarColor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarColor.ForeColor = Color.White;
            BBuscarColor.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarColor.Location = new Point(249, 45);
            BBuscarColor.Margin = new Padding(4);
            BBuscarColor.Name = "BBuscarColor";
            BBuscarColor.Size = new Size(57, 47);
            BBuscarColor.TabIndex = 14;
            BBuscarColor.UseVisualStyleBackColor = false;
            BBuscarColor.Click += BBuscarColor_Click;
            // 
            // TBBuscarColor
            // 
            TBBuscarColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscarColor.Location = new Point(57, 56);
            TBBuscarColor.Margin = new Padding(4);
            TBBuscarColor.Name = "TBBuscarColor";
            TBBuscarColor.Size = new Size(172, 26);
            TBBuscarColor.TabIndex = 6;
            TBBuscarColor.KeyPress += String_KeyPress;
            // 
            // BModificarColor
            // 
            BModificarColor.BackColor = Color.SteelBlue;
            BModificarColor.FlatAppearance.BorderColor = Color.White;
            BModificarColor.FlatAppearance.BorderSize = 2;
            BModificarColor.FlatStyle = FlatStyle.Flat;
            BModificarColor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarColor.ForeColor = Color.White;
            BModificarColor.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarColor.Location = new Point(851, 225);
            BModificarColor.Margin = new Padding(4);
            BModificarColor.Name = "BModificarColor";
            BModificarColor.Size = new Size(59, 52);
            BModificarColor.TabIndex = 89;
            BModificarColor.UseVisualStyleBackColor = false;
            BModificarColor.Click += BModificarColor_Click;
            // 
            // BEliminarColor
            // 
            BEliminarColor.BackColor = Color.Brown;
            BEliminarColor.FlatAppearance.BorderSize = 2;
            BEliminarColor.FlatStyle = FlatStyle.Flat;
            BEliminarColor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarColor.ForeColor = Color.White;
            BEliminarColor.Image = Properties.Resources.icons8_basura_26;
            BEliminarColor.Location = new Point(851, 312);
            BEliminarColor.Margin = new Padding(4);
            BEliminarColor.Name = "BEliminarColor";
            BEliminarColor.Size = new Size(59, 52);
            BEliminarColor.TabIndex = 88;
            BEliminarColor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarColor.UseVisualStyleBackColor = false;
            BEliminarColor.Click += BEliminarColor_Click;
            // 
            // TabListaColores
            // 
            TabListaColores.Controls.Add(TabPageListaColores);
            TabListaColores.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabListaColores.Location = new Point(86, 183);
            TabListaColores.Margin = new Padding(3, 2, 3, 2);
            TabListaColores.Name = "TabListaColores";
            TabListaColores.SelectedIndex = 0;
            TabListaColores.Size = new Size(723, 202);
            TabListaColores.TabIndex = 90;
            // 
            // TabPageListaColores
            // 
            TabPageListaColores.Controls.Add(dgvListarColores);
            TabPageListaColores.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaColores.ForeColor = Color.White;
            TabPageListaColores.Location = new Point(4, 26);
            TabPageListaColores.Margin = new Padding(3, 2, 3, 2);
            TabPageListaColores.Name = "TabPageListaColores";
            TabPageListaColores.Padding = new Padding(3, 2, 3, 2);
            TabPageListaColores.Size = new Size(715, 172);
            TabPageListaColores.TabIndex = 0;
            TabPageListaColores.Text = "Lista de Colores";
            TabPageListaColores.UseVisualStyleBackColor = true;
            // 
            // dgvListarColores
            // 
            dgvListarColores.AllowUserToAddRows = false;
            dgvListarColores.AllowUserToDeleteRows = false;
            dgvListarColores.AllowUserToResizeColumns = false;
            dgvListarColores.AllowUserToResizeRows = false;
            dgvListarColores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarColores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarColores.BackgroundColor = Color.RosyBrown;
            dgvListarColores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListarColores.ColumnHeadersHeight = 20;
            dgvListarColores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarColores.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarColores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListarColores.Dock = DockStyle.Fill;
            dgvListarColores.EnableHeadersVisualStyles = false;
            dgvListarColores.Location = new Point(3, 2);
            dgvListarColores.Margin = new Padding(4);
            dgvListarColores.Name = "dgvListarColores";
            dgvListarColores.ReadOnly = true;
            dgvListarColores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarColores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListarColores.RowHeadersWidth = 51;
            dgvListarColores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListarColores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListarColores.Size = new Size(709, 168);
            dgvListarColores.TabIndex = 3;
            dgvListarColores.CellContentClick += dgvListarColores_CellContentClick;
            dgvListarColores.RowHeaderMouseClick += dgvListarColores_RowHeaderMouseClick;
            dgvListarColores.RowHeaderMouseDoubleClick += dgvListarColores_RowHeaderMouseDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // GroupBoxDatosColores
            // 
            GroupBoxDatosColores.BackColor = Color.RosyBrown;
            GroupBoxDatosColores.Controls.Add(TBModColor);
            GroupBoxDatosColores.Controls.Add(button1);
            GroupBoxDatosColores.Controls.Add(LModColor);
            GroupBoxDatosColores.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosColores.ForeColor = Color.White;
            GroupBoxDatosColores.Location = new Point(210, 416);
            GroupBoxDatosColores.Margin = new Padding(4);
            GroupBoxDatosColores.Name = "GroupBoxDatosColores";
            GroupBoxDatosColores.Padding = new Padding(4);
            GroupBoxDatosColores.Size = new Size(525, 184);
            GroupBoxDatosColores.TabIndex = 19;
            GroupBoxDatosColores.TabStop = false;
            GroupBoxDatosColores.Text = "Modificar Color";
            GroupBoxDatosColores.Enter += GroupBoxDatosColores_Enter;
            // 
            // TBModColor
            // 
            TBModColor.Location = new Point(147, 53);
            TBModColor.Margin = new Padding(4);
            TBModColor.Name = "TBModColor";
            TBModColor.Size = new Size(248, 32);
            TBModColor.TabIndex = 16;
            TBModColor.TextChanged += TBModColor_TextChanged;
            TBModColor.KeyPress += String_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(403, 54);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 13;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LModColor
            // 
            LModColor.AutoSize = true;
            LModColor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModColor.ForeColor = Color.White;
            LModColor.Location = new Point(11, 53);
            LModColor.Margin = new Padding(7, 0, 7, 0);
            LModColor.Name = "LModColor";
            LModColor.Size = new Size(125, 24);
            LModColor.TabIndex = 15;
            LModColor.Text = "Descripción : ";
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(851, 312);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 93;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += BReactivar_Click;
            // 
            // GestionarColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 634);
            Controls.Add(BReactivar);
            Controls.Add(GroupBoxDatosColores);
            Controls.Add(GroupBoxGestionColores);
            Controls.Add(BModificarColor);
            Controls.Add(BEliminarColor);
            Controls.Add(TabListaColores);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarColores";
            Text = "Form1";
            Load += GestionarColores_Load;
            GroupBoxGestionColores.ResumeLayout(false);
            GroupBoxGestionColores.PerformLayout();
            TabListaColores.ResumeLayout(false);
            TabPageListaColores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarColores).EndInit();
            GroupBoxDatosColores.ResumeLayout(false);
            GroupBoxDatosColores.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionColores;
        internal Button BBuscarColor;
        internal TextBox TBBuscarColor;
        internal Button BModificarColor;
        internal Button BEliminarColor;
        internal TabControl TabListaColores;
        internal TabPage TabPageListaColores;

        #endregion
        internal GroupBox GroupBoxDatosColores;
        internal TextBox TBModColor;
        internal Button button1;
        internal Label LModColor;
        internal DataGridView dgvListarColores;
        internal Button BReactivar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}