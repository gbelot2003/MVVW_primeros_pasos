using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Commands;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class StudentViewModel
    {

        public MyICommand DeleteCommand { get; set; }
        private Student _selectedStudent;

        // Se importa el modelo a una ObservableCollection
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public StudentViewModel()
        {
            LoadStudents();

            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        // Se crea una clase void para cargar a los alumnos
        // Aqui bien podria ser una llamada a base de datos.
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Gerardo", LastName = "Belot" });
            students.Add(new Student { FirstName = "Andrea", LastName = "Belot" });
            students.Add(new Student { FirstName = "Samuel", LastName = "Belot" });

            Students = students;

        }
    } 
}
