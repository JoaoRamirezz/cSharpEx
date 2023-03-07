public class Calculadora
{
    public int Soma(int A, int B)
    {
        return A+B;
    }


    public int Multiplicao(int A, int B)
    {
        return A*B;
    }


    public int Subtracao(int A, int B)
    {
        return A - B;
    }


    public int Divisao(int A, int B)
    {
        return A/B;
    }


    public int Pow(int A, int B)
    {
        int result = A;
        
        for (int i = 1; i < B; i++)
            result *= B;


        return result;
    }
}