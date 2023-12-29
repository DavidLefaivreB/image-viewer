using System.Collections.Generic;
using System.Text;
using ImageBrowser.Model;
using Microsoft.Data.Sqlite;

namespace ImageBrowser.Repository.Sql;

public class SqlPictureRepository : PictureRepository
{
    private static readonly string Path = @"D:\workspace\ImageBrowser\info.sqlite";
    private static readonly HashSet<string> EmptyCollection = new();

    private readonly SqliteConnection _connection;

    internal SqlPictureRepository()
    {
        _connection = new SqliteConnection($"Data Source={Path}");
        _connection.Open();
    }

    public List<Picture> RetrieveAll()
    {
        return RetrieveFor(EmptyCollection, EmptyCollection);
    }

    public List<Picture> RetrieveFor(HashSet<string> categoriesFilter, HashSet<string> franchisesFilter)
    {
        var whereQuery = new StringBuilder();

        whereQuery.Append(CreateWhereFilter(categoriesFilter, "category", true));
        whereQuery.Append(CreateWhereFilter(franchisesFilter, "franchise", whereQuery.Length == 0));

        var sql = "SELECT * FROM PICTURE_V " + whereQuery;
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

    private static StringBuilder CreateWhereFilter(HashSet<string> filters, string columnName, bool isFirst)
    {
        var filterClause = new StringBuilder();
        if (filters.Count > 0)
        {
            filterClause.Append(isFirst ? "WHERE " : "AND ");
            filterClause.Append($"{columnName} in ('");
            
            foreach (var category in filters)
            {
                filterClause.Append(category).Append("', '");
            }

            filterClause.Length -= 3;
            filterClause.Append(")");
        }

        return filterClause;
    }
}