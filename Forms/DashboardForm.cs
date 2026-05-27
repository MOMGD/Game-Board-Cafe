using System;
using System.Windows.Forms;

namespace BoardGameCafeApp.Forms;

public partial class DashboardForm : Form
{
    private readonly IServiceProvider _provider;

    private void DashboardForm_Load(object sender, EventArgs e)
    {
    }

    public DashboardForm(IServiceProvider provider)
    {
        InitializeComponent();
        _provider = provider;

        StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnGames_Click(object sender, EventArgs e)
    {
        using var f = new GameCatalogForm(_provider);
        f.ShowDialog();
    }

    private void btnAddGame_Click(object sender, EventArgs e)
    {
        using var f = new AddEditGameForm(_provider);
        f.ShowDialog();
    }

    private void btnRentGame_Click(object sender, EventArgs e)
    {
        using var f = new RentGameForm(_provider);
        f.ShowDialog();
    }

    private void btnBookTable_Click(object sender, EventArgs e)
    {
        using var f = new TableBookingForm(_provider);
        f.ShowDialog();
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        using var f = new HistoryForm(_provider);
        f.ShowDialog();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
    }
}