using System;
using DesignPatternLib.AbstractFactory;
using DesignPatternLib.Singleton;
using DesignPatternLib.Strategy;
using DesignPatternLib.Template;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create and run the African animal world
            var africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();

            // Create and run the American animal world
            var america = new AnimalWorld<America>();
            america.RunFoodChain();

            //Singleton
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
            //Singleton end 

            // Strategy begin
            // Two contexts following different strategies
            var studentRecords = new SortedList()
              {
                new Student{ Name = "Samual", Ssn = "154-33-2009" },
                new Student{ Name = "Jimmy", Ssn = "487-43-1665" },
                new Student{ Name = "Sandra", Ssn = "655-00-2944" },
                new Student{ Name = "Vivek", Ssn = "133-98-8399" },
                new Student{ Name = "Anna", Ssn = "760-94-9844" },
              };

            studentRecords.SortStrategy = new QuickSort();
            studentRecords.SortStudents();

            studentRecords.SortStrategy = new ShellSort();
            studentRecords.SortStudents();

            studentRecords.SortStrategy = new MergeSort();
            studentRecords.SortStudents();
            //Strategy end

            //Template
            Employee manager = new Manager();
            manager.GetSalary();
            Employee ceo = new CEO();
            ceo.GetSalary();
            // Wait for user input
            Console.ReadKey();
        }
    }
}
