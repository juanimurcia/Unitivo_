using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unitivo.Presentacion.Administrador
{
    public partial class VentasPorCategoria : Form
    {
        CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private bool filtrarFecha = false;
        private DateTime fechaDesde = DateTime.Now;
        private DateTime fechaHasta = DateTime.Now;
        public VentasPorCategoria()
        {
            InitializeComponent();

            List<Categoria> categorias = categoriaRepositorio.ListarCategorias();
            categorias.Insert(0, new Categoria { Id = 0, Descripcion = "Todas" });

            comboBox1.DataSource = categorias;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Descripcion";

        }

        private void BBuscarCategoria_Click(object sender, EventArgs e)
        {
        }

        private void VentasPorCategoria_Load(object sender, EventArgs e)
        {
            Chart10.Series[0].Points.Clear();
            Chart20.Series[0].Points.Clear();
            chart30.Series[0].Points.Clear();
            Chart40.Series[0].Points.Clear();
            Chart50.Series[0].Points.Clear();
            RP_CategoriasMasVendidos(Chart10);
            RP_CategoriaPorMes(Chart20);
            RP_EmpleadoMasVendioCateg(chart30);
            RP_ClientesMasComproCateg(Chart40);
            RP_RecaudadoPorMes(Chart50);
            LTotalRecaudado.Text = "$ " + categoriaRepositorio.TotalRecaudadoCategoria(fechaDesde, fechaHasta, filtrarFecha, (int)comboBox1.SelectedValue!);


        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filtrarFecha = false;
            fechaDesde = DTPDesde.Value.Date;
            fechaHasta = DTPHasta.Value.Date.AddDays(1);
            VentasPorCategoria_Load(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        public int RP_CategoriasMasVendidos(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = categoriaRepositorio.categoriasMasVendidas(fechaDesde, fechaHasta, filtrarFecha);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Categoria, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = resultado.Categoria;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = resultado.Cantidad.ToString();
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Categorias";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Ventas";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Categorias"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            return 0;
        }

        public int RP_CategoriaPorMes(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = categoriaRepositorio.categoriaPorMes(fechaDesde, fechaHasta, filtrarFecha, (int)comboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            string[] nombresMeses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Mes, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = "" + resultado.Mes;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = nombresMeses[resultado.Mes];
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Meses";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Ventas";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Categoria"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            p_chart.Series[0].Name = comboBox1.Text;
            return 0;
        }

        public int RP_EmpleadoMasVendioCateg(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = categoriaRepositorio.empleadosMasVendioCateg(fechaDesde, fechaHasta, filtrarFecha, (int)comboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Vendedor, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = resultado.Vendedor;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = resultado.Cantidad.ToString();
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Vendedores";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Ventas";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Vendedores"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            return 0;
        }

        public int RP_ClientesMasComproCateg(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = categoriaRepositorio.clientesMasComproCateg(fechaDesde, fechaHasta, filtrarFecha, (int)comboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Cliente, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = resultado.Cliente;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = resultado.Cantidad.ToString();
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Clientes";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Compras";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Clientes"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            p_chart.Series[0].Name = "Clientes";

            return 0;
        }

        public object RP_RecaudadoPorMes(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = categoriaRepositorio.recaudadoCategoriaPorFecha(fechaDesde, fechaHasta, filtrarFecha, (int)comboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            string[] nombresMeses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Mes, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = "" + resultado.Mes;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = nombresMeses[resultado.Mes];
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Meses";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Totales";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Categoria"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            p_chart.Series[0].Name = comboBox1.Text;
            return 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            if (DTPDesde.Value > DTPHasta.Value || DTPHasta.Value > fecha || DTPDesde.Value > fecha)
            {
                MessageBox.Show("Fecha incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                filtrarFecha = true;
                fechaDesde = DTPDesde.Value.Date;
                fechaHasta = DTPHasta.Value.Date.AddDays(1);
                VentasPorCategoria_Load(sender, e);
            }
        }
    }
}
