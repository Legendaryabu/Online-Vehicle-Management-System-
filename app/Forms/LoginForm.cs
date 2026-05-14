using OVSMS_Desktop.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OVSMS_Desktop.Forms
{
    public partial class LoginForm : Form
    {
        public User? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            { MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrEmpty(txtPassword.Text))
            { MessageBox.Show("Please enter your password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                using (var context = new AppDbContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Email == txtEmail.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (user.Password == txtPassword.Text)
                    {
                        // --- ROLE ROUTING ---
                        if (user.Role == UserRole.Customer)
                        {
                            this.LoggedInUser = user;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else if (user.Role == UserRole.Provider)
                        {
                            if (!user.IsApproved)
                            {
                                MessageBox.Show("Your provider account is awaiting admin approval.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            this.LoggedInUser = user;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else if (user.Role == UserRole.Admin)
                        {
                            this.LoggedInUser = user;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Unknown user role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm()) { registerForm.ShowDialog(); }
        }

        private void linkForgotPassword_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Password recovery is handled by the system administrator.\n\n" +
                             "Please contact support with your email address to have your password reset.";

            MessageBox.Show(message, "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try { return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)); }
            catch (RegexMatchTimeoutException) { return false; }
        }
    }
}