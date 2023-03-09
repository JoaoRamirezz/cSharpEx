public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Quilometragem { get; set; }
    public bool Ligado { get; set; } = false;


    public Veiculo(string marca, string modelo, int quilometragem)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Quilometragem = quilometragem;
    }


    public virtual void Ligar()
    {
        this.Ligado = true;
    }

    public virtual void Desligar()
    {
        this.Ligado = false;
    }
}



public class Caminhao : Veiculo
{
    public int Capacidade { get; set; }

    public Caminhao(string marca, string modelo, int quilometragem, int capacidade) : base(marca, modelo, quilometragem)
    {
        this.Capacidade = capacidade;
    }
}



public class Carros : Veiculo
{
    public int NumeroPassageiros { get; set; }

    public Carros(string marca, string modelo, int quilometragem, int numeroPassageiros) : base(marca, modelo, quilometragem)
    {
        this.NumeroPassageiros = numeroPassageiros;
    }
}



public class Moto : Veiculo
{
    public int Cilindradas { get; set; }
    
    public Moto(string marca, string modelo, int quilometragem, int cilindradas) : base(marca, modelo, quilometragem)
    {
        this.Cilindradas = cilindradas;
    }
}





