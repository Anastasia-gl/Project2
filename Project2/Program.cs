namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (AppContext appContext = new AppContext())
            {
                var project = new Project1Facade(appContext);
                project.Run().Wait();
                appContext.SaveChanges();
            }
        }
    }
}