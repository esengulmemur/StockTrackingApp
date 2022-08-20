using StockTrackingApp.BL;
using StockTrackingApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class FrmListCustomer : Form
    {
        private readonly IStockTrackingRepository<Customer> _customerRepository;
        private int id = 0;

        public FrmListCustomer(IStockTrackingRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
            InitializeComponent();
        }

        private async void FrmListCustomer_Load(object sender, EventArgs e)
        {
            await GetCustomersAsync();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            txtPhoneNumber.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            txtAdress.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            txtEMail.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            int.TryParse(dgvCustomers.CurrentRow.Cells["Id"].Value.ToString(), out id);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = await _customerRepository.GetAsync(x => x.Id == id);
                if (customer != null)
                {
                    customer.TC = txtTC.Text;
                    customer.FullName = txtFullName.Text;
                    customer.PhoneNumber = txtPhoneNumber.Text;
                    customer.Adress = txtAdress.Text;
                    customer.Email = txtEMail.Text;

                    await _customerRepository.UpdateAsync(customer);
                    await GetCustomersAsync();

                    MessageBox.Show("Müşteri kaydı güncellendi!", "Başarılı");
                    ClearTexts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"{txtFullName.Text} müşterisi silinecektir!", "Emin Misiniz?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _customerRepository.DeleteAsync(id);
                    await GetCustomersAsync();
                    MessageBox.Show("Kullanıcı başarılı bir şekilde silindi", "Başarılı");
                    ClearTexts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private async void txtTCSearch_TextChanged(object sender, EventArgs e)
        {
            await GetCustomersAsync();
        }

        #region Helper Methods
        private void ClearTexts()
        {
            txtAdress.Text = "";
            txtEMail.Text = "";
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
            txtTC.Text = "";
            txtTCSearch.Text = "";
            id = 0;
        }

        private async Task GetCustomersAsync()
        {
            //*** filtered by tc
            if (string.IsNullOrEmpty(txtTCSearch.Text))
                dgvCustomers.DataSource = await _customerRepository
                    .ListAsync();
            else
                dgvCustomers.DataSource = await _customerRepository
                    .ListAsync(x => x.TC.Contains(txtTCSearch.Text));

            dgvCustomers.Columns[0].HeaderText = "TC";
            dgvCustomers.Columns[1].HeaderText = "Ad Soyad";
            dgvCustomers.Columns[2].HeaderText = "Tel No";
            dgvCustomers.Columns[3].HeaderText = "Adres";
            dgvCustomers.Columns[4].HeaderText = "E-mail";
            dgvCustomers.Columns["Id"].Visible = false;
        }
        #endregion
    }
}
