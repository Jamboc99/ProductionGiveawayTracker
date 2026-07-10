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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
