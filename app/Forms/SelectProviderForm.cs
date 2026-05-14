using OVSMS_Desktop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OVSMS_Desktop.Forms
{
    public partial class SelectProviderForm : Form
    {
        public User? SelectedProvider { get; private set; }

        private readonly Service _selectedService;
        private readonly List<User> _availableProviders;

        public SelectProviderForm(Service service, List<User> providers)
        {
            InitializeComponent();
            _selectedService = service ?? throw new ArgumentNullException(nameof(service));
            _availableProviders = providers;

            lblServiceName.Text = _selectedService.Name;
            lblInstruction.Text = $"Select an approved provider offering '{_selectedService.Name}':";
        }

        private void SelectProviderForm_Load(object? sender, EventArgs e)
        {
            listBoxProviders.Items.Clear(); 
            if (_availableProviders.Any())
            {
                foreach (var provider in _availableProviders)
                {
                    // Use null-coalescing on nullable properties
                    string name = provider.Name ?? "N/A";
                    string phone = provider.Phone ?? "N/A";

                    // Add Phone number and placeholder for Rating
                    string displayText = $"{name} - Phone: {phone} (Rating: N/A)";
                    listBoxProviders.Items.Add(displayText);
                }
            }
            else
            {
                listBoxProviders.Items.Add("No providers found for this service.");
                btnSelect.Enabled = false; // Disable select if list is empty/placeholder
            }


            listBoxProviders.SelectedIndex = -1;
            btnSelect.Enabled = false;
        }

        private void listBoxProviders_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Enable button only if a valid provider item is selected 
            // (check if index is valid and within the bounds of our provider list)
            btnSelect.Enabled = (listBoxProviders.SelectedIndex >= 0 &&
                                 listBoxProviders.SelectedIndex < _availableProviders.Count);
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            // Get the selected User object based on the index
            if (listBoxProviders.SelectedIndex >= 0 && listBoxProviders.SelectedIndex < _availableProviders.Count)
            {
                // Retrieve the User object from our original list using the selected index
                SelectedProvider = _availableProviders[listBoxProviders.SelectedIndex];

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a valid provider from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}