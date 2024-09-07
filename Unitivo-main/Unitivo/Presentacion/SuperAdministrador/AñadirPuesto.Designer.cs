namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirPuesto
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
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            DataGridViewListarPerfiles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            PanelRegClientes = new Panel();
            BRegistrarPerfil = new Button();
            TBNombrePerfil = new TextBox();
            LNombrePerfil = new Label();
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).BeginInit();
            PanelRegClientes.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegPerfil
            // 
            TabControlRegPerfil.Controls.Add(TabPageListaPerfil);
            TabControlRegPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegPerfil.Location = new Point(129, 209);
            TabControlRegPerfil.Margin = new Padding(3, 2, 3, 2);
            TabControlRegPerfil.Name = "TabControlRegPerfil";
            TabControlRegPerfil.SelectedIndex = 0;
            TabControlRegPerfil.Size = new Size(624, 279);
            TabControlRegPerfil.TabIndex = 13;
            // 
            // TabPageListaPerfil
            // 
            TabPageListaPerfil.Controls.Add(DataGridViewListarPerfiles);
            TabPageListaPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 26);
            TabPageListaPerfil.Margin = new Padding(3, 2, 3, 2);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(3, 2, 3, 2);
            TabPageListaPerfil.Size = new Size(616, 249);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Puestos";
            TabPageListaPerfil.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarPerfiles
            // 
            DataGridViewListarPerfiles.AllowUserToAddRows = false;
            DataGridViewListarPerfiles.AllowUserToDeleteRows = false;
            DataGridViewListarPerfiles.AllowUserToResizeColumns = false;
            DataGridViewListarPerfiles.AllowUserToResizeRows = false;
            DataGridViewListarPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarPerfiles.BackgroundColor = Color.RosyBrown;
            DataGridViewListarPerfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarPerfiles.ColumnHeadersHeight = 20;
            DataGridViewListarPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarPerfiles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarPerfiles.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarPerfiles.Dock = DockStyle.Fill;
            DataGridViewListarPerfiles.EnableHeadersVisualStyles = false;
            DataGridViewListarPerfiles.Location = new Point(3, 2);
            DataGridViewListarPerfiles.Margin = new Padding(3, 2, 3, 2);
            DataGridViewListarPerfiles.Name = "DataGridViewListarPerfiles";
            DataGridViewListarPerfiles.ReadOnly = true;
            DataGridViewListarPerfiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarPerfiles.RowHeadersWidth = 51;
            DataGridViewListarPerfiles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarPerfiles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarPerfiles.RowTemplate.Height = 24;
            DataGridViewListarPerfiles.Size = new Size(610, 245);
            DataGridViewListarPerfiles.TabIndex = 0;
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
            // PanelRegClientes
            // 
            PanelRegClientes.BackColor = Color.Cornsilk;
            PanelRegClientes.BackgroundImageLayout = ImageLayout.None;
            PanelRegClientes.Controls.Add(BRegistrarPerfil);
            PanelRegClientes.Controls.Add(TBNombrePerfil);
            PanelRegClientes.Controls.Add(LNombrePerfil);
            PanelRegClientes.Location = new Point(198, 57);
            PanelRegClientes.Margin = new Padding(4);
            PanelRegClientes.Name = "PanelRegClientes";
            PanelRegClientes.Size = new Size(505, 129);
            PanelRegClientes.TabIndex = 12;
            // 
            // BRegistrarPerfil
            // 
            BRegistrarPerfil.BackColor = Color.DarkOliveGreen;
            BRegistrarPerfil.FlatAppearance.BorderColor = Color.White;
            BRegistrarPerfil.FlatAppearance.BorderSize = 2;
            BRegistrarPerfil.FlatStyle = FlatStyle.Flat;
            BRegistrarPerfil.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarPerfil.ForeColor = Color.White;
            BRegistrarPerfil.Location = new Point(371, 56);
            BRegistrarPerfil.Margin = new Padding(4);
            BRegistrarPerfil.Name = "BRegistrarPerfil";
            BRegistrarPerfil.Size = new Size(115, 49);
            BRegistrarPerfil.TabIndex = 13;
            BRegistrarPerfil.Text = "Añadir";
            BRegistrarPerfil.UseVisualStyleBackColor = false;
            BRegistrarPerfil.Click += BRegistrarPerfil_Click;
            // 
            // TBNombrePerfil
            // 
            TBNombrePerfil.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombrePerfil.Location = new Point(24, 67);
            TBNombrePerfil.Margin = new Padding(4);
            TBNombrePerfil.Name = "TBNombrePerfil";
            TBNombrePerfil.Size = new Size(325, 26);
            TBNombrePerfil.TabIndex = 6;
            TBNombrePerfil.KeyPress += String_KeyPress;
            // 
            // LNombrePerfil
            // 
            LNombrePerfil.AutoSize = true;
            LNombrePerfil.BackColor = Color.Cornsilk;
            LNombrePerfil.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNombrePerfil.ForeColor = Color.DarkOrange;
            LNombrePerfil.Location = new Point(24, 9);
            LNombrePerfil.Margin = new Padding(4, 0, 4, 0);
            LNombrePerfil.Name = "LNombrePerfil";
            LNombrePerfil.Size = new Size(273, 33);
            LNombrePerfil.TabIndex = 0;
            LNombrePerfil.Text = "Nombre de Puesto :";
            // 
            // AñadirPuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(934, 566);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(PanelRegClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AñadirPuesto";
            Text = "Form1";
            Load += AñadirPuesto_Load;
            TabControlRegPerfil.ResumeLayout(false);
            TabPageListaPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).EndInit();
            PanelRegClientes.ResumeLayout(false);
            PanelRegClientes.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegPerfil;
        internal TabPage TabPageListaPerfil;
        internal DataGridView DataGridViewListarPerfiles;
        internal Panel PanelRegClientes;
        internal Button BRegistrarPerfil;
        internal TextBox TBNombrePerfil;
        internal Label LNombrePerfil;

        #endregion

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}