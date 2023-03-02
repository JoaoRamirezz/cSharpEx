public class Carro{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int VelocidadeAtual { get; set; } = 0;

    public Carro(string marca, string modelo, int ano, int velocidadeatual)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
    }


    public void Acelerar()
    {
        this.VelocidadeAtual += 15;
    }


    public void Frear()
    {
        this.VelocidadeAtual -= 10;
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {this.Marca}");
        Console.WriteLine($"Modelo: {this.Modelo}");
        Console.WriteLine($"Ano: {this.Ano}");
        Console.WriteLine($"Velocidade: {this.VelocidadeAtual}");
    }
}