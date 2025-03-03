using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventTicket.Repositories;

namespace EventTicket.Forms.Event
{
    public partial class EventListForm : Form
    {
        private readonly EventRepository _eventRepository;
        public EventListForm(EventRepository eventRepository)
        {
            InitializeComponent();
            _eventRepository = eventRepository;
        }
    }
}
