namespace ScreenSoundV2.Models;
internal class Band : IEvaluate
{
    private List<Album> albums = new List<Album>();

    private List<Grade> grades = new List<Grade>();
    public Band(string name)
    {
        this.Name = name;
    }
    
    public IEnumerable<Album> Albums => albums;
  
    public string Name { get; }

    public double AverageOfGrades
    {
        get
        {
            if (grades.Count == 0) return 0;
            else return grades.Average(g => g.Value);

        }
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddGrade(Grade grade)
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