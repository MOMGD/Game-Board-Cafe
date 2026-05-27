namespace BoardGameCafeApp.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnRentGame;
        private System.Windows.Forms.Button btnBookTable;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLogout;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnRentGame = new System.Windows.Forms.Button();
            this.btnBookTable = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Main Menu";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(310, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Choose an action to manage games and bookings";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.Controls.Add(this.btnLogout);
            this.pnlGrid.Controls.Add(this.btnHistory);
            this.pnlGrid.Controls.Add(this.btnBookTable);
            this.pnlGrid.Controls.Add(this.btnRentGame);
            this.pnlGrid.Controls.Add(this.btnAddGame);
            this.pnlGrid.Controls.Add(this.btnGames);
            this.pnlGrid.Location = new System.Drawing.Point(20, 125);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(760, 305);
            this.pnlGrid.TabIndex = 1;
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.White;
            this.btnGames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGames.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnGames.Location = new System.Drawing.Point(0, 0);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(246, 90);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Game Catalog";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.White;
            this.btnAddGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGame.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGame.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAddGame.Location = new System.Drawing.Point(257, 0);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(246, 90);
            this.btnAddGame.TabIndex = 1;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnRentGame
            // 
            this.btnRentGame.BackColor = System.Drawing.Color.White;
            this.btnRentGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRentGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentGame.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRentGame.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRentGame.Location = new System.Drawing.Point(514, 0);
            this.btnRentGame.Name = "btnRentGame";
            this.btnRentGame.Size = new System.Drawing.Size(246, 90);
            this.btnRentGame.TabIndex = 2;
            this.btnRentGame.Text = "Rent Game";
            this.btnRentGame.UseVisualStyleBackColor = false;
            this.btnRentGame.Click += new System.EventHandler(this.btnRentGame_Click);
            // 
            // btnBookTable
            // 
            this.btnBookTable.BackColor = System.Drawing.Color.White;
            this.btnBookTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBookTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTable.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBookTable.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnBookTable.Location = new System.Drawing.Point(0, 110);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(246, 90);
            this.btnBookTable.TabIndex = 3;
            this.btnBookTable.Text = "Book Table";
            this.btnBookTable.UseVisualStyleBackColor = false;
            this.btnBookTable.Click += new System.EventHandler(this.btnBookTable_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.White;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnHistory.Location = new System.Drawing.Point(257, 110);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(246, 90);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(514, 110);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(246, 90);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}