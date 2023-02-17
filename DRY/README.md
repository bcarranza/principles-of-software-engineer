# KISS
El principio DRY (Don't Repeat Yourself) promueve la reutilización de código y la eliminación de duplicación innecesaria. 

Supongamos que tienes un programa que necesita realizar operaciones aritméticas básicas, como sumar, restar, multiplicar y dividir dos números. En lugar de escribir una función separada para cada operación, podemos aplicar el principio DRY y crear una única función genérica para realizar todas estas operaciones.

Aquí está un ejemplo de cómo se podría escribir este código en C#:

csharp
public class Calculadora {

    public double RealizarOperacion(string operador, double a, double b) {
        switch(operador) {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                throw new ArgumentException("Operador inválido");
        }
    }
}

En este ejemplo, hemos creado una clase llamada Calculadora que contiene un método llamado RealizarOperacion. Este método acepta tres parámetros: el operador que se utilizará para realizar la operación, el primer número y el segundo número.

Dentro del método, usamos una instrucción switch para determinar qué operación realizar en función del operador proporcionado. En lugar de escribir una función separada para cada operación, hemos creado una única función que puede realizar cualquier operación aritmética básica.

Este enfoque nos permite escribir menos código, hacer que nuestro código sea más fácil de leer y mantener, y reducir la posibilidad de errores causados por la repetición de código. De esta manera, estamos aplicando el principio DRY y mejorando la calidad de nuestro código.