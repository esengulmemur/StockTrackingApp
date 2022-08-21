using Core.Entities;
using EntityFrameworkCore.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp.Products
{
    public partial class FormAddProduct : Form
    {
        private readonly IStockTrackingRepository<Brand> _brandRepository;
        private readonly IStockTrackingRepository<Category> _categoryRepository;
        private readonly IStockTrackingRepository<Product> _productRepository;
        private Product? existingProduct;
        private List<Category>? categories;
        private List<Brand>? brands;

        public FormAddProduct(IStockTrackingRepository<Category> categoryRepository,
            IStockTrackingRepository<Brand> brandRepository,
            IStockTrackingRepository<Product> productRepository)
        {
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _productRepository = productRepository;

            InitializeComponent();
        }

        private async void FormAddProduct_Load(object sender, EventArgs e)
        {
            await GetCategories();
            await GetBrands();
        }
        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product()
                {
                    CategoryId = ((KeyValuePair<string, int>)cmbNewCategory.SelectedItem).Value,
                    BrandId = ((KeyValuePair<string, int>)cmbNewBrand.SelectedItem).Value,
                    Amount = int.Parse(txtNewAmount.Text),
                    Barcode = txtNewBarcode.Text,
                    Name = txtNewProductName.Text,
                    PurchasePrice = decimal.Parse(txtNewPurchasePrice.Text),
                    SalePrice = decimal.Parse(txtNewSalePrice.Text)
                };

                await _productRepository.AddAsync(product);

                MessageBox.Show($"{product.Name} ürünü eklendi.", "Başarılı");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        private async void txtExistingBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtExistingBarcode.Text))
                {
                    lblAmounts.Text = "";
                    foreach(var item in grbExistingProduct.Controls)
                    {
                        if(item is TextBox)
                        {
                            var i = (TextBox)item;
                            i.Text = "";
                        }
                        else if (item is ComboBox)
                        {
                            var i = (ComboBox)item;
                            i.SelectedItem = null;
                            i.Text = "Seçiniz";
                        }
                    }
                }

                var product = await _productRepository
                    .Query(x => x.Barcode == txtExistingBarcode.Text)
                    .Include(x => x.Brand)
                    .Include(x => x.Category)
                    .FirstOrDefaultAsync();
                if(product != null)
                {
                    txtExistingAmount.Text = product.Amount.ToString();
                    txtExistingProductName.Text = product.Name;
                    txtExistingPurchasePrice.Text = product.PurchasePrice.ToString();
                    txtExistingSalePrice.Text = product.SalePrice.ToString();

                    cmbExistingCategory.Text = product.Category.Name;
                    cmbExistingCategory.SelectedItem = new { Key = product.Category.Name, Value = product.CategoryId};
                    //cmbExistingCategory.SelectedIndex = (categories != null && product.CategoryId > 0) ? 
                    //    categories.IndexOf(categories.Find(x => x.Id == product.CategoryId)) : 
                    //    0;

                    cmbExistingBrand.Text = product.Brand.Name;
                    cmbExistingBrand.SelectedItem = new { Key = product.Brand.Name, Value = product.BrandId };
                    //cmbExistingBrand.SelectedIndex = (brands != null && product.BrandId > 0) ? 
                    //    brands.IndexOf(brands.Find(x => x.Id == product.BrandId)) :
                    //    0;
                }
                existingProduct = product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        private async void btnAddExisting_Click(object sender, EventArgs e)
        {
            try
            {
                if(existingProduct != null)
                {
                    existingProduct.CategoryId = ((KeyValuePair<string, int>)cmbExistingCategory.SelectedItem).Value;
                    existingProduct.BrandId = ((KeyValuePair<string, int>)cmbExistingBrand.SelectedItem).Value;
                    existingProduct.Amount = int.Parse(txtExistingAmount.Text);
                    existingProduct.Barcode = txtExistingBarcode.Text;
                    existingProduct.Name = txtExistingProductName.Text;
                    existingProduct.PurchasePrice = decimal.Parse(txtExistingPurchasePrice.Text);
                    existingProduct.SalePrice = decimal.Parse(txtExistingSalePrice.Text);

                    await _productRepository.UpdateAsync(existingProduct);

                    MessageBox.Show($"{existingProduct.Name} ürünü Güncellendi.", "Başarılı");
                    existingProduct = null;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen girdiğiniz verileri kontrol ediniz.", "Hata");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        #region Helpers


        public void Clear()
        {
            txtExistingAmount.Text = "";
            txtExistingBarcode.Text = "";
            txtExistingProductName.Text = "";
            txtExistingPurchasePrice.Text = "";
            txtExistingSalePrice.Text = "";
            txtNewAmount.Text = "";
            txtNewBarcode.Text = "";
            txtNewProductName.Text = "";
            txtNewPurchasePrice.Text = "";
            txtNewSalePrice.Text = "";
            cmbExistingBrand.SelectedItem = null;
            cmbExistingCategory.SelectedItem = null;
            cmbNewBrand.SelectedItem = null;
            cmbNewCategory.SelectedItem = null;
            cmbExistingBrand.Text = "Seçiniz";
            cmbExistingCategory.Text = "Seçiniz";
            cmbNewBrand.Text = "Seçiniz";
            cmbNewCategory.Text = "Seçiniz";
        }

        public async Task GetCategories()
        {
            try
            {
                var categoriess = new List<Category>(){
                    new Category()
                    {
                        Id = 0,
                        Name = "Seçiniz"
                    }
                };
                categoriess.AddRange(await _categoryRepository.ListAsync());
                var comboboxItems = categoriess.ToDictionary(x => x.Name, y => y.Id);
                cmbNewCategory.DataSource = new BindingSource(comboboxItems, null);
                cmbNewCategory.DisplayMember = "Key";
                cmbNewCategory.ValueMember = "Value";

                cmbExistingCategory.DataSource = new BindingSource(comboboxItems, null);
                cmbExistingCategory.DisplayMember = "Key";
                cmbExistingCategory.ValueMember = "Value";

                categories = categoriess;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task GetBrands()
        {
            try
            {
                var brandss = new List<Brand>(){
                    new Brand()
                    {
                        Id = 0,
                        Name = "Seçiniz"
                    }
                };
                brandss.AddRange(await _brandRepository.ListAsync());
                var comboboxItems = brandss.ToDictionary(x => x.Name, y => y.Id);
                cmbNewBrand.DataSource = new BindingSource(comboboxItems, null);
                cmbNewBrand.DisplayMember = "Key";
                cmbNewBrand.ValueMember = "Value";

                cmbExistingBrand.DataSource = new BindingSource(comboboxItems, null);
                cmbExistingBrand.DisplayMember = "Key";
                cmbExistingBrand.ValueMember = "Value";

                brands = brandss;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        #endregion
    }
}
