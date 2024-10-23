using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baibuoi8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var student = new Students
                {
                    FullName = txtFullName.Text,
                    Age = int.Parse(txtAge.Text),
                    Major = cmbMajor.Text
                };
                context.Students.Add(student);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (var context = new SchoolContext())
                {
                    // Lấy ID sinh viên từ cột "StudentID"
                    int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[dataGridView1.Columns["StudentID"].Index].Value);

                    // Tìm sinh viên trong cơ sở dữ liệu
                    var student = context.Students.FirstOrDefault(s => s.StudentID == studentId);

                    if (student != null)
                    {
                        // Xóa sinh viên khỏi cơ sở dữ liệu
                        context.Students.Remove(student);
                        context.SaveChanges();

                        // Cập nhật lại DataGridView sau khi xóa
                        LoadData();
                        MessageBox.Show("Sinh viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                // Thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra số hàng được chọn
            {
                using (var context = new SchoolContext())
                {
                    int studentId;
                    if (int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out studentId))
                    {
                        var student = context.Students.Find(studentId);
                        if (student != null)
                        {
                            student.FullName = txtFullName.Text;
                            student.Age = int.Parse(txtAge.Text);
                            student.Major = cmbMajor.Text;
                            context.SaveChanges();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên trong cơ sở dữ liệu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID sinh viên không hợp lệ.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int currentIndex = 0;
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currentIndex < dataGridView1.Rows.Count - 1)
            {
                currentIndex++;
                LoadStudent();
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadStudent();
            }
        }
        private void LoadStudent()
            {
            if (dataGridView1.Rows.Count > 0 && currentIndex >= 0 && currentIndex < dataGridView1.Rows.Count) // Kiểm tra chỉ số
            {
                var row = dataGridView1.Rows[currentIndex];
                txtMSSV.Text = row.Cells["StudentId"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbMajor.Text = row.Cells["Major"].Value.ToString();
            }
        }
        private void LoadData()
        {
            using (var context = new SchoolContext())
            {
                var students = context.Students.ToList();
                dataGridView1.DataSource = students;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Thay e.RowIndex >= 0 để loại bỏ dòng tiêu đề
            {
                // Lấy hàng được nhấp
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ các cột trong hàng được nhấp và hiển thị lên TextBox/ComboBox
                txtMSSV.Text = row.Cells["StudentID"].Value.ToString(); // Đảm bảo tên cột đúng
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbMajor.Text = row.Cells["Major"].Value.ToString();
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }
}
