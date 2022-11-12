namespace TrabalhoCSharp.teste;
using veiculos;

public class OnibusTeste
{     
       public static void testeOnibus()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("CLASSE ONIBUS TESTES");
            Console.WriteLine("==========================================================");
            Onibus onibus1 = new Onibus("Mercedes-Benz","OF",78);
            Console.WriteLine($"Marca do onibus: {onibus1.Marca} \n" +
                              $"Modelo do onibus: {onibus1.Modelo} \n" +
                              $"Onibus ligado: {onibus1.Ligado} \n" +
                              $"Onibus quantidade de acessentos : {onibus1.QuantidadeAssentos} \n"+
                              $"Velocidade atual: {onibus1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Ligar e Desligar:");
            onibus1.Desligar();
            Console.WriteLine($"Onibus ligado: {onibus1.Ligado}");
            onibus1.Ligar();
            Console.WriteLine($"Onibus ligado: {onibus1.Ligado}");
            onibus1.Ligar();
            Console.WriteLine($"Onibus ligado: {onibus1.Ligado}");
            onibus1.Desligar();
            Console.WriteLine($"Onibus ligado: {onibus1.Ligado}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Teste métado Acelerar,Parar, Desacelerar:");
           onibus1.Acelerar();
            Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
           onibus1.Desacelerar();
           Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
           onibus1.Ligar();
           onibus1.Acelerar();
           Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
           onibus1.Desacelerar();
           Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
            for (int x = 0; x < 10; x++)
            {
               onibus1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
           onibus1.Parar();
           Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
            for (int x = 0; x < 3; x++)
            {
               onibus1.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
           onibus1.Desligar();
           Console.WriteLine($"Velocidade atual: {onibus1.VelocidadeGet()}");
            Console.WriteLine("---------------------------------------------------------");
        }
            
}