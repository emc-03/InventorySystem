
using System;

namespace InventorySystem_EmilyCarter
{
    partial class InventoryMain
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
            this.components = new System.ComponentModel.Container();
            this.searchProductBox = new System.Windows.Forms.TextBox();
            this.searchPartBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.dataParts = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteParts = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainPartsSearch = new System.Windows.Forms.Button();
            this.mainProductSearch = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.ModifyProducts = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchProductBox
            // 
            this.searchProductBox.Location = new System.Drawing.Point(735, 77);
            this.searchProductBox.Name = "searchProductBox";
            this.searchProductBox.Size = new System.Drawing.Size(180, 23);
            this.searchProductBox.TabIndex = 35;
            this.searchProductBox.TextChanged += new System.EventHandler(this.searchProductBox_TextChanged);
            // 
            // searchPartBox
            // 
            this.searchPartBox.Location = new System.Drawing.Point(221, 77);
            this.searchPartBox.Name = "searchPartBox";
            this.searchPartBox.Size = new System.Drawing.Size(171, 23);
            this.searchPartBox.TabIndex = 34;
            this.searchPartBox.TextChanged += new System.EventHandler(this.searchPartBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "SysName";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Inventory Management System";
            // 
            // dataProducts
            // 
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(536, 134);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.RowHeadersWidth = 62;
            this.dataProducts.RowTemplate.Height = 25;
            this.dataProducts.Size = new System.Drawing.Size(379, 185);
            this.dataProducts.TabIndex = 32;
            // 
            // dataParts
            // 
            this.dataParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParts.Location = new System.Drawing.Point(12, 134);
            this.dataParts.Name = "dataParts";
            this.dataParts.RowHeadersWidth = 62;
            this.dataParts.RowTemplate.Height = 25;
            this.dataParts.Size = new System.Drawing.Size(380, 185);
            this.dataParts.TabIndex = 31;
            this.dataParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataParts_CellContentClick);
            this.dataParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // Products
            // 
            this.Products.AccessibleName = "ProductsName";
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Products.Location = new System.Drawing.Point(536, 102);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(82, 23);
            this.Products.TabIndex = 30;
            this.Products.Text = "Products";
            // 
            // label1
            // 
            this.label1.AccessibleName = "PartsName";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-96, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Parts";
            // 
            // DeleteParts
            // 
            this.DeleteParts.Location = new System.Drawing.Point(309, 325);
            this.DeleteParts.Name = "DeleteParts";
            this.DeleteParts.Size = new System.Drawing.Size(83, 32);
            this.DeleteParts.TabIndex = 28;
            this.DeleteParts.Text = "Delete";
            this.DeleteParts.UseVisualStyleBackColor = true;
            this.DeleteParts.Click += new System.EventHandler(this.DeleteParts_Click);
            // 
            // mainPartsSearch
            // 
            this.mainPartsSearch.AccessibleName = "partSearch";
            this.mainPartsSearch.Location = new System.Drawing.Point(131, 77);
            this.mainPartsSearch.Name = "mainPartsSearch";
            this.mainPartsSearch.Size = new System.Drawing.Size(75, 23);
            this.mainPartsSearch.TabIndex = 27;
            this.mainPartsSearch.Text = "Search";
            this.mainPartsSearch.UseVisualStyleBackColor = true;
            this.mainPartsSearch.Click += new System.EventHandler(this.mainPartsSearch_Click);
            // 
            // mainProductSearch
            // 
            this.mainProductSearch.AccessibleName = "ProductsSearch";
            this.mainProductSearch.Location = new System.Drawing.Point(643, 76);
            this.mainProductSearch.Name = "mainProductSearch";
            this.mainProductSearch.Size = new System.Drawing.Size(75, 23);
            this.mainProductSearch.TabIndex = 26;
            this.mainProductSearch.Text = "Search";
            this.mainProductSearch.UseVisualStyleBackColor = true;
            this.mainProductSearch.Click += new System.EventHandler(this.mainProductSearch_Click);
            // 
            // Exit
            // 
            this.Exit.AutoEllipsis = true;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(846, 394);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 31);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.Location = new System.Drawing.Point(832, 325);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(83, 32);
            this.DeleteProducts.TabIndex = 24;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = true;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // ModifyProducts
            // 
            this.ModifyProducts.Location = new System.Drawing.Point(743, 325);
            this.ModifyProducts.Name = "ModifyProducts";
            this.ModifyProducts.Size = new System.Drawing.Size(83, 32);
            this.ModifyProducts.TabIndex = 23;
            this.ModifyProducts.Text = "Modify";
            this.ModifyProducts.UseVisualStyleBackColor = true;
            this.ModifyProducts.Click += new System.EventHandler(this.ModifyProducts_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(654, 325);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(83, 32);
            this.AddProducts.TabIndex = 22;
            this.AddProducts.Text = "Add";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(220, 325);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(83, 32);
            this.Modify.TabIndex = 21;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(131, 325);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(83, 32);
            this.AddParts.TabIndex = 20;
            this.AddParts.Text = "Add";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // Parts
            // 
            this.Parts.AccessibleName = "PartsName";
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Parts.Location = new System.Drawing.Point(12, 102);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(51, 23);
            this.Parts.TabIndex = 36;
            this.Parts.Text = "Parts";
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.searchProductBox);
            this.Controls.Add(this.searchPartBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.dataParts);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteParts);
            this.Controls.Add(this.mainPartsSearch);
            this.Controls.Add(this.mainProductSearch);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.ModifyProducts);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.AddParts);
            this.Name = "InventoryMain";
            this.Text = "InventoryMain";
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchProductBox;
        private System.Windows.Forms.TextBox searchPartBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridView dataParts;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteParts;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button mainPartsSearch;
        private System.Windows.Forms.Button mainProductSearch;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button ModifyProducts;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Label Parts;

       
        public EventHandler button1_Click { get; private set; }
    }
}