using BoardGameCafeApp.Models;
using BoardGameCafeApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGameCafeApp.Forms;

public partial class AddEditGameForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly GameService _gameService;

    private readonly int? _editGameId; // null => Add mode

    public AddEditGameForm(IServiceProvider provider) : this(provider, null)
    {
    }

    public AddEditGameForm(IServiceProvider provider, int? gameIdToEdit)
    {
        InitializeComponent();
        _provider = provider;
        _gameService = _provider.GetRequiredService<GameService>();

        _editGameId = gameIdToEdit;

        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        Load += AddEditGameForm_Load;
    }

    private void AddEditGameForm_Load(object? sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            if (_editGameId == null)
            {
                Text = "Add Game";
                lblHeader.Text = Text;
                // defaults
                nudTotalCopies.Value = 1;
                nudPricePerHour.Value = 1;
                return;
            }

            Text = "Edit Game";
            lblHeader.Text = Text;

            var game = _gameService.GetById(_editGameId.Value);
            if (game == null)
            {
                MessageBox.Show("Game not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtTitle.Text = game.Title;
            txtGenre.Text = game.Genre;
            nudTotalCopies.Value = game.TotalCopies;
            nudPricePerHour.Value = game.PricePerHour;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load game.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            // ---- Input validation (form-level) ----
            bool valid = true;

            var title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                errorProvider1.SetError(txtTitle, "Title is required.");
                valid = false;
            }

            var genre = txtGenre.Text.Trim();
            if (string.IsNullOrWhiteSpace(genre))
            {
                errorProvider1.SetError(txtGenre, "Genre is required.");
                valid = false;
            }

            var copies = (int)nudTotalCopies.Value;
            var price = nudPricePerHour.Value;

            if (copies < 0)
            {
                errorProvider1.SetError(nudTotalCopies, "Copies cannot be negative.");
                valid = false;
            }

            if (price < 0)
            {
                errorProvider1.SetError(nudPricePerHour, "Price cannot be negative.");
                valid = false;
            }

            if (!valid) return;

            // ---- Map to entity ----
            if (_editGameId == null)
            {
                var newGame = new Game
                {
                    Title = title,
                    Genre = genre,
                    TotalCopies = copies,
                    PricePerHour = price
                };

                _gameService.Add(newGame);
                MessageBox.Show("Game added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existing = _gameService.GetById(_editGameId.Value);
                if (existing == null)
                {
                    MessageBox.Show("Game not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                existing.Title = title;
                existing.Genre = genre;
                existing.TotalCopies = copies;
                existing.PricePerHour = price;

                _gameService.Update(existing);
                MessageBox.Show("Game updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (InvalidOperationException ex)
        {
            // From GameService.ValidateGame
            MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Save failed.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}