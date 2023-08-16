namespace ScreenSoundV2.Models;
class Band
{
    public Band(string name)
    {
        this.Name = name;
    }

    private List<Album> albums = new List<Album>();

    private List<int> grades = new List<int>();

    public string Name { get; }

    public double AverageOfGrades => grades.Average();

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public void ShowAlbum()
    {
        Console.WriteLine($"Discography of {Name}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDurationOfThisAlbum})");
        }
    }

}