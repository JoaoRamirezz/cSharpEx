public class Alunos
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string CPF { get; set; }
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }
    public bool Recuperação { get; set; }
    public int Faltas { get; set; } = 0;
    public string DataNasc { get; set; }


    public Alunos(string nome, int idade, string cpf, bool recuperação, string datanasc)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.CPF = cpf;
        this.Recuperação = recuperação;
        this.DataNasc = datanasc;
    }

    public void Faltou()
    {
        Faltas += 1;
    }



    public int GetFaltas()
    {
        return Faltas;
    }



    public void SetNota(int n1, int n2)
    {
        this.Nota1 = n1;
        this.Nota2 = n2;
    }



    public string Reprovou()
    {
        if ((Nota1 + Nota2)/2 < 7)
        {
            return "Reprovou!!";
        }
        else
        {
            return "Não Reprovou!";
        }
    }





}