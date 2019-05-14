using System.Collections;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
    }
}