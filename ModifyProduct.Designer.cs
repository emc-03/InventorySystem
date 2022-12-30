
namespace InventorySystem_EmilyCarter
{
    partial class ModifyProduct
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
            this.labelModifyProd = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInvent = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelAllParts = new System.Windows.Forms.Label();
            this.labelAssociated = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.modifySave = new System.Windows.Forms.Button();
            this.modifySearch = new System.Windows.Forms.Button();
            this.modifyAdd = new System.Windows.Forms.Button();
            this.modifyDelete = new System.Windows.Forms.Button();
            this.allPartsModify = new System.Windows.Forms.DataGridView();
            this.partsAssociatedProductView = new System.Windows.Forms.DataGridView();
            this.modifySearchBox = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModifyProd
            // 
            this.labelModifyProd.AutoSize = true;
            this.labelModifyProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModifyProd.Location = new System.Drawing.Point(0, 0);
            this.labelModifyProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModifyProd.Name = "labelModifyProd";
            this.labelModifyProd.Size = new System.Drawing.Size(530, 32);
            this.labelModifyProd.TabIndex = 0;
            this.labelModifyProd.Text = "Inventory Management System -Modify Product";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(73, 95);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 150);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInvent
            // 
            this.labelInvent.AutoSize = true;
            this.labelInvent.Location = new System.Drawing.Point(17, 212);
            this.labelInvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInvent.Name = "labelInvent";
            this.labelInvent.Size = new System.Drawing.Size(87, 25);
            this.labelInvent.TabIndex = 3;
            this.labelInvent.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(51, 258);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 25);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(59, 327);
            this.labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(42, 25);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(257, 327);
            this.labelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(45, 25);
            this.labelMax.TabIndex = 6;
            this.labelMax.Text = "Max";
            // 
            // labelAllParts
            // 
            this.labelAllParts.AutoSize = true;
            this.labelAllParts.Location = new System.Drawing.Point(587, 95);
            this.labelAllParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllParts.Name = "labelAllParts";
            this.labelAllParts.Size = new System.Drawing.Size(75, 25);
            this.labelAllParts.TabIndex = 7;
            this.labelAllParts.Text = "All Parts";
            // 
            // labelAssociated
            // 
            this.labelAssociated.AutoSize = true;
            this.labelAssociated.Location = new System.Drawing.Point(587, 445);
            this.labelAssociated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssociated.Name = "labelAssociated";
            this.labelAssociated.Size = new System.Drawing.Size(279, 25);
            this.labelAssociated.TabIndex = 8;
            this.labelAssociated.Text = "Parts Associated with this Product";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(1139, 817);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(107, 38);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // modifySave
            // 
            this.modifySave.Location = new System.Drawing.Point(964, 817);
            this.modifySave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifySave.Name = "modifySave";
            this.modifySave.Size = new System.Drawing.Size(107, 38);
            this.modifySave.TabIndex = 10;
            this.modifySave.Text = "Save";
            this.modifySave.UseVisualStyleBackColor = true;
            this.modifySave.Click += new System.EventHandler(this.modifySave_Click);
            // 
            // modifySearch
            // 
            this.modifySearch.Location = new System.Drawing.Point(807, 20);
            this.modifySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifySearch.Name = "modifySearch";
            this.modifySearch.Size = new System.Drawing.Size(107, 38);
            this.modifySearch.TabIndex = 11;
            this.modifySearch.Text = "Search";
            this.modifySearch.UseVisualStyleBackColor = true;
            this.modifySearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // modifyAdd
            // 
            this.modifyAdd.Location = new System.Drawing.Point(1139, 407);
            this.modifyAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyAdd.Name = "modifyAdd";
            this.modifyAdd.Size = new System.Drawing.Size(107, 38);
            this.modifyAdd.TabIndex = 12;
            this.modifyAdd.Text = "Add";
            this.modifyAdd.UseVisualStyleBackColor = true;
            this.modifyAdd.Click += new System.EventHandler(this.modifyAdd_Click);
            // 
            // modifyDelete
            // 
            this.modifyDelete.Location = new System.Drawing.Point(1139, 768);
            this.modifyDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyDelete.Name = "modifyDelete";
            this.modifyDelete.Size = new System.Drawing.Size(107, 38);
            this.modifyDelete.TabIndex = 13;
            this.modifyDelete.Text = "Delete";
            this.modifyDelete.UseVisualStyleBackColor = true;
            this.modifyDelete.Click += new System.EventHandler(this.modifyDelete_Click);
            // 
            // allPartsModify
            // 
            this.allPartsModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsModify.Location = new System.Drawing.Point(587, 125);
            this.allPartsModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsModify.Name = "allPartsModify";
            this.allPartsModify.RowHeadersWidth = 62;
            this.allPartsModify.RowTemplate.Height = 25;
            this.allPartsModify.Size = new System.Drawing.Size(659, 272);
            this.allPartsModify.TabIndex = 14;
            this.allPartsModify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partsAssociatedProductView
            // 
            this.partsAssociatedProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedProductView.Location = new System.Drawing.Point(587, 475);
            this.partsAssociatedProductView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partsAssociatedProductView.Name = "partsAssociatedProductView";
            this.partsAssociatedProductView.RowHeadersWidth = 62;
            this.partsAssociatedProductView.RowTemplate.Height = 25;
            this.partsAssociatedProductView.Size = new System.Drawing.Size(659, 283);
            this.partsAssociatedProductView.TabIndex = 15;
            this.partsAssociatedProductView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // modifySearchBox
            // 
            this.modifySearchBox.Location = new System.Drawing.Point(929, 22);
            this.modifySearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifySearchBox.Name = "modifySearchBox";
            this.modifySearchBox.Size = new System.Drawing.Size(315, 31);
            this.modifySearchBox.TabIndex = 16;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(107, 90);
            this.textID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(315, 31);
            this.textID.TabIndex = 17;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(107, 150);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(315, 31);
            this.textName.TabIndex = 18;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(107, 207);
            this.textInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(315, 31);
            this.textInventory.TabIndex = 19;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(107, 255);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(315, 31);
            this.textPrice.TabIndex = 20;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(107, 322);
            this.textMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(110, 31);
            this.textMin.TabIndex = 21;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(309, 327);
            this.textMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(114, 31);
            this.textMax.TabIndex = 22;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 965);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.modifySearchBox);
            this.Controls.Add(this.partsAssociatedProductView);
            this.Controls.Add(this.allPartsModify);
            this.Controls.Add(this.modifyDelete);
            this.Controls.Add(this.modifyAdd);
            this.Controls.Add(this.modifySearch);
            this.Controls.Add(this.modifySave);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.labelAssociated);
            this.Controls.Add(this.labelAllParts);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInvent);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelModifyProd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyProduct";
            this.Text = "Inventory Management System - Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModifyProd;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInvent;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelAllParts;
        private System.Windows.Forms.Label labelAssociated;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button modifySave;
        private System.Windows.Forms.Button modifySearch;
        private System.Windows.Forms.Button modifyAdd;
        private System.Windows.Forms.Button modifyDelete;
        private System.Windows.Forms.DataGridView allPartsModify;
        private System.Windows.Forms.DataGridView partsAssociatedProductView;
        private System.Windows.Forms.TextBox modifySearchBox;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
    }
}