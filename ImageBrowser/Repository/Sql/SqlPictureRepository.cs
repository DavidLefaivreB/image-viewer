using System.Collections.Generic;
using ImageBrowser.Model;
using Microsoft.Data.Sqlite;

namespace ImageBrowser.Repository.Sql;

public class SqlPictureRepository : PictureRepository
{
    private static readonly string Path = @"D:\workspace\ImageBrowser\info.sqlite";

    private readonly SqliteConnection _connection;

    public SqlPictureRepository()
    {
        _connection = new SqliteConnection($"Data Source={Path}");
        _connection.Open();
    }

    public List<Picture> RetrieveAll()
    {
        var sql = "SELECT * FROM PICTURES_V";
        var command = new SqliteCommand(sql, _connection);
        var reader = command.ExecuteReader();

        var pictures = new List<Picture>();

        while (reader.Read())
        {
            var picture = new Picture(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            pictures.Add(picture);
        }

        return pictures;
    }

    public List<Picture> RetrieveFor(HashSet<string> categoriesFilter, HashSet<string> franchisesFilter)
    {
        return new List<Picture>();
    }
}