using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Idade(int Idade);
    }
}

class Animal : IAnimal
{
    public string Nome { get; set}
    public string nomeDono { get; set; }
    public int Idade { get; set;}

    void IAnimal.nome(string, nome)
    {
        this.Nome = Nome;

    }
    void IAnimal.Dono(string, nome)
    {
        this.nomeDono = Dono;

    }
    void IAnimal.Idade(int, nome)
    {
        this.Idade = Idade;
    }

}