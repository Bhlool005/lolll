namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        var svgBuilder = new SvgBuilder(500, 500);
        var gridBuilder = new GridBuilder(svgBuilder, 8);

        var inputPath = "../input.txt";
        using var inputFile = new StreamReader(inputPath);

        foreach (var line in inputFile.ReadToEnd().Split('\n'))
        {
            gridBuilder.Parse(line);
        }

        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svgBuilder.Build());
    }
}
