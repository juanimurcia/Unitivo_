using Unitivo.Properties;
using Unitivo.Recursos;
namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class ManejoBD : Form
    {
        private string connectionString = Resources.DB_BackupRestore;
        //private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Unitivo;Integrated Security=True";
        private string databaseName = "Unitivo";
        public ManejoBD()
        {
            InitializeComponent();
        }

        private void BResguardar_Click(object sender, EventArgs e)
        {
            DatabaseBackupRestore backupRestore = new DatabaseBackupRestore(connectionString);
            backupRestore.BackupDatabase(databaseName);
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            DatabaseBackupRestore backupRestore = new DatabaseBackupRestore(connectionString);
            backupRestore.RestoreDatabase(databaseName);
        }

        private void ManejoBD_Load(object sender, EventArgs e)
        {

        }
    }
}
