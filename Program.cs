namespace GameStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            /**
             * 
             * Place for Configuration of a series of sevices depending on my needs
             * (builder.action)
             * 
             */

            //Implicit Declarition of List of Game (Data Transfer Objects)
            // For Crud??

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
