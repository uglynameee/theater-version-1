namespace Theater.Version1
{
    partial class BasicForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.NumericUpDown durationBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label status;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.heading = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.durationBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.grid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // heading
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.heading.Location = new System.Drawing.Point(24, 18);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(137, 32);
            this.heading.Text = "Спектакли";
            // field labels
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(27, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(117, 15);
            this.titleLabel.Text = "Название спектакля";
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(340, 70);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 15);
            this.dateLabel.Text = "Дата и время";
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(590, 70);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(153, 15);
            this.durationLabel.Text = "Продолжительность (мин.)";
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(805, 70);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 15);
            this.priceLabel.Text = "Цена билета";
            // fields
            this.titleBox.Location = new System.Drawing.Point(27, 91);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(292, 23);
            this.dateBox.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox.Location = new System.Drawing.Point(340, 91);
            this.dateBox.Name = "dateBox";
            this.dateBox.ShowUpDown = true;
            this.dateBox.Size = new System.Drawing.Size(230, 23);
            this.durationBox.Location = new System.Drawing.Point(590, 91);
            this.durationBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.durationBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(190, 23);
            this.durationBox.Value = new decimal(new int[] { 90, 0, 0, 0 });
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.priceBox.Location = new System.Drawing.Point(805, 91);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(150, 23);
            this.priceBox.ThousandsSeparator = true;
            // grid
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(27, 135);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(928, 390);
            this.grid.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            // buttons
            this.addButton.Location = new System.Drawing.Point(27, 544);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddClicked);
            this.saveButton.Location = new System.Drawing.Point(151, 544);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 34);
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveClicked);
            this.clearButton.Location = new System.Drawing.Point(275, 544);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 34);
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClicked);
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(410, 553);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.status);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "BasicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Театр | Версия 1";
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
