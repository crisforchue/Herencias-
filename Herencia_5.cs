public class Persona
{
    public string Nombre { get; set; }
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}.");
    }
}

public class Estudiante : Persona
{
    public void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando.");
    }
}

public class Profesor : Persona
{
    public void Ensenar()
    {
        Console.WriteLine($"{Nombre} está enseñando.");
    }
}
