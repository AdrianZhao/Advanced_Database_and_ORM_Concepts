using Microsoft.Extensions.DependencyInjection;
namespace Advanced_Database_and_ORM_Concepts
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }
        ServiceLifetime Lifetime { get; }
    }
}
