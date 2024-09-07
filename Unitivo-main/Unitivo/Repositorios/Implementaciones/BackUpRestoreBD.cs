using System.Data.SqlClient;
using System;
using System.Diagnostics;

public class DatabaseBackupRestore
{
    private readonly string connectionString;

    public DatabaseBackupRestore(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void BackupDatabase(string databaseName)
    {
        try
        {
            // Generar el nombre del archivo de respaldo basado en la fecha actual
            string dateString = DateTime.Now.ToString("yyyyMMdd");
            string backupFilePath = $@"C:\BackUpUnitivo\Backup_{dateString}.bak";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}'";
                SqlCommand command = new SqlCommand(backupQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show($"Backup de la base de datos '{databaseName}' realizado con éxito en '{backupFilePath}'.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al realizar el backup de la base de datos '{databaseName}': {ex.Message}");
        }
    }

    public void RestoreDatabase(string databaseName)
    {
        try
        {
            // Buscar el archivo de respaldo más reciente
            string backupFolder = @"C:\BackUpUnitivo";
            string latestBackupFile = Directory.GetFiles(backupFolder, "Backup_*.bak")
                                               .OrderByDescending(f => f)
                                               .FirstOrDefault();

            if (latestBackupFile == null)
            {
                MessageBox.Show("No se encontró ningún archivo de respaldo para restaurar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener la lista de archivos en el respaldo
                string sqlFileList = $"RESTORE FILELISTONLY FROM DISK = '{latestBackupFile}'";
                SqlCommand commandFileList = new SqlCommand(sqlFileList, connection);

                string logicalNameData = "";
                string logicalNameLog = "";

                using (SqlDataReader reader = commandFileList.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Type"].ToString() == "D")
                        {
                            logicalNameData = reader["LogicalName"].ToString();
                        }
                        else if (reader["Type"].ToString() == "L")
                        {
                            logicalNameLog = reader["LogicalName"].ToString();
                        }
                    }
                }

                // Verifica la existencia de la carpeta y créala si no existe
                string dataFolderPath = @"C:\Databases";
                if (!Directory.Exists(dataFolderPath))
                {
                    Directory.CreateDirectory(dataFolderPath);
                }

                // Ruta a la que moveremos los archivos físicos
                string dataFilePath = Path.Combine(dataFolderPath, $"{databaseName}.mdf");
                string logFilePath = Path.Combine(dataFolderPath, $"{databaseName}_Log.ldf");

                // Comando para restaurar la base de datos
                string restoreQuery = $@"
                    USE master;
                    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE [{databaseName}]
                    FROM DISK = '{latestBackupFile}'
                    WITH REPLACE,
                    MOVE '{logicalNameData}' TO '{dataFilePath}',
                    MOVE '{logicalNameLog}' TO '{logFilePath}';
                    ALTER DATABASE [{databaseName}] SET MULTI_USER;
                ";

                using (SqlCommand commandRestore = new SqlCommand(restoreQuery, connection))
                {
                    commandRestore.ExecuteNonQuery();
                    MessageBox.Show($"Restauración de la base de datos '{databaseName}' realizada con éxito desde '{latestBackupFile}'.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al restaurar la base de datos '{databaseName}': {ex.Message}");
        }
    }
}