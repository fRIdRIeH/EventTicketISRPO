using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using EventTicket.Models;
using MySql.Data.MySqlClient;

namespace EventTicket.Repositories
{
    public class EventRepository
    {
        private readonly MySqlConnection _connection;

        public EventRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(EventSAT eventSAT)
        {
            string insertQuery = "INSERT INTO Events " +
                "(Name, Date, Time, Place, Ticket_Price, Seat_Amount, Description) " +
                "VALUES " +
                "(@Name, @Date, @Time, @Place, @Ticket_Price, @Seat_Amount, @Description)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", eventSAT.Name);
                cmd.Parameters.AddWithValue("@Date", eventSAT.Date);
                cmd.Parameters.AddWithValue("@Time", eventSAT.Time);
                cmd.Parameters.AddWithValue("@Place", eventSAT.Place);
                cmd.Parameters.AddWithValue("@Ticket_Price", eventSAT.TicketPrice);
                cmd.Parameters.AddWithValue("@Seat_Amount", eventSAT.SeatAmount);
                cmd.Parameters.AddWithValue("@Description", eventSAT.Description);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id)
        {
            string deleteQuery = "DELETE FROM Events WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsDeleted = cmd.ExecuteNonQuery();
                if(rowsDeleted > 0)
                    return true;
                return false;
            }
        }

        public bool Update(EventSAT eventSAT)
        {
            string updateQuery = "UPDATE Events SET Name = @Name, Date = @Date, Time = @Time, Place = @Place, Ticket_Price = @Ticket_Price, " +
                "Seat_Amount = @Seat_Amount, Description = @Description WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", eventSAT.Name);
                cmd.Parameters.AddWithValue("@Date", eventSAT.Date);
                cmd.Parameters.AddWithValue("@Time", eventSAT.Time);
                cmd.Parameters.AddWithValue("@Place", eventSAT.Place);
                cmd.Parameters.AddWithValue("@Ticket_Price", eventSAT.TicketPrice);
                cmd.Parameters.AddWithValue("@Seat_Amount", eventSAT.SeatAmount);
                cmd.Parameters.AddWithValue("@Description", eventSAT.Description);
                cmd.Parameters.AddWithValue("@Id", eventSAT.Id);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if(rowsUpdated > 0)
                    return true;
                return false;
            }
        }

        public EventSAT? Get(int id)
        {
            string selectQuery = "SELECT * FROM Events WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        EventSAT eventSAT = new EventSAT 
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Date = reader.GetDateTime("Date"),
                            Time = TimeOnly.FromTimeSpan(reader.GetTimeSpan("Time")),
                            Place = reader.GetString("Place"),
                            TicketPrice = reader.GetInt32("Ticket_Price"),
                            SeatAmount = reader.GetInt32("Seat_Amount"),
                            Description = reader.GetString("Description"),
                        };
                        return eventSAT;
                    };
                }
            }
            return null;
        }

        public List<EventSAT> GetAll()
        { 
            List<EventSAT> events = new List<EventSAT>();
            string selectQuery = "SELECT * FROM Events";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    EventSAT eventSAT = new()
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Date = reader.GetDateTime("Date"),
                        Time = TimeOnly.FromTimeSpan(reader.GetTimeSpan("Time")),
                        Place = reader.GetString("Place"),
                        TicketPrice = reader.GetInt32("Ticket_Price"),
                        SeatAmount = reader.GetInt32("Seat_Amount"),
                        Description = reader.GetString("Description"),
                    };
                    events.Add(eventSAT);
                }
            }
            return events;
        }
    }
}
