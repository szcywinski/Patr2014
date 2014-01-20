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
    public class MainPageViewModel : PropertyChangedBase
    {
        private decimal averageGrade;
        private ObservableCollection<Student> students;
        private Student selectedStudent;
       
        
        public MainPageViewModel()
        {
            AverageGrade = 3.456m;
            Students = new BindableCollection<Student>
            {
                new Student(){FirstName="Janusz",LastName="Pień",Grade=3.0m},
                new Student(){FirstName="Marian",LastName="Kutacz",Grade=3.0m}
            };
        }

        public void AddStudent()
        {
            MessageBox.Show("Item added");
        }

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                NotifyOfPropertyChange(() => SelectedStudent);
                MessageBox.Show(value.Grade.ToString());
            }
        }

        public decimal AverageGrade
        {
            get { return averageGrade; }
            set
            {
                averageGrade = value;
                NotifyOfPropertyChange(() => AverageGrade);
            }
        }

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                NotifyOfPropertyChange(() => Students);
            }

        }
    }
}
