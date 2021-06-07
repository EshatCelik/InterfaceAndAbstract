using AbstractAndInterfaceDmo.Abstract;
using AbstractAndInterfaceDmo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDmo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService

    {
        public bool IfCheckRealPerson(Customer customer)
        {
            if (customer.NationalityId=="123"&&customer.FistName=="Eshat"&&customer.LastName=="Çelik")//mersisten doğrulama yapılmış
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
