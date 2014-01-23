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
    public class MainPageViewModel : PropertyChangedBase
    {
              
        private readonly INavigationService navigationService;
 
        private StudentService studentServ;
        private Student selectedStudent;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            StudentServ = StudentService.Instance;
           
        }

        public void AddStudent()
        {
            PhoneApplicationService.Current.State["CurrentStudent"] = null;
            navigationService.UriFor<AddStudentPageViewModel>().Navigate();
        }

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                NotifyOfPropertyChange(() => SelectedStudent);
                PhoneApplicationService.Current.State["CurrentStudent"] = value; 
                navigationService.UriFor<AddStudentPageViewModel>().Navigate();
            }
        }

        public StudentService StudentServ
        {
            get { return studentServ; }
            set
            {
                studentServ = value;
                NotifyOfPropertyChange(() => StudentServ);
            }
        }

      
    }
}
