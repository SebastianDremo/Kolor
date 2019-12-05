using System;

namespace Abc
{
    public class Human
    {
        public string name;
        public int age;

        public void Print(){
            Console.WriteLine(GetString());
        }

        private string GetString()
        {
            return "Mam na imie: " + name + "oraz mam " + age + " lat"
        }
    }
}