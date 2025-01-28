using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace dotnet6KfmmcApi.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product>? Products { get; set; }
    }
}
