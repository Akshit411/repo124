using System;

namespace Repo124.Models
{
    public class Chatbot123
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ChatbotConfiguration Configuration { get; set; } = new ChatbotConfiguration();
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;

        public void ApplyDefaultConfiguration(DefaultConfigurationTemplate template)
        {
            Configuration = template.CreateConfiguration();
        }

        public void UpdateConfiguration(ChatbotConfiguration configuration)
        {
            Configuration = configuration;
        }

        public bool ValidateConfiguration()
        {
            return Configuration != null && Configuration.IsComplete();
        }
    }
}
