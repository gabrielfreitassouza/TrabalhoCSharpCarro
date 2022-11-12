namespace TrabalhoCSharp.teste;
using veiculos;
public class CarroTeste
{
       public static void testeCarro()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("CLASSE CARRO TESTES");
            Console.WriteLine("==========================================================");
            Carro carro1 = new Carro("BMW","i4");
            Console.WriteLine($"Marca do carro: {carro1.Marca} \n" +
                              $"Modelo do carro: {carro1.Modelo} \n" +
                              $"Carro ligado: {carro1.Ligado}\n" +
                              $"Velocidade atual: {carro1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Ligar e Desligar:");
            carro1.Desligar();
            Console.WriteLine($"Carro ligado: {carro1.Ligado}");
            carro1.Ligar();
            Console.WriteLine($"Carro ligado: {carro1.Ligado}");
            carro1.Ligar();
            Console.WriteLine($"Carro ligado: {carro1.Ligado}");
            carro1.Desligar();
            Console.WriteLine($"Carro ligado: {carro1.Ligado}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Acelerar,Parar, Desacelerar:");
            carro1.Acelerar();
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            carro1.Desacelerar();
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            carro1.Ligar();
            carro1.Acelerar();
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            carro1.Desacelerar();
            Console.WriteLine($"Velocidade atual:  {carro1.VelocidadeGet()}");
            for (int x = 0; x < 10; x++)
            {
                carro1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            carro1.Parar();
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            for (int x = 0; x < 5; x++)
            {
                carro1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            carro1.Desligar();
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
        }
}