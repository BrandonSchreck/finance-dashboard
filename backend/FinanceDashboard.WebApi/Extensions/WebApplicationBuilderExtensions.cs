using Serilog;

namespace FinanceDashboard.WebApi.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void ConfigureRequestPipeline(this IApplicationBuilder app)
    {
        var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();

        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseSerilogRequestLogging();
    }
}