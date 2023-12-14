namespace SampleProject.Exceptions;

public class DublicateKeyExceptions : Exception
{
    public DublicateKeyExceptions() : base("key cannot be dublicate")
    {
        
    }
}
