using EventTicket.Forms.Client;
using EventTicket.Forms.Commission;
using EventTicket.Forms.Event;
using EventTicket.Repositories;
using MySql.Data.MySqlClient;

namespace EventTicket
{
    public partial class MainForm : Form
    {
        private readonly MySqlConnection _connection;
        public MainForm(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void btnGoToEventList_Click(object sender, EventArgs e)
        {
            EventRepository eventRepository = new(_connection);
            EventListForm eventListForm = new EventListForm(eventRepository);
            eventListForm.ShowDialog();
        }

        private void btnGoToClientList_Click(object sender, EventArgs e)
        {
            ClientRepository clientRepository = new(_connection);
            ClientListForm clientListForm = new ClientListForm(clientRepository);
            clientListForm.ShowDialog();
        }

        private void btnGoToCommissionList_Click(object sender, EventArgs e)
        {
            CommissionRepository commissionRepository = new(_connection);
            ClientRepository clientRepository = new(_connection);
            EventRepository eventRepository = new(_connection);
            CommissionListForm commissionListForm = new CommissionListForm(commissionRepository, clientRepository, eventRepository);
            commissionListForm.ShowDialog();
        }
    }
}
