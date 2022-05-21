Console.WriteLine(new Rectangle(50, 70).ToString());

internal record Rectangle(int Height, int Width)
{
    public sealed override string ToString()
    {
        return $"Height is: {this.Height} and width is: {this.Width}";
    }
}

internal record Square : Rectangle
{
    protected Square(int sideLength) : base(sideLength, sideLength)
    {
    }

    //public override string ToString()
    //{
    //    return $"Side length: {Height}";
    //}
}