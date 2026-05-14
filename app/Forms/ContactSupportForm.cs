using System;
using System.Drawing;
using System.Windows.Forms;

namespace OVSMS_Desktop.Forms
{
    public partial class ContactSupportForm : Form
    {

        private const string AdminName = "M.J.ZAID AHAMED (BIT)";
        private const string AdminEmail = "ovsms@support.com";
        private const string AdminPhone = "+94 74 027 9364";
        private const string OfficeHours = "Monday-Friday, 9:00 AM to 5:00 PM";

        public ContactSupportForm()
        {
            InitializeComponent();
        }

        private void ContactSupportForm_Load(object? sender, EventArgs e)
        {
            lblNameValue.Text = AdminName;
            lblEmailValue.Text = AdminEmail;
            lblPhoneValue.Text = AdminPhone;
            lblHoursValue.Text = OfficeHours;
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}