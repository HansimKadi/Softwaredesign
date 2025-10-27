using Microsoft.Data.Sqlite;
using System.Data;
using System.Collections.Generic;
using World.Models;


namespace World.Repositories;

public sealed class SqliteCountryRepository : ICountryRepository//sealed class to prevent inheritance  
{
    private readonly string _connectionString; // The should receive the connection string thorugh constructor injection it doesnt get to decide what database to connect to 
    private readonly ICountryMapper _mapper; // mapper to map data from database to country entity 

    public SqliteCountryRepository(string connectionString, ICountryMapper mapper)
    {
        _connectionString = connectionString;
        _mapper = mapper;
    }

    public IReadOnlyList<Country> GetAll() // This method is also mentioned in the interface

    {
        List<Country> list = new(); // The scope of the list should be inside the method, could use var on left side if we want to
        using SqliteConnection connection = new SqliteConnection(_connectionString);
        connection.Open();

        using SqliteCommand command = connection.CreateCommand();
        command.CommandText = @"
      SELECT *
      FROM Country";

        using SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            list.Add(_mapper.Map(reader));
        }
        return list;
    }


}
