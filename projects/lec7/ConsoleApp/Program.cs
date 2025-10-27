using Microsoft.Data.Sqlite;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdoNetDB db = new();
            db.InitializeDbAndTable();
        }
    }
}
