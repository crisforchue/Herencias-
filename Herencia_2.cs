class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

class Coche : Vehiculo
{
    public Coche(string marca, string modelo) : base(marca, modelo)
    {
    }
}
