using System;

namespace Abc
{
    public class Human
    {
        private string _name;
        private int _age;
        
        public Human(string name, int age)
        {
            _name = name;
            _age = age;  
        }        

        public void Print(){
            Console.WriteLine(GetString());
        }

        private string GetString()
        {
            return "Mam na imie: " + _name + "oraz mam " + _age + " lat";
        }
    }
}