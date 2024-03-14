using System;
using System.ComponentModel;

namespace EmployeeFormDemo
{
    public class Employee : INotifyPropertyChanged
    {
        int employeeID;
        string employeeName;
        string employeeMail;
        DateTime? employeeBirthDate;
        string employeeGender;
        
        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                OnPropertyChanged("EmployeeID");
            }
        }
        
        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                employeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        
        public string EmployeeMail
        {
            get { return employeeMail; }
            set
            {
                employeeMail = value;
                OnPropertyChanged("EmployeeMail");
            }
        }
        
        public DateTime? EmployeeBirthDate
        {
            get { return employeeBirthDate; }
            set
            {
                employeeBirthDate = value;
                OnPropertyChanged("employeeBirthDate");
            }
        }
        
        public string EmployeeGender
        {
            get { return employeeGender; }
            set
            {
                employeeGender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

        public Employee()
        {
                
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}