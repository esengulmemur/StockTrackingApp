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

namespace StockTrackingApp.Brands
{
    public partial class FormBrand : Form
    {
        private readonly IStockTrackingRepository<Brand> _brandRepository;

        public FormBrand(IStockTrackingRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;

            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var brand = new Brand()
                {
                    Name = txtBrand.Text
                };
                await _brandRepository.AddAsync(brand);

                MessageBox.Show($"{txtBrand.Text} eklendi.", "Başarılı");

                txtBrand.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
