namespace CafeManagement.WinForm
{
    partial class Menu
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
            categoryPanel = new System.Windows.Forms.Panel();
            productListPanel = new System.Windows.Forms.Panel();
            txtCount = new System.Windows.Forms.TextBox();
            btnAddOrder = new System.Windows.Forms.Button();
            lblCategory = new System.Windows.Forms.Label();
            lblProducts = new System.Windows.Forms.Label();
            productDetailPanel = new System.Windows.Forms.Panel();
            btnAddProduct = new System.Windows.Forms.Button();
            lblProductId = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtProductDescription = new System.Windows.Forms.RichTextBox();
            txtProductPrice = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            btnProductUpdate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblProductDetail = new System.Windows.Forms.Label();
            addOrderPanel = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            productDetailPanel.SuspendLayout();
            addOrderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // categoryPanel
            // 
            categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            categoryPanel.Location = new System.Drawing.Point(12, 36);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new System.Drawing.Size(216, 690);
            categoryPanel.TabIndex = 0;
            // 
            // productListPanel
            // 
            productListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            productListPanel.Location = new System.Drawing.Point(247, 36);
            productListPanel.Name = "productListPanel";
            productListPanel.Size = new System.Drawing.Size(573, 690);
            productListPanel.TabIndex = 1;
            // 
            // txtCount
            // 
            txtCount.Location = new System.Drawing.Point(28, 70);
            txtCount.Name = "txtCount";
            txtCount.Size = new System.Drawing.Size(114, 27);
            txtCount.TabIndex = 3;
            txtCount.Text = "1";
            txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new System.Drawing.Point(172, 36);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new System.Drawing.Size(174, 73);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "Sipariş Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCategory.Location = new System.Drawing.Point(12, 5);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(118, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Kategoriler";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProducts.Location = new System.Drawing.Point(247, 5);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(83, 28);
            lblProducts.TabIndex = 6;
            lblProducts.Text = "Ürünler";
            // 
            // productDetailPanel
            // 
            productDetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            productDetailPanel.Controls.Add(btnAddProduct);
            productDetailPanel.Controls.Add(lblProductId);
            productDetailPanel.Controls.Add(label3);
            productDetailPanel.Controls.Add(txtProductDescription);
            productDetailPanel.Controls.Add(txtProductPrice);
            productDetailPanel.Controls.Add(txtProductName);
            productDetailPanel.Controls.Add(btnProductUpdate);
            productDetailPanel.Controls.Add(label2);
            productDetailPanel.Controls.Add(label1);
            productDetailPanel.Controls.Add(lblProductName);
            productDetailPanel.Location = new System.Drawing.Point(850, 39);
            productDetailPanel.Name = "productDetailPanel";
            productDetailPanel.Size = new System.Drawing.Size(350, 564);
            productDetailPanel.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new System.Drawing.Point(10, 486);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(158, 65);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Yeni Ürün";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Visible = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProductId.Location = new System.Drawing.Point(129, 29);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(100, 20);
            lblProductId.TabIndex = 14;
            lblProductId.Text = "{lblProductId}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(10, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 25);
            label3.TabIndex = 13;
            label3.Text = "Ürün ID'si";
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new System.Drawing.Point(10, 202);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new System.Drawing.Size(319, 161);
            txtProductDescription.TabIndex = 12;
            txtProductDescription.Text = "";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new System.Drawing.Point(129, 405);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new System.Drawing.Size(200, 27);
            txtProductPrice.TabIndex = 11;
            txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(129, 102);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(200, 27);
            txtProductName.TabIndex = 10;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Location = new System.Drawing.Point(187, 486);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new System.Drawing.Size(158, 65);
            btnProductUpdate.TabIndex = 9;
            btnProductUpdate.Text = "Ürünü Güncelle";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(10, 405);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 25);
            label2.TabIndex = 5;
            label2.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 163);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 25);
            label1.TabIndex = 4;
            label1.Text = "Ürün Açıklaması";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProductName.Location = new System.Drawing.Point(10, 101);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(94, 25);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Ürün İsmi";
            // 
            // lblProductDetail
            // 
            lblProductDetail.AutoSize = true;
            lblProductDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProductDetail.Location = new System.Drawing.Point(850, 5);
            lblProductDetail.Name = "lblProductDetail";
            lblProductDetail.Size = new System.Drawing.Size(126, 28);
            lblProductDetail.TabIndex = 8;
            lblProductDetail.Text = "Ürün Detayı";
            // 
            // addOrderPanel
            // 
            addOrderPanel.Controls.Add(label5);
            addOrderPanel.Controls.Add(btnAddOrder);
            addOrderPanel.Controls.Add(txtCount);
            addOrderPanel.Location = new System.Drawing.Point(850, 614);
            addOrderPanel.Name = "addOrderPanel";
            addOrderPanel.Size = new System.Drawing.Size(350, 112);
            addOrderPanel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(52, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 25);
            label5.TabIndex = 16;
            label5.Text = "Adet";
            // 
            // Products
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1212, 751);
            Controls.Add(lblProductDetail);
            Controls.Add(productDetailPanel);
            Controls.Add(lblProducts);
            Controls.Add(lblCategory);
            Controls.Add(productListPanel);
            Controls.Add(categoryPanel);
            Controls.Add(addOrderPanel);
            Name = "Products";
            Text = "Ürünler";
            productDetailPanel.ResumeLayout(false);
            productDetailPanel.PerformLayout();
            addOrderPanel.ResumeLayout(false);
            addOrderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Panel productListPanel;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel productDetailPanel;
        private System.Windows.Forms.Label lblProductDetail;
        private System.Windows.Forms.Label lblProductDescripton;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel addOrderPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProduct;
    }
}