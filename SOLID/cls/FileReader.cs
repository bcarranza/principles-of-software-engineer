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