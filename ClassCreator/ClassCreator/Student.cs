using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator
{
    class Student
    {
        // Class Properties
        private string name;
        private string id;
        private int numberOfGrades;

        //Constructor
        public Student(string name, string id, int numberOfGrades)
        {
            this.name = name;
            this.id = id;
            this.numberOfGrades = numberOfGrades;
        }

        // Get and Set methods
        public string GetName()
        {
            return this.name;

        }

        public string GetId()
        {
            return this.id;

        }

        public int GetNumberOfGrades()
        {
            return this.numberOfGrades;

        }

        public void SetName(string name)
        {
            this.name = name;

        }

        public void SetId(string id)
        {
            this.id = id;

        }

        public void SetNumberOfGrades(int numberOfGrades)
        {
            this.numberOfGrades = numberOfGrades;

        }
    }
}
