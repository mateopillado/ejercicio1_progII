using ejercicio1;

Pila pila = new Pila(5);

Console.WriteLine("vacio " + pila.estaVacia());

pila.anadir("Primer Elemento");

Console.WriteLine(pila.primero());

Console.WriteLine("vacio " +pila.estaVacia());