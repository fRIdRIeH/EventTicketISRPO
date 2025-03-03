using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventTicket.Models;
using EventTicket.Repositories;

namespace EventTicket.Forms.Event
{
    public partial class EventAddForm : Form
    {
        private readonly int id;
        private readonly EventRepository _eventRepository;
        public EventAddForm(EventRepository eventRepository, int id)
        {
            InitializeComponent();
            _eventRepository = eventRepository;
            this.id = id;

            if (id == 0)
            {
                this.Text = "Добавление мероприятия";
                btnAddOrEdit.Text = "Добавление";
            }
            else
            {
                this.Text = "Редактирование мероприятия";
                btnAddOrEdit.Text = "Редактировать";

                var eventToFill = _eventRepository.Get(id);

                nameEventInput.Text = eventToFill.Name;
                dateEventInput.Value = eventToFill.Date;
                timeEventInput.Value = DateTime.Today.Add(eventToFill.Time.ToTimeSpan());
                placeEventInput.Text = eventToFill.Place;
                ticketPriceEventInput.Value = eventToFill.TicketPrice;
                seatAmountEventInput.Value = eventToFill.SeatAmount;
                descriptionEventInput.Text = eventToFill.Description;
            }
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if(btnAddOrEdit.Text == "Добавление")
            {
                if (nameEventInput.Text == "") { MessageBox.Show("Поле 'название' не должно быть пустым!"); return; }
                if (placeEventInput.Text == "") { MessageBox.Show("Поле 'Место мероприятия' не должно быть пустым!"); return; }
                if (ticketPriceEventInput.Value == 0) { MessageBox.Show("Поле 'Цена билета' не должно быть равно 0!"); return; }
                if (seatAmountEventInput.Value == 0) { MessageBox.Show("Поле 'Количество мест' не должно быть пустым!"); return; }
                if (descriptionEventInput.Text == "") { MessageBox.Show("Поле 'Описание' не должно быть пустым!"); return; }

                try
                {
                    EventSAT eventSAT = new EventSAT() 
                    {
                        Name = nameEventInput.Text,
                        Date = dateEventInput.Value.Date,
                        Time = TimeOnly.FromDateTime(timeEventInput.Value),
                        Place = placeEventInput.Text,
                        TicketPrice = (int)ticketPriceEventInput.Value,
                        SeatAmount = (int)seatAmountEventInput.Value, 
                        Description = descriptionEventInput.Text,
                    };

                    _eventRepository.Add(eventSAT);
                    MessageBox.Show("Мероприятие успешно добавлено!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка! " +  ex.Message);
                }
            }
            if(btnAddOrEdit.Text == "Редактировать")
            {
                if (nameEventInput.Text == "") { MessageBox.Show("Поле 'название' не должно быть пустым!"); return; }
                if (placeEventInput.Text == "") { MessageBox.Show("Поле 'Место мероприятия' не должно быть пустым!"); return; }
                if (ticketPriceEventInput.Value == 0) { MessageBox.Show("Поле 'Цена билета' не должно быть равно 0!"); return; }
                if (seatAmountEventInput.Value == 0) { MessageBox.Show("Поле 'Количество мест' не должно быть пустым!"); return; }
                if (descriptionEventInput.Text == "") { MessageBox.Show("Поле 'Описание' не должно быть пустым!"); return; }

                try
                {
                    EventSAT eventSAT = new EventSAT()
                    {
                        Id = id,
                        Name = nameEventInput.Text,
                        Date = dateEventInput.Value.Date,
                        Time = TimeOnly.FromDateTime(timeEventInput.Value),
                        Place = placeEventInput.Text,
                        TicketPrice = (int)ticketPriceEventInput.Value,
                        SeatAmount = (int)seatAmountEventInput.Value,
                        Description = descriptionEventInput.Text,
                    };

                    _eventRepository.Update(eventSAT);
                    MessageBox.Show("Мероприятие успешно редактировано!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }
            }
        }
    }
}
