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
        private readonly IStockTrackingRepository<Basket> _basketRepository;
        private readonly IStockTrackingRepository<Product> _productRepository;
        private readonly frmAddCustomer _formAddCustomer;
        private readonly FrmListCustomer _formListCustomer;
        private readonly FormAddProduct _formAddProduct;
        private readonly FormListProduct _formListProduct;
        private readonly FormCategory _formCategory;
        private readonly FormBrand _formBrand;

        private string TC = "";
        private string barcode = "";
        private int amount = 0;

        public formSales(IStockTrackingRepository<Customer> customerRepository,
            IStockTrackingRepository<Basket> basketRepository,
            IStockTrackingRepository<Product> productRepository,
            frmAddCustomer formAddCustomer,
            FrmListCustomer formListCustomer,
            FormCategory formCategory,
            FormBrand formBrand,
            FormAddProduct formAddProduct,
            FormListProduct formListProduct)
        {
            _customerRepository = customerRepository;
            _formAddCustomer = formAddCustomer;
            _formListCustomer = formListCustomer;
            _formAddProduct = formAddProduct;
            _formCategory = formCategory;
            _formBrand = formBrand;
            _formListProduct = formListProduct;
            _basketRepository = basketRepository;
            _productRepository = productRepository;

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
            if (_formAddCustomer.DialogResult == DialogResult.OK)
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

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            _formListProduct.ShowDialog();

        }

        private async void formSales_Load(object sender, EventArgs e)
        {
            await GetBasketsAsync();
        }

        private async Task GetBasketsAsync()
        {
            var query = _basketRepository.Query();
            //if (!string.IsNullOrEmpty(txtTC.Text))
            //    query = query.Where(x => x.TC.Contains(txtTC.Text));
            //if(!string.IsNullOrEmpty(txtFullName.Text))
            //    query = query.Where(x => x.FullName.Contains(txtFullName.Text));
            //if(!string.IsNullOrEmpty(txtPhoneNumber.Text))
            //    query = query.Where(x => x.PhoneNumber.Contains(txtPhoneNumber.Text));

            dgvBaskets.DataSource = await query.ToListAsync();

            dgvBaskets.Columns[0].HeaderText = "TC";
            dgvBaskets.Columns[1].HeaderText = "Ad Soyad";
            dgvBaskets.Columns[2].HeaderText = "Tel No";
            dgvBaskets.Columns[3].HeaderText = "Barkod";
            dgvBaskets.Columns[4].HeaderText = "Ürün Adý";
            dgvBaskets.Columns[5].HeaderText = "Miktarý";
            dgvBaskets.Columns[6].HeaderText = "Satýþ Fiyatý";
            dgvBaskets.Columns[7].HeaderText = "Total Fiyat";
            dgvBaskets.Columns["Id"].Visible = false;
        }

        private async void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTC.Text))
            {
                CustomerOperationClear();
            }
            else
            {
                var customer = await _customerRepository.GetAsync(x => x.TC.Contains(txtTC.Text));
                if(customer != null)
                {
                    txtFullName.Text = customer.FullName;
                    txtPhoneNumber.Text = customer.PhoneNumber;
                    TC = customer.TC;
                } 
            }
        }

        private async void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarcode.Text))
            {
                ProductOperationClear();
            }
            else
            {
                var product = await _productRepository.GetAsync(x => x.Barcode.Contains(txtBarcode.Text));
                if (product != null)
                {
                    txtProductName.Text = product.Name;
                    txtPrice.Text = product.SalePrice.ToString();
                    txtTotalPrice.Text = product.PurchasePrice.ToString();
                    barcode = product.Barcode;
                    amount = product.Amount;
                    txtAmount.Text = "1";
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TC) || string.IsNullOrEmpty(barcode) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Lütfen ilgili alanlarý boþ geçmeyiniz!", "Uyarý");
                return;
            }

            if (await basketControlAsync())
            {
                var basket = await _basketRepository.GetAsync(x => x.BarkodeNo == barcode && x.TC == TC);
                if(basket != null)
                {
                    basket.Amount += int.Parse(txtAmount.Text);
                    basket.TotalPrice = basket.Amount * basket.SalePrice;
                    await _basketRepository.UpdateAsync(basket);

                    MessageBox.Show("Sepetteki ürün güncellendi.", "Baþarýlý");
                }
                else
                {
                    MessageBox.Show("Kayýt bulunamadý.", "Hata");
                }
            }
            else
            {
                var basket = new Basket()
                {
                    TC = TC,
                    FullName = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    BarkodeNo = barcode,
                    Amount = int.Parse(txtAmount.Text),
                    ProductName = txtProductName.Text,
                    SalePrice = decimal.Parse(txtPrice.Text),
                    TotalPrice = decimal.Parse(txtTotalPrice.Text),
                    Date = DateTime.Now
                };

                await _basketRepository.AddAsync(basket);

                MessageBox.Show("Ürün sepete eklendi.", "Baþarýlý");
            }

            ClearAll();

            await GetBasketsAsync();
        }

        public void ClearAll()
        {
            CustomerOperationClear();
            ProductOperationClear();
        }

        public void CustomerOperationClear()
        {
            txtTC.Text = "";
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
            TC = "";
        }

        public void ProductOperationClear()
        {
            foreach (var item in grbProductOperations.Controls)
            {
                if (item is TextBox)
                {
                    var i = (TextBox)item;
                    i.Text = "";
                }
            }

            barcode = "";
            amount = 0;
        }

        private async Task<bool> basketControlAsync()
        {
            return await _basketRepository.Query(x => x.BarkodeNo == barcode && x.TC == TC).AnyAsync();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAmount.Text))
                {
                    var customerAmount = decimal.Parse(txtAmount.Text);
                    if (customerAmount > amount)
                        MessageBox.Show("Stok yetersiz!", "Uyarý");

                    txtTotalPrice.Text = (decimal.Parse(txtPrice.Text) * customerAmount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _basketRepository.DeleteAsync(dgvBaskets.CurrentRow.Cells["Id"].Value);

                MessageBox.Show("Ürün sepetten kaldýrýldý.", "Baþarýlý");

                await GetBasketsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private async void btnSalesCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var baskets = await _basketRepository.ListAsync();

                await _basketRepository.DeleteRangeAsync(baskets);

                MessageBox.Show("Ürünler sepetten kaldýrýldý.", "Baþarýlý");

                await GetBasketsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}