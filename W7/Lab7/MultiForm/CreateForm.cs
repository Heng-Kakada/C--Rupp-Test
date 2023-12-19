using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            cboGender.DataSource = new string[] { "Male", "Female" };
            btnCreate.Click += DoCreatePerson;    
        }

        private void DoCreatePerson(object? sender, EventArgs e)
        {
            if (txtName.Text == null) return;
            if (txtAge.Text == null) return;
            byte.TryParse(txtAge.Text, out byte age);
            string? g = cboGender.SelectedItem.ToString();
            Person p = new Person(txtName.Text,g!,age);
            Program._people.Add(p);
        }




    }
}
