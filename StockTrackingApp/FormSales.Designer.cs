namespace StockTrackingApp
{
    partial class formSales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBaskets = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.grbProductOperations = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnListSales = new System.Windows.Forms.Button();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnListCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaskets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbProductOperations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaskets
            // 
            this.dgvBaskets.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaskets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaskets.Location = new System.Drawing.Point(223, 125);
            this.dgvBaskets.Name = "dgvBaskets";
            this.dgvBaskets.RowTemplate.Height = 25;
            this.dgvBaskets.Size = new System.Drawing.Size(517, 287);
            this.dgvBaskets.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(4, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(88, 80);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(119, 23);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(88, 51);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(119, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(88, 22);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(119, 23);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // grbProductOperations
            // 
            this.grbProductOperations.Controls.Add(this.label8);
            this.grbProductOperations.Controls.Add(this.txtTotalPrice);
            this.grbProductOperations.Controls.Add(this.label7);
            this.grbProductOperations.Controls.Add(this.txtPrice);
            this.grbProductOperations.Controls.Add(this.label6);
            this.grbProductOperations.Controls.Add(this.txtAmount);
            this.grbProductOperations.Controls.Add(this.label5);
            this.grbProductOperations.Controls.Add(this.txtProductName);
            this.grbProductOperations.Controls.Add(this.label4);
            this.grbProductOperations.Controls.Add(this.txtBarcode);
            this.grbProductOperations.Location = new System.Drawing.Point(4, 280);
            this.grbProductOperations.Name = "grbProductOperations";
            this.grbProductOperations.Size = new System.Drawing.Size(213, 176);
            this.grbProductOperations.TabIndex = 2;
            this.grbProductOperations.TabStop = false;
            this.grbProductOperations.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toplam Fiyat";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(88, 138);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(119, 23);
            this.txtTotalPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(88, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 23);
            this.txtPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktarı";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(88, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(119, 23);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 51);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(119, 23);
            this.txtProductName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(88, 22);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(119, 23);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(665, 433);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSale.TabIndex = 4;
            this.btnMakeSale.Text = "Satış Yap";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(746, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.Location = new System.Drawing.Point(746, 154);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSalesCancel.TabIndex = 6;
            this.btnSalesCancel.Text = "Satış İptal";
            this.btnSalesCancel.UseVisualStyleBackColor = true;
            this.btnSalesCancel.Click += new System.EventHandler(this.btnSalesCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Genel Toplam";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(550, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnListSales);
            this.panel1.Controls.Add(this.btnListProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.btnListCustomer);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(726, 25);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(111, 47);
            this.btnBrand.TabIndex = 15;
            this.btnBrand.Text = "Marka";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(609, 25);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(111, 47);
            this.btnCategory.TabIndex = 14;
            this.btnCategory.Text = "Kategori";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnListSales
            // 
            this.btnListSales.Location = new System.Drawing.Point(492, 25);
            this.btnListSales.Name = "btnListSales";
            this.btnListSales.Size = new System.Drawing.Size(111, 47);
            this.btnListSales.TabIndex = 13;
            this.btnListSales.Text = "Satışları Listeleme";
            this.btnListSales.UseVisualStyleBackColor = true;
            this.btnListSales.Click += new System.EventHandler(this.btnListSales_Click);
            // 
            // btnListProduct
            // 
            this.btnListProduct.Location = new System.Drawing.Point(375, 25);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(111, 47);
            this.btnListProduct.TabIndex = 12;
            this.btnListProduct.Text = "Ürün Listeleme";
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(258, 25);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(111, 47);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Ürün Ekleme";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.Location = new System.Drawing.Point(141, 25);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(111, 47);
            this.btnListCustomer.TabIndex = 10;
            this.btnListCustomer.Text = "Müşteri Listeleme";
            this.btnListCustomer.UseVisualStyleBackColor = true;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 25);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(111, 47);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "Müşteri Ekleme";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // formSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(860, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalesCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbProductOperations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaskets);
            this.Name = "formSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.formSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaskets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbProductOperations.ResumeLayout(false);
            this.grbProductOperations.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBaskets;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtTC;
        private GroupBox grbProductOperations;
        private Label label8;
        private TextBox txtTotalPrice;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtAmount;
        private Label label5;
        private TextBox txtProductName;
        private Label label4;
        private TextBox txtBarcode;
        private Button btnAdd;
        private Button btnMakeSale;
        private Button btnDelete;
        private Button btnSalesCancel;
        private Label label9;
        private Label lblTotal;
        private Panel panel1;
        private Button btnListSales;
        private Button btnListProduct;
        private Button btnAddProduct;
        private Button btnListCustomer;
        private Button btnAddCustomer;
        private Button btnBrand;
        private Button btnCategory;
    }
}