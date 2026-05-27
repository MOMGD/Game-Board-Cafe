namespace BoardGameCafeApp.Forms
{
    partial class GameCatalogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvGames;

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlFilters = new Panel();
            btnRefresh = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            txtSearchTitle = new TextBox();
            lblSearchTitle = new Label();
            pnlGrid = new Panel();
            dgvGames = new DataGridView();
            pnlActions = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(18, 18);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(964, 86);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(20, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(315, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Search, filter by genre, and manage your game list";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Game Catalog";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Controls.Add(btnClear);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Controls.Add(cmbGenre);
            pnlFilters.Controls.Add(lblGenre);
            pnlFilters.Controls.Add(txtSearchTitle);
            pnlFilters.Controls.Add(lblSearchTitle);
            pnlFilters.Location = new Point(18, 116);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(964, 86);
            pnlFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.FromArgb(30, 41, 59);
            btnRefresh.Location = new Point(846, 39);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 30);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.FromArgb(30, 41, 59);
            btnClear.Location = new Point(742, 39);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(638, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(406, 43);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(210, 23);
            cmbGenre.TabIndex = 3;
            cmbGenre.SelectedIndexChanged += cmbGenre_SelectedIndexChanged;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 9.75F);
            lblGenre.ForeColor = Color.FromArgb(51, 65, 85);
            lblGenre.Location = new Point(406, 20);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(43, 17);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTitle.Font = new Font("Segoe UI", 10F);
            txtSearchTitle.Location = new Point(18, 41);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.PlaceholderText = "Search by title...";
            txtSearchTitle.Size = new Size(372, 25);
            txtSearchTitle.TabIndex = 1;
            txtSearchTitle.KeyDown += txtSearchTitle_KeyDown;
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Font = new Font("Segoe UI", 9.75F);
            lblSearchTitle.ForeColor = Color.FromArgb(51, 65, 85);
            lblSearchTitle.Location = new Point(18, 20);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(32, 17);
            lblSearchTitle.TabIndex = 0;
            lblSearchTitle.Text = "Title";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvGames);
            pnlGrid.Location = new Point(18, 214);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(964, 390);
            pnlGrid.TabIndex = 2;
            // 
            // dgvGames
            // 
            dgvGames.BackgroundColor = Color.White;
            dgvGames.BorderStyle = BorderStyle.None;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(964, 390);
            dgvGames.TabIndex = 0;
            dgvGames.CellContentClick += dgvGames_CellContentClick;
            dgvGames.CellDoubleClick += dgvGames_CellDoubleClick;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.Transparent;
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Location = new Point(18, 616);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(964, 56);
            pnlActions.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.FromArgb(220, 38, 38);
            btnDelete.Location = new Point(254, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.ForeColor = Color.FromArgb(30, 41, 59);
            btnEdit.Location = new Point(136, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(37, 99, 235);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(18, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Game";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // GameCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1000, 690);
            Controls.Add(pnlActions);
            Controls.Add(pnlGrid);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameCatalogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game Catalog";
            Load += GameCatalogForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
    }
}