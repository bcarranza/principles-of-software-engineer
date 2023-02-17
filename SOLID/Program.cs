var pdfReader = new PdfFileReader();
var wordReader = new WordFileReader();
var excelReader = new ExcelFileReader();

var fileReader = new FileReader(pdfReader);
var pdfContent = fileReader.ReadFile("ruta/al/archivo.pdf");
Console.WriteLine(pdfContent);

fileReader = new FileReader(wordReader);
var wordContent = fileReader.ReadFile("ruta/al/archivo.docx");
Console.WriteLine(wordContent);

fileReader = new FileReader(excelReader);
var excelContent = fileReader.ReadFile("ruta/al/archivo.xlsx");
Console.WriteLine(excelContent);
