using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2 {
    public partial class PassTestForm : Form {
        private readonly Test _test;
        private readonly List<Panel> _panels;
        private int _currentPanelIndex = 0;

        public PassTestForm() {
            _test = new Test("Бикмаев");
            _panels = new List<Panel>();
            InitializeComponent();
        }

        private void PassTestForm_Load(object sender, EventArgs e) {
            InitData();

            Text = _test.Theme;
            panelComplete.Hide();

            for (var i = 0; i < _test.Questions.Count; i++) {
                var y = 0;

                var panel = new Panel {
                    Tag = $"panelForQuestion{i}", 
                    Location = new Point(0, 0), 
                    Dock = DockStyle.Fill,
                    Visible = false,
                    BackColor = Color.White
                };

                var question = _test.Questions[i];

                var label = new Label {
                    Text = $@"{i + 1}. {question.Description}",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                panel.Controls.Add(label);

                y += 10 + label.Height;

                for (var j = 0; j < question.Answers.Count; j++) {
                    var answer = question.Answers[j];

                    var checkbox = new CheckBox {
                        Text = $@"{ConvertNumberToVariant(j)}. {answer}",
                        AutoSize = true,
                        Location = new Point(15, y)
                    };

                    var questionIndex = i;
                    var answerIndex = j;
                    checkbox.CheckedChanged += (_, _) => OnCheckboxCheckedChanged(checkbox.Checked, questionIndex, answerIndex);

                    panel.Controls.Add(checkbox);

                    y += checkbox.Height;
                }

                _panels.Add(panel);
                Controls.Add(panel);
            }

            _panels.First().Show();
            btnPrev.Text = "Exit";

            btnNext.Enabled = _test.Questions[_currentPanelIndex].UserAnswers != null;
        }

        private void OnCheckboxCheckedChanged(bool isChecked, int questionIndex, int answerIndex) {
            if (isChecked) {
                _test.Questions[questionIndex].UserAnswers ??= new HashSet<int>();
                _test.Questions[questionIndex].UserAnswers?.Add(answerIndex);
            } else {
                _test.Questions[questionIndex].UserAnswers?.Remove(answerIndex);

                if (_test.Questions[questionIndex].UserAnswers?.Count < 1) {
                    _test.Questions[questionIndex].UserAnswers = null;
                }
            }

            btnNext.Enabled = _test.Questions[_currentPanelIndex].UserAnswers != null;
        }

        private void btnPrev_Click(object sender, EventArgs e) {
            if (_currentPanelIndex < 1) {
                return;
            }

            _panels[_currentPanelIndex].Hide();
            _currentPanelIndex--;
            _panels[_currentPanelIndex].Show();

            btnNext.Text = _currentPanelIndex < _panels.Count ? "Next" : "Complete";
            btnPrev.Text = _currentPanelIndex == 0 ? "Exit" : "Previous";
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (_currentPanelIndex == _panels.Count - 1) {
                _test.CompleteTest();
                ShowCompleteTestPage();
                return;
            }

            _panels[_currentPanelIndex].Hide();
            _currentPanelIndex++;
            _panels[_currentPanelIndex].Show();

            btnPrev.Text = _currentPanelIndex > 0 ? "Previous" : "Exit";
            btnNext.Text = _currentPanelIndex == _panels.Count - 1 ? "Complete" : "Next";

            btnNext.Enabled = _test.Questions[_currentPanelIndex].UserAnswers != null;
        }

        private void ShowCompleteTestPage() {
            var mistakenQuestions = _test.GetMistakenQuestions();

            lblLastName.Text = _test.LastName;
            lblDate.Text = _test.Date.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"));
            lblTheme.Text = _test.Theme;
            lblCountOfQuestions.Text = _test.Questions.Count.ToString();
            lblCountOfMistakes.Text = (_test.Questions.Count - mistakenQuestions.Count).ToString();

            var y = 0;
            for(var i = 0; i < mistakenQuestions.Count; i++) {
                var question = mistakenQuestions[i];

                var labelQuestion = new Label {
                    Text = $@"{i + 1}. {question.Description}",
                    AutoSize = true,
                    Location = new Point(10, y)
                };

                y += labelQuestion.Height;

                for (var j = 0; j < question.Answers.Count; j++) {
                    var label = new Label {
                        Text = $@"{ConvertNumberToVariant(j)}. {question.Answers[j]}",
                        AutoSize = true,
                        Location = new Point(25, y)
                    };

                    panelMiskatesInfo.Controls.Add(label);

                    y += label.Height;
                }

                y -= labelQuestion.Height;

                var userAnswerText = question.UserAnswers != null ? string.Join(", ", question.UserAnswers.Select(ConvertNumberToVariant).ToHashSet()) : string.Empty;
                var labelUserAnswer = new Label {
                    Text = $@"Ваши ответы: {userAnswerText}",
                    AutoSize = true,
                    Location = new Point(10, y + labelQuestion.Height)
                };
                
                var labelRightAnswer = new Label {
                    Text = $@"Правильные ответы: {string.Join(", ", question.RightAnswers.Select(ConvertNumberToVariant).ToHashSet())}",
                    AutoSize = true,
                    Location = new Point(10, y + 2 * labelQuestion.Height)
                };

                y += 4 * labelQuestion.Height;

                panelMiskatesInfo.Controls.Add(labelQuestion);
                panelMiskatesInfo.Controls.Add(labelUserAnswer);
                panelMiskatesInfo.Controls.Add(labelRightAnswer);
            }

            _panels[_currentPanelIndex].Hide();
            tableLayoutPanel1.Hide();
            panelComplete.Dock = DockStyle.Fill;
            panelComplete.AutoScroll = true;
            panelComplete.Show();
        }

        private void InitData() {
            _test.Theme = "Основы государственного управления экономикой";
            _test.Questions.Add(new Question {
                Number = 1,
                Description = "Основной целью государственного регулирования экономики является: ",
                Answers = new List<string> {
                    "контроль и ограничение деятельности коммерческих организаций на рынке",
                    "обеспечение правовых основ экономических решений, равных условий и стабильности правил хозяйствования",
                    "перераспределение ресурсов в пользу неэффективных, но общественно значимых производств"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 2,
                Description = "Объектом государственного регулирования являются: ",
                Answers = new List<string> {
                    "все отрасли и подразделения материального производства; товарные, фондовый, валютный рынки, ценообразование, денежное обращение, а также предприятия независимо от формы собственности и хозяйствования",
                    "государственные предприятия и организации",
                    "неэффективные и финансово неблагополучные предприятия"
                },
                RightAnswers = new HashSet<int> { 0, 1 }
            });
            _test.Questions.Add(new Question {
                Number = 3,
                Description = "Государственное регулирование основывается:",
                Answers = new List<string> {
                    "на административных методах властного управления",
                    "на правах, бюджетной, банковской системы, государственных заказах и др.",
                    "на мониторинге ситуации и вмешательстве в критических ситуациях"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 4,
                Description = "Деятельность предприятий в рыночной среде регулируется:",
                Answers = new List<string> {
                    "объективными законами рынка",
                    "командно-административными методами управления",
                    "правовыми методами"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 5,
                Description = "Объектами муниципального управления являются:",
                Answers = new List<string> {
                    "население муниципального образования",
                    "население, инфраструктура и территория",
                    "население, ресурсы и предприятия"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 6,
                Description = "Муниципальное хозяйство – это совокупность:",
                Answers = new List<string> {
                    "предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность",
                    "предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность, направленную на удовлетворение коллективных (общественных) потребностей его населения",
                    "муниципальных предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 7,
                Description = "Социально-экономическое развитие субъекта хозяйственной деятельности подразумевает в первую очередь:",
                Answers = new List<string> {
                    "изменение территории муниципальных образований",
                    "дотации",
                    "самостоятельную деятельность в данном направлении"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 8,
                Description = "Под комплексным социально-экономическим развитием муниципального образования понимается процесс изменений в различных сферах жизни муниципального образования, направленных на достижение определенного уровня развития социальной (в том числе духовной) и экономической сферна данной территории, осуществляемых с наименьшим ущербом для природных ресурсов и предлагающих максимальное удовлетворение потребностей населения и при соблюдении интересов государства, управляемый:",
                Answers = new List<string> {
                    "государством",
                    "органами местного самоуправления",
                    "населением"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 9,
                Description = "Эффективность государственного управления – это:",
                Answers = new List<string> {
                    "соотношение достигнутых общественных целей и использованных государственных ресурсов",
                    "обеспечение роста национального дохода",
                    "характеристика качества применяемом государством решений и их реализации"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 10,
                Description = "Базовые ценности государства – это:",
                Answers = new List<string> {
                    "обобщенные цели, составляющие основу общегосударственных интересов и политической стратегии, а также инструментальные ценности, выражающие одобряемые обществом средства достижения целей",
                    "основополагающие ценности, обеспечивающие устойчивость функционирования государства",
                    "основные разделяемые обществом устои, ценности, а также национальные традиции"
                },
                RightAnswers = new HashSet<int> { 0 }
            });
        }

        private static char ConvertNumberToVariant(int num) {
            return num switch {
                0 => 'а',
                1 => 'б',
                2 => 'в',
                3 => 'г',
                _ => 'x'
            };
        }
    }
}
