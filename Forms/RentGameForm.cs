using BoardGameCafeApp.Models;
using BoardGameCafeApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGameCafeApp.Forms;

public partial class RentGameForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly RentalService _rentalService;

    public RentGameForm(IServiceProvider provider)
    {
        InitializeComponent();
        _provider = provider;
        _rentalService = _provider.GetRequiredService<RentalService>();

        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        Load += RentGameForm_Load;
    }

    private void RentGameForm_Load(object? sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            dtpRentDate.Value = DateTime.Now;

            LoadGames();

            cmbGames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGames.SelectedIndexChanged += cmbGames_SelectedIndexChanged;

            UpdateAvailabilityLabel();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load rentable games.\n\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRent.Enabled = false;
        }
    }

    private void LoadGames()
    {
        var games = _rentalService.GetRentableGames();

        cmbGames.DisplayMember = nameof(Game.Title);
        cmbGames.ValueMember = nameof(Game.GameId);
        cmbGames.DataSource = games;

        if (games.Count == 0)
        {
            MessageBox.Show("No games are currently available to rent.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRent.Enabled = false;
        }
    }

    private void cmbGames_SelectedIndexChanged(object? sender, EventArgs e)
    {
        UpdateAvailabilityLabel();
    }

    private void UpdateAvailabilityLabel()
    {
        try
        {
            if (cmbGames.SelectedValue is not int gameId)
            {
                lblAvailableCopies.Text = "Available: -";
                return;
            }

            int available = _rentalService.GetAvailableCopies(gameId);
            lblAvailableCopies.Text = $"Available: {available}";
        }
        catch
        {
            lblAvailableCopies.Text = "Available: -";
        }
    }

    private void btnRent_Click(object sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            bool valid = true;

            if (cmbGames.SelectedValue is not int gameId)
            {
                errorProvider1.SetError(cmbGames, "Please select a game.");
                return;
            }

            var customer = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customer))
            {
                errorProvider1.SetError(txtCustomerName, "Customer name is required.");
                valid = false;
            }

            if (!valid) return;

            _rentalService.CreateRental(gameId, customer, dtpRentDate.Value);

            MessageBox.Show("Rental created successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh rentable games after renting
            LoadGames();
            txtCustomerName.Clear();
            UpdateAvailabilityLabel();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Cannot Rent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UpdateAvailabilityLabel();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to create rental.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}