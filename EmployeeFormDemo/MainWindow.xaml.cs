using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeFormDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            // Create a new employee and add it to the ObservableCollection
            Employee newEmployee = new Employee
            {
                EmployeeID = int.Parse(txtEmployeeID.Text),
                EmployeeName = txtEmployeeName.Text,
                EmployeeMail = txtEmployeeMail.Text,
                EmployeeBirthDate = dpEmployeeBirthDate.SelectedDate,
                EmployeeGender = cmbEmployeeGender.Text
            };

            employees.Add(newEmployee);            

            MessageBox.Show("Employee details saved"); 
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtEmployeeMail.Clear();
            dpEmployeeBirthDate.SelectedDate = null;
            cmbEmployeeGender.SelectedItem =null;
            MessageBox.Show("Employee details canceled");
        }
    }
}