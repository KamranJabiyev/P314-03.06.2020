using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object
            //Person person = new Person("Seynur","Memmedov");
            //Console.WriteLine(person.ToString());
            //int a = 5;
            //Console.WriteLine(a.GetType());
            //string word = "Test";
            //Console.WriteLine(a.ToString());
            #endregion

            #region Sealed
            //Man man = new Man("Osman", "Ismayilov");
            //Console.WriteLine(man.ToString());
            #endregion

            #region Abstrack - cannot get instance
            Eagle eagle = new Eagle();
            //eagle.Eat();
            //eagle.HasEyes();
            eagle.Run();
            Shark shark = new Shark();
            shark.Run();
            #endregion
        }
    }
    #region Abstrack
    public abstract class Animal
    {
        public int FootCount;
        public abstract int MyProperty { get; set; }
        //abstrack method  - no body,must be in abstrack class
        public abstract void Eat();

        public void HasEyes()
        {
            Console.WriteLine("Has Eyes");
        }

        public virtual void Run()
        {
            Console.WriteLine("Can be run");
        }
    }

    public abstract class Bird : Animal
    {
        public abstract void Fly();
    }
    public class Eagle : Bird
    {
        public override int MyProperty { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public override void Run()
        {
            Console.WriteLine("Run as Eagle");
        }
    }

    class Shark : Animal
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }
    }
    #endregion

    #region Object
    //public class Person:Object
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }

    //    public Person(string name,string surname)
    //    {
    //        Name = name;
    //        Surname = surname;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{Name} {Surname}";
    //    }
    //}
    #endregion

    #region Sealed
    //public sealed class Man:Person
    //{
    //    public Man(string name, string surname) : base(name, surname)
    //    {
    //    }
    //}

    //cannot get inheretance from sealed class!!!
    //class Test : Man { }
    #endregion
}
