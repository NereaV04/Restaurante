using Models;

public class Combo : Producto {

    public PlatoPrincipal PlatoPrincipal {get; set;}
    public Bebida Bebida {get; set;}
    public Postre? Postre {get; set;}
    public Producto? Extra {get; set;}
    // Si no tiene setter no se puede modificar.
    public decimal Descuento {get; set;} = 20.0m;
    public decimal Precio
    {
        get
        {
            return CalcularPrecio();
        }
    }
    
    public Combo(string _nombre, PlatoPrincipal _platoPrincipal, Bebida _bebida, Postre _postre) : base(_nombre, 0, [""])
    {
        PlatoPrincipal = _platoPrincipal;
        Bebida = _bebida;
        Postre = _postre;
        base.Precio = this.CalcularPrecio();
    }

    public override decimal CalcularPrecio()
    {
        // Si estoy seguro de que un valor nullable va a tener un valor; postr!.Price
        decimal precio = (PlatoPrincipal.Precio <= 0 ? 0 : PlatoPrincipal.Precio) + (Bebida.Precio <= 0 ? 0 : Bebida.Precio) + (Postre?.Precio ?? 0);
        return precio;
    }

    public decimal PrecioConDescuento()
    {
        return Precio - (Precio * Descuento / 100);
    }
}