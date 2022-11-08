using solfordTestCase.Domain.Dto;
using solfordTestCase.Domain.Models;

namespace solfordTestCase.Domain.Repository
{
    public interface IProviderRepository
    {
        Task<ProviderDto> CreateProvider(Provider provider);
        Task<IEnumerable<ProviderDto>> GetProviders();
        Task<ProviderDto> GetProvider(int id);
        Task<bool> DeleteProvider(int id);
    }
}