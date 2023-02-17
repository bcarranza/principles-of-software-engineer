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