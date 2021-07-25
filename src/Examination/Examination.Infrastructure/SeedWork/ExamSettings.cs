namespace Examination.Infrastructure.SeedWork
{
    public class ExamSettings
    {
        public string IdentityUrl { set; get; }
        public DatabaseSettings DatabaseSettings { set; get; }

    }

    public class DatabaseSettings
    {
        public string ConnectionString { set; get; }
        public string DatabaseName { set; get; }
    }
}