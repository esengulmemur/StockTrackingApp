using Core.Entities;
using EntityFrameworkCore.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp.Customers
{
    public partial class frmAddCustomer : Form
    {
        private readonly IStockTrackingRepository<Customer> _customerRepository;
        public frmAddCustomer(IStockTrackingRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;

            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer()
                {
                    TC = txtTC.Text,
                    FullName = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Adress = txtAdress.Text,
                    Email = txtEMail.Text
                };

                await _customerRepository.AddAsync(customer);

                DialogResult = DialogResult.OK;
                frmAddCustomer.ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
