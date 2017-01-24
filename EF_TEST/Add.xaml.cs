using EF_DataAccess;
using EF_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EF_TEST
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDetails objEmpDetails = new EmployeeDetails();
            objEmpDetails.empId = Convert.ToInt32(txtEmpId.Text);
            objEmpDetails.empName = txtEmpName.Text;
            objEmpDetails.experience = txtExperience.Text;
            objEmpDetails.designation = txtDesignation.Text;
            objEmpDetails.salary = Convert.ToDecimal(txtSalary.Text);
            objEmpDetails.skillSet = txtSkillSet.Text;
            CrudOperations objCrudOp = new CrudOperations();
            objCrudOp.create(objEmpDetails);
            MessageBox.Show("Data Saved Successfully");
            
        }
    }
}
