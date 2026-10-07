
namespace Models;

public class Bebida : Producto
{
    public bool IsAlcoholica {get;set;}
    public Bebida(string _nombre, decimal _precio, List<string> _ingredientes, bool _isAlcoholica) : base(_nombre, _precio, _ingredientes)
    {
        IsAlcoholica = _isAlcoholica;
    }

    public void ShowDescription()
    {
        Console.WriteLine(GetDescription() + (IsAlcoholica ? " - Es alcohólica." : " - No es alcohólica."));
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}