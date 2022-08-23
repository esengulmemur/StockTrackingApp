
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

namespace StockTrackingApp.Products
{
    partial class FormListProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbExistingBrand = new System.Windows.Forms.ComboBox();
            this.cmbExistingCategory = new System.Windows.Forms.ComboBox();
            this.txtExistingSalePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExistingPurchasePrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExistingAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExistingProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExistingBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarcodeSearch = new System.Windows.Forms.TextBox();
            this.txtBarkodNoAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(197, 95);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(531, 226);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbExistingBrand
            // 
            this.cmbExistingBrand.FormattingEnabled = true;
            this.cmbExistingBrand.Location = new System.Drawing.Point(79, 153);
            this.cmbExistingBrand.Name = "cmbExistingBrand";
            this.cmbExistingBrand.Size = new System.Drawing.Size(100, 23);
            this.cmbExistingBrand.TabIndex = 32;
            // 
            // cmbExistingCategory
            // 
            this.cmbExistingCategory.FormattingEnabled = true;
            this.cmbExistingCategory.Location = new System.Drawing.Point(79, 124);
            this.cmbExistingCategory.Name = "cmbExistingCategory";
            this.cmbExistingCategory.Size = new System.Drawing.Size(100, 23);
            this.cmbExistingCategory.TabIndex = 19;
            // 
            // txtExistingSalePrice
            // 
            this.txtExistingSalePrice.Location = new System.Drawing.Point(79, 269);
            this.txtExistingSalePrice.Name = "txtExistingSalePrice";
            this.txtExistingSalePrice.Size = new System.Drawing.Size(100, 23);
            this.txtExistingSalePrice.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Satış Fiyatı";
            // 
            // txtExistingPurchasePrice
            // 
            this.txtExistingPurchasePrice.Location = new System.Drawing.Point(79, 240);
            this.txtExistingPurchasePrice.Name = "txtExistingPurchasePrice";
            this.txtExistingPurchasePrice.Size = new System.Drawing.Size(100, 23);
            this.txtExistingPurchasePrice.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Alış Fiyatı";
            // 
            // txtExistingAmount
            // 
            this.txtExistingAmount.Location = new System.Drawing.Point(79, 211);
            this.txtExistingAmount.Name = "txtExistingAmount";
            this.txtExistingAmount.Size = new System.Drawing.Size(100, 23);
            this.txtExistingAmount.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Miktarı";
            // 
            // txtExistingProductName
            // 
            this.txtExistingProductName.Location = new System.Drawing.Point(79, 182);
            this.txtExistingProductName.Name = "txtExistingProductName";
            this.txtExistingProductName.Size = new System.Drawing.Size(100, 23);
            this.txtExistingProductName.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Kategori";
            // 
            // txtExistingBarcode
            // 
            this.txtExistingBarcode.Location = new System.Drawing.Point(79, 95);
            this.txtExistingBarcode.Name = "txtExistingBarcode";
            this.txtExistingBarcode.Size = new System.Drawing.Size(100, 23);
            this.txtExistingBarcode.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Barkod No";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(761, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarcodeSearch
            // 
            this.txtBarcodeSearch.Location = new System.Drawing.Point(443, 35);
            this.txtBarcodeSearch.Name = "txtBarcodeSearch";
            this.txtBarcodeSearch.Size = new System.Drawing.Size(100, 23);
            this.txtBarcodeSearch.TabIndex = 35;
            this.txtBarcodeSearch.TextChanged += new System.EventHandler(this.txtBarcodeSearch_TextChanged);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.AutoSize = true;
            this.txtBarkodNoAra.Location = new System.Drawing.Point(287, 43);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(125, 15);
            this.txtBarkodNoAra.TabIndex = 36;
            this.txtBarkodNoAra.Text = "Barkodno ya Göre Ara ";
            // 
            // FormListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.txtBarcodeSearch);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbExistingBrand);
            this.Controls.Add(this.cmbExistingCategory);
            this.Controls.Add(this.txtExistingSalePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExistingPurchasePrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtExistingAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExistingProductName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtExistingBarcode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FormListProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FormListProduct_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnUpdate;
        private ComboBox cmbExistingBrand;
        private ComboBox cmbExistingCategory;
        private TextBox txtExistingSalePrice;
        private Label label8;
        private TextBox txtExistingPurchasePrice;
        private Label label9;
        private TextBox txtExistingAmount;
        private Label label10;
        private TextBox txtExistingProductName;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtExistingBarcode;
        private Label label14;
        private Button btnSil;
        private TextBox txtBarcodeSearch;
        private Label txtBarkodNoAra;
    }
}