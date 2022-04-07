using BasicAuthentication.Models;

namespace BasicAuthentication.Services
{
    public interface IBeerServices
    {
        public Task<List<Beer>> Get();

    }
}
