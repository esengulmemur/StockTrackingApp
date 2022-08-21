using Core.Entities;
using EntityFrameworkCore.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using StockTrackingApp.Brands;
using StockTrackingApp.Categories;
using StockTrackingApp.Customers;
using StockTrackingApp.Products;

namespace StockTrackingApp
{
    public partial class formSales : Form
    {
        private readonly IStockTrackingRepository<Customer> _customerRepository;
        private readonly frmAddCustomer _formAddCustomer;
        private readonly FrmListCustomer _formListCustomer;
        private readonly FormAddProduct _formAddProduct;
        private readonly FormCategory _formCategory;
        private readonly FormBrand _formBrand;

        public formSales(IStockTrackingRepository<Customer> customerRepository,
            frmAddCustomer formAddCustomer,
            FrmListCustomer formListCustomer,
            FormCategory formCategory,
            FormBrand formBrand,
            FormAddProduct formAddProduct)
        {
            _customerRepository = customerRepository;
            _formAddCustomer = formAddCustomer;
            _formListCustomer = formListCustomer;
            _formAddProduct = formAddProduct;
            _formCategory = formCategory;
            _formBrand = formBrand;

            InitializeComponent();

            //GetCustomers();
        }

        public void GetCustomers()
        {
            try
            {
                #region Filtre oluþturma sonraveriyi çekme iþlemi
                //*** create query
                //var asd = _customerRepository.Query(x => x.FullName.ToLower().Contains("memur")).ToList();
                #endregion

                #region Silme
                var customer = _customerRepository.Get(x => x.Id == 5);
                if (customer != null)
                {
                    _customerRepository.Delete(customer);
                }
                #endregion

                #region Güncelleme
                //var customer = _customerRepository.Get(x => x.Id == 5);
                //if (customer != null)
                //{
                //    customer.PhoneNumber = "5555555523";
                //    _customerRepository.Update(customer);
                //}
                #endregion

                #region Ekleme
                //*** create customer
                //var customer = new Customer()
                //{
                //    TC = "11111111113",
                //    Adress = "Malatya Malatya",
                //    FullName = "Günay Memur",
                //    Email = "memurgunay@esengul.com",
                //    PhoneNumber = "5555555551"
                //};

                //_customerRepository.Add(customer); 
                #endregion

                var customers = _customerRepository.List();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _formAddCustomer.ShowDialog();
            if(_formAddCustomer.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Müþteri baþarýlý bir þekilde eklendi.", "Baþarýlý");
            }
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            _formListCustomer.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _formAddProduct.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            _formCategory.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            _formBrand.ShowDialog();
        }
    }
}