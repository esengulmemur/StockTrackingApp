using Microsoft.EntityFrameworkCore;
using StockTrackingApp.BL;
using StockTrackingApp.Repositories;

namespace StockTrackingApp
{
    public partial class Form1 : Form
    {
        private readonly IStockTrackingRepository<Customer> _customerRepository;
        public Form1(IStockTrackingRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;

            InitializeComponent();

            GetCustomers();
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
    }
}