using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeMVC.Models
{
    internal class Employee
    {
        public string name;
        public string dateBorn;
        public string email;
        public int wage;

        public Employee(string name, string dateBorn, string email, int wage)
        {
            this.name = name;
            this.dateBorn = dateBorn;
            this.email = email;
            this.wage = wage;
        }
    }
}