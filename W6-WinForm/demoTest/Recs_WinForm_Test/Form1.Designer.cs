namespace Recs_WinForm_Test
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
            btnRefresh = new Button();
            dgvRecs = new DataGridView();
            groupBox1 = new GroupBox();
            txtArea = new TextBox();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtNo = new TextBox();
            labelArea = new Label();
            labelLength = new Label();
            labelWidth = new Label();
            labelNo = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnGridRemove = new Button();
            btnDataRemove = new Button();
            btnClearData = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Pink;
            btnRefresh.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(9, 9);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 50);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvRecs
            // 
            dgvRecs.AllowUserToAddRows = false;
            dgvRecs.AllowUserToDeleteRows = false;
            dgvRecs.BackgroundColor = Color.Pink;
            dgvRecs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecs.Location = new Point(9, 74);
            dgvRecs.Name = "dgvRecs";
            dgvRecs.ReadOnly = true;
            dgvRecs.RowHeadersWidth = 50;
            dgvRecs.RowTemplate.Height = 25;
            dgvRecs.Size = new Size(525, 244);
            dgvRecs.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(txtLength);
            groupBox1.Controls.Add(txtWidth);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(labelArea);
            groupBox1.Controls.Add(labelLength);
            groupBox1.Controls.Add(labelWidth);
            groupBox1.Controls.Add(labelNo);
            groupBox1.Location = new Point(9, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Rectangle";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(402, 59);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 7;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(270, 59);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 5;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(144, 59);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 3;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(19, 59);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 1;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(402, 31);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(31, 15);
            labelArea.TabIndex = 6;
            labelArea.Text = "Area";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(270, 31);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(44, 15);
            labelLength.TabIndex = 4;
            labelLength.Text = "Length";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(144, 31);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(39, 15);
            labelWidth.TabIndex = 2;
            labelWidth.Text = "Width";
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Location = new Point(19, 31);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(23, 15);
            labelNo.TabIndex = 0;
            labelNo.Text = "No";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Pink;
            btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(637, 35);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Pink;
            btnUpdate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(637, 110);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 50);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnGridRemove
            // 
            btnGridRemove.BackColor = Color.Pink;
            btnGridRemove.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGridRemove.ForeColor = Color.Black;
            btnGridRemove.Location = new Point(637, 187);
            btnGridRemove.Margin = new Padding(0);
            btnGridRemove.Name = "btnGridRemove";
            btnGridRemove.Size = new Size(125, 50);
            btnGridRemove.TabIndex = 5;
            btnGridRemove.Text = "Remove From GridView";
            btnGridRemove.UseVisualStyleBackColor = false;
            // 
            // btnDataRemove
            // 
            btnDataRemove.BackColor = Color.Pink;
            btnDataRemove.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDataRemove.ForeColor = Color.Black;
            btnDataRemove.Location = new Point(637, 268);
            btnDataRemove.Margin = new Padding(0);
            btnDataRemove.Name = "btnDataRemove";
            btnDataRemove.Size = new Size(125, 50);
            btnDataRemove.TabIndex = 6;
            btnDataRemove.Text = "Remove From Data";
            btnDataRemove.UseVisualStyleBackColor = false;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = Color.Pink;
            btnClearData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearData.ForeColor = Color.Black;
            btnClearData.Location = new Point(547, 397);
            btnClearData.Margin = new Padding(0);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(114, 41);
            btnClearData.TabIndex = 7;
            btnClearData.Text = "Clear Data";
            btnClearData.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearData);
            Controls.Add(btnDataRemove);
            Controls.Add(btnGridRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dgvRecs);
            Controls.Add(btnRefresh);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRecs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvRecs;
        private GroupBox groupBox1;
        private Label labelWidth;
        private Label labelNo;
        private TextBox txtArea;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtNo;
        private Label labelArea;
        private Label labelLength;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnGridRemove;
        private Button btnDataRemove;
        private Button btnClearData;
    }
}