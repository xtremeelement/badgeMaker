using System;

namespace CatWorx.BadgeMaker
{
    class Employee
    {
        public string FirstName;

        public string LastName;

        public int Id;

        public string PhotoUrl;

        //create Employee constructor method with arguments defined above
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetName()
        {
            return ($"{FirstName} {LastName}");
        }
    }
}