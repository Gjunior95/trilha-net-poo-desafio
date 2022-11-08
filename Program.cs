using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("(99)-99999-9999", "14 Pro-Max", "123456", 256);
        Smartphone nokia = new Nokia("(99)-99999-9999", "3310", "78910", 1);

        iphone.Ligar();
        iphone.InstalarAplicativo("whatsapp");
                
        Console.WriteLine("\n");

        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("snake");
    }
}


// TODO: Realizar os testes com as classes Nokia e Iphone