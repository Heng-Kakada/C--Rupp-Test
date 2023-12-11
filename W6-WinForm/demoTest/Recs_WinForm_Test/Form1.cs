using Rectangle = Recs_WinForm_Test.models.Rectangle;

namespace Recs_WinForm_Test
{
    public partial class Form1 : Form
    {

        private DataGridViewRow? curRow = null;

        public Form1()
        {
            InitializeComponent();
            ConfigGridView();

            btnRefresh.Click += (object? sender, EventArgs e) =>
            {
                dgvRecs.Rows.Clear();
                curRow = null;
                Program.Recs.ForEach(r =>
                {
                    dgvRecs.Rows.Add(r.No, r.Width, r.Length, r.Area);
                });
            };

            btnAdd.Click += AddNewRectangle;

            btnUpdate.Click += UpdateRectangle;

            btnClearData.Click += ClearDataFromTextBox;

            dgvRecs.SelectionChanged += (object? sender, EventArgs e) =>
            {
                if (dgvRecs.CurrentRow != curRow) ViewCurrentRectangle();
            };
        }

        private void UpdateRectangle(object? sender, EventArgs e)
        {
            if (dgvRecs.CurrentRow == null) return;

            int.TryParse(txtNo.Text, out int no);

            double.TryParse(txtWidth.Text, out double width);

            if (width == 0){
                Task.Run(() => MessageBox.Show($"Width must not be null or 0"));
                return;
            }
            double.TryParse(txtLength.Text, out double length);

            if (length == 0)
            {
                Task.Run(() => MessageBox.Show($"Length must not be null or 0"));
                return;
            }

            bool statusUpdate = true;
            Program.Recs.ForEach((r) =>
            {
                if(r.No == no)
                {
                    r.Width = width;
                    r.Length = length;
                    MessageBox.Show($"update No = {no}");
                    statusUpdate = false;
                }
            });
            if (statusUpdate) {
                MessageBox.Show($"cannot update");
            }
        }

        private void AddNewRectangle(object? sender, EventArgs e)
        {
            double width, length;
            double.TryParse(txtWidth.Text, out width);
            if (width == 0)
            {
                Task.Run(() => MessageBox.Show($"Width must not be null or 0"));
                return;
            }
            double.TryParse(txtLength.Text, out length);
            if (length == 0)
            {
                Task.Run(() => MessageBox.Show($"Length must not be null or 0"));
                return;
            }
            Rectangle r = Rectangle.CreateInstance(width, length);
            Program.Recs.Add(r);
            Task.Run(() => MessageBox.Show($"A rectangle no, {r.No}, was successfully added"));
            txtLength.Clear();
            txtWidth.Clear();
        }

        private void ClearDataFromTextBox(object? sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtNo.Clear();
            txtWidth.Clear();
            txtLength.Clear();
            txtArea.Clear();
        }

        private void ViewCurrentRectangle()
        {
            curRow = dgvRecs.CurrentRow;
            int? no = (int?)curRow?.Cells["colNo"].Value;
            Rectangle? curRec = Program.Recs.FirstOrDefault(rect => rect.No == no);
            txtNo.Text = curRec?.No.ToString();
            txtWidth.Text = curRec?.Width.ToString();
            txtLength.Text = curRec?.Length.ToString();
            txtArea.Text = curRec?.Area.ToString();
        }

        void ConfigGridView()
        {
            dgvRecs.Columns.Clear();
            dgvRecs.Columns.Add("colNo", "No");
            dgvRecs.Columns.Add("colWidth", "Width");
            dgvRecs.Columns.Add("colLength", "Length");
            dgvRecs.Columns.Add("colArea", "Area");

            foreach (DataGridViewColumn col in dgvRecs.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (col.Name == "colNo") continue;
                col.DefaultCellStyle.Format = "N2";
            }

            dgvRecs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}