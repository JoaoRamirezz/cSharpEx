public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Salario { get; set; }
    public int Faltas { get; set; } = 0;

    public Funcionario(string nome, string cpf, int salario, int faltas)
    {
        this.Nome = nome;
        this.CPF = cpf;
        this.Salario = salario;
        this.Faltas = faltas;
    }


    public int GetBonificacao(int valor)
    {
        return this.Salario + valor;
    }


    public void AumentarSalario(int aumento)
    {
        this.Salario += aumento;
    }


    public void Faltou()
    {
        this.Faltas += 1;
    }


    public int GetFaltas()
    {
        return this.Faltas;
    }
}