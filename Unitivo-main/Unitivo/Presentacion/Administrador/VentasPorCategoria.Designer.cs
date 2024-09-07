namespace Unitivo.Presentacion.Administrador
{
    partial class VentasPorCategoria
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Chart20 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Chart50 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Chart10 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Chart40 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart30 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            button2 = new Button();
            DTPDesde = new DateTimePicker();
            DTPHasta = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            LTotalRecaudado = new Label();
            ((System.ComponentModel.ISupportInitialize)Chart20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart40).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart30).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Chart20
            // 
            chartArea6.Name = "ChartArea1";
            Chart20.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            Chart20.Legends.Add(legend6);
            Chart20.Location = new Point(32, 53);
            Chart20.Name = "Chart20";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            Chart20.Series.Add(series6);
            Chart20.Size = new Size(445, 300);
            Chart20.TabIndex = 0;
            Chart20.Text = "chart1";
            // 
            // Chart50
            // 
            chartArea7.Name = "ChartArea1";
            Chart50.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            Chart50.Legends.Add(legend7);
            Chart50.Location = new Point(32, 408);
            Chart50.Name = "Chart50";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            Chart50.Series.Add(series7);
            Chart50.Size = new Size(445, 300);
            Chart50.TabIndex = 1;
            Chart50.Text = "chart2";
            // 
            // Chart10
            // 
            chartArea8.Name = "ChartArea1";
            Chart10.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            Chart10.Legends.Add(legend8);
            Chart10.Location = new Point(507, 53);
            Chart10.Name = "Chart10";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            Chart10.Series.Add(series8);
            Chart10.Size = new Size(300, 300);
            Chart10.TabIndex = 2;
            Chart10.Text = "chart3";
            // 
            // Chart40
            // 
            chartArea9.Name = "ChartArea1";
            Chart40.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            Chart40.Legends.Add(legend9);
            Chart40.Location = new Point(507, 408);
            Chart40.Name = "Chart40";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            Chart40.Series.Add(series9);
            Chart40.Size = new Size(300, 300);
            Chart40.TabIndex = 3;
            Chart40.Text = "chart4";
            Chart40.Click += chart4_Click;
            // 
            // chart30
            // 
            chartArea10.Name = "ChartArea1";
            chart30.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            chart30.Legends.Add(legend10);
            chart30.Location = new Point(881, 408);
            chart30.Name = "chart30";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            chart30.Series.Add(series10);
            chart30.Size = new Size(300, 300);
            chart30.TabIndex = 4;
            chart30.Text = "chart5";
            chart30.Click += chart5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1064, 177);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 5;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(1064, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 6;
            button2.Text = "Historico";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(862, 115);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(100, 23);
            DTPDesde.TabIndex = 7;
            // 
            // DTPHasta
            // 
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(1064, 115);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(104, 23);
            DTPHasta.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(862, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(875, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1078, 68);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(905, 372);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 12;
            label3.Text = "Vendedores mas Vendieron";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(875, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 12;
            label4.Text = "Categoria\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 372);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 13;
            label5.Text = "Clientes mas compraron";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 372);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 14;
            label6.Text = "Recaudado Por fechas";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 18);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 15;
            label7.Text = "Mas vendidas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 18);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Por meses\r\n";
            // 
            // LTotalRecaudado
            // 
            LTotalRecaudado.AutoSize = true;
            LTotalRecaudado.Location = new Point(32, 749);
            LTotalRecaudado.Name = "LTotalRecaudado";
            LTotalRecaudado.Size = new Size(100, 15);
            LTotalRecaudado.TabIndex = 17;
            LTotalRecaudado.Text = "Total Recaudado: ";
            // 
            // VentasPorCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1270, 793);
            Controls.Add(LTotalRecaudado);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(DTPHasta);
            Controls.Add(DTPDesde);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chart30);
            Controls.Add(Chart40);
            Controls.Add(Chart10);
            Controls.Add(Chart50);
            Controls.Add(Chart20);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentasPorCategoria";
            Text = "Form1";
            Load += VentasPorCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)Chart20).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart50).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart10).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart40).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart30).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal ComboBox ComboBoxBuscarDni;
        internal DateTimePicker DateTimePicker2;
        internal DateTimePicker DateTimePicker1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart20;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart50;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart10;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart40;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart30;
        private Button button1;
        private Button button2;
        private DateTimePicker DTPDesde;
        private DateTimePicker DTPHasta;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label LTotalRecaudado;
    }
}