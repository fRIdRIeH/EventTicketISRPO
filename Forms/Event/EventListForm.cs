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
            LoadData();
        }

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewEvents.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadData()
        {
            var events = _eventRepository.GetAll();

            dataGridViewEvents.DataSource = null;
            dataGridViewEvents.DataSource = events;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventAddForm eventAddForm = new EventAddForm(_eventRepository, 0);
            eventAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewEvents.SelectedRows.Count == 1)
            {
                var selectedRows = dataGridViewEvents.SelectedRows[0];
                var eventId = selectedRows.Cells[0].Value;

                if (eventId != null && int.TryParse(eventId.ToString(), out int id))
                {
                    try
                    {
                        _eventRepository.Delete(id);

                        LoadData();
                        MessageBox.Show("Мероприятие удалено.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка! " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridViewEvents.SelectedRows.Count == 1)
            {
                var selectedRows = dataGridViewEvents.SelectedRows[0];
                var eventId = selectedRows.Cells[0].Value;

                if (eventId != null && int.TryParse(eventId.ToString(), out int id))
                {
                    EventAddForm eventAddForm = new EventAddForm(_eventRepository, id);
                    eventAddForm.ShowDialog();
                }
            }
        }
    }
}
