using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2Emanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 1

            // Essa Afirmativa é falsa,pois não teria como atribuir um número com casa decimal em uma variavel de número inteiro ou atribuição inversa.

            // int b1,;

            // Console.WriteLine("Digite o valor da base: ");
            // b1 = int.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 2

            //ReadLine() Retorna o valor da linha inteira
            //Console.Read() retorna o VALOR ASCII(Código Padrão Americano para o Intercâmbio de Informação) do primeiro caractere digitado.
            //Vai ser sempre o mesmo

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 3

            //Precisamos saber se o numero na variavel int é inteiro,se o numero for float esse numero precisa ser decimal e double comporta mais casas decimais que o float.

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 4 

            //int num, num2, num3;

            //Console.WriteLine("Entre com um numero: ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");

            //Console.ReadKey();

            //O objetivo é que se o num3 for 0 e maior que 10 o programa irá mostrar Mensagem 1, mesmo se der "0,56",porque a variavel é int então so irá mostrar o número antes da vírgula.
            //Se você entrar com o número 8,a saída será: mensagem 2 ,E se entrar com 27 a saída sera:Mensagem 2, E se entrar com 28 a saída será: mensagem 1 

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 5 

            //float acel, velini,inst,velt;
            //Console.WriteLine("Qual a aceleração ? ");
            //acel = float.Parse(Console.ReadLine());

            //Console.WriteLine("Qual a velocidade inicial ? ");
            //velini = float.Parse(Console.ReadLine());

            //Console.WriteLine("Me fale um instante qualquer ? ");
            //inst = float.Parse(Console.ReadLine());

            //velt = velini + acel * inst;

            //Console.WriteLine("A sua velocidade é " + velt);
            //Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 6

            //int num;

            //Console.WriteLine("Digite um número inteiro ");

            //num = int.Parse(Console.ReadLine());


            //if (((num % 3) == 0) && ((num % 5) == 0) && ((num % 10) == 0)){
            //    Console.WriteLine("Seu número é divisel por 3,5,10");

            //}else if( ((num % 3) == 0) && ((num % 5) == 0))
            //{
            //    Console.WriteLine("Seu número é divisel por 3,5");

            //} else if ((num % 3) == 0)
            //{
            //    Console.WriteLine("Seu número é divisel por 3");

            //}
            //else if ((num % 5) == 0)
            //{
            //    Console.WriteLine("Seu número é divisel por 5");
            //}
            //else
            //    Console.WriteLine("Não é divisivel ");

            //Console.ReadKey();

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 7



            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 8

            float pra, raca, compra,luli;

            Console.WriteLine("quantos pacotes de ração: ");
            pra = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a marca de ração de sua escolha: ");

            Console.WriteLine("==========MENU==========");
            Console.WriteLine("ROYAL");
            Console.WriteLine("WISKAS");
            Console.WriteLine("GOLDEN");
            Console.WriteLine("NUTRIEN");
            Console.WriteLine("SPECIALCAT");
            Console.WriteLine("MARBA");
            Console.WriteLine("GATUS");
            Console.WriteLine("=======================");

           raca  = float.Parse(Console.ReadLine());

            switch (raca)
            {
                case 1: compra = pra * 129.50;
                    luli = ((compra - (77.5 / 100) - 33 / 100);
                        Console.WriteLine("O total da sua compra é:" + compra "E o lucro líquido é: " + luli);
                        
            }





        }
    }
}
