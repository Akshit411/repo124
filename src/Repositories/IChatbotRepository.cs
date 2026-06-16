using System;
using Repo124.Models;

namespace Repo124.Repositories
{
    public interface IChatbotRepository
    {
        Chatbot GetById(Guid chatbotId);
        void Save(Chatbot chatbot);
    }
}
