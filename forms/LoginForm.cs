using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoardGameCafeApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly IServiceProvider _provider;

        // Hardcoded credentials (simple and acceptable for the course)
        private const string ValidUsername = "admin";
        private const string ValidPassword = "1234";

        public LoginForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;

            // Quality-of-life defaults
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Optional: if you have controls, set them here
            // (If you haven't created them in the designer, use the "manual UI" version below)
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text;

                bool valid = true;

                if (string.IsNullOrWhiteSpace(username))
                {
                    errorProvider1.SetError(txtUsername, "Username is required.");
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    errorProvider1.SetError(txtPassword, "Password is required.");
                    valid = false;
                }

                if (!valid) return;

                if (!IsValidLogin(username, password))
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                // Success -> open dashboard
                Hide();
                using (var dashboard = new DashboardForm(_provider))
                {
                    dashboard.ShowDialog();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error during login.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static bool IsValidLogin(string username, string password)
        {
            return string.Equals(username, ValidUsername, StringComparison.OrdinalIgnoreCase)
                   && password == ValidPassword;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter triggers login (event-driven behavior)
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}