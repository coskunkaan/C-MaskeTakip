using System;
using System.Collections.Generic;
using Business.Concrete;
using Businnes.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

        

            Person person1 = new Person();
            person1.FirstName = "Kaan";
            person1.LastName = "Kaya";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 1;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        
       

    }
}



