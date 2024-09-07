namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirColor
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
            TabControlRegColor = new TabControl();
            TabPageListaColor = new TabPage();
            DataGridViewListarColor = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            PanelRegColor = new Panel();
            BRegistrarColor = new Button();
            TBNombreColor = new TextBox();
            LNombreColor = new Label();
            TabControlRegColor.SuspendLayout();
            TabPageListaColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarColor).BeginInit();
            PanelRegColor.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegColor
            // 
            TabControlRegColor.Controls.Add(TabPageListaColor);
            TabControlRegColor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegColor.Location = new Point(155, 200);
            TabControlRegColor.Margin = new Padding(2);
            TabControlRegColor.Name = "TabControlRegColor";
            TabControlRegColor.SelectedIndex = 0;
            TabControlRegColor.Size = new Size(624, 279);
            TabControlRegColor.TabIndex = 37;
            // 
            // TabPageListaColor
            // 
            TabPageListaColor.Controls.Add(DataGridViewListarColor);
            TabPageListaColor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaColor.ForeColor = Color.White;
            TabPageListaColor.Location = new Point(4, 26);
            TabPageListaColor.Margin = new Padding(2);
            TabPageListaColor.Name = "TabPageListaColor";
            TabPageListaColor.Padding = new Padding(2);
            TabPageListaColor.Size = new Size(616, 249);
            TabPageListaColor.TabIndex = 0;
            TabPageListaColor.Text = "Lista de Colores";
            TabPageListaColor.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarColor
            // 
            DataGridViewListarColor.AllowUserToAddRows = false;
            DataGridViewListarColor.AllowUserToDeleteRows = false;
            DataGridViewListarColor.AllowUserToResizeColumns = false;
            DataGridViewListarColor.AllowUserToResizeRows = false;
            DataGridViewListarColor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarColor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarColor.BackgroundColor = Color.RosyBrown;
            DataGridViewListarColor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarColor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarColor.ColumnHeadersHeight = 20;
            DataGridViewListarColor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarColor.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarColor.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarColor.Dock = DockStyle.Fill;
            DataGridViewListarColor.EnableHeadersVisualStyles = false;
            DataGridViewListarColor.Location = new Point(2, 2);
            DataGridViewListarColor.Margin = new Padding(2);
            DataGridViewListarColor.Name = "DataGridViewListarColor";
            DataGridViewListarColor.ReadOnly = true;
            DataGridViewListarColor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarColor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarColor.RowHeadersWidth = 51;
            DataGridViewListarColor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarColor.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarColor.RowTemplate.Height = 24;
            DataGridViewListarColor.Size = new Size(612, 245);
            DataGridViewListarColor.TabIndex = 0;
            DataGridViewListarColor.CellContentClick += DataGridViewListarColores_CellContentClick;
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
            // PanelRegColor
            // 
            PanelRegColor.BackColor = Color.Cornsilk;
            PanelRegColor.BackgroundImageLayout = ImageLayout.None;
            PanelRegColor.Controls.Add(BRegistrarColor);
            PanelRegColor.Controls.Add(TBNombreColor);
            PanelRegColor.Controls.Add(LNombreColor);
            PanelRegColor.Location = new Point(188, 29);
            PanelRegColor.Margin = new Padding(4, 3, 4, 3);
            PanelRegColor.Name = "PanelRegColor";
            PanelRegColor.Size = new Size(550, 133);
            PanelRegColor.TabIndex = 36;
            PanelRegColor.Paint += PanelRegColor_Paint;
            // 
            // BRegistrarColor
            // 
            BRegistrarColor.BackColor = Color.DarkOliveGreen;
            BRegistrarColor.FlatAppearance.BorderColor = Color.White;
            BRegistrarColor.FlatAppearance.BorderSize = 2;
            BRegistrarColor.FlatStyle = FlatStyle.Flat;
            BRegistrarColor.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarColor.ForeColor = Color.White;
            BRegistrarColor.Location = new Point(395, 55);
            BRegistrarColor.Margin = new Padding(4, 3, 4, 3);
            BRegistrarColor.Name = "BRegistrarColor";
            BRegistrarColor.Size = new Size(114, 48);
            BRegistrarColor.TabIndex = 13;
            BRegistrarColor.Text = "Añadir";
            BRegistrarColor.UseVisualStyleBackColor = false;
            BRegistrarColor.Click += BRegistrarColor_Click;
            // 
            // TBNombreColor
            // 
            TBNombreColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreColor.Location = new Point(20, 55);
            TBNombreColor.Margin = new Padding(4, 3, 4, 3);
            TBNombreColor.Name = "TBNombreColor";
            TBNombreColor.Size = new Size(325, 26);
            TBNombreColor.TabIndex = 6;
            TBNombreColor.KeyPress += String_KeyPress;
            // 
            // LNombreColor
            // 
            LNombreColor.AutoSize = true;
            LNombreColor.BackColor = Color.Cornsilk;
            LNombreColor.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreColor.ForeColor = Color.DarkOrange;
            LNombreColor.Location = new Point(21, 12);
            LNombreColor.Margin = new Padding(4, 0, 4, 0);
            LNombreColor.Name = "LNombreColor";
            LNombreColor.Size = new Size(206, 29);
            LNombreColor.TabIndex = 0;
            LNombreColor.Text = "Nombre de Color:";
            // 
            // AñadirColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(933, 577);
            Controls.Add(TabControlRegColor);
            Controls.Add(PanelRegColor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirColor";
            Text = "Form1";
            Load += AñadirColor_Load;
            TabControlRegColor.ResumeLayout(false);
            TabPageListaColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarColor).EndInit();
            PanelRegColor.ResumeLayout(false);
            PanelRegColor.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegColor;
        internal TabPage TabPageListaColor;
        internal DataGridView DataGridViewListarColor;
        internal Panel PanelRegColor;
        internal Button BRegistrarColor;
        internal TextBox TBNombreColor;
        internal Label LNombreColor;

        #endregion

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}