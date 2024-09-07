namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarTalles
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
            GroupBoxGestionTalles = new GroupBox();
            BBuscarTalle = new Button();
            TBBuscarTalle = new TextBox();
            BModificarTalle = new Button();
            BEliminarTalle = new Button();
            TabListaTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            dgvListarTalles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            TipoTalle = new DataGridViewTextBoxColumn();
            GroupBoxDatosTalles = new GroupBox();
            TBModTalle = new TextBox();
            button1 = new Button();
            LModTalle = new Label();
            BReactivar = new Button();
            GroupBoxGestionTalles.SuspendLayout();
            TabListaTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).BeginInit();
            GroupBoxDatosTalles.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionTalles
            // 
            GroupBoxGestionTalles.BackColor = Color.Cornsilk;
            GroupBoxGestionTalles.Controls.Add(BBuscarTalle);
            GroupBoxGestionTalles.Controls.Add(TBBuscarTalle);
            GroupBoxGestionTalles.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionTalles.ForeColor = Color.SaddleBrown;
            GroupBoxGestionTalles.Location = new Point(291, 25);
            GroupBoxGestionTalles.Margin = new Padding(4);
            GroupBoxGestionTalles.Name = "GroupBoxGestionTalles";
            GroupBoxGestionTalles.Padding = new Padding(4);
            GroupBoxGestionTalles.Size = new Size(372, 114);
            GroupBoxGestionTalles.TabIndex = 91;
            GroupBoxGestionTalles.TabStop = false;
            GroupBoxGestionTalles.Text = "Gestión de Talles";
            // 
            // BBuscarTalle
            // 
            BBuscarTalle.BackColor = Color.DarkOliveGreen;
            BBuscarTalle.FlatAppearance.BorderColor = Color.White;
            BBuscarTalle.FlatAppearance.BorderSize = 2;
            BBuscarTalle.FlatStyle = FlatStyle.Flat;
            BBuscarTalle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarTalle.ForeColor = Color.White;
            BBuscarTalle.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarTalle.Location = new Point(249, 45);
            BBuscarTalle.Margin = new Padding(4);
            BBuscarTalle.Name = "BBuscarTalle";
            BBuscarTalle.Size = new Size(57, 47);
            BBuscarTalle.TabIndex = 14;
            BBuscarTalle.UseVisualStyleBackColor = false;
            BBuscarTalle.Click += BBuscarTalle_Click;
            // 
            // TBBuscarTalle
            // 
            TBBuscarTalle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscarTalle.Location = new Point(57, 56);
            TBBuscarTalle.Margin = new Padding(4);
            TBBuscarTalle.Name = "TBBuscarTalle";
            TBBuscarTalle.Size = new Size(172, 26);
            TBBuscarTalle.TabIndex = 6;
            // 
            // BModificarTalle
            // 
            BModificarTalle.BackColor = Color.SteelBlue;
            BModificarTalle.FlatAppearance.BorderColor = Color.White;
            BModificarTalle.FlatAppearance.BorderSize = 2;
            BModificarTalle.FlatStyle = FlatStyle.Flat;
            BModificarTalle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarTalle.ForeColor = Color.White;
            BModificarTalle.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarTalle.Location = new Point(851, 225);
            BModificarTalle.Margin = new Padding(4);
            BModificarTalle.Name = "BModificarTalle";
            BModificarTalle.Size = new Size(59, 52);
            BModificarTalle.TabIndex = 89;
            BModificarTalle.UseVisualStyleBackColor = false;
            BModificarTalle.Click += BModificarTalle_Click;
            // 
            // BEliminarTalle
            // 
            BEliminarTalle.BackColor = Color.Brown;
            BEliminarTalle.FlatAppearance.BorderSize = 2;
            BEliminarTalle.FlatStyle = FlatStyle.Flat;
            BEliminarTalle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarTalle.ForeColor = Color.White;
            BEliminarTalle.Image = Properties.Resources.icons8_basura_26;
            BEliminarTalle.Location = new Point(851, 312);
            BEliminarTalle.Margin = new Padding(4);
            BEliminarTalle.Name = "BEliminarTalle";
            BEliminarTalle.Size = new Size(59, 52);
            BEliminarTalle.TabIndex = 88;
            BEliminarTalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarTalle.UseVisualStyleBackColor = false;
            BEliminarTalle.Click += BEliminarTalle_Click;
            // 
            // TabListaTalles
            // 
            TabListaTalles.Controls.Add(TabPageListaTalles);
            TabListaTalles.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabListaTalles.Location = new Point(86, 183);
            TabListaTalles.Margin = new Padding(3, 2, 3, 2);
            TabListaTalles.Name = "TabListaTalles";
            TabListaTalles.SelectedIndex = 0;
            TabListaTalles.Size = new Size(723, 202);
            TabListaTalles.TabIndex = 90;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(dgvListarTalles);
            TabPageListaTalles.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 26);
            TabPageListaTalles.Margin = new Padding(3, 2, 3, 2);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(3, 2, 3, 2);
            TabPageListaTalles.Size = new Size(715, 172);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // dgvListarTalles
            // 
            dgvListarTalles.AllowUserToAddRows = false;
            dgvListarTalles.AllowUserToDeleteRows = false;
            dgvListarTalles.AllowUserToResizeColumns = false;
            dgvListarTalles.AllowUserToResizeRows = false;
            dgvListarTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarTalles.BackgroundColor = Color.RosyBrown;
            dgvListarTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListarTalles.ColumnHeadersHeight = 20;
            dgvListarTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarTalles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado, TipoTalle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarTalles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListarTalles.Dock = DockStyle.Fill;
            dgvListarTalles.EnableHeadersVisualStyles = false;
            dgvListarTalles.Location = new Point(3, 2);
            dgvListarTalles.Margin = new Padding(4);
            dgvListarTalles.Name = "dgvListarTalles";
            dgvListarTalles.ReadOnly = true;
            dgvListarTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListarTalles.RowHeadersWidth = 51;
            dgvListarTalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListarTalles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListarTalles.Size = new Size(709, 168);
            dgvListarTalles.TabIndex = 3;
            dgvListarTalles.CellContentClick += dgvListarTalles_CellContentClick;
            dgvListarTalles.RowHeaderMouseClick += dgvListarTalles_RowHeaderMouseClick;
            dgvListarTalles.RowHeaderMouseDoubleClick += dgvListarTalles_RowHeaderMouseDoubleClick;
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
            // GroupBoxDatosTalles
            // 
            GroupBoxDatosTalles.BackColor = Color.RosyBrown;
            GroupBoxDatosTalles.Controls.Add(TBModTalle);
            GroupBoxDatosTalles.Controls.Add(button1);
            GroupBoxDatosTalles.Controls.Add(LModTalle);
            GroupBoxDatosTalles.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosTalles.ForeColor = Color.White;
            GroupBoxDatosTalles.Location = new Point(210, 416);
            GroupBoxDatosTalles.Margin = new Padding(4);
            GroupBoxDatosTalles.Name = "GroupBoxDatosTalles";
            GroupBoxDatosTalles.Padding = new Padding(4);
            GroupBoxDatosTalles.Size = new Size(525, 184);
            GroupBoxDatosTalles.TabIndex = 19;
            GroupBoxDatosTalles.TabStop = false;
            GroupBoxDatosTalles.Text = "Modificar Talle";
            GroupBoxDatosTalles.Enter += GroupBoxDatosTalles_Enter;
            // 
            // TBModTalle
            // 
            TBModTalle.Location = new Point(147, 53);
            TBModTalle.Margin = new Padding(4);
            TBModTalle.Name = "TBModTalle";
            TBModTalle.Size = new Size(248, 32);
            TBModTalle.TabIndex = 16;
            TBModTalle.TextChanged += TBModTalle_TextChanged;
            TBModTalle.KeyPress += Num_KeyPress;
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
            // LModTalle
            // 
            LModTalle.AutoSize = true;
            LModTalle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModTalle.ForeColor = Color.White;
            LModTalle.Location = new Point(11, 53);
            LModTalle.Margin = new Padding(7, 0, 7, 0);
            LModTalle.Name = "LModTalle";
            LModTalle.Size = new Size(125, 24);
            LModTalle.TabIndex = 15;
            LModTalle.Text = "Descripción : ";
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
            // GestionarTalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 634);
            Controls.Add(BReactivar);
            Controls.Add(GroupBoxDatosTalles);
            Controls.Add(GroupBoxGestionTalles);
            Controls.Add(BModificarTalle);
            Controls.Add(BEliminarTalle);
            Controls.Add(TabListaTalles);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarTalles";
            Text = "Form1";
            Load += GestionarTalles_Load;
            GroupBoxGestionTalles.ResumeLayout(false);
            GroupBoxGestionTalles.PerformLayout();
            TabListaTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).EndInit();
            GroupBoxDatosTalles.ResumeLayout(false);
            GroupBoxDatosTalles.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionTalles;
        internal Button BBuscarTalle;
        internal TextBox TBBuscarTalle;
        internal Button BModificarTalle;
        internal Button BEliminarTalle;
        internal TabControl TabListaTalles;
        internal TabPage TabPageListaTalles;

        #endregion
        internal GroupBox GroupBoxDatosTalles;
        internal TextBox TBModTalle;
        internal Button button1;
        internal Label LModTalle;
        internal DataGridView dgvListarTalles;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn TipoTalle;
        internal Button BReactivar;
    }
}