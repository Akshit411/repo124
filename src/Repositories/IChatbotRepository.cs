using System;
using Repo124.Models;

namespace Repo124.Repositories
{
    public interface IChatbotRepository
    {
        Chatbot123 GetById(Guid chatbotId);
        void Save(Chatbot123 chatbot);
    }
}
