using AbstractAndInterfaceDmo.Abstract;
using AbstractAndInterfaceDmo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDmo.Concreate
{
    public class CustomerCheckManager : ICustomerCheckService
    {

        public bool IfCheckRealPerson(Customer customer)
        {
            return true;//bizim servisimiz 
        }
    }
}
