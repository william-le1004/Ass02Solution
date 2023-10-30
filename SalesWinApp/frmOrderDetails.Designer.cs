
namespace SalesWinApp
{
    partial class frmOrderDetails
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
            dgvMemberList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtOrderDate = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtRequiredDate = new System.Windows.Forms.TextBox();
            lbRequiredDate = new System.Windows.Forms.Label();
            lbFreight = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbMemberID = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            lbOrderID = new System.Windows.Forms.Label();
            txtShippedDate = new System.Windows.Forms.TextBox();
            txtFreight = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(13, 272);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMemberList.MultiSelect = false;
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(736, 126);
            dgvMemberList.TabIndex = 38;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(81, 127);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(124, 22);
            btnLoad.TabIndex = 37;
            btnLoad.Text = "&Load Details";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(340, 127);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(82, 22);
            btnNew.TabIndex = 36;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(559, 127);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(178, 85);
            txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(192, 23);
            txtOrderDate.TabIndex = 33;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(178, 51);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(192, 23);
            txtMemberID.TabIndex = 32;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(178, 11);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(192, 23);
            txtOrderID.TabIndex = 31;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new System.Drawing.Point(479, 11);
            txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new System.Drawing.Size(219, 23);
            txtRequiredDate.TabIndex = 30;
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new System.Drawing.Point(392, 14);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            lbRequiredDate.TabIndex = 29;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new System.Drawing.Point(392, 88);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new System.Drawing.Size(44, 15);
            lbFreight.TabIndex = 28;
            lbFreight.Text = "Freight";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(392, 53);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(77, 15);
            lbCountry.TabIndex = 27;
            lbCountry.Text = "Shipped Date";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(81, 51);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(66, 15);
            lbMemberID.TabIndex = 26;
            lbMemberID.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(81, 85);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(64, 15);
            lbOrderDate.TabIndex = 25;
            lbOrderDate.Text = "Order Date";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(81, 14);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(51, 15);
            lbOrderID.TabIndex = 24;
            lbOrderID.Text = "Order ID";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new System.Drawing.Point(479, 51);
            txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(219, 23);
            txtShippedDate.TabIndex = 46;
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(479, 85);
            txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(219, 23);
            txtFreight.TabIndex = 47;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(559, 417);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 22);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(340, 417);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(82, 22);
            btnSave.TabIndex = 48;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(81, 417);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(124, 22);
            button1.TabIndex = 73;
            button1.Text = "&Load Members";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(13, 465);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(736, 151);
            dataGridView1.TabIndex = 72;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(479, 215);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(219, 23);
            textBox1.TabIndex = 81;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(479, 181);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(219, 23);
            textBox2.TabIndex = 80;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(178, 215);
            textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(192, 23);
            textBox3.TabIndex = 79;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(178, 181);
            textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(192, 23);
            textBox4.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(392, 218);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 77;
            label1.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(392, 183);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 76;
            label2.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(81, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 75;
            label3.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(81, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 74;
            label4.Text = "Quantity";
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(758, 627);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(dgvMemberList);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(txtRequiredDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbFreight);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderDate);
            Controls.Add(lbOrderID);
            Name = "frmOrderDetails";
            Text = "OrderDetail";
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}