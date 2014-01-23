using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patr14.ViewModels
{
    public class AddStudentPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService navigationService;

        public ObservableCollection<Decimal> Grades
        {
             get{ return new ObservableCollection<Decimal>() { 2, 2.5m, 3, 3.5m, 4, 4.5m, 5 };}
        }

        public AddStudentPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    
    }
}
