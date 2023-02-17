# Ejemplo # 1
Supongamos que tenemos que escribir un programa que solicita al usuario que ingrese un número y luego determina si ese número es par o impar. Para aplicar el principio KISS, podemos escribir el código de la manera más simple y directa posible.

Aquí hay un ejemplo de cómo se podría escribir este código en C# utilizando el principio KISS:

csharp
```
Console.WriteLine("Ingrese un número:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0) {
    Console.WriteLine("El número es par.");
} else {
    Console.WriteLine("El número es impar.");
}
```

En este ejemplo, el programa solicita al usuario que ingrese un número, lo convierte a un entero utilizando Convert.ToInt32 y luego determina si el número es par o impar utilizando un condicional if. Si el número es par, el programa imprimirá "El número es par." en la consola, y si es impar, el programa imprimirá "El número es impar.".

Este enfoque utiliza una cantidad mínima de código para lograr el objetivo del programa, lo que lo hace fácil de entender y mantener. Al aplicar el principio KISS, estamos evitando la complejidad innecesaria y creando un programa más simple y fácil de usar.

# Ejemplo # 2
Supongamos que tenemos una aplicación que realiza operaciones matemáticas más complejas, como el cálculo de la raíz cuadrada de un número, pero queremos asegurarnos de que sea fácil de usar para los usuarios.

En lugar de escribir una función complicada que requiere que los usuarios ingresen muchos parámetros, podemos aplicar el principio KISS y escribir una función simple que solo requiere un parámetro: el número del cual se calculará la raíz cuadrada.

Aquí hay un ejemplo de cómo se podría escribir este código en C# utilizando el principio KISS:

```
public static double CalcularRaizCuadrada(double numero) {
    return Math.Sqrt(numero);
}
```
En este ejemplo, hemos creado una función llamada CalcularRaizCuadrada que acepta un parámetro numero y utiliza la función Math.Sqrt para calcular la raíz cuadrada del número.

# Ejemplo # 3
Supongamos que queremos crear una función que tome una lista de números y devuelva el promedio de esos números. En lugar de escribir una función complicada que realice varios cálculos, podemos aplicar el principio KISS y escribir una función simple que utilice los métodos proporcionados por la biblioteca estándar de C#.

Aquí hay un ejemplo de cómo se podría escribir este código en C# utilizando el principio KISS:

```
public static double CalcularPromedio(List<double> numeros) {
    return numeros.Average();
}
```

En este ejemplo, hemos creado una función llamada CalcularPromedio que acepta un parámetro numeros que es una lista de números, y utilizamos el método Average() proporcionado por la biblioteca estándar de C# para calcular el promedio de la lista de números.

Este enfoque utiliza una cantidad mínima de código para lograr el objetivo de la función, lo que lo hace fácil de entender y mantener.
