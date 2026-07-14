namespace ProductionGiveawayTracker
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
            dtpDate = new DateTimePicker();
            cmbShift = new ComboBox();
            nudLineNumber = new NumericUpDown();
            txtProduct = new TextBox();
            nudGiveawayKg = new NumericUpDown();
            btnAddRecord = new Button();
            dgvRecords = new DataGridView();
            lblTotalGiveaway = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnDeleteRecord = new Button();
            btnEditRecord = new Button();
            btnUpdateRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiveawayKg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(23, 29);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 0;
            // 
            // cmbShift
            // 
            cmbShift.FormattingEnabled = true;
            cmbShift.Location = new Point(23, 58);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(121, 23);
            cmbShift.TabIndex = 1;
            // 
            // nudLineNumber
            // 
            nudLineNumber.Location = new Point(24, 87);
            nudLineNumber.Name = "nudLineNumber";
            nudLineNumber.Size = new Size(120, 23);
            nudLineNumber.TabIndex = 2;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(24, 116);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(100, 23);
            txtProduct.TabIndex = 3;
            // 
            // nudGiveawayKg
            // 
            nudGiveawayKg.Location = new Point(23, 145);
            nudGiveawayKg.Name = "nudGiveawayKg";
            nudGiveawayKg.Size = new Size(120, 23);
            nudGiveawayKg.TabIndex = 4;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(23, 208);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(121, 23);
            btnAddRecord.TabIndex = 5;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(24, 237);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(764, 173);
            dgvRecords.TabIndex = 6;
            // 
            // lblTotalGiveaway
            // 
            lblTotalGiveaway.AutoSize = true;
            lblTotalGiveaway.Location = new Point(249, 426);
            lblTotalGiveaway.Name = "lblTotalGiveaway";
            lblTotalGiveaway.Size = new Size(112, 15);
            lblTotalGiveaway.TabIndex = 7;
            lblTotalGiveaway.Text = "Total Giveaway: 0Kg";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(401, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(549, 48);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(150, 208);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(134, 23);
            btnDeleteRecord.TabIndex = 10;
            btnDeleteRecord.Text = "Delete Record";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click_1;
            // 
            // btnEditRecord
            // 
            btnEditRecord.Location = new Point(290, 208);
            btnEditRecord.Name = "btnEditRecord";
            btnEditRecord.Size = new Size(144, 23);
            btnEditRecord.TabIndex = 11;
            btnEditRecord.Text = "Edit Selected Record";
            btnEditRecord.UseVisualStyleBackColor = true;
            btnEditRecord.Click += btnEditRecord_Click;
            // 
            // btnUpdateRecord
            // 
            btnUpdateRecord.Location = new Point(440, 208);
            btnUpdateRecord.Name = "btnUpdateRecord";
            btnUpdateRecord.Size = new Size(119, 23);
            btnUpdateRecord.TabIndex = 12;
            btnUpdateRecord.Text = "Update Record";
            btnUpdateRecord.UseVisualStyleBackColor = true;
            btnUpdateRecord.Click += btnUpdateRecord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateRecord);
            Controls.Add(btnEditRecord);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lblTotalGiveaway);
            Controls.Add(dgvRecords);
            Controls.Add(btnAddRecord);
            Controls.Add(nudGiveawayKg);
            Controls.Add(txtProduct);
            Controls.Add(nudLineNumber);
            Controls.Add(cmbShift);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Production Giveaway tracker";
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiveawayKg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private ComboBox cmbShift;
        private NumericUpDown nudLineNumber;
        private TextBox txtProduct;
        private NumericUpDown nudGiveawayKg;
        private Button btnAddRecord;
        private DataGridView dgvRecords;
        private Label lblTotalGiveaway;
        private Button btnSave;
        private Button btnLoad;
        private Button btnDeleteRecord;
        private Button btnEditRecord;
        private Button btnUpdateRecord;
    }
}
