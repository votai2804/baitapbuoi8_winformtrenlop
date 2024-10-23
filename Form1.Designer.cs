namespace baibuoi8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.FullName,
            this.Age,
            this.Major});
            this.dataGridView1.Location = new System.Drawing.Point(301, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(155, 151);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(124, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(43, 312);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(69, 22);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(155, 213);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(121, 24);
            this.cmbMajor.TabIndex = 4;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(118, 312);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(69, 22);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(193, 312);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(69, 22);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(358, 70);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(69, 31);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(978, 70);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(69, 31);
            this.btnprevious.TabIndex = 3;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(155, 179);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(124, 22);
            this.txtAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quản Lý Sinh Viên";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(155, 123);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(124, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Số Sinh Viên";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentId
            // 
            this.studentId.DataPropertyName = "studentId";
            this.studentId.HeaderText = "Mã Sinh Viên";
            this.studentId.MinimumWidth = 6;
            this.studentId.Name = "studentId";
            this.studentId.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Tên Sinh Viên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Tuổi";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Major
            // 
            this.Major.DataPropertyName = "Major";
            this.Major.HeaderText = "Chuyên Ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 413);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
    }
}