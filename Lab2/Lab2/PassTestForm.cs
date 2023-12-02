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
        private int _currentPanelIndex;

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
            lblCountOfQuestions.Text = _test.Questions.Count.ToString(CultureInfo.InvariantCulture);
            lblCountOfMistakes.Text = (_test.Questions.Count - mistakenQuestions.Count).ToString(CultureInfo.InvariantCulture);

            var ratio = (double)(_test.Questions.Count - mistakenQuestions.Count) / _test.Questions.Count;
            var point = 0;
            if (ratio > 0.86) {
                point = 5;
            } else if (ratio > 0.71) {
                point = 4;
            } else if (ratio > 56) {
                point = 3;
            } else {
                point = 2;
            }

            lblPoint.Text = point.ToString(CultureInfo.InvariantCulture);

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
            _test.Theme = "Эффективность  менеджмента  организации";
            _test.Questions.Add(new Question {
                Number = 1,
                Description = "Эффективность менеджмента – это: ",
                Answers = new List<string> {
                    "соотношение затрат на управленческие процессы и результатов бизнеса",
                    "прибыльность бизнеса",
                    "целесообразность и качество управления, ориентированного на успешность организации (бизнеса)"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 2,
                Description = "Экономический эффект – это: ",
                Answers = new List<string> {
                    "чистая прибыль организации",
                    "разность между результатами деятельности (продуктом в стоимостном выражении) и затратами на их получение и использование",
                    "сравнительная стоимостная оценка результатов деятельности организации (например, относительно прошлого года)"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 3,
                Description = "Экономическая эффективность – это: ",
                Answers = new List<string> {
                    "способность организации создавать экономический эффект",
                    "сравнительная характеристика успешности деятельности организации",
                    "относительная количественная характеристика (например, частное от деления экономического эффекта на величину затрат"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 4,
                Description = "Соотношение понятий «успешность бизнеса» и «эффективность менеджмента» слудующие: ",
                Answers = new List<string> {
                    "это одно и то же",
                    "успешность  бизнеса - оценка того, что делает организация, эффектив­ность менеджмента – оценка того, как она это делает",
                    "успешность бизнеса - понятие количественное,  экономическое,  эффективность менеджмента - понятие качественное, не оцениваемое экономически­ми показателями"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 5,
                Description = "Факторы успеха (эффективности) – это: ",
                Answers = new List<string> {
                    "основные результаты деятельности",
                    "оптимальные критерии функционирования организации, определяющие ее ус­пех и эффективность",
                    "причины успешности бизнеса"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 6,
                Description = "Менеджмент может считаться эффективным, если: ",
                Answers = new List<string> {
                    "выполняются цели организации",
                    "растет прибыль организации",
                    "стабильно повышается доходность акций организации"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 7,
                Description = "Соотношение понятий «эффективность организации» и «эффективность экономики» следующие: ",
                Answers = new List<string> {
                    "никак не связаны",
                    "эффективность организаций благоприятно сказываются на эффективности экономики",
                    "эффективность экономики определяет эффективность организаций"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 8,
                Description = "Эффективность менеджмента зависит: ",
                Answers = new List<string> {
                    "только от внутренних факторов организации и бизнеса",
                    "только от внешних условий ведения бизнеса",
                    "от рационального сочетания внутренней и внешней эффективности"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Number = 9,
                Description = "Стратегическая эффективность – это: ",
                Answers = new List<string> {
                    "оценка качества стратегий организации",
                    "эффективность,  связанная со стратегическим менеджментом,  т. е.  целенаправленным развитием организации на долгосрочную перспективу в условиях меняющейся, неопределенной среды",
                    "оценка эффективности деятельности организации на долгосрочную перспективу"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Number = 10,
                Description = "Стоимость бизнеса, как критерий эффективности менеджмента и бизнеса, определяется:",
                Answers = new List<string> {
                    "объемом выпускаемой (в стоимостном выражении) продукции организацией",
                    "стоимостью имущественного комплекса организации",
                    "доходностью, рисками и перспективами развития организации"
                },
                RightAnswers = new HashSet<int> { 2 }
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
