public class Vehiculo
{
    public string Marca { get; set; }
    public void Conducir()
    {
        Console.WriteLine($"{Marca} está conduciendo.");
    }
}

public class Coche : Vehiculo
{
    public void TocarBocina()
    {
        Console.WriteLine($"El coche {Marca} toca la bocina.");
    }
}


public class Bicicleta : Vehiculo
{
    public void TocarCampana()
    {
        Console.WriteLine($"La bicicleta {Marca} está tocando la campana.");
    }
}
