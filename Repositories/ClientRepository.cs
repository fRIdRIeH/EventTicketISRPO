using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventTicket.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace EventTicket.Repositories
{
    public class ClientRepository
    {
        private readonly MySqlConnection _connection;

        public ClientRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Models.ClientSAT client)
        {
            string insertQuery = "INSERT INTO Clients " +
                "(Surname, Name, Patronimyc, Email, Telephone, Address) " +
                "VALUES " +
                "(@Surname, @Name, @Patronimyc, @Email, @Telephone, @Address)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Patronimyc", client.Patronimyc);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Telephone", client.Telephone);
                cmd.Parameters.AddWithValue("@Address", client.Address);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id) 
        {
            string deleteQuery = "DELETE FROM Clients WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsDeleted = cmd.ExecuteNonQuery();
                if(rowsDeleted > 0) 
                    return true;
                return false;
            }
        }

        public bool Update(Models.ClientSAT client)
        {
            string updateQuery = "UPDATE Clients SET Surname = @Surname, Name = @Name, Patronimyc = @Patronimyc, Email = @Email," +
                "Telephone = @Telephone, Address = @Address WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Patronimyc", client.Patronimyc);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Telephone", client.Telephone);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Id", client.Id);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if(rowsUpdated > 0) 
                    return true;
                return false;
            }
        }

        public Models.ClientSAT? Get(int id)
        {
            string selectQuery = "SELECT * FROM Clients WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Models.ClientSAT client = new Models.ClientSAT
                        {
                            Id = reader.GetInt32("Id"),
                            Surname = reader.GetString("Surname"),
                            Name = reader.GetString("Name"),
                            Patronimyc = reader.GetString("Patronimyc"),
                            Email = reader.GetString("Email"),
                            Telephone = reader.GetString("Telephone"),
                            Address = reader.GetString("Address")
                        };
                        return client;
                    }
                }
            }
            return null;
        }

        public List<Models.ClientSAT> GetAll()
        {
            List<Models.ClientSAT>clients = new List<Models.ClientSAT>();
            string selectQuery = "SELECT * FROM Clients";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Models.ClientSAT client = new()
                    {
                        Id = reader.GetInt32("Id"),
                        Surname = reader.GetString("Surname"),
                        Name = reader.GetString("Name"),
                        Patronimyc = reader.GetString("Patronimyc"),
                        Email = reader.GetString("Email"),
                        Telephone = reader.GetString("Telephone"),
                        Address = reader.GetString("Address")
                    };
                    clients.Add(client);
                }
            }
            return clients;
        }
    }
}
