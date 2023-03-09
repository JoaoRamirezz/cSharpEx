public class ContaBanco
{
    public string NumeroConta { get; set; }
    public string Agencia { get; set; }
    public string NomeTitular { get; set; }
    public int Saldo { get; set; }


    public ContaBanco(string numeroconta, string agencia, string nometitular, int saldo)
    {
        this.NumeroConta = numeroconta;
        this.Agencia = agencia;
        this.NomeTitular = nometitular;
        this.Saldo = saldo;
    }



    public virtual void AlterNome(string nome)
    {
        this.NomeTitular = nome;
    }



    public virtual void Deposito(int valor)
    {
        this.Saldo += valor;
    }



    public virtual void Saque(int valor)
    {
        this.Saldo -= valor;
    }
}



public class ContaCorrente : ContaBanco
{
    public ContaCorrente(string numeroconta, string agencia, string nometitular, int saldo) : base(numeroconta, agencia, nometitular, saldo)
    {
    }
}



public class ContaPoupanca : ContaBanco
{
    public int Rendimento { get; set; }
    public ContaPoupanca(string numeroconta, string agencia, string nometitular, int saldo, int rendimento) : base(numeroconta, agencia, nometitular, saldo)
    {
        this.Rendimento = rendimento;
    }
}