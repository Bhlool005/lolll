namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        var svg = new SvgBuilder(500, 500)
            .AddRectangle(10, 10, 100, 100, "#ff0000")
            .AddRectangle(200, 200, 100, 100, "#00ff00")
            .Build();

        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svg);
    }
}
