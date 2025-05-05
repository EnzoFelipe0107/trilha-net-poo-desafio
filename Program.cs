using DesafioPOO.Models;
{
    {
        Smartphone nokia = new Nokia("12345", "Nokia g60", "88888888888889", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine($"Número do Nokia: {nokia.Numero}");
        Console.WriteLine($"Modelo do Nokia: {nokia.Modelo}");
        Console.WriteLine($"IMEI do Nokia: {nokia.IMEI}");
        Console.WriteLine($"Memória do Nokia: {nokia.Memoria}GB");
        Console.WriteLine("\n");


        Console.WriteLine("Testes adicionais com Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
        Console.WriteLine($"Memória do Nokia antes da instalação de um novo app: {nokia.Memoria}GB");


        Console.WriteLine("\n"); // Adiciona uma linha em branco para separar a saída.

        // Exemplo de uso da classe Iphone
        Smartphone iphone = new iphone("67890", "Iphone 14", "55555555959", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine($"Número do Iphone: {iphone.Numero}");
        Console.WriteLine($"Modelo do Iphone: {iphone.Modelo}");
        Console.WriteLine($"IMEI do Iphone: {iphone.IMEI}");
        Console.WriteLine($"Memória do Iphone: {iphone.Memoria}GB");

        Console.WriteLine("\n");
        Console.WriteLine("Testes adicionais com Iphone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
        Console.WriteLine($"Memória do Iphone antes da instalação de um novo app: {iphone.Memoria}GB");


        Console.ReadKey();
    }
}
