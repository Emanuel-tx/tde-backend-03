decimal saldo = 1000.0m;
Console.WriteLine("Bem vindo ao caixa eletronico da ADS!");
int opcao = 0;
// decimal valor = 0;
do
{
    Console.WriteLine("1: ver saldo\n2: Depositar \n3: Sacar \n4: Sair");
opcao = int.Parse(Console.ReadLine());
switch(opcao)
{
    case 1:
    Console.WriteLine($"Saldo disponivel: R${saldo:F2}");
    break;
    case 2:
    Console.WriteLine("informe o valor que deseja depositar:");
    decimal deposito = Convert.ToDecimal(Console.ReadLine());
    saldo += deposito;
    Console.WriteLine($"Saldo atual: {saldo:F2}");
    break;
    case 3:
    Console.WriteLine("Digite o valor que queira sacar:");
    decimal saque = decimal.Parse(Console.ReadLine());
    saldo -= saque;
    break;
    case 4:
    Console.WriteLine("muito obrigado por utilizar nossos serviços!");
    break;
    default:
    Console.WriteLine("favor digitar uma opção válida");
    break;
}
}while(opcao != 4);
