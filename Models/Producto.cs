using System.ComponentModel.DataAnnotations;

namespace Models;

public abstract class Producto
{
    public string Nombre {get;set;}
    public decimal Precio {get;set;}
    public List<string> Ingredientes {get;set;} = new ();
    // public List<string> Alergenos {get;set;}
    // public List<string> Type {get;set;}

    public Producto (string _nombre, decimal _precio, List<string> _ingredientes)
    {
        this.Nombre = _nombre;
        this.Precio = _precio;
        this.Ingredientes = _ingredientes;
    }

    public void ShowDescription()
    {
        Console.WriteLine($"Name: {this.Nombre} - Price: {this.Precio:F2}");
    }

    public abstract decimal CalcularPrecio();
}