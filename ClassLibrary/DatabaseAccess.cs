using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary
{
    static class DatabaseAccess
    {
        static string connectionString = @"Server=DESKTOP-7NO5IML\SQLEXPRESS;Database=AcmeCorporationDB;Trusted_Connection=true";//Trusted_Connection=true é para utilizar autenticação do windows
        static SqlConnection conn;

        static public IEnumerable<DrawEntry> GetEntryList()
        {
            List<DrawEntry> drawEntries = new List<DrawEntry>();
            using(conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM DrawEntry", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DrawEntry drawEntry = new DrawEntry(reader.GetString(1),reader.GetString(2));
                        drawEntries.Add(drawEntry);
                    }
                }
            }
            return drawEntries;
        }
        static public void Add(DrawEntry drawEntry)
        {
            using(conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("INSERT INTO DrawEntry (Email,ProductSerialNumber) VALUES (@email, @productsn)", conn);
                insertCommand.Parameters.Add(new SqlParameter("@email", drawEntry.Email));
                insertCommand.Parameters.Add(new SqlParameter("@productsn", drawEntry.ProductSerialNumber));
                insertCommand.ExecuteNonQuery();

            }

        }
    }
}
