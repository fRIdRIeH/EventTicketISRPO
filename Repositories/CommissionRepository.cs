using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventTicket.Models;
using MySql.Data.MySqlClient;

namespace EventTicket.Repositories
{
    public class CommissionRepository
    {
        private readonly MySqlConnection _connection;

        public CommissionRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(CommissionSAT commissionSAT)
        {
            string insertQuery = "INSERT INTO Orders " +
                "(Event_Id, Ticket_Count, Order_Price, Client_Id, Status, Note) " +
                "VALUES " +
                "(@Event_Id, @Ticket_Count, @Order_Price, @Client_Id, @Status, @Note)";

            using(MySqlCommand cmd = new MySqlCommand(insertQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Event_Id", commissionSAT.EventId);
                cmd.Parameters.AddWithValue("@Ticket_Count", commissionSAT.TicketCount);
                cmd.Parameters.AddWithValue("@Order_Price", commissionSAT.OrderPrice);
                cmd.Parameters.AddWithValue("@Client_Id", commissionSAT.ClientId);
                cmd.Parameters.AddWithValue("@Status", commissionSAT.Status);
                cmd.Parameters.AddWithValue("@Note", commissionSAT.Note);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id) 
        {
            string deleteQuery = "DELETE FROM Orders WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsDeleted = cmd.ExecuteNonQuery();
                if(rowsDeleted > 0) 
                    return true;
                return false;
            }
        }

        public bool Update(CommissionSAT commissionSAT)
        {
            string updateQuery = "UPDATE Orders SET Ticket_Count = @Ticket_Count, Order_Price = @Order_Price, Status = @Status, Note = @Note WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Ticket_Count", commissionSAT.TicketCount);
                cmd.Parameters.AddWithValue("@Order_Price", commissionSAT.OrderPrice);
                cmd.Parameters.AddWithValue("@Status", commissionSAT.Status);
                cmd.Parameters.AddWithValue("@Note", commissionSAT.Note);
                cmd.Parameters.AddWithValue("@Id", commissionSAT.Id);

                int rowsDeleted = cmd.ExecuteNonQuery();
                if (rowsDeleted > 0)
                    return true;
                return false;
            }
        }

        public CommissionSAT? Get(int id)
        {
            string selectQuery = "SELECT " +
                "o.Id, " +
                "o.Event_Id, " +
                "e.Name AS Event_Name, " +
                "o.Ticket_Count, " +
                "o.Order_Date, " +
                "o.Order_Price, " +
                "o.Client_Id, " +
                "c.Name AS Client_Name, " +
                "c.Address AS Client_Address, " +
                "c.Telephone AS Client_Telephone, " +
                "o.Status, " +
                "o.Note " +
                "FROM Orders o " +
                "JOIN Events e ON o.Event_Id = e.Id " +
                "JOIN Clients c ON o.Client_Id = c.Id " +
                "WHERE o.Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CommissionSAT commissionSAT = new CommissionSAT
                        {
                            Id = reader.GetInt32("Id"),
                            EventId = reader.GetInt32("Event_Id"),
                            EventName = reader.GetString("Event_Name"),
                            TicketCount = reader.GetInt32("Ticket_Count"),
                            OrderDate = reader.GetDateTime("Order_date"),
                            OrderPrice = reader.GetInt32("Order_Price"),
                            ClientId = reader.GetInt32("Client_Id"),
                            ClientName = reader.GetString("Client_Name"),
                            ClientAddress = reader.GetString("Client_Address"),
                            ClientTelephone = reader.GetString("Client_Telephone"),
                            Status = reader.GetString("Status"),
                            Note = reader.GetString("Note"),
                        };
                        return commissionSAT;
                    }
                }
            }
            return null;
        }

        public List<CommissionSAT> GetAll()
        {
            List<CommissionSAT> commissions = new List<CommissionSAT>();
            string selectQuery = "SELECT " +
                "o.Id, " +
                "o.Event_Id, " +
                "e.Name AS Event_Name, " +
                "o.Ticket_Count, " +
                "o.Order_Date, " +
                "o.Order_Price, " +
                "o.Client_Id, " +
                "c.Name AS Client_Name, " +
                "c.Address AS Client_Address, " +
                "c.Telephone AS Client_Telephone, " +
                "o.Status, " +
                "o.Note " +
                "FROM Orders o " +
                "JOIN Events e ON o.Event_Id = e.Id " +
                "JOIN Clients c ON o.Client_Id = c.Id";

            using( MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            using(MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CommissionSAT commissionSAT = new() 
                    {
                        Id = reader.GetInt32("Id"),
                        EventId = reader.GetInt32("Event_Id"),
                        EventName = reader.GetString("Event_Name"),
                        TicketCount = reader.GetInt32("Ticket_Count"),
                        OrderDate = reader.GetDateTime("Order_date"),
                        OrderPrice = reader.GetInt32("Order_Price"),
                        ClientId = reader.GetInt32("Client_Id"),
                        ClientName = reader.GetString("Client_Name"),
                        ClientAddress = reader.GetString("Client_Address"),
                        ClientTelephone = reader.GetString("Client_Telephone"),
                        Status = reader.GetString("Status"),
                        Note = reader.GetString("Note"),
                    };
                    commissions.Add(commissionSAT);
                }
                
                return commissions;
            }
        }
    }
}
