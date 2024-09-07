namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirCategoria
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
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            DataGridViewListarCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            TipoTalle = new DataGridViewTextBoxColumn();
            PanelRegCategoria = new Panel();
            label1 = new Label();
            CBTipoTalle = new ComboBox();
            BRegistrarCategoria = new Button();
            TBNombreCategoria = new TextBox();
            LNombreCategoria = new Label();
            TabControlRegCategoria.SuspendLayout();
            TabPageListaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarCategorias).BeginInit();
            PanelRegCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegCategoria.Location = new Point(155, 200);
            TabControlRegCategoria.Margin = new Padding(2);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(624, 279);
            TabControlRegCategoria.TabIndex = 37;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(DataGridViewListarCategorias);
            TabPageListaCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 26);
            TabPageListaCategoria.Margin = new Padding(2);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2);
            TabPageListaCategoria.Size = new Size(616, 249);
            TabPageListaCategoria.TabIndex = 0;
            TabPageListaCategoria.Text = "Lista de Categorias";
            TabPageListaCategoria.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarCategorias
            // 
            DataGridViewListarCategorias.AllowUserToAddRows = false;
            DataGridViewListarCategorias.AllowUserToDeleteRows = false;
            DataGridViewListarCategorias.AllowUserToResizeColumns = false;
            DataGridViewListarCategorias.AllowUserToResizeRows = false;
            DataGridViewListarCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarCategorias.BackgroundColor = Color.RosyBrown;
            DataGridViewListarCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarCategorias.ColumnHeadersHeight = 20;
            DataGridViewListarCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, TipoTalle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarCategorias.Dock = DockStyle.Fill;
            DataGridViewListarCategorias.EnableHeadersVisualStyles = false;
            DataGridViewListarCategorias.Location = new Point(2, 2);
            DataGridViewListarCategorias.Margin = new Padding(2);
            DataGridViewListarCategorias.Name = "DataGridViewListarCategorias";
            DataGridViewListarCategorias.ReadOnly = true;
            DataGridViewListarCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarCategorias.RowHeadersWidth = 51;
            DataGridViewListarCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarCategorias.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarCategorias.RowTemplate.Height = 24;
            DataGridViewListarCategorias.Size = new Size(612, 245);
            DataGridViewListarCategorias.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripcion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // TipoTalle
            // 
            TipoTalle.HeaderText = "Tipo de talle";
            TipoTalle.MinimumWidth = 6;
            TipoTalle.Name = "TipoTalle";
            TipoTalle.ReadOnly = true;
            // 
            // PanelRegCategoria
            // 
            PanelRegCategoria.BackColor = Color.Cornsilk;
            PanelRegCategoria.BackgroundImageLayout = ImageLayout.None;
            PanelRegCategoria.Controls.Add(label1);
            PanelRegCategoria.Controls.Add(CBTipoTalle);
            PanelRegCategoria.Controls.Add(BRegistrarCategoria);
            PanelRegCategoria.Controls.Add(TBNombreCategoria);
            PanelRegCategoria.Controls.Add(LNombreCategoria);
            PanelRegCategoria.Location = new Point(188, 29);
            PanelRegCategoria.Margin = new Padding(4, 3, 4, 3);
            PanelRegCategoria.Name = "PanelRegCategoria";
            PanelRegCategoria.Size = new Size(550, 133);
            PanelRegCategoria.TabIndex = 36;
            PanelRegCategoria.Paint += PanelRegCategoria_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 95);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 39;
            label1.Text = "Seleccione el tipo de talle:";
            label1.Click += label1_Click;
            // 
            // CBTipoTalle
            // 
            CBTipoTalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTipoTalle.FormattingEnabled = true;
            CBTipoTalle.Location = new Point(186, 92);
            CBTipoTalle.Name = "CBTipoTalle";
            CBTipoTalle.Size = new Size(159, 23);
            CBTipoTalle.TabIndex = 38;
            CBTipoTalle.SelectedIndexChanged += CBTipoTalle_SelectedIndexChanged;
            // 
            // BRegistrarCategoria
            // 
            BRegistrarCategoria.BackColor = Color.DarkOliveGreen;
            BRegistrarCategoria.FlatAppearance.BorderColor = Color.White;
            BRegistrarCategoria.FlatAppearance.BorderSize = 2;
            BRegistrarCategoria.FlatStyle = FlatStyle.Flat;
            BRegistrarCategoria.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarCategoria.ForeColor = Color.White;
            BRegistrarCategoria.Location = new Point(395, 55);
            BRegistrarCategoria.Margin = new Padding(4, 3, 4, 3);
            BRegistrarCategoria.Name = "BRegistrarCategoria";
            BRegistrarCategoria.Size = new Size(114, 48);
            BRegistrarCategoria.TabIndex = 13;
            BRegistrarCategoria.Text = "Añadir";
            BRegistrarCategoria.UseVisualStyleBackColor = false;
            BRegistrarCategoria.Click += BRegistrarCategoria_Click;
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreCategoria.Location = new Point(20, 55);
            TBNombreCategoria.Margin = new Padding(4, 3, 4, 3);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(325, 26);
            TBNombreCategoria.TabIndex = 6;
            TBNombreCategoria.KeyPress += String_KeyPress;
            // 
            // LNombreCategoria
            // 
            LNombreCategoria.AutoSize = true;
            LNombreCategoria.BackColor = Color.Cornsilk;
            LNombreCategoria.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCategoria.ForeColor = Color.DarkOrange;
            LNombreCategoria.Location = new Point(20, 12);
            LNombreCategoria.Margin = new Padding(4, 0, 4, 0);
            LNombreCategoria.Name = "LNombreCategoria";
            LNombreCategoria.Size = new Size(258, 29);
            LNombreCategoria.TabIndex = 0;
            LNombreCategoria.Text = "Nombre de Categoria :";
            // 
            // AñadirCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(933, 577);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(PanelRegCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirCategoria";
            Text = "Form1";
            Load += AñadirCategoria_Load;
            TabControlRegCategoria.ResumeLayout(false);
            TabPageListaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarCategorias).EndInit();
            PanelRegCategoria.ResumeLayout(false);
            PanelRegCategoria.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegCategoria;
        internal TabPage TabPageListaCategoria;
        internal DataGridView DataGridViewListarCategorias;
        internal Panel PanelRegCategoria;
        internal Button BRegistrarCategoria;
        internal TextBox TBNombreCategoria;
        internal Label LNombreCategoria;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox CBTipoTalle;
        private DataGridViewTextBoxColumn TipoTalle;
        private Label label1;
    }
}