public abstract class Animal
{
    public string Patas { get; set; }
    public string Raça { get; set; }
    public string Nome { get; set; }

    public Animal(string patas, string raça, string nome)
    {
        this.Patas = patas;
        this.Raça = raça;
        this.Nome = nome;
    }

    

    public abstract void Barulho();
}


public class Gato : Animal
{

    public Gato(string patas, string raça, string nome) : base(patas, raça, nome)
    {
    }

    public override void Barulho()
    {
        Console.WriteLine("miau!");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string patas, string raça, string nome) : base(patas, raça, nome)
    {
    }


    public override void Barulho()
    {
        Console.WriteLine("au au!");
    }
}