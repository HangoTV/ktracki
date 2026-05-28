namespace ConsoleApp6;

public class VideoFile : MediaFile
{
    public string Resolution { get; set; }

    public VideoFile(string fileName, string fileExtension, string fileSize, string resolution) : base(fileName,
        fileExtension, fileSize)
    {
        Resolution = resolution;
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"{FileExtension}: {Resolution}");
    }
}