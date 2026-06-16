using Repo124.Models;

namespace Repo124.Repositories
{
    public interface IDefaultConfigurationRepository
    {
        DefaultConfigurationTemplate GetActiveTemplate();
        void Save(DefaultConfigurationTemplate template);
    }
}
