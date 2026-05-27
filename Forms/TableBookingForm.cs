using BoardGameCafeApp.Models;
using BoardGameCafeApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BoardGameCafeApp.Forms;

public partial class TableBookingForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly BookingService _bookingService;

    public TableBookingForm(IServiceProvider provider)
    {
        InitializeComponent();
        _provider = provider;
        _bookingService = _provider.GetRequiredService<BookingService>();

        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;

        // Good defaults
        dtpStart.Value = DateTime.Now.AddMinutes(15);
        dtpEnd.Value = DateTime.Now.AddHours(1);

        Load += TableBookingForm_Load;
    }

    private void TableBookingForm_Load(object? sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            var tables = _bookingService.GetActiveTables()
                .OrderBy(t => t.TableName)
                .ToList();

            cmbTables.DisplayMember = nameof(CafeTable.TableName);
            cmbTables.ValueMember = nameof(CafeTable.CafeTableId);
            cmbTables.DataSource = tables;

            if (tables.Count == 0)
            {
                MessageBox.Show(
                    "No active tables found. Please add tables in the database (seed) first.",
                    "No Tables",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load tables.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            errorProvider1.Clear();

            bool valid = true;

            if (cmbTables.SelectedItem == null)
            {
                errorProvider1.SetError(cmbTables, "Please select a table.");
                valid = false;
            }

            var customer = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customer))
            {
                errorProvider1.SetError(txtCustomerName, "Customer name is required.");
                valid = false;
            }

            var start = dtpStart.Value;
            var end = dtpEnd.Value;

            if (end <= start)
            {
                errorProvider1.SetError(dtpEnd, "End time must be after start time.");
                valid = false;
            }

            if (!valid) return;

            if (cmbTables.SelectedValue is not int tableId)
            {
                errorProvider1.SetError(cmbTables, "Please select a valid table.");
                return;
            }

            var booking = new Booking
            {
                CafeTableId = tableId,
                CustomerName = customer,
                StartTime = start,
                EndTime = end,
                Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
            };

            _bookingService.CreateBooking(booking);

            MessageBox.Show("Booking saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Booking Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to save booking.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}