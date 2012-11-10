using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace bookArchive.Classes
{
    public class Author
    {
        public int authorId { get; set; }
        public string authorName { get; set; }

        public void addAuthor()
        {
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "insert into authors (author_name) values (@authorName)";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@authorName", this.authorName);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static String getAuthorName(int authorId) {
            String authorName = "";
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "select * from authors where author_id = @authorId";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@authorId", authorId);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                authorName = reader["author_name"].ToString();
            }
            cnn.Close();
            return authorName;

        }

        public static List<Author> getAuthors()
        {
            List<Author> authors = new List<Author>();
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "select * from authors";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read()) {
                Author a = new Author();
                a.authorId = int.Parse(reader["author_id"].ToString());
                a.authorName = reader["author_name"].ToString();
                authors.Add(a);
            }
            return authors;
        }

        public void updateAuthor() {
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "update authors set author_name = @authorName where author_id = @authorId";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@authorName", this.authorName);
            cmd.Parameters.AddWithValue("@authorId", this.authorId);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

       
    }
}