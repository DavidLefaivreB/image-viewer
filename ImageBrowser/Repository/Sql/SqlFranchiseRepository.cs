using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace ImageBrowser.Repository.Sql;

public class SqlFranchiseRepository : FranchiseRepository
{
    private static readonly string path = @"D:\workspace\ImageBrowser\info.sqlite";

    private SqliteConnection _connection;

    public SqlFranchiseRepository()
    {
        _connection = new SqliteConnection($"Data Source={path}");
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