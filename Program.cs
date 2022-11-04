// See https://aka.ms/new-console-template for more information

using projeto_paralelo;

Console.WriteLine(@$"
******************************************************************
******************************************************************
*                                                                *
*       Seja bem-Vindo ao sistema de controle financieiro        *
*                                                                *
******************************************************************
******************************************************************
");

List<Corrente> listaCC = new List<Corrente>();

BarraCarregamento("Carregando", 200);

Console.Clear();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
******************************************************************
******************************************************************
*                                                                *
*                Escolha uma das opções a seguir:                *
*                                                                *
*                          1. Conta Corrente                     *
*                          2. Conta Poupança                     *
*                          0. Sair                               *
*                                                                *
******************************************************************
******************************************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            string opcaoCC;
            do
            {
                Console.Clear();
                    Console.WriteLine(@$"
******************************************************************
******************************************************************
*                Escolha uma das opções a seguir:                *
*                                                                *
*                          1. Cadastrar Conta Corrente           *
*                          2. Mostrar Conta Corrente             *
*                          0. Voltar ao Menu Anterior            *
*                                                                *
******************************************************************
******************************************************************
");
            opcaoCC = Console.ReadLine();

            switch (opcaoCC)
            {
                case "1":
                    Console.WriteLine($"Digite o número da Conta Corrente: ");
                    string numero = Console.ReadLine();

                    Console.WriteLine($"Digite o número da Agencia: ");
                    string agencia = Console.ReadLine();

                    Console.WriteLine($"Digite o Limite: ");
                    double limite = Double.Parse(Console.ReadLine());
                    

                    Corrente obj_cc = new Corrente(numero, agencia, limite);

                    listaCC.Add(obj_cc);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso!!");
                    Console.ResetColor();

                    Console.WriteLine($"Aperte enter para continuar");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    if (listaCC.Count > 0){
                        foreach(Corrente cadaCC in listaCC){
                            Console.Clear();
                            Console.WriteLine($"{cadaCC.ToString()}");
                            Console.WriteLine($"Aperte ENTER para continuar");
                            Console.ReadLine();
                        }
                    }
                    else{
                        Console.WriteLine($"A lista está vazia!");
                        Thread.Sleep(3000);
                    }
                    //Console.WriteLine($"{obj_cc.ToString()}");
                    break;
                case "0":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Opção Invalida, por favor digite outra opção. ");
                    Thread.Sleep(3000);
                    break;
            }           

            } while (opcaoCC != "0");                           
            
            break;
        case "2":
            Poupanca obj_cpp = new Poupanca("1010-0", "1978", 3);
            Console.WriteLine($"{obj_cpp.ToString()}");
            Console.WriteLine($"Aperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
            break;
        case "0":
            Console.WriteLine(@$"Você entrou na oção 0");
            break;

        default:
            Console.Clear();
            Console.WriteLine(@$"Opção invalida, por favor digite outra opção");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"texto");

    Console.Write("Carregando ");
    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(".   ");
        Thread.Sleep(500);
    }
    Console.ResetColor();
}




/*
// Primeiro objeto de conta corrente
Conta obj_conta = new Conta("7800-8", "8898");

//obj_conta.agencia = "7800-8";
//obj_conta.agencia = "7800-8";
//obj_conta.setNumero("8898");
//obj_conta.saldo = 1000;
//obj_conta.setSaldo(1000);

Console.WriteLine($"Agencia: {obj_conta.agencia}");
Console.WriteLine($"Numero: {obj_conta.numero}");
Console.WriteLine($"Numero: {obj_conta.getSaldo()}");


Corrente obj_cc = new Corrente("3030-0", "988", 101);
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"**************************");
Console.WriteLine($"{obj_cc.Depositar(100)}");
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"**************************");
Console.WriteLine($"{obj_cc.Sacar(200)}");
Console.WriteLine($"{obj_cc.ToString()}");


//obj_cc.Depositar(100);


string ret;
ret = obj_cc.ToString();
Console.WriteLine($"{ret}");
*/

