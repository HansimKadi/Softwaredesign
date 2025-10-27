using Microsoft.Data.Sqlite;
namespace ConsoleApp;

public class AdoNetDB
{
    public void InitializeDbAndTable()
    {
        using SqliteConnection connection = new("Data Source =filename.db"); // when we add a tbale we should get a db file in the bin folder
        connection.Open();
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = @"
      DROP TABLE IF EXISTS user;
      CREATE TABLE USER (
          id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
          name TEXT NOT NULL
          );
      ";
        command.ExecuteNonQuery();

    }
}
