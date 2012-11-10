using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookArchive.Classes
{
    public class Book
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public int authorId { get; set; }
        public string authorName { get; set; }
        public string bookIsbn { get; set; }
        public int publisherId { get; set; }
        public string publisherName { get; set; }
        public string bookIndex { get; set; }
        public string bookNotes { get; set; }
        public int isDigitized { get; set; }


        public void addBook()
        {
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "insert into books (book_name,author_id,book_isbn,publisher_id,book_index,book_notes,is_digitized)"
                        + "values"
                        + "(@bookName,@authorId,@bookIsbn,@publisherId,@bookIndex,@bookNotes,@isDigitized)";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@bookName", this.bookName);
            cmd.Parameters.AddWithValue("@authorId", this.authorId);
            cmd.Parameters.AddWithValue("@bookIsbn", this.bookIsbn);
            cmd.Parameters.AddWithValue("@publisherId", this.publisherId);
            cmd.Parameters.AddWithValue("@bookIndex", this.bookIndex);
            cmd.Parameters.AddWithValue("@bookNotes", this.bookNotes);
            cmd.Parameters.AddWithValue("@isDigitized", this.isDigitized);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Book> listBooks() {
            List<Book> books = new List<Book>();

            String sql = "select * from books";
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Book b = new Book();
                b.bookId = int.Parse(reader["book_id"].ToString());
                b.bookName = reader["book_name"].ToString();
                b.authorId = int.Parse(reader["author_id"].ToString());
                b.authorName = Author.getAuthorName(b.authorId);
                b.bookIsbn = reader["book_isbn"].ToString();
                b.publisherId = int.Parse(reader["publisher_id"].ToString());
                b.publisherName = Publisher.getPublisherName(b.publisherId);
                b.bookIndex = reader["book_index"].ToString();
                b.bookNotes = reader["book_notes"].ToString();
                b.isDigitized = int.Parse(reader["is_digitized"].ToString());
                books.Add(b);
            }
            cnn.Close();

            return books;
        }

      
    }
}