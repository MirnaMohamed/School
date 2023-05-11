namespace School.Models
{
    public class SchoolRepository : ISchoolRepository
    {
        private SchoolDbContext _context;
        public SchoolRepository(SchoolDbContext context) 
        {
            _context = context;
        }
        public IQueryable<Student> Students => _context.Students;
    }
}
