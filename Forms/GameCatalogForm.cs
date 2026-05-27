using BoardGameCafeApp.Models;
using BoardGameCafeApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGameCafeApp.Forms;

public partial class GameCatalogForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly GameService _gameService;

    public GameCatalogForm(IServiceProvider provider)
    {
        InitializeComponent();
        _provider = provider;
        _gameService = _provider.GetRequiredService<GameService>();

        StartPosition = FormStartPosition.CenterParent;

        Load += GameCatalogForm_Load;
    }

    private void GameCatalogForm_Load(object? sender, EventArgs e)
    {
        try
        {
            SetupGrid();
            LoadGenres();
            RefreshGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load catalog.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetupGrid()
    {
        dgvGames.AutoGenerateColumns = false;
        dgvGames.MultiSelect = false;
        dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvGames.ReadOnly = true;
        dgvGames.AllowUserToAddRows = false;

        if (dgvGames.Columns.Count == 0)
        {
            dgvGames.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = nameof(Game.GameId),
                Width = 60
            });

            dgvGames.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTitle",
                HeaderText = "Title",
                DataPropertyName = nameof(Game.Title),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvGames.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGenre",
                HeaderText = "Genre",
                DataPropertyName = nameof(Game.Genre),
                Width = 120
            });

            dgvGames.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCopies",
                HeaderText = "Copies",
                DataPropertyName = nameof(Game.TotalCopies),
                Width = 80
            });

            dgvGames.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Price/Hour",
                DataPropertyName = nameof(Game.PricePerHour),
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" }
            });
        }
    }

    private void LoadGenres()
    {
        var genres = _gameService.GetGenres();
        genres.Insert(0, "All");

        cmbGenre.DataSource = genres;
        cmbGenre.SelectedIndex = 0;
        cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void RefreshGrid()
    {
        var title = txtSearchTitle.Text.Trim();
        var genre = cmbGenre.SelectedItem?.ToString();

        var data = _gameService.GetGames(title, genre);
        dgvGames.DataSource = data;
    }

    private int? GetSelectedGameId()
    {
        if (dgvGames.CurrentRow?.DataBoundItem is Game g)
            return g.GameId;

        return null;
    }

    private void btnSearch_Click(object sender, EventArgs e) => RefreshGrid();

    private void btnRefresh_Click(object sender, EventArgs e) => RefreshGrid();

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtSearchTitle.Clear();
        cmbGenre.SelectedIndex = 0;
        RefreshGrid();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var f = new AddEditGameForm(_provider);
        if (f.ShowDialog() == DialogResult.OK)
        {
            LoadGenres();
            RefreshGrid();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var gameId = GetSelectedGameId();
        if (gameId == null)
        {
            MessageBox.Show("Please select a game first.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var f = new AddEditGameForm(_provider, gameId.Value);
        if (f.ShowDialog() == DialogResult.OK)
        {
            LoadGenres();
            RefreshGrid();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var gameId = GetSelectedGameId();
        if (gameId == null)
        {
            MessageBox.Show("Please select a game first.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show(
            "Are you sure you want to delete the selected game?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirm != DialogResult.Yes) return;

        try
        {
            _gameService.Delete(gameId.Value);
            LoadGenres();
            RefreshGrid();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Delete failed.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgvGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        btnEdit.PerformClick();
    }
    // new features added to make the UI better for searcing it makes it auto refresh yep that is a really great feature to be honest i surprise myself sometimes :}
    private void txtSearchTitle_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            RefreshGrid();              // run filtering
            e.Handled = true;           // mark event handled
            e.SuppressKeyPress = true;  // prevents the ding ding dingggg sound really genius of me must say
        }
    }

    private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Only refresh if the form is loaded and the combo has data just best practice to avoid unnecessary refreshes during form initialization preatty much that's it MOMGD WAS HERE
        if (cmbGenre.SelectedItem != null)
            RefreshGrid();
    }
}