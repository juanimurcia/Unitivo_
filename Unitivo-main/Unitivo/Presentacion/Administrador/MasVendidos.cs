using System.Windows.Forms.DataVisualization.Charting;
using Unitivo.Modelos;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class MasVendidos : Form
    {
        ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private bool filtrarFecha = false;
        private DateTime fechaDesde = DateTime.Now;
        private DateTime fechaHasta = DateTime.Now;
        public MasVendidos()
        {
            InitializeComponent();

            List<Producto> productos = productoRepositorio.ListarProductos();
            productos.Insert(0, new Producto { Id = 0, Nombre = "Todas" });

            ComboBox1.DataSource = productos;
            ComboBox1.ValueMember = "Id";
            ComboBox1.DisplayMember = "Nombre";
        }

        private void BBuscarCategoria_Click(object sender, EventArgs e)
        {
        }

        private void VentasPorProducto_Load(object sender, EventArgs e)
        {
            Chart10.Series[0].Points.Clear();
            Chart20.Series[0].Points.Clear();
            chart30.Series[0].Points.Clear();
            Chart40.Series[0].Points.Clear();
            Chart50.Series[0].Points.Clear();
            RP_ProductosMasVendidos(Chart10);
            RP_ProductoPorMes(Chart20);
            RP_EmpleadoMasVendioProd(chart30);
            RP_ClientesMasComproProd(Chart40);
            RP_RecaudadoPorMes(Chart50);
            LTotalRecaudado.Text = "$ " + productoRepositorio.TotalRecaudadoProducto(fechaDesde, fechaHasta, filtrarFecha, (int)ComboBox1.SelectedValue).ToString();
        }

        public int RP_ProductosMasVendidos(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

            // Consulta para obtener la cantidad de productos por categoría
            dynamic query = productoRepositorio.ProductosMasVendidos(fechaDesde, fechaHasta, filtrarFecha);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Producto, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = resultado.Producto;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = resultado.Cantidad.ToString();
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Productos";
            // Asignar nombre al eje Y
            p_chart.ChartAreas[0].AxisY.Title = "Ventas";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Productos"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            return 0;
        }

        public int RP_ProductoPorMes(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

            // Consulta para obtener la cantidad de productos por categoría
            dynamic query = productoRepositorio.ProductoPorMes(fechaDesde, fechaHasta, filtrarFecha, (int)ComboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            string[] nombresMeses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Mes, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = ""+resultado.Mes;
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
            p_chart.Legends[0].Title = "Producto"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            p_chart.Series[0].Name = ComboBox1.Text;

            return 0;
        }

        public int RP_EmpleadoMasVendioProd(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

            // Consulta para obtener la cantidad de productos por categoría
            dynamic query = productoRepositorio.EmpleadosMasVendioProd(fechaDesde, fechaHasta, filtrarFecha, (int)ComboBox1.SelectedValue);

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

        public int RP_ClientesMasComproProd(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Producto"

            // Consulta para obtener la cantidad de productos por categoría
            dynamic query = productoRepositorio.ClientesMasComproProd(fechaDesde, fechaHasta, filtrarFecha, (int)ComboBox1.SelectedValue);

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

        public int RP_RecaudadoPorMes(Chart p_chart)
        {
            // Aquí asumimos que tienes una clase Entity Framework llamada "Entities" y un modelo llamado "Categoria"

            // Consulta para obtener la cantidad de Categorias por categoría
            dynamic query = productoRepositorio.RecaudadoProductoPorFecha(fechaDesde, fechaHasta, filtrarFecha, (int)ComboBox1.SelectedValue);

            int index = 0;
            // Recorrer los resultados del query para agregar los datos al gráfico y a la leyenda
            string[] nombresMeses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            foreach (var resultado in query)
            {
                p_chart.Series[0].Points.AddXY(resultado.Mes, resultado.Cantidad);
                p_chart.Series[0].Points[p_chart.Series[0].Points.Count - 1].LegendText = ""+resultado.Mes;
                // Establecer las etiquetas en el eje X del gráfico
                p_chart.Series[0].Points[index].AxisLabel = nombresMeses[resultado.Mes];
                index = index + 1;
            }

            // Asignar nombre al eje X
            p_chart.ChartAreas[0].AxisX.Title = "Meses";
            // Asignar nombre al eje y
            p_chart.ChartAreas[0].AxisY.Title = "Totales";

            // Mostrar etiquetas en el eje X
            p_chart.ChartAreas[0].AxisX.Interval = 1; // Intervalo entre etiquetas

            // Establecer el título de la leyenda
            p_chart.Legends[0].Title = "Productos"; // Título de la leyenda

            // Mostrar la leyenda
            p_chart.Legends[0].Enabled = true; // Habilitar la visualización de la leyenda

            p_chart.Series[0].Name = ComboBox1.Text;
            return 0;
        }
        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            filtrarFecha = false;
            fechaDesde = DTPDesde.Value.Date;
            fechaHasta = DTPHasta.Value.Date.AddDays(1);
            VentasPorProducto_Load(sender, e);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            if (DTPDesde.Value > DTPHasta.Value || DTPHasta.Value > fecha || DTPDesde.Value > fecha)
            {
                MessageBox.Show("Fecha incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                filtrarFecha = true;
                fechaDesde = DTPDesde.Value.Date;
                fechaHasta = DTPHasta.Value.Date.AddDays(1);
                VentasPorProducto_Load(sender, e);
            }
        }
    }
}
