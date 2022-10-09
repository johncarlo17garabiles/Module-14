using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp7
{
    internal class Person
    {
        public string name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public int birthdate { get; set; }
        public string schoollastgraduated { get; set; }
        public string course { get; set; }

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "John";
            person1.address = "Nueva Ecija";
            person1.gender = "Male";
            person1.phone = 09456903505;
            person1.email = "jomagarabilesauphinmaedcom";
            person1.birthdate = 20031703;
            person1.schoollastgraduated = "Phinma AU";
            person1.course = "BSIT";

            Console.WriteLine("Name: {0}.   Address: {1} .   Gender: {2} .   Phone: {3} .   Email: {4} .   BirthDate: {5} .   School Last Graduated: {6} .   Course: {7} .", person1.name, person1.address, person1.gender, person1.phone, person1.email, person1.birthdate, person1.schoollastgraduated, person1.course); ;

            Console.ReadLine();

        }
    }
}
