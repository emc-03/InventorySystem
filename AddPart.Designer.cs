
namespace InventorySystem_EmilyCarter
{
    partial class AddPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.companyNameMachineID = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.partCancel = new System.Windows.Forms.Button();
            this.addSave = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.machineNameID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System - Add Part";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(46, 75);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(46, 175);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(87, 25);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max";
            // 
            // companyNameMachineID
            // 
            this.companyNameMachineID.AutoSize = true;
            this.companyNameMachineID.Location = new System.Drawing.Point(46, 368);
            this.companyNameMachineID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameMachineID.Name = "companyNameMachineID";
            this.companyNameMachineID.Size = new System.Drawing.Size(101, 25);
            this.companyNameMachineID.TabIndex = 7;
            this.companyNameMachineID.Text = "Machine ID";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Checked = true;
            this.radioInHouse.Location = new System.Drawing.Point(97, 36);
            this.radioInHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(110, 29);
            this.radioInHouse.TabIndex = 8;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(233, 36);
            this.radioOutsourced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(132, 29);
            this.radioOutsourced.TabIndex = 9;
            this.radioOutsourced.Text = "OutSourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // partCancel
            // 
            this.partCancel.Location = new System.Drawing.Point(383, 447);
            this.partCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partCancel.Name = "partCancel";
            this.partCancel.Size = new System.Drawing.Size(107, 38);
            this.partCancel.TabIndex = 10;
            this.partCancel.Text = "Cancel";
            this.partCancel.UseVisualStyleBackColor = true;
            this.partCancel.Click += new System.EventHandler(this.partCancel_Click);
            // 
            // addSave
            // 
            this.addSave.Location = new System.Drawing.Point(267, 447);
            this.addSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(107, 38);
            this.addSave.TabIndex = 11;
            this.addSave.Text = "Save";
            this.addSave.UseVisualStyleBackColor = true;
            this.addSave.Click += new System.EventHandler(this.addSave_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(136, 75);
            this.textID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(141, 31);
            this.textID.TabIndex = 12;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(136, 127);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(141, 31);
            this.textName.TabIndex = 13;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(136, 175);
            this.textInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(141, 31);
            this.textInventory.TabIndex = 14;
            this.textInventory.TextChanged += new System.EventHandler(this.textInventory_TextChanged);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(136, 233);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(141, 31);
            this.textPrice.TabIndex = 15;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(136, 290);
            this.textMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(93, 31);
            this.textMin.TabIndex = 16;
            this.textMin.TextChanged += new System.EventHandler(this.textMin_TextChanged);
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(304, 290);
            this.textMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(100, 31);
            this.textMax.TabIndex = 17;
            this.textMax.TextChanged += new System.EventHandler(this.textMax_TextChanged);
            // 
            // machineNameID
            // 
            this.machineNameID.Location = new System.Drawing.Point(196, 363);
            this.machineNameID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.machineNameID.Name = "machineNameID";
            this.machineNameID.Size = new System.Drawing.Size(208, 31);
            this.machineNameID.TabIndex = 18;
            this.machineNameID.TextChanged += new System.EventHandler(this.textCompName_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 505);
            this.Controls.Add(this.machineNameID);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.addSave);
            this.Controls.Add(this.partCancel);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.companyNameMachineID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPart";
            this.Text = "Inventory Management System - Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label companyNameMachineID;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Button partCancel;
        private System.Windows.Forms.Button addSave;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox machineNameID;
    }
}