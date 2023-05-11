namespace School.Models
{
    public interface ISchoolRepository
    {
        IQueryable<Student> Students { get; }
    }
}
