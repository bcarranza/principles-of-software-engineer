# Solid
## Descripción
Supongamos que estamos desarrollando una aplicación de manejo de archivos. Una de las funcionalidades de la aplicación es leer archivos de diferentes formatos, como PDF, Word y Excel. Para implementar esta funcionalidad, creamos una clase llamada FileReader que se encarga de leer los archivos.

Sin embargo, si no aplicamos los principios SOLID, nuestra clase FileReader podría tener un diseño que no es fácil de mantener y que no cumple con los requisitos de los clientes.

Para aplicar los principios SOLID, podemos tomar los siguientes pasos:

Principio SRP (Single Responsibility Principle): Debemos asegurarnos de que nuestra clase tenga una única responsabilidad. En este caso, la responsabilidad de nuestra clase FileReader es leer archivos. No debería tener otras responsabilidades, como la validación de los datos.

Principio OCP (Open-Closed Principle): Debemos asegurarnos de que nuestra clase esté abierta a la extensión pero cerrada a la modificación. Para implementar esto, podemos crear una interfaz IFileReader que define el método ReadFile(). Luego, podemos crear diferentes clases que implementen esta interfaz para leer archivos de diferentes formatos.

Principio LSP (Liskov Substitution Principle): Debemos asegurarnos de que las clases que implementan la interfaz IFileReader se puedan utilizar como sustitutos de la clase FileReader. Esto significa que cualquier código que utilice la clase FileReader debe poder trabajar sin cambios con cualquiera de las clases que implementen IFileReader.

Principio ISP (Interface Segregation Principle): Debemos asegurarnos de que la interfaz IFileReader tenga solo los métodos que las clases que la implementan necesitan. En este caso, la única responsabilidad de IFileReader es leer archivos, por lo que no debería tener métodos para escribir o validar los datos.

Principio DIP (Dependency Inversion Principle): Debemos asegurarnos de que FileReader dependa de abstracciones en lugar de concreciones. En lugar de crear una instancia de la clase concreta en FileReader, debemos pasar una instancia de la interfaz IFileReader en su constructor.

Al aplicar los principios SOLID, podemos asegurarnos de que nuestra clase FileReader sea fácil de mantener, extender y escalar. Además, nuestra aplicación puede cumplir con los requisitos de los clientes y estar lista para futuras expansiones.


## Ejemplo Práctico
Primero, creamos una interfaz IFileReader que define el método ReadFile():

c#
```
public interface IFileReader
{
    string ReadFile(string filePath);
}
```
Luego, creamos una clase PdfFileReader que implementa la interfaz IFileReader para leer archivos PDF:

c#
```
public class PdfFileReader : IFileReader
{
    public string ReadFile(string filePath)
    {
        // Lógica para leer un archivo PDF
        return "Contenido del archivo PDF";
    }
}
```
Hacemos lo mismo para las clases WordFileReader y ExcelFileReader para leer archivos Word y Excel respectivamente:

c#
```
public class WordFileReader : IFileReader
{
    public string ReadFile(string filePath)
    {
        // Lógica para leer un archivo Word
        return "Contenido del archivo Word";
    }
}

public class ExcelFileReader : IFileReader
{
    public string ReadFile(string filePath)
    {
        // Lógica para leer un archivo Excel
        return "Contenido del archivo Excel";
    }
}
```
Finalmente, creamos la clase FileReader que depende de la interfaz IFileReader para leer archivos de diferentes formatos:

c#
```
public class FileReader
{
    private readonly IFileReader _fileReader;

    public FileReader(IFileReader fileReader)
    {
        _fileReader = fileReader;
    }

    public string ReadFile(string filePath)
    {
        return _fileReader.ReadFile(filePath);
    }
}
```
Ahora podemos utilizar la clase FileReader para leer archivos de diferentes formatos sin tener que modificar su código. Podemos crear una instancia de la clase FileReader y pasar una instancia de la clase concreta PdfFileReader, WordFileReader o ExcelFileReader según el formato del archivo que queremos leer:

c#
```
var pdfReader = new PdfFileReader();
var wordReader = new WordFileReader();
var excelReader = new ExcelFileReader();

var fileReader = new FileReader(pdfReader);
var pdfContent = fileReader.ReadFile("ruta/al/archivo.pdf");

fileReader = new FileReader(wordReader);
var wordContent = fileReader.ReadFile("ruta/al/archivo.docx");

fileReader = new FileReader(excelReader);
var excelContent = fileReader.ReadFile("ruta/al/archivo.xlsx");
```
De esta manera, hemos aplicado los principios SOLID para crear una aplicación de manejo de archivos escalable, flexible y fácil de mantener.
