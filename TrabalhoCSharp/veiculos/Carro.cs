namespace TrabalhoCSharp.veiculos;

public class Carro
{
    public Carro(string marca, string modelo)
    {
        Ligado = false;
        Marca = marca;
        Modelo = modelo;
        Velocidade = 0;
        VelocidadeMaxima = 180;
    }
    

    public bool Ligado { get; private set; }
    public string Marca { get;}
    public string Modelo { get;}
    private int Velocidade {get; set;}
    
    protected int VelocidadeMaxima { get; set; }

    public void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
        }
    }

    public void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Velocidade = 0;
        }
    }
    
    public void Acelerar()
    {
        if (Velocidade >= 0 && Velocidade < VelocidadeMaxima && Ligado)
        {
            Velocidade += 20;
        }
    }

    public void Desacelerar()
    {
        if (Velocidade > 0 && Ligado)
        {
            Velocidade -= 20;
        }
    }

    public void Parar()
    {
        if (Ligado)
        {
            Velocidade = 0;
        }
    }

    public int VelocidadeGet()
    {
        return Velocidade;
    }
}