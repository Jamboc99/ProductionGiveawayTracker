using System.Text.Json;
using System.Text.Json;
//             //
namespace ProductionGiveawayTracker
{
    public partial class Form1 : Form
    {
        private List<GiveawayRecord> records = new List<GiveawayRecord>();
        private string saveFilePath = "giveaway_records.json";
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
            if (nudLineNumber.Text == "")
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(records);
            File.WriteAllText(saveFilePath, json);
            MessageBox.Show("Records saved successfully!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(saveFilePath))
            {
                MessageBox.Show("No saved records found.");
                return;
            }

            string json = File.ReadAllText(saveFilePath);


            List<GiveawayRecord>? loadedRecords = JsonSerializer.Deserialize<List<GiveawayRecord>>(json);

            if (loadedRecords == null)
            {
                MessageBox.Show("could not load records");
                return;
            }

            records = loadedRecords;

            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;

            UpdateTotalGiveaway();

            MessageBox.Show("Records loaded successfully");
        }
    }
}
