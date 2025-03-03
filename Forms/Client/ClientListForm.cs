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
    public partial class ClientListForm : Form
    {
        private readonly ClientRepository _clientRepository;
        public ClientListForm(ClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm(_clientRepository, 0);
            clientAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 1)
            {
                var selectedRows = dataGridViewClients.SelectedRows[0];

                var clientId = selectedRows.Cells["Id"].Value;

                if (clientId != null && int.TryParse(clientId.ToString(), out int id))
                {
                    try
                    {
                        _clientRepository.Delete(id);

                        LoadData();
                        MessageBox.Show("Клиент удален.");
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
            if (dataGridViewClients.SelectedRows.Count == 1)
            {
                var selectedRows = dataGridViewClients.SelectedRows[0];

                var clientId = selectedRows.Cells["Id"].Value;

                if (clientId != null && int.TryParse(clientId.ToString(), out int id))
                {
                    ClientAddForm clientAddForm = new ClientAddForm(_clientRepository, id);
                    clientAddForm.ShowDialog();
                }
            }
        }

        private void LoadData()
        {
            var clients = _clientRepository.GetAll();

            dataGridViewClients.DataSource = null;
            dataGridViewClients.DataSource = clients;
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
