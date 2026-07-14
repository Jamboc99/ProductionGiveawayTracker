using System.Text.Json;
//             //
namespace ProductionGiveawayTracker
{
    public partial class Form1 : Form
    {
        private List<GiveawayRecord> records = new List<GiveawayRecord>();
        private string saveFilePath = "giveaway_records.json";
        private int editingIndex = -1;
        public Form1()
        {
            InitializeComponent();

            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.MultiSelect = false;

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

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRecord_Click_1(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            int selectedIndex = dgvRecords.SelectedRows[0].Index;

            if (selectedIndex >= 0 && selectedIndex < records.Count)
            {
                records.RemoveAt(selectedIndex);
            }

            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;
            UpdateTotalGiveaway();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a record to edit");
                return;
            }
            int selectedIndex = dgvRecords.SelectedRows[0].Index;

            if(selectedIndex <0 || selectedIndex >= records.Count)
            {
                MessageBox.Show("Invalid record selected");
                return;
            }

            GiveawayRecord recordToEdit = records[selectedIndex];
            dtpDate.Value = recordToEdit.Date;
            cmbShift.Text = recordToEdit.Shift;
            nudLineNumber.Value = recordToEdit.LineNumber;
            txtProduct.Text = recordToEdit.Product;
            nudGiveawayKg.Value = recordToEdit.GiveawayKg;
           
            editingIndex = selectedIndex;
            
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if(editingIndex < 0 || editingIndex >= records.Count)
            {
                MessageBox.Show("No record is being edited.");
                return;
            }
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

            records[editingIndex] = new GiveawayRecord(
                dtpDate.Value,
                cmbShift.Text,
                (int)nudLineNumber.Value,
                txtProduct.Text,
                nudGiveawayKg.Value
            );

            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;

            UpdateTotalGiveaway();
            ClearInputFields();

            editingIndex = -1;
            MessageBox.Show("record updated successfully");

        }
    }
}
