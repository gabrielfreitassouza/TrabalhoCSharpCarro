namespace TrabalhoCSharp.veiculos;

public class Onibus : Carro
{
    public Onibus(string marca, string modelo, int quantidadeAssentos) : base(marca, modelo)
    {
        QuantidadeAssentos = quantidadeAssentos;
        VelocidadeMaxima = 140;
    }
    public int QuantidadeAssentos {get;}
}