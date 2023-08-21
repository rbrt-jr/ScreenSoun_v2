namespace ScreenSoundV2.Models;
internal class Album : IEvaluate
{
    public Album(string name)
    {
        this.Name = name;
      CounterOfAlbuns++;
    }

    private List<Music> songs = new List<Music>();

    private List<Grade> grades = new(); 
    public string Name { get; }

    public static int CounterOfAlbuns = 0;
    public int TotalDurationOfThisAlbum => songs.Sum(s => s.Duration);

    public double AverageOfGrades 
    {
        get
        {
            if (grades.Count == 0) return 0;
            else return grades.Average(g => g.Value);
        }
    }

    public void AddSongAtAlbum(Music music)
    {
        songs.Add(music);
 
    }

    public void ShowSongsFromThisAlbum()
    {
        Console.WriteLine($"List of songs from album {Name}:\n");
        foreach (Music music in songs)
        {
            Console.WriteLine($"Song: {music.Name}");
        }
        Console.WriteLine($"This album has a total of {TotalDurationOfThisAlbum} seconds ");

    }

    public void AddGrade(Grade grade)
    {
        grades.Add(grade);
    }
}