using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MEUSITE
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração de serviços
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(@"
<!DOCTYPE html>
<html lang='pt-br'>
<head>
    <meta charset='utf-8' />
    <title>Meu Site</title>
    <link rel='preconnect' href='https://fonts.googleapis.com'>
    <link rel='preconnect' href='https://fonts.gstatic.com' crossorigin>
    <link href='https://fonts.googleapis.com/css2?family=Inter:wght@400;700&display=swap' rel='stylesheet'>
    <style>
        body {
            font-family: 'Inter', sans-serif;
            background-color: #f4f7f6;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .card {
            background: white;
            padding: 40px 60px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.05);
            border: 1px solid #e2e8f0;
            text-align: center;
        }
        h1 {
            color: #1e293b;
            font-size: 2.5rem;
            margin: 0;
        }
    </style>
</head>
<body>
    <div class='card'>
        <h1>Bem-vindo ao MeuSite!</h1>
    </div>
</body>
</html>
                    ");
                });
            });
        }
    }
}