using System.Collections.Generic;
using System.Linq;

namespace Repo124.Models
{
    public class PromptInstructionSet
    {
        public System.Guid Id { get; set; }
        public string SystemPrompt { get; set; } = string.Empty;
        public List<string> ConversationRules { get; set; } = new List<string>();
        public List<string> SafetyRules { get; set; } = new List<string>();
        public string ToneOfVoice { get; set; } = string.Empty;

        public void AddConversationRule(string rule)
        {
            ConversationRules.Add(rule);
        }

        public void AddSafetyRule(string rule)
        {
            SafetyRules.Add(rule);
        }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(SystemPrompt)
                && !string.IsNullOrWhiteSpace(ToneOfVoice)
                && ConversationRules.Any();
        }
    }
}
