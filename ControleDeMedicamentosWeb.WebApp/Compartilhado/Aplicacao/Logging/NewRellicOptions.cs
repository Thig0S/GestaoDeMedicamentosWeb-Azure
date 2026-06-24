namespace ControleDeMedicamentosWeb.WebApp.Compartilhado.Aplicacao.Logging
{
    public sealed class NewRellicOptions
    {
        public const string SectionName = "NewRelic";

        public string EndPointUrl { get; set; } = string.Empty;
        public string ApplicationName { get; set; } = string.Empty;
        public string LicenseKey { get; set; } = string.Empty;
    }
}