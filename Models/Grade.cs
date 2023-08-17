namespace ScreenSoundV2.Models;

internal class Grade
{
    public Grade(int value) 
    {
        this.Value = value;
    }
    public int  Value { get; }

    public static Grade Parse(string text)
    {
        int grade = int.Parse(text);
        if (grade < 0)
        {
            grade = 0;
            return new Grade(grade);
        }
        else if (grade > 10)
        {
            grade = 10;
            return new Grade(10);
        } else
        {
            return new Grade(grade);
        }
        
    }
}
