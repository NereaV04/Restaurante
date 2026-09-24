// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using Models;

/* Producto platoPrincipal1 = new PlatoPrincipal("Pizza", 12, ["Tomate", "Queso"]);
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
*/

Console.WriteLine("\n\n**** COMIENZO DE LOS EJERCICIOS ****");
// Almacenar los productos en una colección.
List<Producto> carta = new List<Producto>();

// Crear 2 entrantes.
Entrante entrante1 = new Entrante("Patatas bravas", 6m, 4, false);
carta.Add(entrante1);
Entrante entrante2 = new Entrante("Nachos", 8.25m, 1, true);
carta.Add(entrante2);

// Crear 2 platos principales.
PlatoPrincipal platoPrincipal1 = new PlatoPrincipal("Hamburguesa", 12m, ["Carne", "Lechuga"]);
carta.Add(platoPrincipal1);
Producto platoPrincipal2 = new PlatoPrincipal("Pizza", 12, ["Tomate", "Queso"]);
carta.Add(platoPrincipal2);

// Crear 2 bebidas.
Bebida bebida1 = new Bebida("Coca-Cola", 3m, ["Cafeina", "Limón"], false);
carta.Add(bebida1);
Bebida bebida2 = new Bebida("Cerveza", 1.50m, ["Cevada", "Trazas de levadura"], true);
carta.Add(bebida2);

// Crear 2 postres.
Postre postre1 = new Postre("Tarta de queso", 5m, ["Queso", "Huevos"], 321m, false);
carta.Add(postre1);
Postre postre2 = new Postre("Tiramisu", 7m, ["Mascarpone", "Huevos"], 250m, false);
carta.Add(postre2);

// Mostrar los elementos de la carta usando un foreach
Console.WriteLine("\t=== CARTA ===");
int contEntran = 0;
int contPlatoPrin = 0;
int contBeb = 0;
int contPostr = 0;
int cont = 1;

foreach (Producto producto in carta)
{
    if (producto is Entrante)
    {
        if (contEntran == 0)
        {
            Console.WriteLine("** Entrantes **");
            contEntran++;
        }
        Console.WriteLine(cont + ". " + producto.GetDescription());        
    } else if (producto is PlatoPrincipal)
    {
        if (contPlatoPrin == 0)
        {
            Console.WriteLine("\n** Platos Principales **");
            contPlatoPrin++;
        }
        Console.WriteLine(cont + ". " + producto.GetDescription());
    } else if (producto is Bebida)
    {
        if (contBeb == 0)
        {
            Console.WriteLine("\n** Bebidas **");
            contBeb++;
        }
        Console.WriteLine(cont + ". " + producto.GetDescription());
    } else if (producto is Postre)
    {
        if (contPostr == 0)
        {
            Console.WriteLine("\n** Postres **");
            contPostr++;
        }
        Console.WriteLine(cont + ". " + producto.GetDescription());
    }
    cont++;
}

Console.WriteLine("\n\t=== CARTA FILTRADA POR BEBIDAS ===");
foreach (Producto producto in carta)
{
    if (producto is Bebida)
    {
        Console.WriteLine(producto.GetDescription());
    }
}