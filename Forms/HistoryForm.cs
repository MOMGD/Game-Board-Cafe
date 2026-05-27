using BoardGameCafeApp.Models;
using BoardGameCafeApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGameCafeApp.Forms;

public partial class HistoryForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly RentalService _rentalService;
    private readonly BookingService _bookingService;

    public HistoryForm(IServiceProvider provider)
    {
        InitializeComponent();
        _provider = provider;

        _rentalService = _provider.GetRequiredService<RentalService>();
        _bookingService = _provider.GetRequiredService<BookingService>();

        StartPosition = FormStartPosition.CenterParent;

        Load += HistoryForm_Load;
    }

    private void HistoryForm_Load(object? sender, EventArgs e)
    {
        try
        {
            SetupRentalGrid();
            SetupBookingGrid();

            // Default filter setup
            cmbRentalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRentalStatus.Items.Clear();
            cmbRentalStatus.Items.AddRange(["All", "Active", "Returned"]);
            cmbRentalStatus.SelectedIndex = 0;

            chkRentalUseDateFilter.Checked = false;
            chkBookingUseDateFilter.Checked = false;

            chkRentalUseDateFilter_CheckedChanged(chkRentalUseDateFilter, EventArgs.Empty);
            chkBookingUseDateFilter_CheckedChanged(chkBookingUseDateFilter, EventArgs.Empty);

            dtpRentalFrom.Value = DateTime.Today.AddDays(-7);
            dtpRentalTo.Value = DateTime.Today;

            dtpBookingFrom.Value = DateTime.Today.AddDays(-7);
            dtpBookingTo.Value = DateTime.Today;

            LoadBookingTablesFilter();

            RefreshRentals();
            RefreshBookings();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load history.\n\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private sealed class ComboItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public override string ToString() => Name;
    }

    // ---------------- Rentals ----------------
    private void SetupRentalGrid()
    {
        dgvRentals.AutoGenerateColumns = false;
        dgvRentals.MultiSelect = false;
        dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRentals.ReadOnly = true;
        dgvRentals.AllowUserToAddRows = false;

        if (dgvRentals.Columns.Count > 0) return;

        dgvRentals.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRentalId",
            HeaderText = "Rental ID",
            DataPropertyName = nameof(Rental.RentalId),
            Width = 80
        });

        dgvRentals.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colGameTitle",
            HeaderText = "Game",
            DataPropertyName = "GameTitle",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });

        dgvRentals.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRentalCustomer",
            HeaderText = "Customer",
            DataPropertyName = nameof(Rental.CustomerName),
            Width = 160
        });

        dgvRentals.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRentDate",
            HeaderText = "Rent Date",
            DataPropertyName = nameof(Rental.RentDate),
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
        });

        dgvRentals.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colReturnDate",
            HeaderText = "Return Date",
            DataPropertyName = nameof(Rental.ReturnDate),
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
        });
    }

    private void RefreshRentals()
    {
        DateTime? from = null;
        DateTime? to = null;

        if (chkRentalUseDateFilter.Checked)
        {
            from = dtpRentalFrom.Value.Date;
            to = dtpRentalTo.Value.Date.AddDays(1).AddTicks(-1);
        }

        bool? activeOnly = cmbRentalStatus.SelectedItem?.ToString() switch
        {
            "Active" => true,
            "Returned" => false,
            _ => null
        };

        var list = _rentalService.GetRentalHistory(
            from: from,
            to: to,
            customerSearch: txtRentalCustomer.Text.Trim(),
            activeOnly: activeOnly);

        // Bind a projection so we can show Game title easily
        var gridData = list.Select(r => new
        {
            r.RentalId,
            GameTitle = r.Game?.Title ?? "(unknown)",
            r.CustomerName,
            r.RentDate,
            r.ReturnDate
        }).ToList();

        dgvRentals.DataSource = gridData;
    }

    private int? GetSelectedRentalId()
    {
        if (dgvRentals.CurrentRow?.Cells["colRentalId"]?.Value is int id)
            return id;

        // Sometimes it comes as boxed Int32
        if (dgvRentals.CurrentRow?.Cells["colRentalId"]?.Value is object o && int.TryParse(o.ToString(), out int parsed))
            return parsed;

        return null;
    }

    private void btnRentalApply_Click(object sender, EventArgs e) => RefreshRentals();

    private void btnRentalClear_Click(object sender, EventArgs e)
    {
        txtRentalCustomer.Clear();
        chkRentalUseDateFilter.Checked = false;
        cmbRentalStatus.SelectedIndex = 0;
        RefreshRentals();
    }

    private void btnReturnSelected_Click(object sender, EventArgs e)
    {
        var rentalId = GetSelectedRentalId();
        if (rentalId == null)
        {
            MessageBox.Show("Select a rental first.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show("Mark this rental as returned now?", "Return Rental",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            _rentalService.ReturnRental(rentalId.Value, DateTime.Now);
            RefreshRentals();
            MessageBox.Show("Rental returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Cannot Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to return rental.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ---------------- Bookings ----------------
    private void SetupBookingGrid()
    {
        dgvBookings.AutoGenerateColumns = false;
        dgvBookings.MultiSelect = false;
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBookings.ReadOnly = true;
        dgvBookings.AllowUserToAddRows = false;

        if (dgvBookings.Columns.Count > 0) return;

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colBookingId",
            HeaderText = "Booking ID",
            DataPropertyName = nameof(Booking.BookingId),
            Width = 90
        });

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTable",
            HeaderText = "Table",
            DataPropertyName = "TableName",
            Width = 100
        });

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colBookingCustomer",
            HeaderText = "Customer",
            DataPropertyName = nameof(Booking.CustomerName),
            Width = 160
        });

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStart",
            HeaderText = "Start",
            DataPropertyName = nameof(Booking.StartTime),
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
        });

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colEnd",
            HeaderText = "End",
            DataPropertyName = nameof(Booking.EndTime),
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
        });

        dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colNotes",
            HeaderText = "Notes",
            DataPropertyName = nameof(Booking.Notes),
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
    }

    private void LoadBookingTablesFilter()
    {
        var tables = _bookingService.GetAllTables();

        cmbBookingTable.DropDownStyle = ComboBoxStyle.DropDownList;

        var items = new List<ComboItem>
    {
        new ComboItem { Id = 0, Name = "All" }
    };

        items.AddRange(tables.Select(t => new ComboItem
        {
            Id = t.CafeTableId,
            Name = t.TableName
        }));

        cmbBookingTable.DataSource = items;
        cmbBookingTable.DisplayMember = nameof(ComboItem.Name);
        cmbBookingTable.ValueMember = nameof(ComboItem.Id);
        cmbBookingTable.SelectedIndex = 0;
    }

    private void RefreshBookings()
    {
        DateTime? from = null;
        DateTime? to = null;

        if (chkBookingUseDateFilter.Checked)
        {
            from = dtpBookingFrom.Value.Date;
            to = dtpBookingTo.Value.Date.AddDays(1).AddTicks(-1);
        }

        int? tableId = null;
        if (cmbBookingTable.SelectedValue is int id && id > 0)
            tableId = id;

        var list = _bookingService.GetBookingHistory(
            from: from,
            to: to,
            customerSearch: txtBookingCustomer.Text.Trim(),
            tableId: tableId);

        var gridData = list.Select(b => new
        {
            b.BookingId,
            TableName = b.CafeTable?.TableName ?? "(unknown)",
            b.CustomerName,
            b.StartTime,
            b.EndTime,
            b.Notes
        }).ToList();

        dgvBookings.DataSource = gridData;
    }

    private void btnBookingApply_Click(object sender, EventArgs e) => RefreshBookings();

    private void btnBookingClear_Click(object sender, EventArgs e)
    {
        txtBookingCustomer.Clear();
        chkBookingUseDateFilter.Checked = false;
        cmbBookingTable.SelectedIndex = 0;
        RefreshBookings();
    }

    private void chkRentalUseDateFilter_CheckedChanged(object sender, EventArgs e)
    {
        dtpRentalFrom.Enabled = chkRentalUseDateFilter.Checked;
        dtpRentalTo.Enabled = chkRentalUseDateFilter.Checked;
    }

    private void chkBookingUseDateFilter_CheckedChanged(object sender, EventArgs e)
    {
        dtpBookingFrom.Enabled = chkBookingUseDateFilter.Checked;
        dtpBookingTo.Enabled = chkBookingUseDateFilter.Checked;
    }

    private void txtRentalCustomer_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            RefreshRentals();
            e.SuppressKeyPress = true;
        }
    }

    private void txtBookingCustomer_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            RefreshBookings();
            e.SuppressKeyPress = true;
        }
    }
}