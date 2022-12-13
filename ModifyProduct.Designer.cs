
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModifyProd
            // 
            this.labelModifyProd.AutoSize = true;
            this.labelModifyProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModifyProd.Location = new System.Drawing.Point(0, 0);
            this.labelModifyProd.Name = "labelModifyProd";
            this.labelModifyProd.Size = new System.Drawing.Size(117, 21);
            this.labelModifyProd.TabIndex = 0;
            this.labelModifyProd.Text = "Modify Product";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(51, 57);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInvent
            // 
            this.labelInvent.AutoSize = true;
            this.labelInvent.Location = new System.Drawing.Point(12, 127);
            this.labelInvent.Name = "labelInvent";
            this.labelInvent.Size = new System.Drawing.Size(57, 15);
            this.labelInvent.TabIndex = 3;
            this.labelInvent.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(36, 155);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(41, 196);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(28, 15);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(180, 196);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(30, 15);
            this.labelMax.TabIndex = 6;
            this.labelMax.Text = "Max";
            // 
            // labelAllParts
            // 
            this.labelAllParts.AutoSize = true;
            this.labelAllParts.Location = new System.Drawing.Point(411, 57);
            this.labelAllParts.Name = "labelAllParts";
            this.labelAllParts.Size = new System.Drawing.Size(50, 15);
            this.labelAllParts.TabIndex = 7;
            this.labelAllParts.Text = "All Parts";
            // 
            // labelAssociated
            // 
            this.labelAssociated.AutoSize = true;
            this.labelAssociated.Location = new System.Drawing.Point(411, 267);
            this.labelAssociated.Name = "labelAssociated";
            this.labelAssociated.Size = new System.Drawing.Size(186, 15);
            this.labelAssociated.TabIndex = 8;
            this.labelAssociated.Text = "Parts Associated with this Product";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(797, 490);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // modifySave
            // 
            this.modifySave.Location = new System.Drawing.Point(675, 490);
            this.modifySave.Name = "modifySave";
            this.modifySave.Size = new System.Drawing.Size(75, 23);
            this.modifySave.TabIndex = 10;
            this.modifySave.Text = "Save";
            this.modifySave.UseVisualStyleBackColor = true;
            // 
            // modifySearch
            // 
            this.modifySearch.Location = new System.Drawing.Point(565, 12);
            this.modifySearch.Name = "modifySearch";
            this.modifySearch.Size = new System.Drawing.Size(75, 23);
            this.modifySearch.TabIndex = 11;
            this.modifySearch.Text = "Search";
            this.modifySearch.UseVisualStyleBackColor = true;
            this.modifySearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // modifyAdd
            // 
            this.modifyAdd.Location = new System.Drawing.Point(797, 244);
            this.modifyAdd.Name = "modifyAdd";
            this.modifyAdd.Size = new System.Drawing.Size(75, 23);
            this.modifyAdd.TabIndex = 12;
            this.modifyAdd.Text = "Add";
            this.modifyAdd.UseVisualStyleBackColor = true;
            // 
            // modifyDelete
            // 
            this.modifyDelete.Location = new System.Drawing.Point(797, 461);
            this.modifyDelete.Name = "modifyDelete";
            this.modifyDelete.Size = new System.Drawing.Size(75, 23);
            this.modifyDelete.TabIndex = 13;
            this.modifyDelete.Text = "Delete";
            this.modifyDelete.UseVisualStyleBackColor = true;
            this.modifyDelete.Click += new System.EventHandler(this.modifyDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(461, 163);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(411, 285);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(461, 170);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 16;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(75, 54);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(222, 23);
            this.textID.TabIndex = 17;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(75, 90);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(222, 23);
            this.textName.TabIndex = 18;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(75, 124);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(222, 23);
            this.textInventory.TabIndex = 19;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(75, 153);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(222, 23);
            this.textPrice.TabIndex = 20;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(75, 193);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(78, 23);
            this.textMin.TabIndex = 21;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(216, 196);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(81, 23);
            this.textMax.TabIndex = 22;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 579);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
    }
}