namespace toliBichig
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblLanguage = new Label();
            cmbLanguage = new ComboBox();
            txtEnglsh = new TextBox();
            txtMongolian = new TextBox();
            txtRussian = new TextBox();
            lblEnglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lblCount = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            colEng = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colRus = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(24, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 30);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            lblSearch.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(93, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Хайх үг...";
            txtSearch.Size = new Size(602, 42);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(742, 21);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(51, 30);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Хэл:";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLanguage.Location = new Point(816, 13);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(174, 44);
            cmbLanguage.TabIndex = 3;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // txtEnglsh
            // 
            txtEnglsh.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnglsh.Location = new Point(127, 607);
            txtEnglsh.Name = "txtEnglsh";
            txtEnglsh.Size = new Size(175, 51);
            txtEnglsh.TabIndex = 4;
            // 
            // txtMongolian
            // 
            txtMongolian.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMongolian.Location = new Point(490, 607);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(175, 51);
            txtMongolian.TabIndex = 5;
            // 
            // txtRussian
            // 
            txtRussian.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRussian.Location = new Point(816, 607);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(175, 51);
            txtRussian.TabIndex = 6;
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(51, 620);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(70, 30);
            lblEnglish.TabIndex = 7;
            lblEnglish.Text = "Англи";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(397, 620);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(87, 30);
            lblMongolian.TabIndex = 8;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(742, 620);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(63, 30);
            lblRussian.TabIndex = 9;
            lblRussian.Text = "Орос";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(51, 675);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 57);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+ Нэмэх ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnSave.Location = new Point(833, 675);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "Санах";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnClear.Location = new Point(635, 675);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 57);
            btnClear.TabIndex = 13;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnDelete.Location = new Point(444, 675);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 57);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnEdit.Location = new Point(247, 675);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 57);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button6_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 6.857143F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(12, 755);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(189, 21);
            lblCount.TabIndex = 16;
            lblCount.Text = "Нийт: 0 үг ~ Санасан: 0 \r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, colEng, colMon, colRus });
            dataGridView1.Location = new Point(24, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(671, 510);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // colEng
            // 
            colEng.HeaderText = "Англи";
            colEng.MinimumWidth = 9;
            colEng.Name = "colEng";
            colEng.ReadOnly = true;
            // 
            // colMon
            // 
            colMon.HeaderText = "Монгол";
            colMon.MinimumWidth = 9;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            // 
            // colRus
            // 
            colRus.HeaderText = "Орос";
            colRus.MinimumWidth = 9;
            colRus.Name = "colRus";
            colRus.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Menu;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5 });
            dataGridView2.Location = new Point(742, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(297, 262);
            dataGridView2.TabIndex = 18;
            // 
            // Column2
            // 
            Column2.HeaderText = "№";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Англи";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Монгол";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Орос";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 796);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lblCount);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEnglish);
            Controls.Add(txtRussian);
            Controls.Add(txtMongolian);
            Controls.Add(txtEnglsh);
            Controls.Add(cmbLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblLanguage;
        private ComboBox cmbLanguage;
        private TextBox txtEnglsh;
        private TextBox txtMongolian;
        private TextBox txtRussian;
        private Label lblEnglish;
        private Label lblMongolian;
        private Label lblRussian;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblCount;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colEng;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colRus;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
