using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QuizWebApp.Models;

namespace QuizWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var context = new QuizContext()){

                //var count = context.Quizzes.Count();
                //Console.WriteLine(count);
                CreateWebHostBuilder(args).Build().Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetUpConfiguration)
                .UseStartup<Startup>();

        private static void SetUpConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //builder.Sources.Clear();
            builder.AddJsonFile("appsettings.json", false, true)
                    .AddEnvironmentVariables();
        }
    }
}
