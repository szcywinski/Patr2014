using Caliburn.Micro;
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

        public Student CurrentStudent
        {
            get { return currentStudent; }
            set 
            { 
                currentStudent = value;
                NotifyOfPropertyChange(() => CurrentStudent);
            }
        }

        public AddStudentPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            CurrentStudent = new Student();
           // !String.IsNullOrEmpty(CurrentStudent.FirstName) && !String.IsNullOrEmpty(CurrentStudent.LastName)
        }

        public ObservableCollection<Decimal> Grades
        {
             get{ return new ObservableCollection<Decimal>() { 2, 2.5m, 3, 3.5m, 4, 4.5m, 5 };}
        }

        private bool canSave;
       
        public bool CanSave
        {
            get { return canSave; }
            set 
            { 
                canSave = value;
                NotifyOfPropertyChange(() => CanSave);
            }
        }

        public void Save()
        {

        }

        public void DataChanged()
        {
            CanSave = !String.IsNullOrEmpty(CurrentStudent.FirstName) && !String.IsNullOrEmpty(CurrentStudent.LastName);
        }
        
    
    }
}
