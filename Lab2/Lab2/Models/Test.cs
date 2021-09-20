using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Models {
    public class Test {
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Theme { get; set; } = string.Empty;
        public List<Question> Questions { get; set; } = new List<Question>();

        public Test(string lastName) {
            LastName = lastName;
        }

        public void CompleteTest() {
            Date = DateTime.Now;
        }

        public int GetCountOfMistakes() {
            var counter = 0;
            foreach (var question in Questions) {
                if (question.UserAnswers == null) {
                    counter++;
                    continue;
                }

                counter += question.UserAnswers.Count(x => !question.RightAnswers.Contains(x)) > 0 ? 1 : 0;
            }

            return counter;
        }

        public List<Question> GetMistakenQuestions() {
            var result = new List<Question>();
            foreach (var question in Questions) {
                if (question.UserAnswers == null) {
                    result.Add(question);
                    continue;
                }

                if (!question.UserAnswers.SetEquals(question.RightAnswers)) {
                    result.Add(question);
                }
            }

            return result;
        }
    }
}