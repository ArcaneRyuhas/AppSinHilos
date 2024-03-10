namespace AppSinHilos;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Mario Morales Portilla: Desarrollo de sistemas en red.");
        DoTrabajoPesado();
        DoAlgo();

        Console.WriteLine("El hilo principal termina aquí.");
        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.ReadKey(true);
    }

    public static void DoTrabajoPesado()
    {
        Console.WriteLine("DoTrabajoPesado: Estoy levantando un camion!");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Cansado! necesito una siesta de 3 segundos...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 1...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3...");
        Console.WriteLine("DoTrabajoPesado: Ya he despertado.");
    }

    public static void DoAlgo()
    {
        Console.WriteLine("DoAlgo: Oye! Haciendo algo aquí!");
        
        for (int iterator = 0; iterator < 20; iterator++)
        {
            Console.WriteLine($"{iterator}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Ya terminé!");
    }
}
