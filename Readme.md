Bloque 1 - Herencia y polimorfismo
2. Carta del restaurante
¿Por qué una List<Producto> puede contener objetos de tipo Bebida, Postre, PlatoPrincipal o Entrante?
Porque todas esas clases heredan de Producto.

Una variable de tipo Producto puede almacenar objetos de cualquiera de sus clases hijas.

¿Qué relación existe entre estas clases y Producto?
Producto es la clase padre, mientras que Bebida, Postre, PlatoPrincipal y Entrante son clases hijas.

Las clases hijas heredan los atributos y métodos de Producto y pueden añadir sus propios atributos.

4. Filtrado por tipo
¿Qué tipo tiene la variable utilizada para recorrer la List<Producto>?
La variable utilizada es de tipo Producto.

¿Puede esa variable contener un objeto cuyo tipo real sea Bebida?
Si, ya que Bebida es una clase hija de Producto.

¿Qué permite comprobar el operador is?
Permite comprobar si un objeto es de un determinado tipo o clase.

5. Polimorfismo
¿Cuál es el tipo de la variable producto1?
El tipo de producto1 es Producto.

¿Cuál es el tipo real del objeto almacenado en producto1?
Su tipo real es Bebida.

¿Qué implementación de ObtenerDescripcion() se ejecutará?
Se ejecutará la implementación de ObtenerDescripcion() de la clase Bebida si está sobreescrito con override.

¿Qué ocurrirá con producto2?
La variable es de tipo Producto, pero el objeto real es Postre.

¿Qué ocurrirá con producto3?
La variable es de tipo Producto, pero el objeto real es Entrante.

¿Qué concepto de programación orientada a objetos permite este comportamiento?
El concepto es el polimorfismo. Este permite utilizar una variable de la clase padre, para trabajar con objetos de diferentes clases hijas.

6. ¿Compila?
A)
Producto producto = new Producto(...);
No compila porque Producto es una clase abstracta.

B)
Bebida bebida = new Bebida(...);
Producto producto = bebida;
Si compila. Bebida hereda de Producto, por lo que podemos almacenar una Bebida en una variable de tipo Producto.

Variable bebida  -> Bebida
Objeto           -> Bebida

Variable producto -> Producto
Objeto            -> Bebida
C)
Producto producto = new Bebida(...);
Si compila. Bebida hereda de Producto.

Variable -> Producto
Objeto real -> Bebida
D)
Producto producto = new Bebida(...);
Bebida bebida = producto;
No compila. El objeto es una Bebida, la variable producto está declarada como Producto.

C# no realiza esta conversión de la clase padre a la clase hija, por lo que es necesario realizar la conversación de manera explícita.

E)
List<Producto> productos = new List<Producto>();
productos.Add(new Bebida(...)); -> Objeto real: Bebida
productos.Add(new Postre(...)); -> Objeto real: Postre
productos.Add(new Entrante(...)); -> Objeto real: Entrante
Si que compila porque una Una List<Producto> definida con la clase padre puede contener objetos de sus clases hijas.

F)
Producto producto = new Bebida(...);
Console.WriteLine(producto.ObtenerDescripcion());
Si compila, suponiendo que ObtenerDescripcion() esté correctamente declarado en Producto y sobrescrito en Bebida.

Variable -> Producto
Tipo Real -> Bebida
