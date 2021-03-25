using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSortApp
{
    class Person
    {
        private String lastName;
        private String firstName;
        private int age;

        public Person(String last, String first, int a)
        { // Конструктор
            lastName = last;
            firstName = first;
            age = a;
        }

        public void displayPerson()
        {
            Console.Write(" Last name: " + lastName);
            Console.Write(", First name: " + firstName);
            Console.WriteLine(", Age: " + age);
        }

        public String getLast() // Получение фамилии
        { 
            return lastName; 
        }
    }
}

