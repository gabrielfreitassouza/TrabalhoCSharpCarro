namespace TrabalhoCSharp.teste;
using veiculos;

public class SuvTeste
{
           public static void testeSuv()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("CLASSE SUV TESTES");
            Console.WriteLine("==========================================================");
            Suv suv1 = new Suv("Troller","T4","4x4");
            Console.WriteLine($"Marca do suv: {suv1.Marca} \n" +
                              $"Modelo do suv: {suv1.Modelo} \n" +
                              $"Suv ligado: {suv1.Ligado} \n" +
                              $"Suv tração : {suv1.Tracao} \n"+
                              $"Velocidade atual: {suv1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Ligar e Desligar:");
            suv1.Desligar();
            Console.WriteLine($"suv ligado: {suv1.Ligado}");
            suv1.Ligar();
            Console.WriteLine($"suv ligado: {suv1.Ligado}");
            suv1.Ligar();
            Console.WriteLine($"suv ligado: {suv1.Ligado}");
            suv1.Desligar();
            Console.WriteLine($"suv ligado: {suv1.Ligado}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Acelerar,Parar, Desacelerar:");
           suv1.Acelerar();
            Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
           suv1.Desacelerar();
           Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
           suv1.Ligar();
           suv1.Acelerar();
           Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
           suv1.Desacelerar();
           Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
            for (int x = 0; x < 15; x++)
            {
               suv1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
           suv1.Parar();
           Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
            for (int x = 0; x < 7; x++)
            {
               suv1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
           suv1.Desligar();
           Console.WriteLine($"Velocidade atual: {suv1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
        }
}