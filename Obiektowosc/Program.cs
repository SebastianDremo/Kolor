using Abc;

namespace Obiektowosc
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.age = 21;
            human.name = "Sebastian";

            human.Print();
        }
    }
}
