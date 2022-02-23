using System;

namespace ProgramaçãoEstruturada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int[] numeros = new int[10];
            int soma = 0;
            int maiorNumero = numeros[0];
            int segundoMaiorValor = numeros[0];
            int terceiroMaiorValor = numeros[0];
            int menorNumero = numeros[0];


            Leearmazenanumeros(aux, numeros);


            Console.WriteLine(CalculaoMaiornumero(numeros, ref maiorNumero));


            Console.WriteLine(CalculaoMenornumero (numeros, out menorNumero));


            Console.WriteLine(CalculaMediadaSequencia(numeros, soma));

            EncontraOs3MaioresValores(numeros, maiorNumero, ref segundoMaiorValor, ref terceiroMaiorValor);

            EncontraNumerosNegativos(numeros);

            Console.WriteLine("Valores da sequência: ");
            EncontraOsValores(numeros);

            RemoveUmValorDaSequencia(numeros);
        }

        private static void EncontraOs3MaioresValores(int[] numeros, int maiorNumero, ref int segundoMaiorValor, ref int terceiroMaiorValor)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > segundoMaiorValor && numeros[i] < maiorNumero)
                {
                    segundoMaiorValor = numeros[i];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > terceiroMaiorValor && numeros[i] < maiorNumero && numeros[i] < segundoMaiorValor)
                {
                    terceiroMaiorValor = numeros[i];
                }
            }

            Console.WriteLine("Maior valor " + maiorNumero);
            Console.WriteLine("O segundo maior valor é " + segundoMaiorValor);
            Console.WriteLine("O terceiro maior valor é " + terceiroMaiorValor);
        }

        private static void RemoveUmValorDaSequencia(int[] numeros)
        {
            Console.WriteLine("Digite a posição da sequencia (entre 0 e 9) que você deseja remover: ");
            int indiceRemovido = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (indiceRemovido < 0 || indiceRemovido > 9)
            {
                Console.WriteLine("Este indice não existe!");
            }
            else
            {
                Console.WriteLine("Nova sequência:");
                for (int i = 0; i < 10; i++)
                {
                    if (i != indiceRemovido)
                    {
                        Console.WriteLine(numeros[i]);
                    }
                }
            }
        }

        private static void EncontraOsValores(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        private static void EncontraNumerosNegativos(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("O número " + numeros[i] + " é negativo.");
                }
            }
        }

        private static int CalculaMediadaSequencia (int[] numeros, int soma)

        {
            for (int i = 0; i < 10; i++)
            {
                soma = soma + numeros[i];
            }

            int mediaDaSequencia = soma / 10;

            return mediaDaSequencia;
        }        
       
        private static int CalculaoMenornumero(int[] numeros, out int menorNumero)
        {
            menorNumero = numeros[0];
            for (int i = 0; i < 10; i++)
            {               
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }                               
            }
            return menorNumero;
        }

        private static int CalculaoMaiornumero(int[] numeros, ref int maiorNumero)
        {            
            for (int i = 0; i < 10; i++)
            {
                
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];                    
                }                        
            }
            return maiorNumero;            
        }

        private static void Leearmazenanumeros(int aux, int[] numeros)
        {
            
            for (int i = 0; i < 10; i++)
            {
                aux = i + 1;
                Console.WriteLine("Digite o número " + aux + " :");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
