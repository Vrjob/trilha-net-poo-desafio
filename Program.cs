using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando o Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia X1", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando o iPhone
        Smartphone iphone = new Iphone(numero: "7891011", modelo: "iPhone 14", imei: "222222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
