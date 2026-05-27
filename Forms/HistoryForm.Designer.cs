namespace BoardGameCafeApp.Forms
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.TabPage tabBookings;

        // Rentals tab
        private System.Windows.Forms.Panel pnlRentalFilters;
        private System.Windows.Forms.Label lblRentalCustomer;
        private System.Windows.Forms.TextBox txtRentalCustomer;
        private System.Windows.Forms.CheckBox chkRentalUseDateFilter;
        private System.Windows.Forms.Label lblRentalFrom;
        private System.Windows.Forms.DateTimePicker dtpRentalFrom;
        private System.Windows.Forms.Label lblRentalTo;
        private System.Windows.Forms.DateTimePicker dtpRentalTo;
        private System.Windows.Forms.Label lblRentalStatus;
        private System.Windows.Forms.ComboBox cmbRentalStatus;
        private System.Windows.Forms.Button btnRentalApply;
        private System.Windows.Forms.Button btnRentalClear;
        private System.Windows.Forms.Button btnReturnSelected;
        private System.Windows.Forms.Panel pnlRentalsGrid;
        private System.Windows.Forms.DataGridView dgvRentals;

        // Bookings tab
        private System.Windows.Forms.Panel pnlBookingFilters;
        private System.Windows.Forms.Label lblBookingCustomer;
        private System.Windows.Forms.TextBox txtBookingCustomer;
        private System.Windows.Forms.CheckBox chkBookingUseDateFilter;
        private System.Windows.Forms.Label lblBookingFrom;
        private System.Windows.Forms.DateTimePicker dtpBookingFrom;
        private System.Windows.Forms.Label lblBookingTo;
        private System.Windows.Forms.DateTimePicker dtpBookingTo;
        private System.Windows.Forms.Label lblBookingTable;
        private System.Windows.Forms.ComboBox cmbBookingTable;
        private System.Windows.Forms.Button btnBookingApply;
        private System.Windows.Forms.Button btnBookingClear;
        private System.Windows.Forms.Panel pnlBookingsGrid;
        private System.Windows.Forms.DataGridView dgvBookings;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.pnlRentalsGrid = new System.Windows.Forms.Panel();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.pnlRentalFilters = new System.Windows.Forms.Panel();
            this.btnReturnSelected = new System.Windows.Forms.Button();
            this.btnRentalClear = new System.Windows.Forms.Button();
            this.btnRentalApply = new System.Windows.Forms.Button();
            this.cmbRentalStatus = new System.Windows.Forms.ComboBox();
            this.lblRentalStatus = new System.Windows.Forms.Label();
            this.dtpRentalTo = new System.Windows.Forms.DateTimePicker();
            this.lblRentalTo = new System.Windows.Forms.Label();
            this.dtpRentalFrom = new System.Windows.Forms.DateTimePicker();
            this.lblRentalFrom = new System.Windows.Forms.Label();
            this.chkRentalUseDateFilter = new System.Windows.Forms.CheckBox();
            this.txtRentalCustomer = new System.Windows.Forms.TextBox();
            this.lblRentalCustomer = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.pnlBookingsGrid = new System.Windows.Forms.Panel();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.pnlBookingFilters = new System.Windows.Forms.Panel();
            this.btnBookingClear = new System.Windows.Forms.Button();
            this.btnBookingApply = new System.Windows.Forms.Button();
            this.cmbBookingTable = new System.Windows.Forms.ComboBox();
            this.lblBookingTable = new System.Windows.Forms.Label();
            this.dtpBookingTo = new System.Windows.Forms.DateTimePicker();
            this.lblBookingTo = new System.Windows.Forms.Label();
            this.dtpBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.lblBookingFrom = new System.Windows.Forms.Label();
            this.chkBookingUseDateFilter = new System.Windows.Forms.CheckBox();
            this.txtBookingCustomer = new System.Windows.Forms.TextBox();
            this.lblBookingCustomer = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRentals.SuspendLayout();
            this.pnlRentalsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.pnlRentalFilters.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.pnlBookingsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.pnlBookingFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 86);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(337, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "View rentals and bookings history with simple filters";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "History";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRentals);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Location = new System.Drawing.Point(18, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 556);
            this.tabControl1.TabIndex = 1;
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.pnlRentalsGrid);
            this.tabRentals.Controls.Add(this.pnlRentalFilters);
            this.tabRentals.Location = new System.Drawing.Point(4, 24);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Padding = new System.Windows.Forms.Padding(10);
            this.tabRentals.Size = new System.Drawing.Size(956, 528);
            this.tabRentals.TabIndex = 0;
            this.tabRentals.Text = "Rentals";
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // pnlRentalsGrid
            // 
            this.pnlRentalsGrid.BackColor = System.Drawing.Color.White;
            this.pnlRentalsGrid.Controls.Add(this.dgvRentals);
            this.pnlRentalsGrid.Location = new System.Drawing.Point(10, 116);
            this.pnlRentalsGrid.Name = "pnlRentalsGrid";
            this.pnlRentalsGrid.Size = new System.Drawing.Size(936, 402);
            this.pnlRentalsGrid.TabIndex = 1;
            // 
            // dgvRentals
            // 
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowTemplate.Height = 25;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(936, 402);
            this.dgvRentals.TabIndex = 0;
            // 
            // pnlRentalFilters
            // 
            this.pnlRentalFilters.BackColor = System.Drawing.Color.White;
            this.pnlRentalFilters.Controls.Add(this.btnReturnSelected);
            this.pnlRentalFilters.Controls.Add(this.btnRentalClear);
            this.pnlRentalFilters.Controls.Add(this.btnRentalApply);
            this.pnlRentalFilters.Controls.Add(this.cmbRentalStatus);
            this.pnlRentalFilters.Controls.Add(this.lblRentalStatus);
            this.pnlRentalFilters.Controls.Add(this.dtpRentalTo);
            this.pnlRentalFilters.Controls.Add(this.lblRentalTo);
            this.pnlRentalFilters.Controls.Add(this.dtpRentalFrom);
            this.pnlRentalFilters.Controls.Add(this.lblRentalFrom);
            this.pnlRentalFilters.Controls.Add(this.chkRentalUseDateFilter);
            this.pnlRentalFilters.Controls.Add(this.txtRentalCustomer);
            this.pnlRentalFilters.Controls.Add(this.lblRentalCustomer);
            this.pnlRentalFilters.Location = new System.Drawing.Point(10, 10);
            this.pnlRentalFilters.Name = "pnlRentalFilters";
            this.pnlRentalFilters.Size = new System.Drawing.Size(936, 96);
            this.pnlRentalFilters.TabIndex = 0;
            // 
            // btnReturnSelected
            // 
            this.btnReturnSelected.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnReturnSelected.FlatAppearance.BorderSize = 0;
            this.btnReturnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnSelected.ForeColor = System.Drawing.Color.White;
            this.btnReturnSelected.Location = new System.Drawing.Point(786, 52);
            this.btnReturnSelected.Name = "btnReturnSelected";
            this.btnReturnSelected.Size = new System.Drawing.Size(134, 30);
            this.btnReturnSelected.TabIndex = 9;
            this.btnReturnSelected.Text = "Return Selected";
            this.btnReturnSelected.UseVisualStyleBackColor = false;
            this.btnReturnSelected.Click += new System.EventHandler(this.btnReturnSelected_Click);
            // 
            // btnRentalClear
            // 
            this.btnRentalClear.BackColor = System.Drawing.Color.White;
            this.btnRentalClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRentalClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRentalClear.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRentalClear.Location = new System.Drawing.Point(682, 52);
            this.btnRentalClear.Name = "btnRentalClear";
            this.btnRentalClear.Size = new System.Drawing.Size(98, 30);
            this.btnRentalClear.TabIndex = 8;
            this.btnRentalClear.Text = "Clear";
            this.btnRentalClear.UseVisualStyleBackColor = false;
            this.btnRentalClear.Click += new System.EventHandler(this.btnRentalClear_Click);
            // 
            // btnRentalApply
            // 
            this.btnRentalApply.BackColor = System.Drawing.Color.White;
            this.btnRentalApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRentalApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRentalApply.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRentalApply.Location = new System.Drawing.Point(578, 52);
            this.btnRentalApply.Name = "btnRentalApply";
            this.btnRentalApply.Size = new System.Drawing.Size(98, 30);
            this.btnRentalApply.TabIndex = 7;
            this.btnRentalApply.Text = "Apply";
            this.btnRentalApply.UseVisualStyleBackColor = false;
            this.btnRentalApply.Click += new System.EventHandler(this.btnRentalApply_Click);
            // 
            // cmbRentalStatus
            // 
            this.cmbRentalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalStatus.FormattingEnabled = true;
            this.cmbRentalStatus.Location = new System.Drawing.Point(410, 56);
            this.cmbRentalStatus.Name = "cmbRentalStatus";
            this.cmbRentalStatus.Size = new System.Drawing.Size(152, 23);
            this.cmbRentalStatus.TabIndex = 6;
            // 
            // lblRentalStatus
            // 
            this.lblRentalStatus.AutoSize = true;
            this.lblRentalStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentalStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRentalStatus.Location = new System.Drawing.Point(410, 34);
            this.lblRentalStatus.Name = "lblRentalStatus";
            this.lblRentalStatus.Size = new System.Drawing.Size(43, 17);
            this.lblRentalStatus.TabIndex = 5;
            this.lblRentalStatus.Text = "Status";
            // 
            // dtpRentalTo
            // 
            this.dtpRentalTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentalTo.Location = new System.Drawing.Point(306, 56);
            this.dtpRentalTo.Name = "dtpRentalTo";
            this.dtpRentalTo.Size = new System.Drawing.Size(94, 23);
            this.dtpRentalTo.TabIndex = 4;
            // 
            // lblRentalTo
            // 
            this.lblRentalTo.AutoSize = true;
            this.lblRentalTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentalTo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRentalTo.Location = new System.Drawing.Point(306, 34);
            this.lblRentalTo.Name = "lblRentalTo";
            this.lblRentalTo.Size = new System.Drawing.Size(22, 17);
            this.lblRentalTo.TabIndex = 3;
            this.lblRentalTo.Text = "To";
            // 
            // dtpRentalFrom
            // 
            this.dtpRentalFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentalFrom.Location = new System.Drawing.Point(206, 56);
            this.dtpRentalFrom.Name = "dtpRentalFrom";
            this.dtpRentalFrom.Size = new System.Drawing.Size(94, 23);
            this.dtpRentalFrom.TabIndex = 2;
            // 
            // lblRentalFrom
            // 
            this.lblRentalFrom.AutoSize = true;
            this.lblRentalFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentalFrom.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRentalFrom.Location = new System.Drawing.Point(206, 34);
            this.lblRentalFrom.Name = "lblRentalFrom";
            this.lblRentalFrom.Size = new System.Drawing.Size(37, 17);
            this.lblRentalFrom.TabIndex = 1;
            this.lblRentalFrom.Text = "From";
            // 
            // chkRentalUseDateFilter
            // 
            this.chkRentalUseDateFilter.AutoSize = true;
            this.chkRentalUseDateFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRentalUseDateFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkRentalUseDateFilter.Location = new System.Drawing.Point(206, 10);
            this.chkRentalUseDateFilter.Name = "chkRentalUseDateFilter";
            this.chkRentalUseDateFilter.Size = new System.Drawing.Size(104, 21);
            this.chkRentalUseDateFilter.TabIndex = 10;
            this.chkRentalUseDateFilter.Text = "Use date filter";
            this.chkRentalUseDateFilter.UseVisualStyleBackColor = true;
            this.chkBookingUseDateFilter.CheckedChanged += new System.EventHandler(this.chkBookingUseDateFilter_CheckedChanged);

            // 
            // txtRentalCustomer
            // 
            this.txtRentalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRentalCustomer.Location = new System.Drawing.Point(18, 56);
            this.txtRentalCustomer.Name = "txtRentalCustomer";
            this.txtRentalCustomer.PlaceholderText = "Customer search...";
            this.txtRentalCustomer.Size = new System.Drawing.Size(178, 25);
            this.txtRentalCustomer.TabIndex = 0;
            this.txtRentalCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRentalCustomer_KeyDown);
            // 
            // lblRentalCustomer
            // 
            this.lblRentalCustomer.AutoSize = true;
            this.lblRentalCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentalCustomer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRentalCustomer.Location = new System.Drawing.Point(18, 34);
            this.lblRentalCustomer.Name = "lblRentalCustomer";
            this.lblRentalCustomer.Size = new System.Drawing.Size(67, 17);
            this.lblRentalCustomer.TabIndex = 11;
            this.lblRentalCustomer.Text = "Customer";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.pnlBookingsGrid);
            this.tabBookings.Controls.Add(this.pnlBookingFilters);
            this.tabBookings.Location = new System.Drawing.Point(4, 24);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(10);
            this.tabBookings.Size = new System.Drawing.Size(956, 528);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // pnlBookingsGrid
            // 
            this.pnlBookingsGrid.BackColor = System.Drawing.Color.White;
            this.pnlBookingsGrid.Controls.Add(this.dgvBookings);
            this.pnlBookingsGrid.Location = new System.Drawing.Point(10, 116);
            this.pnlBookingsGrid.Name = "pnlBookingsGrid";
            this.pnlBookingsGrid.Size = new System.Drawing.Size(936, 402);
            this.pnlBookingsGrid.TabIndex = 1;
            // 
            // dgvBookings
            // 
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(0, 0);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowTemplate.Height = 25;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(936, 402);
            this.dgvBookings.TabIndex = 0;
            // 
            // pnlBookingFilters
            // 
            this.pnlBookingFilters.BackColor = System.Drawing.Color.White;
            this.pnlBookingFilters.Controls.Add(this.btnBookingClear);
            this.pnlBookingFilters.Controls.Add(this.btnBookingApply);
            this.pnlBookingFilters.Controls.Add(this.cmbBookingTable);
            this.pnlBookingFilters.Controls.Add(this.lblBookingTable);
            this.pnlBookingFilters.Controls.Add(this.dtpBookingTo);
            this.pnlBookingFilters.Controls.Add(this.lblBookingTo);
            this.pnlBookingFilters.Controls.Add(this.dtpBookingFrom);
            this.pnlBookingFilters.Controls.Add(this.lblBookingFrom);
            this.pnlBookingFilters.Controls.Add(this.chkBookingUseDateFilter);
            this.pnlBookingFilters.Controls.Add(this.txtBookingCustomer);
            this.pnlBookingFilters.Controls.Add(this.lblBookingCustomer);
            this.pnlBookingFilters.Location = new System.Drawing.Point(10, 10);
            this.pnlBookingFilters.Name = "pnlBookingFilters";
            this.pnlBookingFilters.Size = new System.Drawing.Size(936, 96);
            this.pnlBookingFilters.TabIndex = 0;
            // 
            // btnBookingClear
            // 
            this.btnBookingClear.BackColor = System.Drawing.Color.White;
            this.btnBookingClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBookingClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookingClear.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnBookingClear.Location = new System.Drawing.Point(682, 52);
            this.btnBookingClear.Name = "btnBookingClear";
            this.btnBookingClear.Size = new System.Drawing.Size(98, 30);
            this.btnBookingClear.TabIndex = 7;
            this.btnBookingClear.Text = "Clear";
            this.btnBookingClear.UseVisualStyleBackColor = false;
            this.btnBookingClear.Click += new System.EventHandler(this.btnBookingClear_Click);
            // 
            // btnBookingApply
            // 
            this.btnBookingApply.BackColor = System.Drawing.Color.White;
            this.btnBookingApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBookingApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookingApply.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnBookingApply.Location = new System.Drawing.Point(578, 52);
            this.btnBookingApply.Name = "btnBookingApply";
            this.btnBookingApply.Size = new System.Drawing.Size(98, 30);
            this.btnBookingApply.TabIndex = 6;
            this.btnBookingApply.Text = "Apply";
            this.btnBookingApply.UseVisualStyleBackColor = false;
            this.btnBookingApply.Click += new System.EventHandler(this.btnBookingApply_Click);
            // 
            // cmbBookingTable
            // 
            this.cmbBookingTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingTable.FormattingEnabled = true;
            this.cmbBookingTable.Location = new System.Drawing.Point(410, 56);
            this.cmbBookingTable.Name = "cmbBookingTable";
            this.cmbBookingTable.Size = new System.Drawing.Size(152, 23);
            this.cmbBookingTable.TabIndex = 5;
            // 
            // lblBookingTable
            // 
            this.lblBookingTable.AutoSize = true;
            this.lblBookingTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingTable.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingTable.Location = new System.Drawing.Point(410, 34);
            this.lblBookingTable.Name = "lblBookingTable";
            this.lblBookingTable.Size = new System.Drawing.Size(37, 17);
            this.lblBookingTable.TabIndex = 4;
            this.lblBookingTable.Text = "Table";
            // 
            // dtpBookingTo
            // 
            this.dtpBookingTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingTo.Location = new System.Drawing.Point(306, 56);
            this.dtpBookingTo.Name = "dtpBookingTo";
            this.dtpBookingTo.Size = new System.Drawing.Size(94, 23);
            this.dtpBookingTo.TabIndex = 3;
            // 
            // lblBookingTo
            // 
            this.lblBookingTo.AutoSize = true;
            this.lblBookingTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingTo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingTo.Location = new System.Drawing.Point(306, 34);
            this.lblBookingTo.Name = "lblBookingTo";
            this.lblBookingTo.Size = new System.Drawing.Size(22, 17);
            this.lblBookingTo.TabIndex = 2;
            this.lblBookingTo.Text = "To";
            // 
            // dtpBookingFrom
            // 
            this.dtpBookingFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingFrom.Location = new System.Drawing.Point(206, 56);
            this.dtpBookingFrom.Name = "dtpBookingFrom";
            this.dtpBookingFrom.Size = new System.Drawing.Size(94, 23);
            this.dtpBookingFrom.TabIndex = 1;
            // 
            // lblBookingFrom
            // 
            this.lblBookingFrom.AutoSize = true;
            this.lblBookingFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingFrom.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingFrom.Location = new System.Drawing.Point(206, 34);
            this.lblBookingFrom.Name = "lblBookingFrom";
            this.lblBookingFrom.Size = new System.Drawing.Size(37, 17);
            this.lblBookingFrom.TabIndex = 0;
            this.lblBookingFrom.Text = "From";
            // 
            // chkBookingUseDateFilter
            // 
            this.chkBookingUseDateFilter.AutoSize = true;
            this.chkBookingUseDateFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBookingUseDateFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkBookingUseDateFilter.Location = new System.Drawing.Point(206, 10);
            this.chkBookingUseDateFilter.Name = "chkBookingUseDateFilter";
            this.chkBookingUseDateFilter.Size = new System.Drawing.Size(104, 21);
            this.chkBookingUseDateFilter.TabIndex = 10;
            this.chkBookingUseDateFilter.Text = "Use date filter";
            this.chkBookingUseDateFilter.UseVisualStyleBackColor = true;
            this.chkBookingUseDateFilter.CheckedChanged += new System.EventHandler(this.chkBookingUseDateFilter_CheckedChanged);
            // 
            // txtBookingCustomer
            // 
            this.txtBookingCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookingCustomer.Location = new System.Drawing.Point(18, 56);
            this.txtBookingCustomer.Name = "txtBookingCustomer";
            this.txtBookingCustomer.PlaceholderText = "Customer search...";
            this.txtBookingCustomer.Size = new System.Drawing.Size(178, 25);
            this.txtBookingCustomer.TabIndex = 0;
            this.txtBookingCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookingCustomer_KeyDown);
            // 
            // lblBookingCustomer
            // 
            this.lblBookingCustomer.AutoSize = true;
            this.lblBookingCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingCustomer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingCustomer.Location = new System.Drawing.Point(18, 34);
            this.lblBookingCustomer.Name = "lblBookingCustomer";
            this.lblBookingCustomer.Size = new System.Drawing.Size(67, 17);
            this.lblBookingCustomer.TabIndex = 11;
            this.lblBookingCustomer.Text = "Customer";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabRentals.ResumeLayout(false);
            this.pnlRentalsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.pnlRentalFilters.ResumeLayout(false);
            this.pnlRentalFilters.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.pnlBookingsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.pnlBookingFilters.ResumeLayout(false);
            this.pnlBookingFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}