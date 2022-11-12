using TrabalhoCSharp.teste;

namespace TrabalhoCSharp
{
    class Program
    {
        public static void Main()
        {   
            string? input;
            int op;
            Console.Clear();
            Console.WriteLine("==================");
            Console.WriteLine(" Menu de Teste");
            Console.WriteLine("==================");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Onibus");
            Console.WriteLine("3 - Suv");
            Console.WriteLine("0 - Sair");
            Console.Write("-> ");
            input = Console.ReadLine();
            Int32.TryParse(input, out op);
            switch(op)
            {   
                case 0:
                    break;
                case 1: 
                    Console.Clear();
                    CarroTeste.testeCarro();
                    Console.ReadLine();
                    Main();
                    break;
                case 2:
                    Console.Clear();
                    OnibusTeste.testeOnibus();
                    Console.ReadLine();
                    Main();
                    break;
                case 3:
                    Console.Clear();
                    SuvTeste.testeSuv();
                    Console.ReadLine();
                    Main();
                    break;
                default:
                    Console.WriteLine("Opção Invalida!!!");
                    Console.ReadLine();
                    Main();
                    break;
            }
        }
    }
}


