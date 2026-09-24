
namespace Models;

public class Postre : Producto
{
    public decimal NumCalorias {get;set;}
    public bool IsSugarFree {get;set;}
    public Postre(string _nombre, decimal _precio, List<string> _ingredientes, decimal _numCalorias, bool _isSugarFree) : base(_nombre, _precio, _ingredientes)
    {
        NumCalorias = _numCalorias;
        IsSugarFree = _isSugarFree;
    }

    public override decimal CalcularPrecio()
    {
        throw new NotImplementedException();
    }
}