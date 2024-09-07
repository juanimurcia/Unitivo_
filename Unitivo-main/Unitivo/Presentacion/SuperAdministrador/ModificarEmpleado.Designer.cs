namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class ModificarEmpleado
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
            Label1 = new Label();
            Panel1 = new Panel();
            DateTimePickerFechaNacimiento = new DateTimePicker();
            label8 = new Label();
            BCancelar = new Button();
            BModEmpleado = new Button();
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
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.RosyBrown;
            Label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(105, 42);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(470, 50);
            Label1.TabIndex = 4;
            Label1.Text = "Modificar Empleado";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.RosyBrown;
            Panel1.Controls.Add(DateTimePickerFechaNacimiento);
            Panel1.Controls.Add(label8);
            Panel1.Controls.Add(BCancelar);
            Panel1.Controls.Add(BModEmpleado);
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
            Panel1.Location = new Point(123, 132);
            Panel1.Margin = new Padding(4, 5, 4, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(431, 557);
            Panel1.TabIndex = 3;
            // 
            // DateTimePickerFechaNacimiento
            // 
            DateTimePickerFechaNacimiento.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            DateTimePickerFechaNacimiento.Location = new Point(213, 409);
            DateTimePickerFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento";
            DateTimePickerFechaNacimiento.Size = new Size(169, 28);
            DateTimePickerFechaNacimiento.TabIndex = 35;
            DateTimePickerFechaNacimiento.ValueChanged += DPFechaNacimiento_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(47, 367);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(253, 29);
            label8.TabIndex = 19;
            label8.Text = "Fecha Nacimiento :";
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.White;
            BCancelar.Location = new Point(47, 473);
            BCancelar.Margin = new Padding(4, 5, 4, 5);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(141, 58);
            BCancelar.TabIndex = 18;
            BCancelar.Text = "Volver";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BModEmpleado
            // 
            BModEmpleado.BackColor = Color.DarkOliveGreen;
            BModEmpleado.FlatAppearance.BorderSize = 2;
            BModEmpleado.FlatStyle = FlatStyle.Flat;
            BModEmpleado.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BModEmpleado.ForeColor = Color.White;
            BModEmpleado.Location = new Point(219, 473);
            BModEmpleado.Margin = new Padding(4, 5, 4, 5);
            BModEmpleado.Name = "BModEmpleado";
            BModEmpleado.Size = new Size(177, 58);
            BModEmpleado.TabIndex = 17;
            BModEmpleado.Text = "Modificar";
            BModEmpleado.UseVisualStyleBackColor = false;
            BModEmpleado.Click += BModEmpleado_Click;
            // 
            // TBCorreoEmpleado
            // 
            TBCorreoEmpleado.Location = new Point(213, 319);
            TBCorreoEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBCorreoEmpleado.Name = "TBCorreoEmpleado";
            TBCorreoEmpleado.Size = new Size(169, 27);
            TBCorreoEmpleado.TabIndex = 16;
            TBCorreoEmpleado.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(47, 314);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(106, 29);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionEmpleado
            // 
            TBDireccionEmpleado.Location = new Point(213, 263);
            TBDireccionEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBDireccionEmpleado.Name = "TBDireccionEmpleado";
            TBDireccionEmpleado.Size = new Size(169, 27);
            TBDireccionEmpleado.TabIndex = 14;
            TBDireccionEmpleado.KeyPress += NumStr_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(47, 259);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(148, 29);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelEmpleado
            // 
            TBTelEmpleado.Location = new Point(213, 206);
            TBTelEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBTelEmpleado.Name = "TBTelEmpleado";
            TBTelEmpleado.Size = new Size(169, 27);
            TBTelEmpleado.TabIndex = 12;
            TBTelEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(47, 202);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(137, 29);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniEmpleado
            // 
            TBDniEmpleado.Location = new Point(213, 151);
            TBDniEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBDniEmpleado.Name = "TBDniEmpleado";
            TBDniEmpleado.Size = new Size(169, 27);
            TBDniEmpleado.TabIndex = 10;
            TBDniEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(47, 146);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(77, 29);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoEmpleado
            // 
            TBApellidoEmpleado.Location = new Point(213, 91);
            TBApellidoEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBApellidoEmpleado.Name = "TBApellidoEmpleado";
            TBApellidoEmpleado.Size = new Size(169, 27);
            TBApellidoEmpleado.TabIndex = 8;
            TBApellidoEmpleado.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(47, 86);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(135, 29);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreEmpleado
            // 
            TBNombreEmpleado.Location = new Point(213, 31);
            TBNombreEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBNombreEmpleado.Name = "TBNombreEmpleado";
            TBNombreEmpleado.Size = new Size(169, 27);
            TBNombreEmpleado.TabIndex = 6;
            TBNombreEmpleado.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(47, 26);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(128, 29);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // ModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(696, 716);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Panel Panel1;
        internal Button BCancelar;
        internal Button BModEmpleado;
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

        #endregion
        internal Label label8;
        internal DateTimePicker DateTimePickerFechaNacimiento;
    }
}