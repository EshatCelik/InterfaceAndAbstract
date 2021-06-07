using AbstractAndInterfaceDmo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDmo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
