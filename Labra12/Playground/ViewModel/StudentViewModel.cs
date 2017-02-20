using Playground.Model;
using System.Collections.ObjectModel;

namespace Playground.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allen", AsioId = "K0011" });
            students.Add(new Student { FirstName = "John", LastName = "Doe", AsioId = "B4567" });
            students.Add(new Student { FirstName = "Linda", LastName = "Kernell", AsioId = "C3421" });
            Students = students;
        }
    }
}