
namespace SalesWinApp
{
    partial class frmProductDetails
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
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtProductID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(328, 278);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 22);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(156, 278);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(82, 22);
            btnSave.TabIndex = 27;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(156, 11);
            txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(254, 23);
            txtProductID.TabIndex = 25;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(156, 50);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(254, 23);
            txtProductName.TabIndex = 24;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(156, 96);
            txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(254, 23);
            txtCategoryID.TabIndex = 23;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(156, 140);
            txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(254, 23);
            txtWeight.TabIndex = 22;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(12, 183);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            lbUnitPrice.TabIndex = 21;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(12, 231);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            lbUnitsInStock.TabIndex = 20;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(12, 140);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(45, 15);
            lbWeight.TabIndex = 19;
            lbWeight.Text = "Weight";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(12, 98);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(66, 15);
            lbCategoryID.TabIndex = 18;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(12, 50);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(84, 15);
            lbProductName.TabIndex = 17;
            lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(12, 11);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(63, 15);
            lbProductID.TabIndex = 16;
            lbProductID.Text = "Product ID";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(156, 180);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(254, 23);
            txtUnitPrice.TabIndex = 29;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(156, 228);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(254, 23);
            txtUnitsInStock.TabIndex = 30;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(426, 309);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProductID);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtWeight);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Name = "frmProductDetails";
            Text = "Product Detail";
            Load += frmProductDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
    }
}