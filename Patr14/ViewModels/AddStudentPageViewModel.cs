using Caliburn.Micro;
using Microsoft.Phone.Shell;
using Patr14.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Patr14.ViewModels
{
    public class AddStudentPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService navigationService;

        private Student currentStudent;
        private Student editedStudent;
        private bool canSave;

        public AddStudentPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            var student = PhoneApplicationService.Current.State["CurrentStudent"];
            if (student != null && student is Student)
            {
                editedStudent = (Student)student;
                CurrentStudent = StudentService.Instance.CloneStudent(editedStudent);
            }
            else
            {
                CurrentStudent = new Student();
            }
                     
        }

        public ObservableCollection<Decimal> Grades
        {
             get{ return new ObservableCollection<Decimal>() { 2, 2.5m, 3, 3.5m, 4, 4.5m, 5 };}
        }
          
        
        public void Save()
        {
            if (editedStudent != null)
            {
                StudentService.Instance.CopyStudentTo(CurrentStudent, editedStudent);
            }
            else
            {
                StudentService.Instance.AddStudent(CurrentStudent);
            }
            navigationService.GoBack();
        }

        public void DataChanged()
        {
            CanSave = !String.IsNullOrEmpty(CurrentStudent.FirstName) && !String.IsNullOrEmpty(CurrentStudent.LastName) &&
                    (editedStudent == null || CurrentStudent.FirstName != editedStudent.FirstName || CurrentStudent.LastName != editedStudent.LastName || CurrentStudent.Grade != editedStudent.Grade);
        }

        public Student CurrentStudent
        {
            get { return currentStudent; }
            set
            {
                currentStudent = value;
                NotifyOfPropertyChange(() => CurrentStudent);
            }
        }

        public bool CanSave
        {
            get { return canSave; }
            set
            {
                canSave = value;
                NotifyOfPropertyChange(() => CanSave);
            }
        }
    
    }
}
