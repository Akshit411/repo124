using System;

namespace Repo124.Models
{
    public class DefaultConfigurationTemplate
    {
        public Guid Id { get; set; }
        public string TemplateName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PromptInstructionSet DefaultPromptInstructions { get; set; } = new PromptInstructionSet();
        public ResponseGuidelineSet DefaultResponseGuidelines { get; set; } = new ResponseGuidelineSet();
        public bool IsActive { get; set; }
        public string Version { get; set; } = string.Empty;

        public ChatbotConfiguration CreateConfiguration()
        {
            return new ChatbotConfiguration
            {
                Id = Guid.NewGuid(),
                PromptInstructions = DefaultPromptInstructions,
                ResponseGuidelines = DefaultResponseGuidelines,
                IsDefaultApplied = true,
                AppliedAt = DateTime.UtcNow
            };
        }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TemplateName)
                && DefaultPromptInstructions.Validate()
                && DefaultResponseGuidelines.Validate();
        }
    }
}
