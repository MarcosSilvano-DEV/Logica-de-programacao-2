using System;

namespace Lógica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR AS VÁRIAVEIS
            float nota1, nota2, nota3, media;
            string nomeCommpleto;

            //ENTRADA DE DADOS
            Console.Write("Digite o nome do aluno: ");
            nomeCommpleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //PROCESSAMENTO
            media = (nota1+nota2+nota3)/3;

            //EXIBIR O RESULTADO
            if(media>5){
                Console.WriteLine("O aluno "+nomeCommpleto+" está APROVADO com a média de: "+media);
            }
            else{
                Console.WriteLine("O aluno "+nomeCommpleto+" está REPROVADO com a média de: "+media);
            }

        }
    }
}
