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
        public Employee(string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetName()
        {
            return ($"Name: {FirstName} {LastName} \nID:{Id}\nPhoto:{PhotoUrl}\n");
        }

        public int GetId()
        {
            return Id;
        }

        public string GetPhotoUrl()
        {
            return PhotoUrl;
        }
    }
}
