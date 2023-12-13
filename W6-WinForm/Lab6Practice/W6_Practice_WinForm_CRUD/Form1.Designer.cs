namespace W6_Practice_WinForm_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            dgvPeople = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            creatingGroupBox = new GroupBox();
            genderCCB = new ComboBox();
            btnAdd = new Button();
            txtCAge = new TextBox();
            ageCLabel = new Label();
            genderCLable = new Label();
            txtCName = new TextBox();
            nameCLabel = new Label();
            txtCNo = new TextBox();
            noCLable = new Label();
            editingGroupBox = new GroupBox();
            genderUCB = new ComboBox();
            btnUpdate = new Button();
            txtUAge = new TextBox();
            ageULabel = new Label();
            genderULabel = new Label();
            txtUName = new TextBox();
            nameULabel = new Label();
            txtUNo = new TextBox();
            noULabel = new Label();
            btnDelete = new Button();
            totalLabel = new Label();
            totalPeople = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            creatingGroupBox.SuspendLayout();
            editingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.CornflowerBlue;
            label1.CausesValidation = false;
            label1.Font = new Font("Cascadia Mono", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1180, 50);
            label1.TabIndex = 0;
            label1.Text = "PEOPLE RECORD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeColumns = false;
            dgvPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.BackgroundColor = Color.CornflowerBlue;
            dgvPeople.BorderStyle = BorderStyle.None;
            dgvPeople.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPeople.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Orange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = Color.Orange;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPeople.GridColor = Color.White;
            dgvPeople.Location = new Point(25, 125);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersWidth = 40;
            dgvPeople.RowTemplate.Height = 25;
            dgvPeople.Size = new Size(600, 450);
            dgvPeople.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 5F;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 50;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 119;
            // 
            // Column4
            // 
            Column4.HeaderText = "Age";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Green;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.White;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(25, 75);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Reload";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // creatingGroupBox
            // 
            creatingGroupBox.Controls.Add(genderCCB);
            creatingGroupBox.Controls.Add(btnAdd);
            creatingGroupBox.Controls.Add(txtCAge);
            creatingGroupBox.Controls.Add(ageCLabel);
            creatingGroupBox.Controls.Add(genderCLable);
            creatingGroupBox.Controls.Add(txtCName);
            creatingGroupBox.Controls.Add(nameCLabel);
            creatingGroupBox.Controls.Add(txtCNo);
            creatingGroupBox.Controls.Add(noCLable);
            creatingGroupBox.Location = new Point(686, 125);
            creatingGroupBox.Name = "creatingGroupBox";
            creatingGroupBox.Size = new Size(250, 225);
            creatingGroupBox.TabIndex = 3;
            creatingGroupBox.TabStop = false;
            creatingGroupBox.Text = "Creating";
            // 
            // genderCCB
            // 
            genderCCB.DisplayMember = "Male";
            genderCCB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCCB.FormattingEnabled = true;
            genderCCB.Items.AddRange(new object[] { "Male", "Female" });
            genderCCB.Location = new Point(65, 111);
            genderCCB.Name = "genderCCB";
            genderCCB.Size = new Size(121, 23);
            genderCCB.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(141, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtCAge
            // 
            txtCAge.Location = new Point(65, 151);
            txtCAge.Name = "txtCAge";
            txtCAge.PlaceholderText = "18";
            txtCAge.Size = new Size(78, 23);
            txtCAge.TabIndex = 7;
            // 
            // ageCLabel
            // 
            ageCLabel.AutoSize = true;
            ageCLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ageCLabel.Location = new Point(10, 152);
            ageCLabel.Name = "ageCLabel";
            ageCLabel.Size = new Size(33, 19);
            ageCLabel.TabIndex = 6;
            ageCLabel.Text = "Age";
            // 
            // genderCLable
            // 
            genderCLable.AutoSize = true;
            genderCLable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genderCLable.Location = new Point(10, 112);
            genderCLable.Name = "genderCLable";
            genderCLable.Size = new Size(54, 19);
            genderCLable.TabIndex = 4;
            genderCLable.Text = "Gender";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(65, 67);
            txtCName.Name = "txtCName";
            txtCName.PlaceholderText = "Eg: Heng Kakada";
            txtCName.Size = new Size(176, 23);
            txtCName.TabIndex = 3;
            // 
            // nameCLabel
            // 
            nameCLabel.AutoSize = true;
            nameCLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameCLabel.Location = new Point(10, 68);
            nameCLabel.Name = "nameCLabel";
            nameCLabel.Size = new Size(45, 19);
            nameCLabel.TabIndex = 2;
            nameCLabel.Text = "Name";
            // 
            // txtCNo
            // 
            txtCNo.Location = new Point(65, 29);
            txtCNo.Name = "txtCNo";
            txtCNo.PlaceholderText = "Eg: 1";
            txtCNo.Size = new Size(78, 23);
            txtCNo.TabIndex = 1;
            // 
            // noCLable
            // 
            noCLable.AutoSize = true;
            noCLable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            noCLable.Location = new Point(10, 30);
            noCLable.Name = "noCLable";
            noCLable.Size = new Size(27, 19);
            noCLable.TabIndex = 0;
            noCLable.Text = "No";
            // 
            // editingGroupBox
            // 
            editingGroupBox.Controls.Add(genderUCB);
            editingGroupBox.Controls.Add(btnUpdate);
            editingGroupBox.Controls.Add(txtUAge);
            editingGroupBox.Controls.Add(ageULabel);
            editingGroupBox.Controls.Add(genderULabel);
            editingGroupBox.Controls.Add(txtUName);
            editingGroupBox.Controls.Add(nameULabel);
            editingGroupBox.Controls.Add(txtUNo);
            editingGroupBox.Controls.Add(noULabel);
            editingGroupBox.Location = new Point(686, 395);
            editingGroupBox.Name = "editingGroupBox";
            editingGroupBox.Size = new Size(250, 225);
            editingGroupBox.TabIndex = 9;
            editingGroupBox.TabStop = false;
            editingGroupBox.Text = "Editing";
            // 
            // genderUCB
            // 
            genderUCB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderUCB.FormattingEnabled = true;
            genderUCB.Items.AddRange(new object[] { "Male", "Female" });
            genderUCB.Location = new Point(65, 111);
            genderUCB.Name = "genderUCB";
            genderUCB.Size = new Size(121, 23);
            genderUCB.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PaleVioletRed;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(141, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtUAge
            // 
            txtUAge.Location = new Point(65, 151);
            txtUAge.Name = "txtUAge";
            txtUAge.PlaceholderText = "18";
            txtUAge.Size = new Size(78, 23);
            txtUAge.TabIndex = 7;
            // 
            // ageULabel
            // 
            ageULabel.AutoSize = true;
            ageULabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ageULabel.Location = new Point(10, 152);
            ageULabel.Name = "ageULabel";
            ageULabel.Size = new Size(33, 19);
            ageULabel.TabIndex = 6;
            ageULabel.Text = "Age";
            // 
            // genderULabel
            // 
            genderULabel.AutoSize = true;
            genderULabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genderULabel.Location = new Point(10, 112);
            genderULabel.Name = "genderULabel";
            genderULabel.Size = new Size(54, 19);
            genderULabel.TabIndex = 4;
            genderULabel.Text = "Gender";
            // 
            // txtUName
            // 
            txtUName.Location = new Point(65, 67);
            txtUName.Name = "txtUName";
            txtUName.PlaceholderText = "Eg: Heng Kakada";
            txtUName.Size = new Size(176, 23);
            txtUName.TabIndex = 3;
            // 
            // nameULabel
            // 
            nameULabel.AutoSize = true;
            nameULabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameULabel.Location = new Point(10, 68);
            nameULabel.Name = "nameULabel";
            nameULabel.Size = new Size(45, 19);
            nameULabel.TabIndex = 2;
            nameULabel.Text = "Name";
            // 
            // txtUNo
            // 
            txtUNo.Location = new Point(65, 29);
            txtUNo.Name = "txtUNo";
            txtUNo.PlaceholderText = "Eg: 1";
            txtUNo.ReadOnly = true;
            txtUNo.Size = new Size(78, 23);
            txtUNo.TabIndex = 1;
            // 
            // noULabel
            // 
            noULabel.AutoSize = true;
            noULabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            noULabel.Location = new Point(10, 30);
            noULabel.Name = "noULabel";
            noULabel.Size = new Size(27, 19);
            noULabel.TabIndex = 0;
            noULabel.Text = "No";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(525, 603);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.Location = new Point(25, 608);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(128, 25);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "Total People : ";
            // 
            // totalPeople
            // 
            totalPeople.AutoSize = true;
            totalPeople.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            totalPeople.Location = new Point(159, 608);
            totalPeople.Name = "totalPeople";
            totalPeople.Size = new Size(0, 25);
            totalPeople.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 657);
            Controls.Add(totalPeople);
            Controls.Add(totalLabel);
            Controls.Add(btnDelete);
            Controls.Add(editingGroupBox);
            Controls.Add(creatingGroupBox);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPeople);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CRUD PEOPLE";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            creatingGroupBox.ResumeLayout(false);
            creatingGroupBox.PerformLayout();
            editingGroupBox.ResumeLayout(false);
            editingGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPeople;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox creatingGroupBox;
        private Label noCLable;
        private TextBox txtCNo;
        private TextBox txtCName;
        private Label nameCLabel;
        private TextBox txtCAge;
        private Label ageCLabel;
        private Label genderCLable;
        private Button btnAdd;
        private ComboBox genderCCB;
        private GroupBox editingGroupBox;
        private ComboBox genderUCB;
        private Button btnUpdate;
        private TextBox txtUAge;
        private Label ageULabel;
        private Label genderULabel;
        private TextBox txtUName;
        private Label nameULabel;
        private TextBox txtUNo;
        private Label noULabel;
        private Button btnDelete;
        private Label totalLabel;
        private Label totalPeople;
    }
}