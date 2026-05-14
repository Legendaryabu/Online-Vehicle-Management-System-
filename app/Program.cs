using OVSMS_Desktop.Data;
using OVSMS_Desktop.Forms;
using System;
using System.Windows.Forms;

namespace OVSMS_Desktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try { AppDbContext.InitializeDatabase(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database: {ex.Message}\nThe application might not work correctly.", "Database Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // return;
            }

            User? loggedInUser = null;
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedInUser = loginForm.LoggedInUser;
                }
            }

            // --- DASHBOARD ROUTING ---
            if (loggedInUser != null)
            {
                if (loggedInUser.Role == UserRole.Customer)
                {
                    Application.Run(new DashboardForm(loggedInUser));
                }
                else if (loggedInUser.Role == UserRole.Provider)
                {
                    Application.Run(new ProviderDashboardForm(loggedInUser));
                }
                else if (loggedInUser.Role == UserRole.Admin)
                {
                    Application.Run(new AdminDashboardForm(loggedInUser));
                }
                else
                {
                    MessageBox.Show("Login successful but user role is unknown or not supported.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }
    }
}