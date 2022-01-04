
using System; 
using CSharp;
using Interface;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();
            person.Nome = "Kaique";
            person.Idade = 21;
            person.Estado = "Sp";

            var person2 = new Pessoa();

            person2.Nome = "M Jordan";
            person2.Idade = 23;
            person2.Estado = "Chicago";

            var animal = new Animal();
            animal.Nome = "Rex";
            animal.Idade = 1000;
            animal.Dono = "Deus";

                
            var a = "Hello";
            var b = "World!";
            var classe = new Primeiro.Classe();
            var classe2 = new Segundo.Classe();
            Console.WriteLine(a + b);
        }
    }
}
