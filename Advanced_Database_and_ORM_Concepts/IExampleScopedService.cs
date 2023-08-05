using Microsoft.Extensions.DependencyInjection;
namespace Advanced_Database_and_ORM_Concepts
{
    public interface IExampleScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
