using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        // create a method 
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
