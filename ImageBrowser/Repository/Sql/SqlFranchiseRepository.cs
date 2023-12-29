using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace ImageBrowser.Repository.Sql;

public class SqlFranchiseRepository : FranchiseRepository
{
    private static readonly string Path = @"D:\workspace\ImageBrowser\info.sqlite";

    private readonly SqliteConnection _connection;

    internal SqlFranchiseRepository()
    {
        _connection = new SqliteConnection($"Data Source={Path}");
        _connection.Open();
    }

    public List<string> RetrieveAll()
    {
        var sql = "Select * from franchises";
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