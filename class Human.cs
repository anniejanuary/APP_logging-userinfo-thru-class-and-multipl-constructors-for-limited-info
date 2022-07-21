using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMultipleConstructors2
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        //DEFAULT CONSTRUCTOR
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // CREATING ANOTHER CONSTRUCTOR METHOD W/O AGE PARAMETER
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        // CONSTRRUCTOR FOR WHEN ONLY FIRST NAME AVAILABLE
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //CONSTRUCTOR FOR WHEN EYE COLOR AND AGE ARE UNAVAILABLE
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //PARAMETERIZED CONTRUCTOR
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public void introduceMyself()
        {
            if(age !=0)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I'm {age}, my eye color is {eyeColor}");
            }
            else if(lastName == null && age == 0 && eyeColor == null)
            {
                Console.WriteLine($"Hi, I'm {firstName}");
            }

            else if(age == 0 && eyeColor == null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}");
            }

            else
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, my eye color is {eyeColor}");
            }
            
        }
    }
}
