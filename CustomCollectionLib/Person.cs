using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionLib
{
    public enum Job
    {
        Software_Engineer,
        Economist,
        Admin,
        Doctor,
        Electrician,
        Accountant

    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Job Job { get; set; }

        public CustomList<Person> GetAllPersons()
        {
            CustomList<Person> persons = new CustomList<Person> { new Person {Id=1,Name = "Ella Sawyer",Age=22,Job=Job.Software_Engineer },
                                                                new Person{Id=2,Name= "Cory Watson",Age=30,Job=Job.Doctor },
                                                                new Person{Id=3,Name="Paula Ruiz",Age=46,Job=Job.Accountant},
                                                                new Person{Id=4,Name="Pedro Wilson", Age=35,Job=Job.Doctor},
                                                                new Person{Id=5,Name="Danny Walton",Age=29,Job=Job.Economist} };
            return persons;
        }

        public void printPerson()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nAge: {Age}\nJob: {Job}");

        }

    }
}



