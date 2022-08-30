using System;

namespace Licao29_08IBM {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite quantos jogos serão feitos: ");
            int jogos = int.Parse(Console.ReadLine());

            for (int i = 0; i < jogos; i++) {

                Console.WriteLine("Digite pedra, papel ou ataque: ");
                string jogador1 = (Console.ReadLine());
                Console.WriteLine("Digite pedra, papel ou ataque: ");
                string jogador2 = (Console.ReadLine());
                Console.WriteLine("Resultado: ");
                
                if (jogador1.Equals("ataque") && jogador2.Equals("ataque")) Console.WriteLine("Aniquilacao mutua");
                else if (jogador1.Equals("papel") && jogador2.Equals("papel")) Console.WriteLine("Ambos venceram");
                else if (jogador1.Equals("ataque")) Console.WriteLine("Jogador 1 venceu");
                else if (jogador2.Equals("ataque")) Console.WriteLine("Jogador 2 venceu");
                else if (jogador2.Equals("papel")) Console.WriteLine("Jogador 1 venceu");
                else if (jogador1.Equals("papel")) Console.WriteLine("Jogador 2 venceu");
                else Console.WriteLine("Sem ganhador");
            }
        }
    }
}