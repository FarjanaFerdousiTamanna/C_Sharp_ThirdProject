using System;

namespace ThirdProject
{
    // creating customized class 
    public class Person
    {
        //declaring fields which are a little different from properties. 
        // In properties we need to initialized value immedietly.
        public string name;
        public int age;
        public bool hasPets;

        //creating Method
        // we use void before method name when we do not need to return any value from the inside of the method.
        // in this method I am not passing any value. 
        // but if in the () i would have passed values like (int x, int y) then I would have to remove the void. 
        // under the method there must be a section with {        }
        public void greetings()
        {
            // Here the values of name and age will be fetch from the main class. 
            Console.WriteLine("Hi, My name is " + name + " and my age is " + age + ".");
        }


    }
    // this is the main class with "static void Main(string[] args)"
    class Program
    {
        static void Main(string[] args)
        {
            // "Person person = new Person();" is a mandatory step where we are using the memory to keep the values.
            Person person = new Person();

            // initializing values of the fields here 
            person.name = "Tamanna";
            person.age = 23;
            person.hasPets = true;

            // calling the method here for giving it necessary values. that will take values from here 
            // then will be printed from inside itself where  is console.writeline(); exists. 
            person.greetings();
        }
    }
}
