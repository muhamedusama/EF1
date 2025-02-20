using EF1.DbContexts;

namespace EF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItIDbContext dbContext = new ItIDbContext();
        }
    }
}
