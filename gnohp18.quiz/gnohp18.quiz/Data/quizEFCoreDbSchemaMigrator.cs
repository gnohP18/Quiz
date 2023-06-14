using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace gnohp18.quiz.Data;

public class quizEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public quizEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the quizDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<quizDbContext>()
            .Database
            .MigrateAsync();
    }
}
