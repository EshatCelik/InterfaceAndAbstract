using AbstractAndInterfaceDmo.Abstract;
using AbstractAndInterfaceDmo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDmo.Concreate
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.IfCheckRealPerson(customer))
            {

                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }


    }
}
