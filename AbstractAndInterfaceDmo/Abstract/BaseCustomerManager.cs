using AbstractAndInterfaceDmo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDmo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to DB "+customer.FistName); //veri tabanına kaydettiğimizi düşünelim
        }
    }
}
