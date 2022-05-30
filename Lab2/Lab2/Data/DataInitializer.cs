namespace Lab2.Data
{
    public class DataInitializer
    {
        public static void Initialize(ArchitectureDesignDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
