using System;
using System.Collections.Generic;

namespace MethodListAssignmentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean moreNames = true;
            Person person = new Person();

            while (moreNames)
            {
                Console.WriteLine("What is your fullname?");
                person.AddName(Console.ReadLine());

                Console.WriteLine("Want to add more names? Y or N");
                String input = Console.ReadLine();

                if (input.ToUpper() == "Y")
                {
                    moreNames = true;
                }
                else if (input.ToUpper() == "N")
                {
                    moreNames = false;
                }
                else
                {
                    Console.WriteLine("Press Y or N");
                    break;
                }
            }
            Console.WriteLine();


            foreach (String fullname in person.ListOfNames)
            {
                string[] splitName = fullname.Split(" ");
                int count = splitName.Length;
                string fNameSplit = splitName[0];
                string sNameSplit = splitName[count - 1];
                string alias = (fNameSplit.Substring(0, 1).ToUpper() + (sNameSplit.Substring(0, 1).ToUpper()));
                string fName = ((char.ToUpper(fNameSplit[0])) + fNameSplit.Substring(1));
                string sName = ((char.ToUpper(sNameSplit[0])) + sNameSplit.Substring(1));
                Console.WriteLine("\nName: " + sName + ", " + fName + " \nAlias: " + alias);
                Console.ReadLine();
            }

        }

        public class Person
        {
            public List<String> listOfNames = new List<String>();
            

            public List<String> ListOfNames
            {
                get
                {
                    return listOfNames;
                }
            }

            public void AddName(String nameAndSurname)
            {
                listOfNames.Add(nameAndSurname);
               
            }

        }

    }

}