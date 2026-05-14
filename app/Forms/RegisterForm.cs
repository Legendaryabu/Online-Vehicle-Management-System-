using OVSMS_Desktop.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OVSMS_Desktop.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            radioCustomer.Checked = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnCreateAccount_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.Email == txtEmail.Text))
                {
                    MessageBox.Show("An account with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserRole selectedRole = radioCustomer.Checked ? UserRole.Customer : UserRole.Provider;

                var newUser = new User
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text,
                    Role = selectedRole
                };

                // Customers are auto-approved. Providers require admin approval (default is false).
                if (selectedRole == UserRole.Customer)
                {
                    newUser.IsApproved = true;
                }

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void linkLogin_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}