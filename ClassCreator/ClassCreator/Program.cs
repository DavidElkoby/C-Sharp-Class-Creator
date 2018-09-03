using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class name input
            Console.WriteLine("Enter the class' name");
            string className = Console.ReadLine();
            Console.WriteLine("-------");

            // Number of properties in the class
            Console.WriteLine("Enter the number of properties in your class");
            string[] propertiesNames = new string[int.Parse(Console.ReadLine())];
            string[] propertiesTypes = new string[propertiesNames.Length];
            Console.WriteLine("-------");

            // Properties names input
            Console.WriteLine("Enter the name properties of the class and then the type, one each time.");
            Console.WriteLine("-----------------------------------------------------------------------");

            for (int i = 0; i < propertiesNames.Length; i++)
            {
                Console.WriteLine("Enter property {0} name :", i + 1);
                propertiesNames[i] = Console.ReadLine();
                Console.WriteLine("Enter property {0} type :", i + 1);
                propertiesTypes[i] = Console.ReadLine();
                Console.WriteLine("------------------");
            }

            Console.Clear(); // ניקוי המסך לקראת הפלט

            // Class output

            // Class string
            string classString = "";

            // Class properties output
            classString += "// Class Properties\n"; // Comment on the class
            for (int i = 0; i < propertiesNames.Length; i++) // Declaring the properties
                classString += "private " + propertiesTypes[i] + " " + propertiesNames[i] + ";\n";

            classString += "\n//Ctors\n"; // Ctor comment

            // Empty constructor
            classString += "public " + className + " ()\n";
            classString += "{\n\n";
            classString += "}\n\n";

            // Reseting constructor (inputting all properties)
            classString += "public " + className + "(";
            for (int i = 0; i < propertiesNames.Length-1; i++)
                classString += propertiesTypes[i] + " " + propertiesNames[i] + ",";
            classString += propertiesTypes[propertiesNames.Length-1] + " " + propertiesNames[propertiesNames.Length - 1];
            classString += ")\n{\n";

            // Setting up the properties of the class
            for (int i = 0; i < propertiesTypes.Length; i++)
            {
                classString += "\tthis." + propertiesNames[i] + " = " + propertiesNames[i] + "\n";
            }
            classString += "}\n\n";

            classString += "// Get methods\n"; // Get methods comment

            // Getters and setters
            for (int i = 0; i < propertiesNames.Length; i++) // Get
            {
                string nameWithCapital = propertiesNames[i].First().ToString().ToUpper()+ propertiesNames[i].Substring(1);
                classString += "public " + propertiesTypes[i] + " Get" + nameWithCapital + "()\n";
                classString += "{\n";
                classString += "\treturn this." + propertiesNames[i] + ";\n";
                classString += "}\n\n";
            }

            classString += "// Set methods\n";
            for (int i = 0; i < propertiesNames.Length; i++) // Set
            {
                string nameWithCapital = propertiesNames[i].First().ToString().ToUpper() + propertiesNames[i].Substring(1);
                classString += "public void Set" + nameWithCapital + "(" + propertiesTypes[i] + " " + propertiesNames[i] + ")\n";
                classString += "{\n";
                classString += "\tthis." + propertiesNames[i] + " = " + propertiesNames[i] + ";\n";
                classString += "}\n\n";
            }

            // ToString Method
            classString += "// ToString() Method\n";
            classString += "public override string ToString()\n{\n\tstring str = string.Format(\"";
            for (int i = 0; i < propertiesNames.Length; i++)
            {
                classString += propertiesNames[i] + " : {" + i + "}" + @"\n";
            }
            classString += "\",";
            for (int i = 0; i < propertiesNames.Length-1; i++)
            {
                classString += "this." + propertiesNames[i] + ",";
            }
            classString += "this." + propertiesNames[propertiesNames.Length - 1] + ");\n";
            classString += "\treturn str;\n}\n";

            System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + @"\" + className + ".cs", classString);
        }
    }
}