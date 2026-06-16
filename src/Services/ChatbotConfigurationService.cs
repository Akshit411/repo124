using System;
using Repo124.Models;
using Repo124.Repositories;

namespace Repo124.Services
{
    public class ChatbotConfigurationService
    {
        public IDefaultConfigurationRepository DefaultConfigurationRepository { get; }
        public IChatbotRepository ChatbotRepository { get; }

        public ChatbotConfigurationService(
            IDefaultConfigurationRepository defaultConfigurationRepository,
            IChatbotRepository chatbotRepository)
        {
            DefaultConfigurationRepository = defaultConfigurationRepository;
            ChatbotRepository = chatbotRepository;
        }

        public ChatbotConfiguration GetDefaultConfiguration()
        {
            var template = DefaultConfigurationRepository.GetActiveTemplate();
            return template.CreateConfiguration();
        }

        public void ApplyDefaultConfigurationToChatbot(Guid chatbotId)
        {
            var chatbot = ChatbotRepository.GetById(chatbotId);
            var template = DefaultConfigurationRepository.GetActiveTemplate();

            chatbot.ApplyDefaultConfiguration(template);
            ChatbotRepository.Save(chatbot);
        }

        public void SaveConfiguration(Guid chatbotId, ChatbotConfiguration configuration)
        {
            var chatbot = ChatbotRepository.GetById(chatbotId);
            chatbot.UpdateConfiguration(configuration);
            ChatbotRepository.Save(chatbot);
        }
    }
}
