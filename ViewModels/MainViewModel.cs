using StudentDiaryWPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows;

namespace StudentDiaryWPF.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        
        
        public MainViewModel()
        {
            RefreshStudentCommand = new RelayCommand(RefreshStudents, CanRefreshStudents);
        }
        public ICommand RefreshStudentCommand { get; set; }
        private string _test = "Start";
        
        public string Test
        { 
            get { return _test; } 
            set 
            {
                _test = value;
                OnPropertyChanged();
            } 
        
        }

        private void RefreshStudents(object obj)
        {
            Test = "Meta";
        }
        private bool CanRefreshStudents(object obj)
        {
            return true;
        }
    }
}
