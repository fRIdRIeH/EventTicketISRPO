using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicket.Models
{
    public class CommissionSAT
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int TicketCount { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderPrice { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientTelephone { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

        public CommissionSAT() { }

        public CommissionSAT(int eventId, string eventName, int ticketCount, DateTime orderDate, int clientId, string clientName, string clientAddress, string clientTelephone, string status, string note)
        {
            EventId = eventId;
            EventName = eventName;
            TicketCount = ticketCount;
            OrderDate = orderDate;
            ClientId = clientId;
            ClientName = clientName;
            ClientAddress = clientAddress;
            ClientTelephone = clientTelephone;
            Status = status;
            Note = note;
        }

        public CommissionSAT(int id, int eventId, string eventName, int ticketCount, DateTime orderDate, int clientId, string clientName, string clientAddress, string clientTelephone, string status, string note)
        {
            Id = id;
            EventId = eventId;
            EventName = eventName;
            TicketCount = ticketCount;
            OrderDate = orderDate;
            ClientId = clientId;
            ClientName = clientName;
            ClientAddress = clientAddress;
            ClientTelephone = clientTelephone;
            Status = status;
            Note = note;
        }

        public CommissionSAT(int eventId, int ticketCount, int orderPrice, int clientId, string status, string note)
        {
            EventId = eventId;
            TicketCount = ticketCount;
            OrderPrice = orderPrice;
            ClientId = clientId;
            Status = status;
            Note = note;
        }

        public CommissionSAT(int id, int ticketCount, int orderPrice, string status, string note)
        {
            Id = id;
            TicketCount = ticketCount;
            OrderPrice = orderPrice;
            Status = status;
            Note = note;
        }
    }
}
