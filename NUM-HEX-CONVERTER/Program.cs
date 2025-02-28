using System;
using System.IO;

class ConversorHexCompleto
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CONVERSOR HEXADECIMAL/NUMERAL ===");
            Console.WriteLine("1 - Hexadecimal para Numeral");
            Console.WriteLine("2 - Numeral para Hexadecimal");
            Console.WriteLine("3 - Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExecutarConversaoHexParaDecimal();
                    break;
                case "2":
                    ExecutarConversaoDecimalParaHex();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ExecutarConversaoHexParaDecimal()
    {
        try
        {
            Console.Write("\nInserir nome do colaborador: ");
            string nome = Console.ReadLine().Trim();

            Console.Write("Digite o valor hexadecimal (com ou sem 0x): ");
            string hex = Console.ReadLine().Trim().ToUpper().Replace("0X", "");

            ulong decimalValue = Convert.ToUInt64(hex, 16);
            string resultado = $"{nome} - {decimalValue} - 0x{hex}";

            SalvarResultado(resultado);
            ExibirResultado(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ExecutarConversaoDecimalParaHex()
    {
        try
        {
            Console.Write("\nInserir nome do colaborador: ");
            string nome = Console.ReadLine().Trim();

            Console.Write("Digite o valor numeral: ");
            ulong numero = ulong.Parse(Console.ReadLine());

            string hex = "0x" + numero.ToString("X");
            string resultado = $"{nome} - {numero} - {hex}";

            SalvarResultado(resultado);
            ExibirResultado(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ExibirResultado(string resultado)
    {
        Console.WriteLine("\n=== RESULTADO ===");
        Console.WriteLine("COLABORADOR   -   NUMERAL   -   HEXADECIMAL");
        Console.WriteLine(resultado);
    }

    static void SalvarResultado(string texto)
    {
        try
        {
            string caminhoArquivo = "log_conversoes.txt";
            string registro = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {texto}";

            File.AppendAllText(caminhoArquivo, registro + Environment.NewLine);
            Console.WriteLine($"\nLog salvo em: {Path.GetFullPath(caminhoArquivo)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar arquivo: {ex.Message}");
        }
    }
}