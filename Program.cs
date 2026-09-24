// See https://aka.ms/new-console-template for more information
using Models;

Producto platoPrincipal1 = new PlatoPrincipal("Pizza", 12, ["Tomate", "Queso"]);
Console.WriteLine(platoPrincipal1.GetDescription());

Producto bebida1 = new Bebida("CocaCola", 8.5m, ["Cafeina", "Limón"], false);
Console.WriteLine(bebida1.GetDescription());

Postre postre1 = new Postre("Tarta de queso", 12.45m, ["Leche", "Queso", "Huevos"], 300m, false);
Console.WriteLine(postre1.GetDescription());

// Producto producto1 = new Producto("Producto", 15m, ["Lechuga", "Carne"]);

List<Producto> combo = new ();
combo.Add(platoPrincipal1);
combo.Add(bebida1);
combo.Add(postre1);

foreach (var producto in combo)
{
    Console.WriteLine(producto);
    Console.WriteLine(producto.Nombre + " - " + producto.Precio);
    Console.WriteLine(producto.GetDescription());
}


Combo combo1 = new Combo("Menú del día", (PlatoPrincipal)platoPrincipal1, (Bebida)bebida1, postre1);

Console.WriteLine($"El precio total del menú es; {combo1.CalcularPrecio()}");
Console.WriteLine($"El precio {combo1.CalcularPrecio()} con el 10% de descuento aplicado es {combo1.PrecioConDescuento():F2}.");

if (combo1.PlatoPrincipal is PlatoPrincipal)
{
    Console.WriteLine("Esto es un Plato Principal dentro de un combo.");
}


Console.WriteLine("\n\n**** COMIENZO DE LOS EJERCICIOS ****");
Entrante entrante1 = new Entrante("Patatas bravas", 10.25m, 4, false);
entrante1.ObtenerDescripcion();
Entrante entrante2 = new Entrante("Nachos", 6.50m, 1, true);
entrante2.ObtenerDescripcion();
Entrante entrante3 = new Entrante("Ensaladilla rusa", 16.00m, 2, true);
entrante3.ObtenerDescripcion();