namespace DesignPatternLib.Strategy
{
    public class Client
    {
        public static void Test()
        {
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
        }
    }
}