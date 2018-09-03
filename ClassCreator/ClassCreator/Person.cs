using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator
{
    class Person
    {
        // Class Properties
        private string name;
        private string id;
        private int age;
        private int kids;

        //Constructor
        public Person(string name, string id, int age, int kids)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.kids = kids;
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

        public int GetAge()
        {
            return this.age;

        }

        public int GetKids()
        {
            return this.kids;

        }

        public void SetName(string name)
        {
            this.name = name;

        }

        public void SetId(string id)
        {
            this.id = id;

        }

        public void SetAge(int age)
        {
            this.age = age;

        }

        public void SetKids(int kids)
        {
            this.kids = kids;

        }
    }
}
