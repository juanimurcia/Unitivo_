namespace Unitivo.Presentacion.Vendedor
{
    partial class ModificarCliente
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
            Panel1 = new Panel();
            BCancelar = new Button();
            BModCliente = new Button();
            TBCorreoCliente = new TextBox();
            Label7 = new Label();
            TBDireccion = new TextBox();
            Label6 = new Label();
            TBTelCliente = new TextBox();
            Label5 = new Label();
            TBDniCliente = new TextBox();
            Label4 = new Label();
            TBApellidoCliente = new TextBox();
            Label3 = new Label();
            TBNombreCliente = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            panel2 = new Panel();
            panel12 = new Panel();
            panel10 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel13 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel11 = new Panel();
            Panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BCancelar);
            Panel1.Controls.Add(BModCliente);
            Panel1.Controls.Add(TBCorreoCliente);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccion);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelCliente);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniCliente);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoCliente);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreCliente);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(153, 108);
            Panel1.Margin = new Padding(4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(377, 371);
            Panel1.TabIndex = 1;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.Cornsilk;
            BCancelar.Location = new Point(41, 298);
            BCancelar.Margin = new Padding(4);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(123, 44);
            BCancelar.TabIndex = 18;
            BCancelar.Text = "Volver";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BModCliente
            // 
            BModCliente.BackColor = Color.DarkOliveGreen;
            BModCliente.FlatAppearance.BorderSize = 2;
            BModCliente.FlatStyle = FlatStyle.Flat;
            BModCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BModCliente.ForeColor = Color.Cornsilk;
            BModCliente.Location = new Point(186, 298);
            BModCliente.Margin = new Padding(4);
            BModCliente.Name = "BModCliente";
            BModCliente.Size = new Size(155, 44);
            BModCliente.TabIndex = 17;
            BModCliente.Text = "Modificar";
            BModCliente.UseVisualStyleBackColor = false;
            BModCliente.Click += BModCliente_Click;
            // 
            // TBCorreoCliente
            // 
            TBCorreoCliente.Location = new Point(186, 242);
            TBCorreoCliente.Margin = new Padding(4);
            TBCorreoCliente.Name = "TBCorreoCliente";
            TBCorreoCliente.Size = new Size(148, 23);
            TBCorreoCliente.TabIndex = 16;
            TBCorreoCliente.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(41, 238);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(78, 25);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccion
            // 
            TBDireccion.Location = new Point(186, 200);
            TBDireccion.Margin = new Padding(4);
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Size = new Size(148, 23);
            TBDireccion.TabIndex = 14;
            TBDireccion.KeyPress += NumStr_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(41, 196);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 25);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelCliente
            // 
            TBTelCliente.Location = new Point(186, 157);
            TBTelCliente.Margin = new Padding(4);
            TBTelCliente.Name = "TBTelCliente";
            TBTelCliente.Size = new Size(148, 23);
            TBTelCliente.TabIndex = 12;
            TBTelCliente.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(41, 154);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(100, 25);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniCliente
            // 
            TBDniCliente.Location = new Point(186, 113);
            TBDniCliente.Margin = new Padding(4);
            TBDniCliente.Name = "TBDniCliente";
            TBDniCliente.Size = new Size(148, 23);
            TBDniCliente.TabIndex = 10;
            TBDniCliente.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(41, 110);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(56, 25);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.Location = new Point(186, 68);
            TBApellidoCliente.Margin = new Padding(4);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(148, 23);
            TBApellidoCliente.TabIndex = 8;
            TBApellidoCliente.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(41, 64);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(93, 25);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(186, 23);
            TBNombreCliente.Margin = new Padding(4);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(148, 23);
            TBNombreCliente.TabIndex = 6;
            TBNombreCliente.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(41, 20);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(92, 25);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(163, 50);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(276, 39);
            Label1.TabIndex = 2;
            Label1.Text = "Modificar Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(665, -2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(46, 522);
            panel2.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Gray;
            panel12.Location = new Point(0, 512);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(50, 8);
            panel12.TabIndex = 8;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gray;
            panel10.Location = new Point(0, 2);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(50, 8);
            panel10.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Location = new Point(38, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 522);
            panel6.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(0, -2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 522);
            panel3.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Gray;
            panel13.Location = new Point(8, 512);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(39, 8);
            panel13.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gray;
            panel9.Location = new Point(0, 2);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(59, 8);
            panel9.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Location = new Point(0, 2);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(9, 522);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(620, 8);
            panel8.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(47, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(620, 17);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RosyBrown;
            panel5.Controls.Add(panel11);
            panel5.Location = new Point(47, 503);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(620, 17);
            panel5.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gray;
            panel11.Location = new Point(0, 8);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(620, 8);
            panel11.TabIndex = 6;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(710, 519);
            Controls.Add(panel2);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ModificarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal Button BCancelar;
        internal Button BModCliente;
        internal TextBox TBCorreoCliente;
        internal Label Label7;
        internal TextBox TBDireccion;
        internal Label Label6;
        internal TextBox TBTelCliente;
        internal Label Label5;
        internal TextBox TBDniCliente;
        internal Label Label4;
        internal TextBox TBApellidoCliente;
        internal Label Label3;
        internal TextBox TBNombreCliente;
        internal Label Label2;
        internal Label Label1;

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel12;
        private Panel panel10;
        private Panel panel13;
        private Panel panel11;
    }
}