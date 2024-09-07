namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarCategorias
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
            GroupBoxGestionCategorias = new GroupBox();
            BBuscarCategoria = new Button();
            TBGestionCategoria = new TextBox();
            BModificarCategoria = new Button();
            BEliminarCategoria = new Button();
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            dgvRegistroCategoria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            TipoTalle = new DataGridViewTextBoxColumn();
            GroupBoxDatosCategoria = new GroupBox();
            TBNombreCategoria = new TextBox();
            button1 = new Button();
            LModCategoria = new Label();
            BReactivar = new Button();
            GroupBoxGestionCategorias.SuspendLayout();
            TabControlRegCategoria.SuspendLayout();
            TabPageListaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).BeginInit();
            GroupBoxDatosCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionCategorias
            // 
            GroupBoxGestionCategorias.BackColor = Color.Cornsilk;
            GroupBoxGestionCategorias.Controls.Add(BBuscarCategoria);
            GroupBoxGestionCategorias.Controls.Add(TBGestionCategoria);
            GroupBoxGestionCategorias.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionCategorias.ForeColor = Color.SaddleBrown;
            GroupBoxGestionCategorias.Location = new Point(270, 22);
            GroupBoxGestionCategorias.Margin = new Padding(4);
            GroupBoxGestionCategorias.Name = "GroupBoxGestionCategorias";
            GroupBoxGestionCategorias.Padding = new Padding(4);
            GroupBoxGestionCategorias.Size = new Size(372, 114);
            GroupBoxGestionCategorias.TabIndex = 27;
            GroupBoxGestionCategorias.TabStop = false;
            GroupBoxGestionCategorias.Text = "Gestión de Categorias";
            // 
            // BBuscarCategoria
            // 
            BBuscarCategoria.BackColor = Color.DarkOliveGreen;
            BBuscarCategoria.FlatAppearance.BorderColor = Color.White;
            BBuscarCategoria.FlatAppearance.BorderSize = 2;
            BBuscarCategoria.FlatStyle = FlatStyle.Flat;
            BBuscarCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarCategoria.ForeColor = Color.White;
            BBuscarCategoria.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarCategoria.Location = new Point(249, 45);
            BBuscarCategoria.Margin = new Padding(4);
            BBuscarCategoria.Name = "BBuscarCategoria";
            BBuscarCategoria.Size = new Size(57, 47);
            BBuscarCategoria.TabIndex = 14;
            BBuscarCategoria.UseVisualStyleBackColor = false;
            BBuscarCategoria.Click += BBuscarCategoria_Click;
            // 
            // TBGestionCategoria
            // 
            TBGestionCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionCategoria.Location = new Point(57, 56);
            TBGestionCategoria.Margin = new Padding(4);
            TBGestionCategoria.Name = "TBGestionCategoria";
            TBGestionCategoria.Size = new Size(172, 26);
            TBGestionCategoria.TabIndex = 6;
            TBGestionCategoria.KeyPress += String_KeyPress;
            // 
            // BModificarCategoria
            // 
            BModificarCategoria.BackColor = Color.SteelBlue;
            BModificarCategoria.FlatAppearance.BorderColor = Color.White;
            BModificarCategoria.FlatAppearance.BorderSize = 2;
            BModificarCategoria.FlatStyle = FlatStyle.Flat;
            BModificarCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarCategoria.ForeColor = Color.White;
            BModificarCategoria.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarCategoria.Location = new Point(836, 210);
            BModificarCategoria.Margin = new Padding(4);
            BModificarCategoria.Name = "BModificarCategoria";
            BModificarCategoria.Size = new Size(59, 52);
            BModificarCategoria.TabIndex = 25;
            BModificarCategoria.UseVisualStyleBackColor = false;
            BModificarCategoria.Click += BModificarCategoria_Click;
            // 
            // BEliminarCategoria
            // 
            BEliminarCategoria.BackColor = Color.Brown;
            BEliminarCategoria.FlatAppearance.BorderSize = 2;
            BEliminarCategoria.FlatStyle = FlatStyle.Flat;
            BEliminarCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarCategoria.ForeColor = Color.White;
            BEliminarCategoria.Image = Properties.Resources.icons8_basura_26;
            BEliminarCategoria.Location = new Point(836, 297);
            BEliminarCategoria.Margin = new Padding(4);
            BEliminarCategoria.Name = "BEliminarCategoria";
            BEliminarCategoria.Size = new Size(59, 52);
            BEliminarCategoria.TabIndex = 24;
            BEliminarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarCategoria.UseVisualStyleBackColor = false;
            BEliminarCategoria.Click += BEliminarCategoria_Click;
            // 
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegCategoria.Location = new Point(55, 164);
            TabControlRegCategoria.Margin = new Padding(2);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(733, 216);
            TabControlRegCategoria.TabIndex = 88;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(dgvRegistroCategoria);
            TabPageListaCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 26);
            TabPageListaCategoria.Margin = new Padding(2);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2);
            TabPageListaCategoria.Size = new Size(725, 186);
            TabPageListaCategoria.TabIndex = 0;
            TabPageListaCategoria.Text = "Lista de Categorias";
            TabPageListaCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroCategoria
            // 
            dgvRegistroCategoria.AllowUserToAddRows = false;
            dgvRegistroCategoria.AllowUserToDeleteRows = false;
            dgvRegistroCategoria.AllowUserToResizeColumns = false;
            dgvRegistroCategoria.AllowUserToResizeRows = false;
            dgvRegistroCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroCategoria.BackgroundColor = Color.RosyBrown;
            dgvRegistroCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistroCategoria.ColumnHeadersHeight = 20;
            dgvRegistroCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroCategoria.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado, TipoTalle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistroCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistroCategoria.Dock = DockStyle.Fill;
            dgvRegistroCategoria.EnableHeadersVisualStyles = false;
            dgvRegistroCategoria.Location = new Point(2, 2);
            dgvRegistroCategoria.Margin = new Padding(2);
            dgvRegistroCategoria.Name = "dgvRegistroCategoria";
            dgvRegistroCategoria.ReadOnly = true;
            dgvRegistroCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistroCategoria.RowHeadersWidth = 51;
            dgvRegistroCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroCategoria.RowTemplate.Height = 24;
            dgvRegistroCategoria.Size = new Size(721, 182);
            dgvRegistroCategoria.TabIndex = 0;
            dgvRegistroCategoria.CellContentClick += dgvRegistroCategoria_CellContentClick;
            dgvRegistroCategoria.RowHeaderMouseClick += dgvRegistroCategoria_RowHeaderMouseClick;
            dgvRegistroCategoria.RowHeaderMouseDoubleClick += dgvRegistroCategoria_RowHeaderMouseDoubleClick;
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
            // TipoTalle
            // 
            TipoTalle.HeaderText = "Tipo de Talle";
            TipoTalle.MinimumWidth = 6;
            TipoTalle.Name = "TipoTalle";
            TipoTalle.ReadOnly = true;
            // 
            // GroupBoxDatosCategoria
            // 
            GroupBoxDatosCategoria.BackColor = Color.RosyBrown;
            GroupBoxDatosCategoria.Controls.Add(TBNombreCategoria);
            GroupBoxDatosCategoria.Controls.Add(button1);
            GroupBoxDatosCategoria.Controls.Add(LModCategoria);
            GroupBoxDatosCategoria.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCategoria.ForeColor = Color.White;
            GroupBoxDatosCategoria.Location = new Point(151, 439);
            GroupBoxDatosCategoria.Margin = new Padding(4);
            GroupBoxDatosCategoria.Name = "GroupBoxDatosCategoria";
            GroupBoxDatosCategoria.Padding = new Padding(4);
            GroupBoxDatosCategoria.Size = new Size(574, 152);
            GroupBoxDatosCategoria.TabIndex = 19;
            GroupBoxDatosCategoria.TabStop = false;
            GroupBoxDatosCategoria.Text = "Modificar Categoria";
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Location = new Point(152, 69);
            TBNombreCategoria.Margin = new Padding(4);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(273, 32);
            TBNombreCategoria.TabIndex = 16;
            TBNombreCategoria.KeyPress += String_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(451, 63);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 13;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LModCategoria
            // 
            LModCategoria.AutoSize = true;
            LModCategoria.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModCategoria.ForeColor = Color.White;
            LModCategoria.Location = new Point(9, 69);
            LModCategoria.Margin = new Padding(7, 0, 7, 0);
            LModCategoria.Name = "LModCategoria";
            LModCategoria.Size = new Size(125, 24);
            LModCategoria.TabIndex = 15;
            LModCategoria.Text = "Descripción : ";
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(836, 297);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 92;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += button2_Click;
            // 
            // GestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 634);
            Controls.Add(BReactivar);
            Controls.Add(GroupBoxDatosCategoria);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(GroupBoxGestionCategorias);
            Controls.Add(BModificarCategoria);
            Controls.Add(BEliminarCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarCategorias";
            Text = "Form1";
            Load += GestionarCategorias_Load;
            GroupBoxGestionCategorias.ResumeLayout(false);
            GroupBoxGestionCategorias.PerformLayout();
            TabControlRegCategoria.ResumeLayout(false);
            TabPageListaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).EndInit();
            GroupBoxDatosCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionCategorias;
        internal Button BBuscarCategoria;
        internal TextBox TBGestionCategoria;
        internal Button BModificarCategoria;
        internal Button BEliminarCategoria;

        #endregion

        internal TabControl TabControlRegCategoria;
        internal TabPage TabPageListaCategoria;
        internal DataGridView dgvRegistroCategoria;
        internal GroupBox GroupBoxDatosCategoria;
        internal TextBox TBNombreCategoria;
        internal Button button1;
        internal Label LModCategoria;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn TipoTalle;
        internal Button BReactivar;
    }
}