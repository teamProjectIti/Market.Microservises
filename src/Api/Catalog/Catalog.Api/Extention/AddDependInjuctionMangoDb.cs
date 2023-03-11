
namespace Catalog.Api.Extention
{
    public static class AddDependInjuctionMangoDb
    {
        public static IServiceCollection AddinjectDbServices(this IServiceCollection services, IConfiguration confic)
        {
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            //services.AddScoped(typeof(IDocument), typeof(Document));
            return services;
        }
    }
}
