
namespace Models;

public class Entrante : Producto
{
    public int NumPersonas {get; set;}
    public bool IsFrio {get; set;}
    public Entrante(string _nombre, decimal _precio, int _numPersonas, bool _isFrio) : base(_nombre, _precio, [""])
    {
        NumPersonas = _numPersonas;
        IsFrio = _isFrio;
    }

    public void ObtenerDescripcion()
    {
        Console.WriteLine($"{GetDescription()} - Num.Personas: {NumPersonas} - {(IsFrio ? "Servido frío" : "Servido caliente")}");
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}