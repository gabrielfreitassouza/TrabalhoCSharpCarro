namespace TrabalhoCSharp.veiculos;

public class Suv : Carro
{
    public Suv(string marca, string modelo, string tracao) : base(marca, modelo)
    {
        Tracao = tracao;
        VelocidadeMaxima = 220;
    }
    public string Tracao { get;}
}