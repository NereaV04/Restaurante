// See https://aka.ms/new-console-template for more information
using Models;

Console.WriteLine("Hello, World!");

Producto platoPrincipal1 = new PlatoPrincipal("Pizza", 12, ["Tomate", "Queso"]);
platoPrincipal1.ShowDescription();

Producto bebida1 = new Bebida("CocaCola", 8.5m, ["Cafeina", "Limón"], false);
bebida1.ShowDescription();

Postre postre1 = new Postre("Tarta de queso", 12.45m, ["Leche", "Queso", "Huevos"], 300m, false);
postre1.ShowDescription();

// Producto producto1 = new Producto("Producto", 15m, ["Lechuga", "Carne"]);

List<Producto> combo = new ();
combo.Add(platoPrincipal1);
combo.Add(bebida1);
combo.Add(postre1);

foreach (var producto in combo)
{
    Console.WriteLine(producto);
    Console.WriteLine(producto.Name + " - " + producto.Price);
    producto.ShowDescription();
}


Combo combo1 = new Combo("Menú del día", (PlatoPrincipal)platoPrincipal1, (Bebida)bebida1, postre1);

Console.WriteLine($"El precio total del menú es; {combo1.CalcularPrecio()}");
Console.WriteLine($"El precio {combo1.CalcularPrecio()} con el 10% de descuento aplicado es {combo1.PrecioConDescuento():F2}.");

if (combo1.PlatoPrincipal is PlatoPrincipal)
{
    Console.WriteLine("Esto es un Plato Principal dentro de un combo.");
}