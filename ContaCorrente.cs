public class ContaBancaria
{
    public int NumeroConta { get; set; }
    public string NomeCorrentista { get; set; }
    public int Saldo { get; set; }

    public ContaBancaria(int conta, string nome, int saldo = 0)
    {
        this.NumeroConta = conta;
        this.NomeCorrentista = nome;
        this.Saldo = saldo;
    }


    public void AlterarNome(string nome)
    {
        this.NomeCorrentista = nome;
    }


    public void AlterarSaldo(int saldo)
    {
        this.NumeroConta = saldo;
    }


    public void Saque(int valor)
    {
        this.Saldo -= valor;
    }
}