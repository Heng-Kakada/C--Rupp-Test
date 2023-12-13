using System;
using W6_Practice_WinForm_CRUD.Model;
namespace W6_Practice_WinForm_CRUD;

public partial class Form1 : Form
{
    List<Person> _people = new();
    public Form1()
    {
        InitializeComponent();
        genderCCB.SelectedIndex = 0;
        LoadPeople("Data/people.txt");
        ConfigView();
        

        dgvPeople.SelectionChanged += DoPersonSelect;
        btnRefresh.Click += DoClickReload;
        btnAdd.Click += DoAddPerson;
        btnUpdate.Click += DoUpdatePerson;
        btnDelete.Click += DoDeletePerson;
    }
    private void ReloadTotalPeople()
    {
        totalPeople.Text = _people.Count.ToString();
    }
    private void DoDeletePerson(object? sender, EventArgs e)
    {
        if (dgvPeople.CurrentRow == null) return;

        int no = (int)dgvPeople.CurrentRow.Cells[0].Value;
        Person? found = FindPersonByNo(no);
        if (found == null) return;

        DialogResult result = MessageBox.Show($"Are You sure to delete a person no, {no}?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No) return;
        if (_people.Remove(found) == true)
        {
            dgvPeople.Rows.Remove(dgvPeople.CurrentRow);
        }
        ReloadTotalPeople();
    }
    private void DoPersonSelect(object? sender, EventArgs e)
    {
        if (dgvPeople.CurrentRow == null) return;
        int no = (int)dgvPeople.CurrentRow.Cells[0].Value;
        Person? found = FindPersonByNo(no);
        if (found == null) return;
        txtUNo.Text = found.No.ToString();
        txtUName.Text = found.Name.ToString();
        genderUCB.Text = found.Gender.ToString();
        txtUAge.Text = found.Age.ToString();
    }
    private void DoUpdatePerson(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUName.Text))
        {
            MessageBox.Show("Name must has atleast 1 character", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (byte.TryParse(txtUAge.Text, out byte age) == false)
        {
            MessageBox.Show("Invalid Age", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        int.TryParse(txtUNo.Text, out int no);
        Person? found = FindPersonByNo(no);
        if (found == null) return;

        found.Name = Utils.CapitalizeName(txtUName.Text);
        found.Gender = genderUCB.Text;
        found.Age = age;

        foreach (DataGridViewRow row in dgvPeople.Rows)
        {
            if (no == (int)row.Cells[0].Value)
            {
                row.SetValues(found.No, found.Name, found.Gender, found.Age);
                break;
            }
        }
        MessageBox.Show($"A Person no, {found.No}, was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ReloadTotalPeople();
    }
    private void DoAddPerson(object? sender, EventArgs e)
    {
        if (int.TryParse(txtCNo.Text, out int no) == false)
        {
            MessageBox.Show("Invalid No", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (FindPersonByNo(no) != null)
        {
            MessageBox.Show($"Person id {no} already added", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(txtCName.Text))
        {
            MessageBox.Show("Name must has atleast 1 character", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (byte.TryParse(txtCAge.Text, out byte age) == false)
        {
            MessageBox.Show("Invalid Age", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Person p = new Person()
        {
            No = no,
            Name = Utils.CapitalizeName(txtCName.Text),
            Gender = genderCCB.Text,
            Age = age
        };
        _people.Add(p);
        MessageBox.Show($"A Person no, {p.No}, was successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        dgvPeople.Rows.Add(p.No, p.Name, p.Gender, p.Age);
        DoClearTextBox();
        ReloadTotalPeople();
    }
    private void DoClearTextBox()
    {
        txtCNo.Clear();
        txtCName.Clear();
        txtCAge.Clear();
    }
    private Person? FindPersonByNo(int no)
    {
        return _people.FirstOrDefault(p => p.No == no);
    }
    private void DoClickReload(object? sender, EventArgs e)
    {
        dgvPeople.Rows.Clear();
        _people.ForEach((p) =>
        {
            dgvPeople.Rows.Add(p.No, p.Name, p.Gender, p.Age);
        });
        ReloadTotalPeople();
    }
    private void LoadPeople(String fileName)
    {
        _people.Clear();
        string[] allLines = File.ReadAllLines(fileName);
        if (allLines.Length <= 0) return;
        foreach (string line in allLines)
        {
            Person? p = Person.CreateInstance(line);
            if (p == null) continue;
            _people.Add(p);
        }
    }
    private void ConfigView()
    {
        foreach (DataGridViewColumn column in dgvPeople.Columns)
        {
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (column.Index == 0) continue;
        }
    }
}