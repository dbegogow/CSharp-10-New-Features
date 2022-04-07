namespace RecordStructs;

internal struct Rectangle
{
    public int Height { get; init; }

    public int Width { get; init; }
}

internal record Person(string FirstName);