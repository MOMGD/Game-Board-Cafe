namespace BoardGameCafeApp.Forms
{
    partial class RentGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cmbGames;

        private System.Windows.Forms.Label lblAvailableCopies;

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;

        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.DateTimePicker dtpRentDate;

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            this.components = new System.ComponentModel.Container();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.cmbGames = new System.Windows.Forms.ComboBox();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.Controls.Add(this.btnRent);
            this.pnlCard.Controls.Add(this.dtpRentDate);
            this.pnlCard.Controls.Add(this.lblRentDate);
            this.pnlCard.Controls.Add(this.txtCustomerName);
            this.pnlCard.Controls.Add(this.lblCustomer);
            this.pnlCard.Controls.Add(this.lblAvailableCopies);
            this.pnlCard.Controls.Add(this.cmbGames);
            this.pnlCard.Controls.Add(this.lblGame);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Location = new System.Drawing.Point(18, 18);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(564, 414);
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rent a Game";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(354, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select a game, enter customer name, then click Rent";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGame.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblGame.Location = new System.Drawing.Point(24, 92);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(41, 17);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "Game";
            // 
            // cmbGames
            // 
            this.cmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGames.FormattingEnabled = true;
            this.cmbGames.Location = new System.Drawing.Point(24, 112);
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(516, 23);
            this.cmbGames.TabIndex = 0;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.AutoSize = true;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableCopies.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblAvailableCopies.Location = new System.Drawing.Point(24, 142);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(92, 19);
            this.lblAvailableCopies.TabIndex = 4;
            this.lblAvailableCopies.Text = "Available: -";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCustomer.Location = new System.Drawing.Point(24, 182);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(102, 17);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.Location = new System.Drawing.Point(24, 202);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PlaceholderText = "Enter customer name";
            this.txtCustomerName.Size = new System.Drawing.Size(516, 25);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRentDate.Location = new System.Drawing.Point(24, 244);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(62, 17);
            this.lblRentDate.TabIndex = 7;
            this.lblRentDate.Text = "Rent Date";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentDate.Location = new System.Drawing.Point(24, 264);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(250, 23);
            this.dtpRentDate.TabIndex = 2;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(302, 370);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(118, 30);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnCancel.Location = new System.Drawing.Point(422, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // RentGameForm
            // 
            this.AcceptButton = this.btnRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}