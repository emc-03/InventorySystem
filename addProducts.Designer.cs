
namespace InventorySystem_EmilyCarter
{
    partial class AddProducts
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.productSave = new System.Windows.Forms.Button();
            this.addID = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.Label();
            this.inventLevel = new System.Windows.Forms.Label();
            this.addPrice = new System.Windows.Forms.Label();
            this.addMin = new System.Windows.Forms.Label();
            this.addMax = new System.Windows.Forms.Label();
            this.addPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addIdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.addProductMin = new System.Windows.Forms.TextBox();
            this.addProductMax = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.AllPartsGrid = new System.Windows.Forms.DataGridView();
            this.addProdLabel = new System.Windows.Forms.Label();
            this.labelPartsAssociated = new System.Windows.Forms.Label();
            this.labelAllParts = new System.Windows.Forms.Label();
            this.productSearch = new System.Windows.Forms.Button();
            this.partsAssociatedProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(765, 508);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(57, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productSave
            // 
            this.productSave.Location = new System.Drawing.Point(668, 468);
            this.productSave.Name = "productSave";
            this.productSave.Size = new System.Drawing.Size(59, 23);
            this.productSave.TabIndex = 1;
            this.productSave.Text = "Save";
            this.productSave.UseVisualStyleBackColor = true;
            this.productSave.Click += new System.EventHandler(this.productSave_Click);
            // 
            // addID
            // 
            this.addID.AutoSize = true;
            this.addID.Location = new System.Drawing.Point(81, 169);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(18, 15);
            this.addID.TabIndex = 2;
            this.addID.Text = "ID";
            this.addID.Click += new System.EventHandler(this.label1_Click);
            // 
            // addName
            // 
            this.addName.AutoSize = true;
            this.addName.Location = new System.Drawing.Point(63, 209);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(39, 15);
            this.addName.TabIndex = 3;
            this.addName.Text = "Name";
            // 
            // inventLevel
            // 
            this.inventLevel.AutoSize = true;
            this.inventLevel.Location = new System.Drawing.Point(45, 249);
            this.inventLevel.Name = "inventLevel";
            this.inventLevel.Size = new System.Drawing.Size(57, 15);
            this.inventLevel.TabIndex = 4;
            this.inventLevel.Text = "Inventory";
            // 
            // addPrice
            // 
            this.addPrice.AutoSize = true;
            this.addPrice.Location = new System.Drawing.Point(66, 283);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(36, 15);
            this.addPrice.TabIndex = 5;
            this.addPrice.Text = " Price";
            // 
            // addMin
            // 
            this.addMin.AutoSize = true;
            this.addMin.Location = new System.Drawing.Point(24, 330);
            this.addMin.Name = "addMin";
            this.addMin.Size = new System.Drawing.Size(28, 15);
            this.addMin.TabIndex = 6;
            this.addMin.Text = "Min";
            // 
            // addMax
            // 
            this.addMax.AutoSize = true;
            this.addMax.Location = new System.Drawing.Point(193, 330);
            this.addMax.Name = "addMax";
            this.addMax.Size = new System.Drawing.Size(30, 15);
            this.addMax.TabIndex = 7;
            this.addMax.Text = "Max";
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(791, 249);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(47, 38);
            this.addPart.TabIndex = 10;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(747, 468);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 11;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addIdBox
            // 
            this.addIdBox.Location = new System.Drawing.Point(108, 169);
            this.addIdBox.Name = "addIdBox";
            this.addIdBox.ReadOnly = true;
            this.addIdBox.Size = new System.Drawing.Size(155, 23);
            this.addIdBox.TabIndex = 12;
            this.addIdBox.TextChanged += new System.EventHandler(this.addIdBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 209);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 23);
            this.nameBox.TabIndex = 14;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Location = new System.Drawing.Point(108, 249);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(155, 23);
            this.inventoryBox.TabIndex = 15;
            this.inventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(108, 283);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(155, 23);
            this.priceBox.TabIndex = 16;
            // 
            // addProductMin
            // 
            this.addProductMin.Location = new System.Drawing.Point(58, 330);
            this.addProductMin.Name = "addProductMin";
            this.addProductMin.Size = new System.Drawing.Size(100, 23);
            this.addProductMin.TabIndex = 17;
            // 
            // addProductMax
            // 
            this.addProductMax.Location = new System.Drawing.Point(229, 330);
            this.addProductMax.Name = "addProductMax";
            this.addProductMax.Size = new System.Drawing.Size(100, 23);
            this.addProductMax.TabIndex = 18;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(559, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(279, 23);
            this.searchBox.TabIndex = 21;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // AllPartsGrid
            // 
            this.AllPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsGrid.Location = new System.Drawing.Point(434, 93);
            this.AllPartsGrid.Name = "AllPartsGrid";
            this.AllPartsGrid.RowHeadersWidth = 62;
            this.AllPartsGrid.RowTemplate.Height = 25;
            this.AllPartsGrid.Size = new System.Drawing.Size(405, 150);
            this.AllPartsGrid.TabIndex = 22;
            this.AllPartsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProdData_CellContentClick);
            // 
            // addProdLabel
            // 
            this.addProdLabel.AutoSize = true;
            this.addProdLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProdLabel.Location = new System.Drawing.Point(24, 30);
            this.addProdLabel.Name = "addProdLabel";
            this.addProdLabel.Size = new System.Drawing.Size(134, 30);
            this.addProdLabel.TabIndex = 24;
            this.addProdLabel.Text = "Add Product";
            // 
            // labelPartsAssociated
            // 
            this.labelPartsAssociated.AutoSize = true;
            this.labelPartsAssociated.Location = new System.Drawing.Point(434, 294);
            this.labelPartsAssociated.Name = "labelPartsAssociated";
            this.labelPartsAssociated.Size = new System.Drawing.Size(186, 15);
            this.labelPartsAssociated.TabIndex = 25;
            this.labelPartsAssociated.Text = "Parts Associated with this Product";
            // 
            // labelAllParts
            // 
            this.labelAllParts.AutoSize = true;
            this.labelAllParts.Location = new System.Drawing.Point(434, 75);
            this.labelAllParts.Name = "labelAllParts";
            this.labelAllParts.Size = new System.Drawing.Size(50, 15);
            this.labelAllParts.TabIndex = 26;
            this.labelAllParts.Text = "All Parts";
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(476, 30);
            this.productSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(78, 20);
            this.productSearch.TabIndex = 27;
            this.productSearch.Text = "Search";
            this.productSearch.UseVisualStyleBackColor = true;
            this.productSearch.Click += new System.EventHandler(this.productSearch_Click);
            // 
            // partsAssociatedProduct
            // 
            this.partsAssociatedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedProduct.Location = new System.Drawing.Point(434, 311);
            this.partsAssociatedProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partsAssociatedProduct.Name = "partsAssociatedProduct";
            this.partsAssociatedProduct.RowHeadersWidth = 62;
            this.partsAssociatedProduct.RowTemplate.Height = 33;
            this.partsAssociatedProduct.Size = new System.Drawing.Size(403, 152);
            this.partsAssociatedProduct.TabIndex = 28;
            this.partsAssociatedProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsAssociatedProduct_CellContentClick);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 564);
            this.Controls.Add(this.partsAssociatedProduct);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.labelAllParts);
            this.Controls.Add(this.labelPartsAssociated);
            this.Controls.Add(this.addProdLabel);
            this.Controls.Add(this.AllPartsGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addProductMax);
            this.Controls.Add(this.addProductMin);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addIdBox);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.addMax);
            this.Controls.Add(this.addMin);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.inventLevel);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.addID);
            this.Controls.Add(this.productSave);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddProducts";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button productSave;
        private System.Windows.Forms.Label addID;
        private System.Windows.Forms.Label addName;
        private System.Windows.Forms.Label inventLevel;
        private System.Windows.Forms.Label addPrice;
        private System.Windows.Forms.Label addMin;
        private System.Windows.Forms.Label addMax;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.TextBox addIdBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox addProductMin;
        private System.Windows.Forms.TextBox addProductMax;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView AllPartsGrid;
        private System.Windows.Forms.DataGridView partsAssociatedProducts;
        private System.Windows.Forms.Label addProdLabel;
        private System.Windows.Forms.Label labelPartsAssociated;
        private System.Windows.Forms.Label labelAllParts;
        private System.Windows.Forms.Button productSearch;
        private System.Windows.Forms.DataGridView partsAssociatedProduct;
    }
}