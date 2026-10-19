using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Theater.Common;

namespace Theater.Version1
{
    public partial class BasicForm : Form
    {
        private int? selectedId;
        private readonly AuthUser user;
        private readonly TableDefinition plays = FindTable("Спектакли");

        public BasicForm() : this(null) { }

        public BasicForm(AuthUser user)
        {
            this.user = user;
            InitializeComponent();
            Load += BasicForm_Load;
        }

        private void BasicForm_Load(object sender, EventArgs e)
        {
            if (!IsInDesignMode())
            {
                UiStyle.PrepareGrid(grid);
                if (user != null && !user.IsEmployee)
                {
                    addButton.Visible = false;
                    saveButton.Visible = false;
                    clearButton.Visible = false;
                    titleBox.ReadOnly = true;
                    dateBox.Enabled = false;
                    durationBox.Enabled = false;
                    priceBox.Enabled = false;
                    status.Text = "Режим зрителя";
                }
                LoadPlays();
            }
        }

        private static bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private static TableDefinition FindTable(string name)
        {
            foreach (TableDefinition table in Db.Tables) if (table.Name == name) return table;
            return null;
        }

        private void LoadPlays()
        {
            DataTable data = Db.Read("SELECT [Код], [Название], [ДатаВремя], [ПродолжительностьМинут], [ЦенаБилета] FROM [Спектакли] ORDER BY [Код] DESC");
            grid.DataSource = data;
            grid.Columns["Код"].Visible = false;
            grid.Columns["Название"].HeaderText = "Название";
            grid.Columns["ДатаВремя"].HeaderText = "Дата и время";
            grid.Columns["ПродолжительностьМинут"].HeaderText = "Минут";
            grid.Columns["ЦенаБилета"].HeaderText = "Цена";
            status.Text = data.Rows.Count + " записей";
        }

        private Dictionary<string, object> ReadValues()
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text)) throw new InvalidOperationException("Введите название спектакля.");
            return new Dictionary<string, object>
            {
                { "Название", titleBox.Text.Trim() }, { "ДатаВремя", dateBox.Value },
                { "ПродолжительностьМинут", Decimal.ToInt32(durationBox.Value) }, { "ЦенаБилета", priceBox.Value }
            };
        }

        private void AddClicked(object sender, EventArgs e)
        {
            try { Db.Add(plays, ReadValues()); LoadPlays(); ClearFields(); status.Text = "Спектакль добавлен в базу данных"; }
            catch (Exception ex) { ShowError(ex); }
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            if (!selectedId.HasValue) { MessageBox.Show("Выберите спектакль в таблице.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            try
            {
                Dictionary<string, object> values = ReadValues();
                Db.UpdateBasicPlay(selectedId.Value, Convert.ToString(values["Название"]), (DateTime)values["ДатаВремя"], Convert.ToInt32(values["ПродолжительностьМинут"]), Convert.ToDecimal(values["ЦенаБилета"]));
                LoadPlays(); ClearFields(); status.Text = "Изменения сохранены";
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null) return;
            object id = grid.CurrentRow.Cells["Код"].Value;
            if (id == null || id == DBNull.Value) return;
            selectedId = Convert.ToInt32(id);
            titleBox.Text = Convert.ToString(grid.CurrentRow.Cells["Название"].Value);
            if (grid.CurrentRow.Cells["ДатаВремя"].Value != DBNull.Value) dateBox.Value = Convert.ToDateTime(grid.CurrentRow.Cells["ДатаВремя"].Value);
            if (grid.CurrentRow.Cells["ПродолжительностьМинут"].Value != DBNull.Value) durationBox.Value = Math.Min(durationBox.Maximum, Math.Max(durationBox.Minimum, Convert.ToDecimal(grid.CurrentRow.Cells["ПродолжительностьМинут"].Value)));
            if (grid.CurrentRow.Cells["ЦенаБилета"].Value != DBNull.Value) priceBox.Value = Math.Min(priceBox.Maximum, Math.Max(priceBox.Minimum, Convert.ToDecimal(grid.CurrentRow.Cells["ЦенаБилета"].Value)));
        }

        private void ClearClicked(object sender, EventArgs e) { ClearFields(); }
        private void ClearFields() { selectedId = null; titleBox.Clear(); dateBox.Value = DateTime.Now; durationBox.Value = 90; priceBox.Value = 0; grid.ClearSelection(); titleBox.Focus(); }
        private void ShowError(Exception ex) { MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
}
