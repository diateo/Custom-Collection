using CustomCollectionLib;

namespace CustomCollection
{
    public class Program
    {
        static void DemonstrateList()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(78);
            list.Add(2);
            list.Add(4);
            list.Add(10);
            list.Insert(2, 88);

            Console.WriteLine("Initial list:");

            foreach (var item in list)
                Console.WriteLine(item);

            list.PrintCount();

            Console.WriteLine("List after removal:");
            list.RemoveAt(3);
            list.Remove(10);

            foreach (var item in list)
                Console.WriteLine(item);

            list.PrintCount();

            ///////////////////////////////////////////
            Person pers = new Person();
            CustomList<Person> list2 = pers.GetAllPersons();

            Console.WriteLine("Initial list:");
            foreach (var p in list2)
            {
                p.printPerson();
                Console.WriteLine();
            }
            list2.PrintCount();

            list2.Add(new Person { Id = list2.Count() + 1, Name = "Aubrielle Newton", Age = 50, Job = Job.Admin });
            list2.Insert(0, new Person { Id = list2.Count() + 1, Name = "Westin Logan", Age = 38, Job = Job.Doctor }); ;

            Console.WriteLine("List after addition:");
            foreach (var p in list2)
            {
                p.printPerson();
                Console.WriteLine();
            }
            list2.PrintCount();

            list2.RemoveAt(5);

            Console.WriteLine("List after removal:");
            foreach (var p in list2)
            {
                p.printPerson();
                Console.WriteLine();
            }
            list2.PrintCount();

            var filter = from p in list2
                         where p.Name.Contains('W') && p.Job == Job.Doctor
                         select p;

            foreach (var p in filter)
            {
                p.printPerson();
                Console.WriteLine();
            }
        }

        static void DemonstrateStack()
        {
            CustomStack<int> stack1 = new CustomStack<int>();

            string response = "";
            Console.WriteLine("Please add a number to the stack: ");
            while (true)
            {
                response = Console.ReadLine();
                if (response.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    stack1.Push(int.Parse(response));
                    Console.WriteLine("Add another number to the stack or type 'quit'");
                }
            }

            foreach (var s in stack1)
                Console.WriteLine(s);

            Console.WriteLine($"The elements that is removed from the top: {stack1.Pop()}");
            Console.WriteLine("The list after removal:");

            foreach (var s in stack1)
                Console.WriteLine(s);
        }
        static void Main()
        {
            //DemonstrateList();
            DemonstrateStack();

        }
    }

}