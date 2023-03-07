public class Retangulo
{
    public int ladoA { get; set; }
    public int ladoB { get; set; }


    public Retangulo(int A, int B)
    {
        this.ladoA = A;
        this.ladoB = B;
    }


    public int CalcularArea()
    {
        return this.ladoA * this.ladoB;
    }


    public int CalcularPerimetro()
    {
        return (this.ladoA * 2) + (this.ladoB * 2);
    }
}