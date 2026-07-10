namespace ProductionGiveawayTracker
{
    public partial class Form1 : Form
    {
        private List<GiveawayRecord> records = new List<GiveawayRecord>();
        public Form1()
        {
            InitializeComponent();

            cmbShift.Items.Add("Dayshift");
            cmbShift.Items.Add("Backshift");
            cmbShift.Items.Add("Nightshift");
            cmbShift.SelectedIndex = 0;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("please enter a product name");
                return;
            }
            if(nudLineNumber.Text == "")
            {
                MessageBox.Show("please enter a line number");
                return;
            }
            if (nudGiveawayKg.Value <= 0)
            {
                MessageBox.Show("Giveaway amount must be greater than 0");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbShift.Text))
            {
                MessageBox.Show("Please select a shift");
                return;
            }

            GiveawayRecord record = new GiveawayRecord(
                dtpDate.Value,
                cmbShift.Text,
                (int)nudLineNumber.Value,
                txtProduct.Text,
                nudGiveawayKg.Value
            );

            records.Add(record);

            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;

            UpdateTotalGiveaway();
            ClearInputFields();

        }

        private void UpdateTotalGiveaway()
        {
            decimal total = 0;

            foreach (GiveawayRecord record in records)
            {
                total += record.GiveawayKg;
            }

            lblTotalGiveaway.Text = $"Total Giveaway: {total} Kg";
        }

        private void ClearInputFields()
        {
            txtProduct.Clear();
            nudGiveawayKg.Value = 0;
            nudLineNumber.Value = 0;
            cmbShift.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
        }
    }
}
