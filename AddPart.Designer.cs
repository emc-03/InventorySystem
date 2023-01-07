
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
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelID.Location = new System.Drawing.Point(32, 68);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 17);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryLabel.Location = new System.Drawing.Point(32, 128);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(61, 17);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(61, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(178, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max";
            // 
            // companyNameMachineID
            // 
            this.companyNameMachineID.AutoSize = true;
            this.companyNameMachineID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyNameMachineID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.companyNameMachineID.Location = new System.Drawing.Point(32, 239);
            this.companyNameMachineID.Name = "companyNameMachineID";
            this.companyNameMachineID.Size = new System.Drawing.Size(73, 17);
            this.companyNameMachineID.TabIndex = 7;
            this.companyNameMachineID.Text = "Machine ID";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Checked = true;
            this.radioInHouse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioInHouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioInHouse.Location = new System.Drawing.Point(74, 35);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(87, 24);
            this.radioInHouse.TabIndex = 8;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioOutsourced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioOutsourced.Location = new System.Drawing.Point(180, 35);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(105, 24);
            this.radioOutsourced.TabIndex = 9;
            this.radioOutsourced.Text = "OutSourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // partCancel
            // 
            this.partCancel.BackColor = System.Drawing.Color.LightGray;
            this.partCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partCancel.ForeColor = System.Drawing.Color.Black;
            this.partCancel.Location = new System.Drawing.Point(268, 311);
            this.partCancel.Name = "partCancel";
            this.partCancel.Size = new System.Drawing.Size(75, 33);
            this.partCancel.TabIndex = 10;
            this.partCancel.Text = "Cancel";
            this.partCancel.UseVisualStyleBackColor = false;
            this.partCancel.Click += new System.EventHandler(this.partCancel_Click);
            // 
            // addSave
            // 
            this.addSave.Location = new System.Drawing.Point(178, 311);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(75, 33);
            this.addSave.TabIndex = 11;
            this.addSave.Text = "Save";
            this.addSave.UseVisualStyleBackColor = true;
            this.addSave.Click += new System.EventHandler(this.addSave_Click);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.PapayaWhip;
            this.textID.Location = new System.Drawing.Point(95, 65);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 12;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.PapayaWhip;
            this.textName.Location = new System.Drawing.Point(95, 99);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 13;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textInventory
            // 
            this.textInventory.BackColor = System.Drawing.Color.PapayaWhip;
            this.textInventory.Location = new System.Drawing.Point(95, 128);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(100, 23);
            this.textInventory.TabIndex = 14;
            this.textInventory.TextChanged += new System.EventHandler(this.textInventory_TextChanged);
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.textPrice.Location = new System.Drawing.Point(95, 166);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 23);
            this.textPrice.TabIndex = 15;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // textMin
            // 
            this.textMin.BackColor = System.Drawing.Color.PapayaWhip;
            this.textMin.Location = new System.Drawing.Point(95, 197);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(66, 23);
            this.textMin.TabIndex = 16;
            this.textMin.TextChanged += new System.EventHandler(this.textMin_TextChanged);
            // 
            // textMax
            // 
            this.textMax.BackColor = System.Drawing.Color.PapayaWhip;
            this.textMax.Location = new System.Drawing.Point(214, 197);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(71, 23);
            this.textMax.TabIndex = 17;
            this.textMax.TextChanged += new System.EventHandler(this.textMax_TextChanged);
            // 
            // machineNameID
            // 
            this.machineNameID.BackColor = System.Drawing.Color.PapayaWhip;
            this.machineNameID.Location = new System.Drawing.Point(137, 238);
            this.machineNameID.Name = "machineNameID";
            this.machineNameID.Size = new System.Drawing.Size(147, 23);
            this.machineNameID.TabIndex = 18;
            this.machineNameID.TextChanged += new System.EventHandler(this.textCompName_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(355, 356);
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