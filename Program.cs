// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net;
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
PlatoPrincipal platoPrincipal1 = new PlatoPrincipal("Hamburguesa Completa", 16m, ["Carne", "Lechuga"]);
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

CartaFiltradaPorBebida(carta);

/*¿Qué tipo tiene la variable utilizada para recorrer la List<Producto>?
Es de tipo Producto, ya que es el tipo de la colección.
¿Puede esa variable contener un objeto cuyo tipo real sea Bebida?
Sí, ya que Bebida hereda de Producto.
¿Qué permite comprobar el operador is?
Permite comprobar si un objeto es de un tipo específico o si es de una clase que hereda de la clase padre.
*/
int opcion;
const int opcionSalir = 0;

do
{
    MostrarMenu();
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Debes introducir un número.");
        opcion = -1; // Asignar un valor inválido para que el bucle continúe.
        continue;
    }
    else if (opcion < opcionSalir || opcion > 5)
    {
        Console.WriteLine("Opción no válida, selecciona una opción válida (0-5).");
        continue;
    }

    switch(opcion)
    {
        case 1:
            MostrarCarta(carta);
            break;
        case 2:
            ElegirProducto(carta);
            break;
        case 3:
            BuscarProducto(carta);
            break;
        case 4:
            MostrarProductosPorPrecio(carta);
            break;
        case 5:
            MostrarProductoMasCaro(carta);
            break;
        case opcionSalir:
            Console.WriteLine("¡Hasta la próxima!");
            break;
    }
} while (opcion != opcionSalir);

void MostrarMenu()
{
    Console.WriteLine("\n========================");
    Console.WriteLine("\tRESTAURANTE");
    Console.WriteLine("========================");
    Console.WriteLine("1. Ver carta.");
    Console.WriteLine("2. Elegir producto.");
    Console.WriteLine("3. Buscar producto.");
    Console.WriteLine("4. Productos por precio.");
    Console.WriteLine("5. Producto más caro.");
    Console.WriteLine("0. Salir.");
    Console.WriteLine("\n Elija una opción: ");
}

void MostrarCarta(List<Producto> carta)
{
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
                Console.WriteLine("  ** Entrantes **");
                contEntran++;
            }
            Console.WriteLine(cont + ". " + producto.GetDescription());
        }
        else if (producto is PlatoPrincipal)
        {
            if (contPlatoPrin == 0)
            {
                Console.WriteLine("\n  ** Platos Principales **");
                contPlatoPrin++;
            }
            Console.WriteLine(cont + ". " + producto.GetDescription());
        }
        else if (producto is Bebida)
        {
            if (contBeb == 0)
            {
                Console.WriteLine("\n  ** Bebidas **");
                contBeb++;
            }
            Console.WriteLine(cont + ". " + producto.GetDescription());
        }
        else if (producto is Postre)
        {
            if (contPostr == 0)
            {
                Console.WriteLine("\n  ** Postres **");
                contPostr++;
            }
            Console.WriteLine(cont + ". " + producto.GetDescription());
        }
        cont++;
    }
}

void ElegirProducto(List<Producto> carta)
{
    Console.WriteLine("¿Qué producto quieres? (numero del plato)");
    int opcion;
    bool hayError;

    do
    {
        hayError = false;
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Debes introducir un número.");
            hayError = true;
        }
        else if (opcion < 1 || opcion > carta.Count)
        {
            Console.WriteLine("Ese producto no existe, selecciona una opción válida (1-8).");
            hayError = true;
        }

        foreach (Producto producto in carta)
        {
            if (carta.IndexOf(producto) == opcion - 1)
            {
                Console.WriteLine($"Has elegido: {producto.GetDescription()}");
            }
        }
    } while (hayError);
}

void CartaFiltradaPorBebida(List<Producto> carta)
{
    // Carta filtrada por bebidas.
    Console.WriteLine("\t=== CARTA FILTRADA POR BEBIDAS ===");
    foreach (Producto producto in carta)
    {
        if (producto is Bebida)
        {
            Bebida bebida = (Bebida)producto;
            bebida.ShowDescription();
        }
    }
}

void BuscarProducto(List<Producto> carta)
{
    Console.WriteLine("Producto a buscar (nombre): ");
    string productoIntroducido = Console.ReadLine();
    bool encontrado = false;

    foreach (Producto prodBuscar in carta)
    {
        if (prodBuscar.Nombre.ToLower() == productoIntroducido.ToLower().Trim())
        {
            Console.WriteLine(prodBuscar.GetDescription());
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("No se ha encontrado el producto.");
    }
}

void MostrarProductosPorPrecio(List<Producto> carta)
{
    Console.WriteLine("Precio máximo: ");
    decimal precioIntroducido;
    bool encontrado = false;

    if (!decimal.TryParse(Console.ReadLine(), out precioIntroducido))
    {
        Console.WriteLine("Error; debe introducir un valor númerico.");
    }
    else
    {
        foreach (Producto prodBuscar in carta)
        {
            if (prodBuscar.Precio <= precioIntroducido)
            {
                Console.WriteLine(prodBuscar.GetDescription());
                encontrado = true;
            }
        }
    }


    if (!encontrado)
    {
        Console.WriteLine("No se ha encontrado ningún producto que cumpla la condición de precio.");
    }
}

void MostrarProductoMasCaro(List<Producto> carta)
{
    decimal precioMaximo = carta[0].Precio;
    foreach (Producto producto in carta)
    {
        if (producto.Precio > precioMaximo)
        {
            precioMaximo = producto.Precio;
        }
    }

    foreach (Producto producto in carta)
    {
        if (producto.Precio == precioMaximo)
        {
            Console.WriteLine($"El producto más caro es: {producto.GetDescription()}");
        }
    }
}