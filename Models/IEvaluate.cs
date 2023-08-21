namespace ScreenSoundV2.Models;

internal interface IEvaluate
{
    void AddGrade(Grade grade);
    double AverageOfGrades { get; }
}
