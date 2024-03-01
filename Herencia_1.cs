using System;

class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public virtual void Tiene4Patas()
    {
        Console.WriteLine("El animal tiene 4 patas");
    }
}

class Perro : Animal
{
    public string Raza { get; set; }

    public override void Tiene4Patas()
    {
        Console.WriteLine("El perro tiene 4 patas");
    }
}
