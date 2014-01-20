using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Patr14.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        private decimal averageGrade;

        public decimal AverageGrade
        {
            get { return averageGrade; }
            set 
            { 
                averageGrade = value;
                NotifyOfPropertyChange(() => AverageGrade);
            }
        }

        public MainPageViewModel()
        {
            AverageGrade = 3.456m;
        }
    }
}
