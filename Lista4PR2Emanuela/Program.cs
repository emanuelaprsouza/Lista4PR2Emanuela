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

          // Console.WriteLine("Não é possivel fazer a atribuição destas variaveis de maneira direta, antes precisamos usar o comando 'nome da variavel que deseja converter.Parse(Console.ReadLine());'");

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

            //console.writeline("digite um número inteiro ");

            //num = int.parse(console.readline());


            //if (((num % 3) == 0) && ((num % 5) == 0) && ((num % 10) == 0)){
            //    console.writeline("seu número é divisel por 3,5,10");

            //}else if( ((num % 3) == 0) && ((num % 5) == 0))
            //{
            //    console.writeline("seu número é divisel por 3,5");

            //} else if ((num % 3) == 0)
            //{
            //    console.writeline("seu número é divisel por 3");

            //}
           // else if ((num % 5) == 0)
           // {
              //  console.writeline("seu número é divisel por 5");
           // }
           // else
             // console.writeline("não é divisivel ");

            //console.readkey();

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 7

                           //  float tempo, km;

                         //     Console.WriteLine("qual o km da sua casa? :");
                        //    km = float.Parse(Console.ReadLine());

                      //     if (km <= 12 && km >= 0)
                     //     {
                    //    tempo = 14 + 17 + 13 + 15 + 12;
                   //     Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                  //   }

                //     else if (km <= 29 && km > 12)
                 //   {
                //     tempo = 17 + 13 + 15 + 12;
               //     Console.WriteLine("voce ira demorar: " + tempo + " minutos");
              // }
             // else if (km <= 55 && km > 29)
            //  {
             //       tempo = 13 + 15 + 12;
            //       Console.WriteLine("voce ira demorar: " + tempo + " minutos");
           //   }
          //  else if (km <= 82 && km > 55)
           //   {
          //   tempo = 15 + 12;
                    //    Console.WriteLine("voce ira demorar: " + tempo + " minutos");
                  //  }
                  //  else if (km <= 100 && km > 82)
                  //  {
                   //     tempo = 12;
                    //    Console.WriteLine("voce ira demorar: " + tempo + " minutos");

                   // }

                   // Console.ReadKey();


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 8

                   // int marca, quant;
                   // double valor, custo, custot, imposto, ll;

                  //  Console.WriteLine("1- Royal \n 2- Wiskas \n 3- Golden \n 4- Nutrien \n 5- Specialcat \n 6- Marba \n 7- Gatus \n  Digite o numero do produto desejado: ");
                  //  marca = int.Parse(Console.ReadLine());
                 //   Console.WriteLine("Digite a quantidade");
                 //   quant = int.Parse(Console.ReadLine());

                 //   switch (marca)
                 //   {
                    //    case 1:
                   //         valor = 129.50 * quant;
                      //      custo = valor * 0.775;
                        //    custot = valor - custo;
                         //   imposto = custot * 0.33;
                         //   ll = ((valor - custo) - imposto);

                           // Console.WriteLine("O lucro liquido é de: R$" + ll);
                           // break;

                       // case 2:
                        //    valor = 182.78 * quant;
                        //    custo = valor * 0.897;
                        //    custot = valor - custo;
                       //     imposto = custot * 0.275;
                       //     ll = (valor - custo) - imposto;

                           // Console.WriteLine("O lucro liquido é de: R$" + ll);
                         //   break;

                     //   case 3:
                      //      valor = 159.46 * quant;
                       //     custo = valor * 0.717;
                        //    custot = valor - custo;
                        //    imposto = custot * 0.225;
                         //   ll = (valor - custo) - imposto;
                         //  Console.WriteLine("O lucro liquido é de: R$" + ll);
                            //break;

                       // case 4:
                       //     valor = 144.80 * quant;
                       //     custo = valor * 0.889;
                      //      custot = valor - custo;
                      //      imposto = custot * 0.25;
                      //      ll = (valor - custo) - imposto;

                           // Console.WriteLine("O lucro liquido é de: R$" + ll);
                          //  break;

                       // case 5:
                       //     valor = 205.40 * quant;
                       //     custo = valor * 0.8324;
                       //     custot = valor - custo;
                        //    imposto = custot * 0.22;
                         //   ll = (valor - custo) - imposto;

                         //   Console.WriteLine("O lucro liquido é de: R$" + ll);
                         //   break;

                     //   case 6:
                        //    valor = 125.10 * quant;
                         //   custo = valor * 0.904;
                         //   custot = valor - custo;
                          //  imposto = custot * 0.179;
                           // ll = (valor - custo) - imposto;

                          //  Console.WriteLine("O lucro liquido é de: R$" + ll);
                        //    break;

                      //  case 7:
                      //      valor = 133.99 * quant;
                       //     custo = valor * 0.946;
                       //     custot = valor - custo;
                        //    imposto = custot * 0.20;
                        //    ll = (valor - custo) - imposto;

                       //     Console.WriteLine("O lucro liquido é de: R$" + ll);
                        //    break;
                //    }
                    

                   // break;

               // default:
              //      Console.WriteLine("opção invalida!");
               //     break;

            //Console.ReadKey();


        }
    }
}
