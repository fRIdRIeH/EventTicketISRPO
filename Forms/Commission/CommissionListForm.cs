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

namespace EventTicket.Forms.Commission
{
    public partial class CommissionListForm : Form
    {
        private readonly CommissionRepository _commissionRepository;
        private readonly ClientRepository _clientRepository;
        private readonly EventRepository _eventRepository;
        public CommissionListForm(CommissionRepository commissionRepository, ClientRepository clientRepository, EventRepository eventRepository)
        {
            InitializeComponent();
            _commissionRepository = commissionRepository;
            _clientRepository = clientRepository;
            _eventRepository = eventRepository;
            LoadData();
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewOrders.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadData()
        {
            var orders = _commissionRepository.GetAll();

            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = orders;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommissionAddForm commissionAddForm = new CommissionAddForm(_commissionRepository, _clientRepository, _eventRepository, 0);
            commissionAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                var orderId = selectedRow.Cells["Id"].Value;

                if(orderId != null && int.TryParse(orderId.ToString(), out int id))
                {
                    try
                    {
                        _commissionRepository.Delete(id);

                        LoadData();
                        MessageBox.Show("Заказ удален.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ошибка! " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                var orderId = selectedRow.Cells["Id"].Value;

                if (orderId != null && int.TryParse(orderId.ToString(), out int id))
                {
                    CommissionAddForm commissionAddForm = new CommissionAddForm(_commissionRepository, _clientRepository, _eventRepository, id);
                    commissionAddForm.ShowDialog();
                }
            }
        }
    }
}
