using AbstractAndInterfaceDmo.Abstract;
using AbstractAndInterfaceDmo.Adapter;
using AbstractAndInterfaceDmo.Concreate;
using AbstractAndInterfaceDmo.Entity;
using System;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BaseCustomerManager customerStarbucks= new StarbucksCustomerManager(new MernisServiceAdapter());//Starbucks için ayrı
            customerStarbucks.Save(new Customer() { FistName = "Eshat", LastName = "Çelik", NationalityId = "123",DateOfBirth=new DateTime(1994,8,8),Id=1 });

            BaseCustomerManager customer = new NeroCustomerManager();//nero  için ayrı
            customer.Save(new Customer() { FistName = "Yeni", LastName = "Kullanıcı", NationalityId = "123", DateOfBirth = new DateTime(2021,7,6), Id = 1 });


            Console.ReadLine();
        }
    }
}
