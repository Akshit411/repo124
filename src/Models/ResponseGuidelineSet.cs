using System.Collections.Generic;
using System.Linq;

namespace Repo124.Models
{
    public class ResponseGuidelineSet
    {
        public System.Guid Id { get; set; }
        public List<string> FormattingRules { get; set; } = new List<string>();
        public List<string> EscalationRules { get; set; } = new List<string>();
        public int MaxResponseLength { get; set; }
        public bool AllowFallbackResponses { get; set; }

        public void AddFormattingRule(string rule)
        {
            FormattingRules.Add(rule);
        }

        public void AddEscalationRule(string rule)
        {
            EscalationRules.Add(rule);
        }

        public bool Validate()
        {
            return FormattingRules.Any() && MaxResponseLength > 0;
        }
    }
}
