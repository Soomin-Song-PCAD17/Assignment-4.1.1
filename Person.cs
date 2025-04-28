using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._1
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }


        public Person(string firstName, string lastName, string mobilePhone, string workPhone, string address)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
            WorkPhone = workPhone;
            Address = address;
        }
        public Person(Person person)
        {
            // copy person object
            Id = person.Id;
            FirstName=person.FirstName;
            LastName=person.LastName;
            MobilePhone = person.MobilePhone;
            WorkPhone = person.WorkPhone;
            Address = person.Address;
        }
    }
}
