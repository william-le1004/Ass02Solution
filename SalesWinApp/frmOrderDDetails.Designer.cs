
namespace SalesWinApp
{
    partial class frmOrderDDetails
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
            txtUnitPrice = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtDiscount = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbDiscount = new System.Windows.Forms.Label();
            lbQuantity = new System.Windows.Forms.Label();
            lbOrderID = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            txtProductID = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(156, 183);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(254, 23);
            txtUnitPrice.TabIndex = 43;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(401, 226);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 22);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(214, 226);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(82, 22);
            btnSave.TabIndex = 41;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(156, 53);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(254, 23);
            txtOrderID.TabIndex = 39;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(156, 99);
            txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(254, 23);
            txtQuantity.TabIndex = 38;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(156, 143);
            txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(254, 23);
            txtDiscount.TabIndex = 37;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(12, 186);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            lbUnitPrice.TabIndex = 36;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new System.Drawing.Point(12, 143);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new System.Drawing.Size(54, 15);
            lbDiscount.TabIndex = 34;
            lbDiscount.Text = "Discount";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(12, 101);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(53, 15);
            lbQuantity.TabIndex = 33;
            lbQuantity.Text = "Quantity";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(12, 53);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(51, 15);
            lbOrderID.TabIndex = 32;
            lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(12, 14);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(63, 15);
            lbProductID.TabIndex = 31;
            lbProductID.Text = "Product ID";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(12, 273);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMemberList.MultiSelect = false;
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(471, 151);
            dgvMemberList.TabIndex = 69;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(156, 11);
            txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(254, 23);
            txtProductID.TabIndex = 70;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(12, 226);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(118, 22);
            btnLoad.TabIndex = 71;
            btnLoad.Text = "&Load Product";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmOrderDDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(495, 437);
            Controls.Add(btnLoad);
            Controls.Add(txtProductID);
            Controls.Add(dgvMemberList);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtOrderID);
            Controls.Add(txtQuantity);
            Controls.Add(txtDiscount);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbDiscount);
            Controls.Add(lbQuantity);
            Controls.Add(lbOrderID);
            Controls.Add(lbProductID);
            Name = "frmOrderDDetails";
            Text = "Order Detail";
            Load += frmOrderDDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnLoad;
    }
}