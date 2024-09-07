using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Unitivo.Formularios;
using Unitivo.Formularios.Vendedor;
using Unitivo.Modelos;
using Unitivo.Presentacion;
using Unitivo.Presentacion.Administrador;
using Unitivo.Properties;
using Unitivo.Recursos;

namespace Unitivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string stringConection = Resources.DB_ConnectionString;
            //string stringConection = "Data Source=.\\SQLEXPRESS;Initial Catalog=Unitivo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            DbContextOptionsBuilder<UnitivoContext> optionsBuilder = new();

            UnitivoContext unitivoContext = new(optionsBuilder.UseSqlServer(stringConection).Options);
            Contexto.dbContexto = unitivoContext;
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}