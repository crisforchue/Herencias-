class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Profesor : Persona
{
    public string Especializacion { get; set; }
}

class Program
{
    static void Main()
    {
        var profesorJohn = new Profesor
        {
            Nombre = "John Doe",
            Edad = 40,
            Especializacion = "Matemáticas"
        };