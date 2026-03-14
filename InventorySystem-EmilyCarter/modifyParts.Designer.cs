
namespace InventorySystem_EmilyCarter
{
    partial class modifyParts
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
            this.modPartSave = new System.Windows.Forms.Button();
            this.modifyLabel = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.Outsourced = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textCompanyName = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelCompName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightGray;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(287, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 33);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modPartSave
            // 
            this.modPartSave.Location = new System.Drawing.Point(287, 339);
            this.modPartSave.Name = "modPartSave";
            this.modPartSave.Size = new System.Drawing.Size(75, 23);
            this.modPartSave.TabIndex = 1;
            this.modPartSave.Text = "Save";
            this.modPartSave.UseVisualStyleBackColor = true;
            this.modPartSave.Click += new System.EventHandler(this.modPartSave_Click);
            // 
            // modifyLabel
            // 
            this.modifyLabel.AutoSize = true;
            this.modifyLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyLabel.Location = new System.Drawing.Point(122, 18);
            this.modifyLabel.Name = "modifyLabel";
            this.modifyLabel.Size = new System.Drawing.Size(125, 23);
            this.modifyLabel.TabIndex = 2;
            this.modifyLabel.Text = " Modify Part";
            this.modifyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioInHouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioInHouse.Location = new System.Drawing.Point(91, 52);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(91, 24);
            this.radioInHouse.TabIndex = 3;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // Outsourced
            // 
            this.Outsourced.AutoSize = true;
            this.Outsourced.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Outsourced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Outsourced.Location = new System.Drawing.Point(194, 52);
            this.Outsourced.Name = "Outsourced";
            this.Outsourced.Size = new System.Drawing.Size(109, 24);
            this.Outsourced.TabIndex = 4;
            this.Outsourced.TabStop = true;
            this.Outsourced.Text = "OutSourced";
            this.Outsourced.UseVisualStyleBackColor = true;
            this.Outsourced.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelID.Location = new System.Drawing.Point(98, 87);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 17);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.PapayaWhip;
            this.textID.Location = new System.Drawing.Point(154, 87);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 13;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.PapayaWhip;
            this.textName.Location = new System.Drawing.Point(154, 128);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 14;
            // 
            // textInventory
            // 
            this.textInventory.BackColor = System.Drawing.Color.PapayaWhip;
            this.textInventory.Location = new System.Drawing.Point(154, 169);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(100, 23);
            this.textInventory.TabIndex = 15;
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.textPrice.Location = new System.Drawing.Point(154, 210);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 23);
            this.textPrice.TabIndex = 16;
            // 
            // textMin
            // 
            this.textMin.BackColor = System.Drawing.Color.PapayaWhip;
            this.textMin.ForeColor = System.Drawing.Color.Black;
            this.textMin.Location = new System.Drawing.Point(125, 249);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(47, 23);
            this.textMin.TabIndex = 17;
            // 
            // textCompanyName
            // 
            this.textCompanyName.BackColor = System.Drawing.Color.PapayaWhip;
            this.textCompanyName.Location = new System.Drawing.Point(132, 288);
            this.textCompanyName.Name = "textCompanyName";
            this.textCompanyName.Size = new System.Drawing.Size(152, 23);
            this.textCompanyName.TabIndex = 18;
            // 
            // textMax
            // 
            this.textMax.BackColor = System.Drawing.Color.PapayaWhip;
            this.textMax.Location = new System.Drawing.Point(222, 249);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(60, 23);
            this.textMax.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(91, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInventory.Location = new System.Drawing.Point(91, 169);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(61, 17);
            this.labelInventory.TabIndex = 21;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(91, 210);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 17);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "Price";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMin.Location = new System.Drawing.Point(91, 249);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 17);
            this.labelMin.TabIndex = 23;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMax.Location = new System.Drawing.Point(186, 249);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 17);
            this.labelMax.TabIndex = 24;
            this.labelMax.Text = "Max";
            // 
            // labelCompName
            // 
            this.labelCompName.AutoSize = true;
            this.labelCompName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCompName.Location = new System.Drawing.Point(30, 288);
            this.labelCompName.Name = "labelCompName";
            this.labelCompName.Size = new System.Drawing.Size(102, 17);
            this.labelCompName.TabIndex = 25;
            this.labelCompName.Text = "Company Name";
            // 
            // modifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(374, 425);
            this.Controls.Add(this.labelCompName);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textCompanyName);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.Outsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.modifyLabel);
            this.Controls.Add(this.modPartSave);
            this.Controls.Add(this.cancelButton);
            this.Name = "modifyParts";
            this.Text = "Inventory Management System - Modify Parts";
            this.Load += new System.EventHandler(this.modifyParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button modPartSave;
        private System.Windows.Forms.Label modifyLabel;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton Outsourced;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textCompanyName;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelCompName;
    }
}