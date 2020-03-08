using System.Collections.Generic;
using System;
namespace VirtualProxy
{
    public class ContactsProxyImpl : IContacts

    {
        private IContacts _contacts;
        private IList<Employee> _employeeList  { get; set;}
        public IList<Employee> Employees()
        {
            Console.WriteLine("Creating contact list and fetching list of employees...");
            if (_contacts == null) {
                _contacts = new ContactsImpl();
                 _employeeList = _contacts.Employees(); }
            return _employeeList;
        }
    }
}