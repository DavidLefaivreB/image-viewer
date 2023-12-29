using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace ImageBrowser.Repository.Sql;

public class SqlCategoryRepository : CategoryRepository
{
    private static readonly string Path = @"D:\workspace\ImageBrowser\info.sqlite";

    private readonly SqliteConnection _connection;
    
    internal SqlCategoryRepository()
    {
        _connection = new SqliteConnection($"Data Source={Path}");
        _connection.Open();
    }

    public List<string> RetrieveAll()
    {
        var sql = "Select * from categories";
        var command = new SqliteCommand(sql, _connection);
        var reader = command.ExecuteReader();

        var franchises = new List<string>();

        while (reader.Read())
        {
            franchises.Add(reader[1].ToString());
        }

        return franchises;
    }
}