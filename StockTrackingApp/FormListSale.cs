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

namespace StockTrackingApp
{
    public partial class FormListSale : Form
    {
        private readonly IStockTrackingRepository<Sales> _saleRepository;

        public FormListSale(IStockTrackingRepository<Sales> saleRepository)
        {
            _saleRepository = saleRepository;

            InitializeComponent();
        }

        private async void FormListSale_Load(object sender, EventArgs e)
        {
            await GetSalesAsync();
        }

        private async Task GetSalesAsync()
        {
            var query = _saleRepository.Query();
            //if (!string.IsNullOrEmpty(txtTC.Text))
            //    query = query.Where(x => x.TC.Contains(txtTC.Text));
            //if(!string.IsNullOrEmpty(txtFullName.Text))
            //    query = query.Where(x => x.FullName.Contains(txtFullName.Text));
            //if(!string.IsNullOrEmpty(txtPhoneNumber.Text))
            //    query = query.Where(x => x.PhoneNumber.Contains(txtPhoneNumber.Text));

            dgvSales.DataSource = await query.ToListAsync();

            dgvSales.Columns[0].HeaderText = "TC";
            dgvSales.Columns[1].HeaderText = "Ad Soyad";
            dgvSales.Columns[2].HeaderText = "Tel No";
            dgvSales.Columns[3].HeaderText = "Barkod";
            dgvSales.Columns[4].HeaderText = "Ürün Adı";
            dgvSales.Columns[5].HeaderText = "Miktarı";
            dgvSales.Columns[6].HeaderText = "Satış Fiyatı";
            dgvSales.Columns[7].HeaderText = "Total Fiyat";
            dgvSales.Columns["Id"].Visible = false;
        }
    }
}
