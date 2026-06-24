using Serilog;

namespace ControleDeMedicamentosWeb.WebApp.Compartilhado.Aplicacao.Logging;

public static class SerilogLoggerFactory
{
    public static void AddSerilogLogger(
        this IServiceCollection services,
        ILoggingBuilder logging,
        IConfiguration configuration
        )
    {
        Log.Logger = SerilogFactory.Create(configuration);

        //remove o provedor de logs da microsoft
        logging.ClearProviders();

        services.AddSerilog(Log.Logger);
    }
}