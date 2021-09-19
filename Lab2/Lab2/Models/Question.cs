using System.Collections.Generic;

namespace Lab2.Models {
    public class Question {
        public int Number { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Answers { get; set; } = new();
        public HashSet<int> RightAnswers { get; set; } = new();
        public HashSet<int>? UserAnswers { get; set; }
    }
}