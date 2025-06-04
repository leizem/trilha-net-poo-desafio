using System;

namespace DesafioPOO
{
    // Classe abstrata Smartphone
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que deve ser implementado pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }

    // Classe Nokia que herda de Smartphone
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia via Nokia Store");
        }
    }

    // Classe Iphone que herda de Smartphone
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone via App Store");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Celulares - Desafio DIO POO ===\n");

            // Criando instância do Nokia
            Nokia nokia = new Nokia("11987654321", "Nokia 3310", "123456789012345", 512);
            
            Console.WriteLine("--- Nokia ---");
            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria}MB");
            
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criando instância do iPhone
            Iphone iphone = new Iphone("11912345678", "iPhone 14", "987654321098765", 256000);
            
            Console.WriteLine("--- iPhone ---");
            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria}MB");
            
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine();

            // Demonstrando polimorfismo
            Console.WriteLine("--- Demonstrando Polimorfismo ---");
            Smartphone[] smartphones = { nokia, iphone };

            foreach (Smartphone smartphone in smartphones)
            {
                Console.WriteLine($"Instalando aplicativo no {smartphone.Modelo}:");
                smartphone.InstalarAplicativo("YouTube");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}