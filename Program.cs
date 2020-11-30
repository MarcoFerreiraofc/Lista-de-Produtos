using System;

namespace RegistroDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] promocaofinal = new double[10];
            double valor;
            int[] porcentagem = new int[10];
            int[] quantidade = new int[10];
            string[] vaiterpromo = new string[10];
            double[] precosprodutos = new double[10];
            string[] nomesprodutos = new string[10];
            int contador = 0;
            string opcoes;
            bool senhacerta;
            string naocadastrado;
            
            string senha;
            


            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Seja bem vindo à (Nome da Empresa)!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Aproveite as nossas promoções da BLACK FRAUDE!");
            Console.WriteLine("");

            Console.WriteLine("Você ja possui uma conta em nosso site? s/n");
            naocadastrado = Console.ReadLine();

            if(naocadastrado == "n"){
                
            }else{}

            do{
                Console.Clear();
                Console.WriteLine("LOGIN:");
                Console.WriteLine("");

                Console.Write("Digite a sua senha: ");
                senha = Console.ReadLine();
                senhacerta = Login(senha);               
            }while(!senhacerta);

            do{
                Console.WriteLine("");
                Console.WriteLine("MENU:");
                Console.WriteLine("");
                Console.WriteLine("[1] Cadastro de produtos;");
                Console.WriteLine("[2] Listagem de produtos;");
                Console.WriteLine("[3] Mostrar menu de produtos;");
                Console.WriteLine("[0] Sair.");
                opcoes = Console.ReadLine();

                switch(opcoes){
                
                    case "1":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Cadastro de produtos:");
                        Console.WriteLine("");

                        if(quantidade[contador] > 10){
                            Console.WriteLine("");
                            Console.WriteLine("Ops, o valor de produtos ultrapassou 10...");
                            Console.WriteLine("Tente novamente com uma quantidade menor que 10");
                            Console.WriteLine("");
                        }

                        if(contador < 10){
                            Console.Write($"Digite o nome do {contador+1}º produto: ");
                            nomesprodutos[contador] = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Digite o preço do produto: ");
                            precosprodutos[contador] = float.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            Console.Write("");
                            Console.WriteLine("Digite a quantidade de produtos: ");
                            quantidade[contador] = int.Parse(Console.ReadLine());

                            valor = quantidade[contador] * precosprodutos[contador];

                            Console.WriteLine("Este produto se encaixa em alguma promoção? s/n");
                            vaiterpromo[contador] = Console.ReadLine();
                            Console.Write("");

                            Console.Write("");
                            if(vaiterpromo[contador] != "s"){
                                Console.Write("");
                                Console.WriteLine("Ok, sem promoção.");
                                Console.Write("");

                                promocaofinal[contador] = valor;

                                Console.WriteLine($"Este produto(s) não está incluíso em nenhuma promoção, portanto, seu valor será de: {promocaofinal[contador].ToString("N2")} reais.");
                                Console.Write("");
                            }else{
                                Console.WriteLine("");
                                Console.WriteLine("Qaul a porcentagem da promoção? 'valores inteiros'");
                                porcentagem[contador] = int.Parse(Console.ReadLine());

                                if(quantidade[contador] <= 10){
                                    double calculoporcentagem = porcentagem[contador] / 100;
                                    double valorfinal = valor * calculoporcentagem;
                                    promocaofinal[contador] = valor - valorfinal;

                                    Console.WriteLine("");
                                    Console.WriteLine($"Com a promoção de {porcentagem[contador]}%, o valor deste produto será de: {promocaofinal[contador].ToString("N2")} reais.");
                                }
                            }
                            
                            contador++;

                        }else{
                            Console.WriteLine("");
                            Console.WriteLine("Número de produtos cadastrados foi excedido!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("O Total de produtos cadastrados nesta seção é:");
                        Console.WriteLine("");
                        for (var i = 0; i < contador; i++){
                            Console.WriteLine($"| Produto: {nomesprodutos[i]} || Preço cada: {precosprodutos[i].ToString("N2")} reais || Quantidade: {quantidade[i]} || Promoção: {vaiterpromo[i]} || Porcentagem: {porcentagem[i]}% || Valor total: {promocaofinal[i].ToString("N2")} reais |");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por comprar nas Casas da Bahia!");
                        break;

                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }

            } while (opcoes != "0");
            
            



            //Funções:
            bool Login(string senha){
                if(senha == "123"){
                    return true;
                }else{
                    Console.WriteLine("---------------");
                    Console.WriteLine("Senha inválida!");
                    Console.WriteLine("---------------");
                    return false;
                }
            }




        }
    }
}