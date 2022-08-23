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
    public partial class FormListProduct : Form
    {
        private readonly IStockTrackingRepository<Product> _productRepository;
        private readonly IStockTrackingRepository<Brand> _brandRepository;
        private readonly IStockTrackingRepository<Category> _categoryRepository;
        private int id = 0;
        private Product? existingProduct;

        public FormListProduct(IStockTrackingRepository<Product> productRepository,
            IStockTrackingRepository<Brand> brandRepository,
            IStockTrackingRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
            _categoryRepository = categoryRepository;

            InitializeComponent();
        }

        private async void FormListProduct_LoadAsync(object sender, EventArgs e)
        {
            await GetCategories();
            await GetBrands();
            await GetProductsAsync();
        }


        private async void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExistingBarcode.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtExistingProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtExistingPurchasePrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtExistingSalePrice.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtExistingAmount.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            cmbExistingCategory.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            cmbExistingCategory.SelectedItem = new 
            { 
                Key = dgvProducts.CurrentRow.Cells[5].Value.ToString(),
                Value = dgvProducts.CurrentRow.Cells[7].Value.ToString()
            };
            cmbExistingBrand.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
            cmbExistingBrand.SelectedItem = new
            {
                Key = dgvProducts.CurrentRow.Cells[6].Value.ToString(),
                Value = dgvProducts.CurrentRow.Cells[8].Value.ToString()
            };
            int.TryParse(dgvProducts.CurrentRow.Cells["Id"].Value.ToString(), out id);

            var product = await _productRepository
                    .Query(x => x.Id == id)
                    .Include(x => x.Brand)
                    .Include(x => x.Category)
                    .FirstOrDefaultAsync();
            existingProduct = product;
        }



        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (existingProduct != null)
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

        private async Task GetProductsAsync()
        {
            //*** filtered by tc
            if (string.IsNullOrEmpty(txtBarcodeSearch.Text))
                dgvProducts.DataSource = await _productRepository
                    .Query()
                    .Select(x => new
                    {
                        Barcode = x.Barcode,
                        Name = x.Name,
                        PurchasePrice = x.PurchasePrice,
                        SalePrice = x.SalePrice,
                        Amount = x.Amount,
                        Category = x.Category.Name,
                        Brand = x.Brand.Name,
                        CategoryId = x.CategoryId,
                        BrandId = x.BrandId,
                        Id = x.Id
                    }).ToListAsync();
            else
                dgvProducts.DataSource = await _productRepository
                    .Query(x => x.Barcode.Contains(txtBarcodeSearch.Text))
                    .Select(x => new
                    {
                        Barcode = x.Barcode,
                        Name = x.Name,
                        PurchasePrice = x.PurchasePrice,
                        SalePrice = x.SalePrice,
                        Amount = x.Amount,
                        Category = x.Category.Name,
                        Brand = x.Brand.Name,
                        CategoryId = x.CategoryId,
                        BrandId = x.BrandId,
                        Id = x.Id
                    }).ToListAsync();

            dgvProducts.Columns[0].HeaderText = "Barcode";
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[2].HeaderText = "PurchasePrice";
            dgvProducts.Columns[3].HeaderText = "SalePrice";
            dgvProducts.Columns[4].HeaderText = "Amount";
            dgvProducts.Columns[5].HeaderText = "Category";
            dgvProducts.Columns[6].HeaderText = "Brand";
            dgvProducts.Columns[7].Visible = false;
            dgvProducts.Columns[8].Visible = false;
            dgvProducts.Columns["Id"].Visible = false;
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

                cmbExistingCategory.DataSource = new BindingSource(comboboxItems, null);
                cmbExistingCategory.DisplayMember = "Key";
                cmbExistingCategory.ValueMember = "Value";

                //categories = categoriess;
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

                cmbExistingBrand.DataSource = new BindingSource(comboboxItems, null);
                cmbExistingBrand.DisplayMember = "Key";
                cmbExistingBrand.ValueMember = "Value";

                //brands = brandss;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void Clear()
        {
            txtExistingAmount.Text = "";
            txtExistingBarcode.Text = "";
            txtExistingProductName.Text = "";
            txtExistingPurchasePrice.Text = "";
            txtExistingSalePrice.Text = "";
            cmbExistingBrand.SelectedItem = null;
            cmbExistingCategory.SelectedItem = null;
        }

        private async void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            await GetProductsAsync();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"{txtExistingProductName.Text} ürünü silinecektir!", "Emin Misiniz?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _productRepository.DeleteAsync(id);
                    await GetProductsAsync();
                    MessageBox.Show("Ürün başarılı bir şekilde silindi", "Başarılı");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
