using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using student.Models;

//using student.Models;

//using System.Data.Entity;
namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)  // Form load Method
        {
 }

        public void Display()   // Display Method is a common method to bind the Student details in datagridview after save,update and delete operation perform.
        {
            StudentInformationEntities _entity = new StudentInformationEntities();
            {
                List<StudentInformation> _studentList = new List<StudentInformation>();
                _studentList = _entity.StudentDetails.Select(x => new StudentInformation
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();
                dataGridView1.DataSource = _studentList;
            }
        }
        private void BtnSaveClick(object sender, EventArgs e)   // Save button click event  
        {
            StudentDetails stu = new StudentDetails();
            stu.Name = txtName.Text;
            stu.Age = Convert.ToInt32(txtAge.Text);
            stu.City = txtCity.Text;
            stu.Gender = cmbGender.SelectedItem.ToString();
            bool result = SaveStudentDetails(stu); // calling SaveStudentDetails method to save the record in table.Here passing a student details object as parameter  
            ShowStatus(result, "Save");
        }
        public bool SaveStudentDetails(StudentDetails Stu) // calling SaveStudentMethod for insert a new record  
        {
            bool result = false;
            StudentInformationEntities _entity = new StudentInformationEntities();
            {
                _entity.StudentDetails.Add(Stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e) //Calling Datagridview cell click to Update and Delete  
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtAge.Text = row.Cells[2].Value.ToString();
                    txtCity.Text = row.Cells[3].Value.ToString();
                    if(row.Cells[4].Value.ToString()=="male")
                    cmbGender.SelectedIndex=0;
                    else cmbGender.SelectedIndex=1;
                }
            }
        }
        private void BtnUpdateClick(object sender, EventArgs e) // Update button click event  
        {
            StudentDetails stu = SetValues(Convert.ToInt32(lblID.Text), txtName.Text, Convert.ToInt32(txtAge.Text), txtCity.Text, cmbGender.SelectedItem.ToString()); // Binding values to StudentInformationModel  
            bool result = UpdateStudentDetails(stu); // calling UpdateStudentDetails Method  
            ShowStatus(result, "Update");
        }
        public bool UpdateStudentDetails(StudentDetails Stu) // UpdateStudentDetails method for update a existing Record  
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                StudentDetails _student = _entity.StudentDetails.Where(x => x.Id == Stu.Id).Select(x => x).FirstOrDefault();
                _student.Name = Stu.Name;
                _student.Age = Stu.Age;
                _student.City = Stu.City;
                _student.Gender = Stu.Gender;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        private void BtnDeleteClick(object sender, EventArgs e) //Delete Button Event  
        {
            StudentDetails stu = SetValues(Convert.ToInt32(lblID.Text), txtName.Text, Convert.ToInt32(txtAge.Text), txtCity.Text, cmbGender.SelectedItem.ToString()); // Binding values to StudentInformationModel  
            bool result = DeleteStudentDetails(stu); //Calling DeleteStudentDetails Method  
            ShowStatus(result, "Delete");
        }
        public bool DeleteStudentDetails(StudentDetails Stu) // DeleteStudentDetails method to delete record from table  
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                StudentDetails _student = _entity.StudentDetails.Where(x => x.Id == Stu.Id).Select(x => x).FirstOrDefault();
                _entity.StudentDetails.Remove(_student);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public StudentDetails SetValues(int Id, string Name, int age, string City, string Gender) //Setvalues method for binding field values to StudentInformation Model class  
        {
            StudentDetails stu = new StudentDetails();
            stu.Id = Id;
            stu.Name = Name;
            stu.Age = age;
            stu.City = City;
            stu.Gender = Gender;
            return stu;
        }

        public void ShowStatus(bool result, string Action) // validate the Operation Status and Show the Messages To User  
        {
            if (result)
            {
                if (Action.ToUpper() == "SAVE")
                {
                    MessageBox.Show("Saved Successfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Updated Successfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Successfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
            Display();
        }
        public void ClearFields() // Clear the fields after Insert or Update or Delete operation  
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";
            cmbGender.SelectedIndex = -1;
        }  
        
        void Form1Load(object sender, EventArgs e)
        {
        	            cmbGender.Items.Add("Male");   // Adding values for Gender Combobox
            cmbGender.Items.Add("Female");
            Display();   // calling Display Method for Bind the Student Details in Datagridview
       
        }
        

    }
}
