using System;

namespace produtos_organizar_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            int opção;
            string[] qualProduto = new string[100];
            float[] preçoProduto = new float[100];
            bool[] desconto = new bool[100];
            string cadastrasMais;
            int contador = 0;
            string resposta;

            Console.WriteLine("");
            Console.WriteLine("Bem vindo ao mercado esperança!!!");

            do
            {

                Console.WriteLine($@"
            ||=========================||
            ||== OQUE DESEJA FAZER?? ==||
            ||=========================||
            ||   1- Cadastrar produto  ||
            ||   2- Listar produto     ||
            ||   3- Sair               ||
            ||                         ||
            ||=========================||
            ");
                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Qual é o produto que deja cadastrar?: ");
                            qualProduto[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o preço a cadastrar: ");
                            preçoProduto[contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine("Gostaria de receber desconto? ( Sim  || Não )");
                            string descontoo = Console.ReadLine().ToUpper();
                            if (descontoo == "Sim")
                            {
                                desconto[contador] = true;
                            }
                            else
                            {
                                desconto[contador] = false;
                            }

                            Console.WriteLine("Gostaria de adicionar mais produtos? ( Sim || Não)");
                            cadastrasMais = Console.ReadLine();
                            contador++;

                        } while (cadastrasMais == "Sim");

                        break;

                    case 2:

                        Console.WriteLine("Aqui está os produtos listados!!!");

                        for (int i = 0; i < contador; i++)
                        {
                            if (qualProduto[i] != null)
                            {

                                Console.Write($@"
            ||=========================||         
            ||======== PRODUTOS =======||
            ||=========================||
            ||      Nome: {qualProduto[i]}
            ||      Preço: {preçoProduto[i]:C2}  
            ||                         ||
            ||=========================||");
                            }

                        }

                        break;

                    case 3:

                        Console.WriteLine("Entendi, obrigado pela atenção :D");

                        break;

                    default:
                        break;
                }

            } while (opção != 3);
        }
    }
}
