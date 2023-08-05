using Microsoft.Extensions.DependencyInjection;
namespace Advanced_Database_and_ORM_Concepts
{
    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    }
}
