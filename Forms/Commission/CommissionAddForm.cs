using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventTicket.Models;
using EventTicket.Repositories;

namespace EventTicket.Forms.Commission
{
    public partial class CommissionAddForm : Form
    {
        private readonly CommissionRepository _commissionRepository;
        private readonly ClientRepository _clientRepository;
        private readonly EventRepository _eventRepository;
        int id;
        public CommissionAddForm(CommissionRepository commissionRepository, ClientRepository clientRepository, EventRepository eventRepository, int id)
        {
            InitializeComponent();
            _commissionRepository = commissionRepository;
            _clientRepository = clientRepository;
            _eventRepository = eventRepository;
            this.id = id;

            if (id == 0)
            {
                this.Text = "Добавление заказа";
                btnAddOrEdit.Text = "Добавить";

                dataGridViewClients.DataSource = null;
                dataGridViewEvents.DataSource = null;

                var clients = _clientRepository.GetAll();
                var events = _eventRepository.GetAll();

                dataGridViewClients.DataSource = clients;
                dataGridViewEvents.DataSource = events;

                label1.Visible = false;
                inputEventName.Visible = false;

                inputClientName.Visible = false;
                inputClientAddress.Visible = false;
                inputClientTelephone.Visible = false;
                label9.Visible = false;

                label11.Visible = false;
                label10.Visible = false;

                textBox11.Visible = false;
                textBox22.Visible = false;
                textBox3.Visible = false;
            }
            else
            {
                this.Text = "Редактирование заказа";
                btnAddOrEdit.Text = "Редактировать";

                Size = new Size(365, 725);
                btnAddOrEdit.Location = new(12, 606);

                label5.Visible = false;
                label6.Visible = false;
                dataGridViewClients.Visible = false;
                dataGridViewEvents.Visible = false;

                label7.Text = "Имя клиента";
                label8.Text = "Адрес клиента";

                inputOrderNote.Visible = false;
                cbStatusChoose.Visible = false;

                label10.Text = "Примечание к заказу";
                label11.Text = "Статус";

                inputEventName.Enabled = false;
                inputClientName.Enabled = false;
                inputClientAddress.Enabled = false;
                inputClientTelephone.Enabled = false;

                var commissionToFill = _commissionRepository.Get(id);

                inputEventName.Text = commissionToFill.EventName;
                inputClientName.Text = commissionToFill.ClientName;
                inputClientAddress.Text = commissionToFill.ClientAddress;
                inputClientTelephone.Text = commissionToFill.ClientTelephone;
                textBox11.Text = commissionToFill.Status;
                textBox22.Text = commissionToFill.Note;
                inputOrderPrice.Value = commissionToFill.OrderPrice;
                inputTicketCount.Value = commissionToFill.TicketCount;
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewEvents.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if(btnAddOrEdit.Text == "Добавить")
            {
                if (cbStatusChoose.Text == "") { MessageBox.Show("Поле 'Статус' не должно быть пустым!"); return; }
                if (inputOrderNote.Text == "") { MessageBox.Show("Поле 'Примечание' не должно быть пустым!"); return; }

                try
                {
                    if(dataGridViewClients.SelectedRows.Count == 1 && dataGridViewEvents.SelectedRows.Count == 1)
                    {
                        var selectedRow = dataGridViewClients.SelectedRows[0];
                        var clientId = selectedRow.Cells["Id"].Value;

                        selectedRow = dataGridViewEvents.SelectedRows[0];
                        var eventId = selectedRow.Cells["Id"].Value;

                        if (clientId != null && int.TryParse(clientId.ToString(), out int cId))
                        {
                            if (eventId != null && int.TryParse(eventId.ToString(), out int eId)) 
                            {
                                CommissionSAT commissionSAT = new()
                                {
                                    EventId = eId,
                                    TicketCount = (int)inputTicketCount.Value,
                                    OrderPrice = (int)inputOrderPrice.Value,
                                    ClientId = cId,
                                    Status = cbStatusChoose.Text,
                                    Note = inputOrderNote.Text,
                                };

                                _commissionRepository.Add(commissionSAT);
                                MessageBox.Show("Заказ успешно добавлен!");
                                this.Close();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Произошла ошибка! " + ex.Message);
                }
            }
            if(btnAddOrEdit.Text == "Редактировать")
            {
                try
                {
                    CommissionSAT commissionSAT = new()
                    {
                        Id = id,
                        TicketCount = (int)inputTicketCount.Value,
                        OrderPrice = (int)inputOrderPrice.Value,
                        Status = textBox11.Text,
                        Note = textBox22.Text,
                    };

                    _commissionRepository.Update(commissionSAT);
                    MessageBox.Show("Заказ успешно обновлен!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Произошла ошибка! " + ex.Message);
                }
            }
        }
    }
}
