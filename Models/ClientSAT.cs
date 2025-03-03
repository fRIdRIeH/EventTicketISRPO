using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EventTicket.Models
{
    public class ClientSAT
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronimyc { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

        public ClientSAT() { }

        public ClientSAT(string surname, string name, string patronimyc, string email, string telephone, string address)
        {
            Surname = surname; Name = name; Patronimyc = patronimyc; Email = email; Telephone = telephone; Address = address;
        }

        public ClientSAT(int id, string surname, string name, string patronimyc, string email, string telephone, string address)
        {
            Id = id; Surname = surname; Name = name; Patronimyc = patronimyc; Email = email; Telephone = telephone; Address = address;
        }
    }

}
