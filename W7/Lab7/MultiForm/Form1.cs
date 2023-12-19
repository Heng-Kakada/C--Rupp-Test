namespace MultiForm;


public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        btnRefresh.Click += DoRefresh;
        btnNew.Click += (sender, e) => new CreateForm().Show();
    }

    private void DoRefresh(object? sender, EventArgs e)
    {
        dgvPers.Rows.Clear();
        Program._people.ForEach(
            (p) => dgvPers.Rows.Add(p.No, p.Name, p.Gender, p.Age)
        );
    }
}