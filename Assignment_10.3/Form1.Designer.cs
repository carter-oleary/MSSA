namespace Assignment_10._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCars = new DataGridView();
            lblVIN = new Label();
            lblMake = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            txtVin = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(180, 60);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersWidth = 51;
            dgvCars.Size = new Size(606, 324);
            dgvCars.TabIndex = 0;
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVIN.Location = new Point(180, 410);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(36, 20);
            lblVIN.TabIndex = 1;
            lblVIN.Text = "VIN";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMake.Location = new Point(180, 464);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(47, 20);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModel.Location = new Point(180, 513);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 20);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.Location = new Point(180, 562);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(39, 20);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(180, 609);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // txtVin
            // 
            txtVin.Location = new Point(277, 407);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(125, 27);
            txtVin.TabIndex = 6;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(277, 461);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(277, 510);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(277, 559);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(277, 606);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(509, 401);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(661, 586);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 43);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(661, 401);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 43);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(509, 494);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(125, 43);
            btnSelect.TabIndex = 14;
            btnSelect.Text = "Select Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(509, 586);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 43);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(661, 494);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 43);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 714);
            Controls.Add(btnUpdate);
            Controls.Add(btnRefresh);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtVin);
            Controls.Add(lblPrice);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            Controls.Add(lblVIN);
            Controls.Add(dgvCars);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCars;
        private Label lblVIN;
        private Label lblMake;
        private Label lblModel;
        private Label lblYear;
        private Label lblPrice;
        private TextBox txtVin;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnRefresh;
        private Button btnUpdate;
    }
}
