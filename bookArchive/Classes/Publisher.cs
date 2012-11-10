using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace bookArchive.Classes
{
    public class Publisher
    {
        public int publisherId { get; set; }
        public string publisherName { get; set; }

        public static String getPublisherName(int publisherId) {
            String publisherName = "";
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "select * from publishers where publisher_id = @publisherId";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@publisherId", publisherId);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                publisherName = reader["publisher_name"].ToString();
            }
            cnn.Close();
            return publisherName;
        }

        internal static object getProducers()
        {
            List<Publisher> publishers = new List<Publisher>();
            MySqlConnection cnn = new MySqlConnection(SystemClasses.connString);
            String sql = "select * from publishers";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Publisher p = new Publisher();
                p.publisherId = int.Parse(reader["publisher_id"].ToString());
                p.publisherName = reader["publisher_name"].ToString();
                publishers.Add(p);
            }
            return publishers;
        }
    }
}