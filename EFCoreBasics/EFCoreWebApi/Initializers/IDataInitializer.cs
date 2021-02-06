using System.Threading.Tasks;

namespace EFCoreWebApi.Initializers {

    public interface IDataInitializer {

        Task SeedDataAsync();

    }

}
