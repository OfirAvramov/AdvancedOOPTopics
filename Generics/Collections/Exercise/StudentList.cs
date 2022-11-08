using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Exercise
{
    //StudentList is a class represented by a List of students.

    public class StudentList
    {

        //Targil 1 - write the Property of StudentList called Students
        #region Properties
        List<Student> Students { get; set; }

        #endregion

        //Targil 2 - Write a constructor which initiates the students and calls for Student.FillList()
        #region Constructor
        public StudentList()
        {
            Students = new List<Student>();
            var l = Student.FillList();
            foreach(var s in l)
            {
                Students.Add(s);
            }
        }
        #endregion



        //Targil 3- Create a dictionary where the key is the name of the Student and the value is the Student object
        #region Work with  Dictionary
        public Dictionary<string, Student> CreateDictionaryFromStudentList()
        {
            Dictionary<string, Student> dictio = new Dictionary<string, Student>();
            var l = Student.FillList();
            for (int i = 0; i < Student.count; i++)
            {
                dictio.Add(var[i].Get_name());
                dictio.Add(Student);
            }

        }

        //Targil 4- write a method which retrieves a Student By name. Use the Dictionary create in Targil 3
        public Student FindStudentByName(string name)
        {
            Students = new List<Student>();
            for (int i = 0; i < Students.count; i++)
			{
                if(Students[i].Get_name = name)
                {
                    Dictionary newdictio<string, Student> = CreateDictionaryFromStudentList();
                    return newdictio
                }
                    

                
			}
            
        }
        #endregion

        #region retrieving a list
        //Targil 5-  write a method which retrieves a list of Students By Kita
        public List<Student> GetStudentsByKits(string kita)
        {
            return null;
        }
        #endregion



    }
}
