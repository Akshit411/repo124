using System;

namespace Repo124.Models
{
    public class ChatbotConfiguration
    {
        public Guid Id { get; set; }
        public Guid ChatbotId { get; set; }
        public PromptInstructionSet PromptInstructions { get; set; } = new PromptInstructionSet();
        public ResponseGuidelineSet ResponseGuidelines { get; set; } = new ResponseGuidelineSet();
        public bool IsDefaultApplied { get; set; }
        public DateTime AppliedAt { get; set; }

        public void ApplyPromptInstructions(PromptInstructionSet instructions)
        {
            PromptInstructions = instructions;
        }

        public void ApplyResponseGuidelines(ResponseGuidelineSet guidelines)
        {
            ResponseGuidelines = guidelines;
        }

        public bool IsComplete()
        {
            return PromptInstructions != null
                && ResponseGuidelines != null
                && PromptInstructions.Validate()
                && ResponseGuidelines.Validate();
        }
    }
}
