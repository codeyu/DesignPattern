using System;
using System.Collections.Generic;

namespace DesignPatternLib.Bridge
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    class CustomersData : IDataObject<string>
    {
        // Gets or sets city
        public string City { get; set; }
        private List<string> _customers;
        private int _current = 0;
        // Constructor
        public CustomersData()
        {
            // Simulate loading from database
            _customers = new List<string>
              { "Jim Jones", "Samual Jackson", "Allan Good",
                "Ann Stills", "Lisa Giolani" };
        }
        public void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }
        public void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }
        public void AddRecord(string customer)
        {
            _customers.Add(customer);
        }
        public void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }
        public string GetCurrentRecord()
        {
            return _customers[_current];
        }
        public void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }
        public void ShowAllRecords()
        {
            Console.WriteLine("Customer Group: " + City);
            _customers.ForEach(customer => 
                Console.WriteLine(" " + customer));
        }
    }
}