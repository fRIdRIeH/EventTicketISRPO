using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicket.Models
{
    public class EventSAT
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Place {  get; set; }
        public int TicketPrice { get; set; }
        public int SeatAmount { get; set; }
        public string Description { get; set; }

        public EventSAT() { }

        public EventSAT(string name, DateTime date, TimeOnly time, string place, int ticketPrice, int seatAmount, string description)
        {
            Name = name;
            Date = date;
            Time = time;
            Place = place;
            TicketPrice = ticketPrice;
            SeatAmount = seatAmount;
            Description = description;
        }

        public EventSAT(int id, string name, DateTime date, TimeOnly time, string place, int ticketPrice, int seatAmount, string description)
        {
            Id = id;
            Name = name;
            Date = date;
            Time = time;
            Place = place;
            TicketPrice = ticketPrice;
            SeatAmount = seatAmount;
            Description = description;
        }
    }
}
