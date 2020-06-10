using ExemploFactory.Domain;
using ExemploFactory.Factory;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExemploFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var florFactory = scope.ServiceProvider.GetRequiredService<FlorFactory>();

                var rosa =  florFactory.gerarFlor(TipoFlorEnum.ROSA);
                var margarida = florFactory.gerarFlor(TipoFlorEnum.MARGARIDA);
                var orquidea = florFactory.gerarFlor(TipoFlorEnum.ORQUIDEA);

                Console.WriteLine($" { rosa.Nome } criada");
                Console.WriteLine($" { margarida.Nome } criada");
                Console.WriteLine($" { orquidea.Nome } criada");
            }

            Console.ReadKey();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
