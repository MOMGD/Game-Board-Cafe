namespace BoardGameCafeApp.Forms
{
    partial class AddEditGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;

        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;

        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.NumericUpDown nudTotalCopies;

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPricePerHour;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.nudTotalCopies = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPricePerHour = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.nudPricePerHour);
            this.pnlCard.Controls.Add(this.lblPrice);
            this.pnlCard.Controls.Add(this.nudTotalCopies);
            this.pnlCard.Controls.Add(this.lblCopies);
            this.pnlCard.Controls.Add(this.txtGenre);
            this.pnlCard.Controls.Add(this.lblGenre);
            this.pnlCard.Controls.Add(this.txtTitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblHeader);
            this.pnlCard.Location = new System.Drawing.Point(18, 18);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(564, 414);
            this.pnlCard.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblHeader.Location = new System.Drawing.Point(22, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(103, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add Game";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(313, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Enter the game details then click Save to confirm";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTitle.Location = new System.Drawing.Point(24, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(24, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "e.g. Catan";
            this.txtTitle.Size = new System.Drawing.Size(516, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblGenre.Location = new System.Drawing.Point(24, 152);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(43, 17);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenre.Location = new System.Drawing.Point(24, 172);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PlaceholderText = "e.g. Strategy";
            this.txtGenre.Size = new System.Drawing.Size(516, 25);
            this.txtGenre.TabIndex = 1;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCopies.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCopies.Location = new System.Drawing.Point(24, 214);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(73, 17);
            this.lblCopies.TabIndex = 6;
            this.lblCopies.Text = "Total Copies";
            // 
            // nudTotalCopies
            // 
            this.nudTotalCopies.Location = new System.Drawing.Point(24, 234);
            this.nudTotalCopies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalCopies.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotalCopies.Name = "nudTotalCopies";
            this.nudTotalCopies.Size = new System.Drawing.Size(250, 23);
            this.nudTotalCopies.TabIndex = 2;
            this.nudTotalCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPrice.Location = new System.Drawing.Point(290, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price/Hour";
            // 
            // nudPricePerHour
            // 
            this.nudPricePerHour.DecimalPlaces = 2;
            this.nudPricePerHour.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536}); // 0.5
            this.nudPricePerHour.Location = new System.Drawing.Point(290, 234);
            this.nudPricePerHour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPricePerHour.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPricePerHour.Name = "nudPricePerHour";
            this.nudPricePerHour.Size = new System.Drawing.Size(250, 23);
            this.nudPricePerHour.TabIndex = 3;
            this.nudPricePerHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(302, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditGameForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Game";
            this.Load += new System.EventHandler(this.AddEditGameForm_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}