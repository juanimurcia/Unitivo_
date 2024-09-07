namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirTalle
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
            TabControlRegTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            DataGridViewListarTalles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            tipoTalle = new DataGridViewTextBoxColumn();
            PanelRegTalles = new Panel();
            label1 = new Label();
            BRegistrarTalle = new Button();
            CBTipoTalle = new ComboBox();
            TBNombreTalle = new TextBox();
            LNombreTalle = new Label();
            TabControlRegTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarTalles).BeginInit();
            PanelRegTalles.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegTalles
            // 
            TabControlRegTalles.Controls.Add(TabPageListaTalles);
            TabControlRegTalles.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegTalles.Location = new Point(155, 190);
            TabControlRegTalles.Margin = new Padding(3, 2, 3, 2);
            TabControlRegTalles.Name = "TabControlRegTalles";
            TabControlRegTalles.SelectedIndex = 0;
            TabControlRegTalles.Size = new Size(624, 279);
            TabControlRegTalles.TabIndex = 40;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(DataGridViewListarTalles);
            TabPageListaTalles.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 26);
            TabPageListaTalles.Margin = new Padding(3, 2, 3, 2);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(3, 2, 3, 2);
            TabPageListaTalles.Size = new Size(616, 249);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarTalles
            // 
            DataGridViewListarTalles.AllowUserToAddRows = false;
            DataGridViewListarTalles.AllowUserToDeleteRows = false;
            DataGridViewListarTalles.AllowUserToResizeColumns = false;
            DataGridViewListarTalles.AllowUserToResizeRows = false;
            DataGridViewListarTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarTalles.BackgroundColor = Color.RosyBrown;
            DataGridViewListarTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarTalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarTalles.ColumnHeadersHeight = 20;
            DataGridViewListarTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarTalles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado, tipoTalle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarTalles.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarTalles.Dock = DockStyle.Fill;
            DataGridViewListarTalles.EnableHeadersVisualStyles = false;
            DataGridViewListarTalles.Location = new Point(3, 2);
            DataGridViewListarTalles.Margin = new Padding(3, 2, 3, 2);
            DataGridViewListarTalles.Name = "DataGridViewListarTalles";
            DataGridViewListarTalles.ReadOnly = true;
            DataGridViewListarTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarTalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarTalles.RowHeadersWidth = 51;
            DataGridViewListarTalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarTalles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarTalles.RowTemplate.Height = 24;
            DataGridViewListarTalles.Size = new Size(610, 245);
            DataGridViewListarTalles.TabIndex = 0;
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
            // tipoTalle
            // 
            tipoTalle.HeaderText = "Tipo de Talle";
            tipoTalle.MinimumWidth = 6;
            tipoTalle.Name = "tipoTalle";
            tipoTalle.ReadOnly = true;
            // 
            // PanelRegTalles
            // 
            PanelRegTalles.BackColor = Color.Cornsilk;
            PanelRegTalles.BackgroundImageLayout = ImageLayout.None;
            PanelRegTalles.Controls.Add(label1);
            PanelRegTalles.Controls.Add(BRegistrarTalle);
            PanelRegTalles.Controls.Add(CBTipoTalle);
            PanelRegTalles.Controls.Add(TBNombreTalle);
            PanelRegTalles.Controls.Add(LNombreTalle);
            PanelRegTalles.Location = new Point(203, 28);
            PanelRegTalles.Margin = new Padding(4);
            PanelRegTalles.Name = "PanelRegTalles";
            PanelRegTalles.Size = new Size(549, 129);
            PanelRegTalles.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 92);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 42;
            label1.Text = "Seleccione el tipo de talle:";
            // 
            // BRegistrarTalle
            // 
            BRegistrarTalle.BackColor = Color.DarkOliveGreen;
            BRegistrarTalle.FlatAppearance.BorderColor = Color.White;
            BRegistrarTalle.FlatAppearance.BorderSize = 2;
            BRegistrarTalle.FlatStyle = FlatStyle.Flat;
            BRegistrarTalle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarTalle.ForeColor = Color.White;
            BRegistrarTalle.Location = new Point(395, 56);
            BRegistrarTalle.Margin = new Padding(4);
            BRegistrarTalle.Name = "BRegistrarTalle";
            BRegistrarTalle.Size = new Size(115, 49);
            BRegistrarTalle.TabIndex = 13;
            BRegistrarTalle.Text = "Añadir";
            BRegistrarTalle.UseVisualStyleBackColor = false;
            BRegistrarTalle.Click += BRegistrarTalle_Click;
            // 
            // CBTipoTalle
            // 
            CBTipoTalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTipoTalle.FormattingEnabled = true;
            CBTipoTalle.Location = new Point(190, 89);
            CBTipoTalle.Name = "CBTipoTalle";
            CBTipoTalle.Size = new Size(176, 23);
            CBTipoTalle.TabIndex = 41;
            CBTipoTalle.SelectedIndexChanged += CBTipoTalle_SelectedIndexChanged_1;
            // 
            // TBNombreTalle
            // 
            TBNombreTalle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreTalle.Location = new Point(33, 56);
            TBNombreTalle.Margin = new Padding(4);
            TBNombreTalle.Name = "TBNombreTalle";
            TBNombreTalle.Size = new Size(325, 26);
            TBNombreTalle.TabIndex = 6;
            TBNombreTalle.TextChanged += TBNombreTalle_TextChanged;
            TBNombreTalle.KeyPress += Num_KeyPress;
            // 
            // LNombreTalle
            // 
            LNombreTalle.AutoSize = true;
            LNombreTalle.BackColor = Color.Cornsilk;
            LNombreTalle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreTalle.ForeColor = Color.DarkOrange;
            LNombreTalle.Location = new Point(20, 11);
            LNombreTalle.Margin = new Padding(4, 0, 4, 0);
            LNombreTalle.Name = "LNombreTalle";
            LNombreTalle.Size = new Size(208, 29);
            LNombreTalle.TabIndex = 0;
            LNombreTalle.Text = "Nombre de Talle :";
            // 
            // AñadirTalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(934, 577);
            Controls.Add(TabControlRegTalles);
            Controls.Add(PanelRegTalles);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AñadirTalle";
            Text = "Form1";
            Load += AñadirTalle_Load;
            TabControlRegTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarTalles).EndInit();
            PanelRegTalles.ResumeLayout(false);
            PanelRegTalles.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegTalles;
        internal TabPage TabPageListaTalles;
        internal DataGridView DataGridViewListarTalles;
        internal Panel PanelRegTalles;
        internal Button BRegistrarTalle;
        internal TextBox TBNombreTalle;
        internal Label LNombreTalle;

        #endregion

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private Label label1;
        private ComboBox CBTipoTalle;
        private DataGridViewTextBoxColumn tipoTalle;
    }
}