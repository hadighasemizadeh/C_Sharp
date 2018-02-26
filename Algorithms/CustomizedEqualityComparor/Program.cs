using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIequalityComapror
{
    class Program
    {
        static void Main(string[] args)
        {
            var University = getStudents().Distinct(new StudentComparor(p => p.department));

            foreach (var student in University)
            {
                Console.WriteLine("{0} study in {1} department.",student.firstName, student.department);
            }

            Console.ReadKey();
        }
        public static List<Student> getStudents()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student { id = 1, firstName = "Nuno", lastName = "Soares", department = "DECA" });
            studentList.Add(new Student { id = 2, firstName = "Marcelo", lastName = "martin", department = "Engineering" });
            studentList.Add(new Student { id = 3, firstName = "Hadi", lastName = "Ghasemi", department = "DECA" });
            studentList.Add(new Student { id = 4, firstName = "Sebastian", lastName = "Soares", department = "Language" });

            return studentList;
        }

        public class Student
        {
            public int id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string department { get; set; }
        }

        public class StudentComparor : IEqualityComparer<Student>
        {
            Func<Student, object> compareSeletor;
            public StudentComparor() {}

            public StudentComparor(Func<Student, object> _compareSeletor)
            {
                compareSeletor = _compareSeletor;
            }

            public bool Equals(Student x, Student y)
            {
                if (compareSeletor(x).Equals(compareSeletor(y)))
                    return true;
                else
                    return false;
            }

            public int GetHashCode(Student obj)
            {
                return compareSeletor(obj).GetHashCode();
            }
        }
    }
}
