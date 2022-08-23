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

namespace StockTrackingApp.Categories
{
    public partial class FormCategory : Form
    {
        private readonly IStockTrackingRepository<Category> _categoryRepository;

        public FormCategory(IStockTrackingRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;

            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category()
                {
                    Name = txtCategoryName.Text
                };
                await _categoryRepository.AddAsync(category);

                MessageBox.Show($"{txtCategoryName.Text} eklendi.", "Başarılı");

                txtCategoryName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
