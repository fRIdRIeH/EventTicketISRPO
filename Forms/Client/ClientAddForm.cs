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

namespace EventTicket.Forms.Client
{
    public partial class ClientAddForm : Form
    {
        ClientRepository _clientRepostiory;
        int id;
        public ClientAddForm(ClientRepository clientRepository, int id)
        {
            InitializeComponent();
            _clientRepostiory = clientRepository;
            this.id = id;

            if (id == 0)
            {
                this.Text = "Добавление клиента";
                btnAddOrEdit.Text = "Добавить";
            }
            else
            {
                this.Text = "Редактирование клиента";
                btnAddOrEdit.Text = "Редактировать";

                var clientToFill = _clientRepostiory.Get(id);

                inputSurnameText.Text = clientToFill.Surname;
                inputNameText.Text = clientToFill.Name;
                inputPatronimycText.Text = clientToFill.Patronimyc;
                inputEmailText.Text = clientToFill.Email;
                inputTelephoneText.Text = clientToFill.Telephone;
                inputAddressText.Text = clientToFill.Address;
            }
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if(btnAddOrEdit.Text == "Добавить")
            {
                if (inputSurnameText.Text == "") { MessageBox.Show("Ошибка! Поле 'Фамилия' должно быть заполненно!"); return; }
                if (inputNameText.Text == "") { MessageBox.Show("Ошибка! Поле 'Имя' должно быть заполненно!"); return; }
                if (inputPatronimycText.Text == "") { MessageBox.Show("Ошибка! Поле 'Отчество' должно быть заполненно!"); return; }
                if (inputEmailText.Text == "") { MessageBox.Show("Ошибка! Поле 'Почта' должно быть заполненно!"); return; }
                if (inputTelephoneText.Text == "") { MessageBox.Show("Ошибка! Поле 'Телефон' должно быть заполненно!"); return; }
                if (inputAddressText.Text == "") { MessageBox.Show("Ошибка! Поле 'Адрес' должно быть заполненно!"); return; }

                try
                {
                    Models.ClientSAT client = new()
                    {
                        Surname = inputSurnameText.Text,
                        Name = inputNameText.Text,
                        Patronimyc = inputPatronimycText.Text,
                        Email = inputEmailText.Text,
                        Telephone = inputTelephoneText.Text,
                        Address = inputAddressText.Text,
                    };
                    _clientRepostiory.Add(client);
                    MessageBox.Show("Клиент успешно добавлен!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }
            }
            if(btnAddOrEdit.Text == "Редактировать")
            {
                if (inputSurnameText.Text == "") { MessageBox.Show("Ошибка! Поле 'Фамилия' должно быть заполненно!"); return; }
                if (inputNameText.Text == "") { MessageBox.Show("Ошибка! Поле 'Имя' должно быть заполненно!"); return; }
                if (inputPatronimycText.Text == "") { MessageBox.Show("Ошибка! Поле 'Отчество' должно быть заполненно!"); return; }
                if (inputEmailText.Text == "") { MessageBox.Show("Ошибка! Поле 'Почта' должно быть заполненно!"); return; }
                if (inputTelephoneText.Text == "") { MessageBox.Show("Ошибка! Поле 'Телефон' должно быть заполненно!"); return; }
                if (inputAddressText.Text == "") { MessageBox.Show("Ошибка! Поле 'Адрес' должно быть заполненно!"); return; }

                try
                {
                    Models.ClientSAT client = new()
                    {
                        Id = id,
                        Surname = inputSurnameText.Text,
                        Name = inputNameText.Text,
                        Patronimyc = inputPatronimycText.Text,
                        Email = inputEmailText.Text,
                        Telephone = inputTelephoneText.Text,
                        Address = inputAddressText.Text,
                    };
                    _clientRepostiory.Update(client);
                    MessageBox.Show("Данные клиента успешно отредактированы!");
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
