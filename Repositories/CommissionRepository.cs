using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
