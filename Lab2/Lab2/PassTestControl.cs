﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2 {
    public partial class PassTestControl : UserControl {
        private Test _test;

        public PassTestControl() {
            InitializeComponent();
        }

        private void PassTestControl_Load(object sender, System.EventArgs e) {
            InitData();
            for (var i = 0; i < _test.Questions.Count; i++) {
                var question = _test.Questions[i];

                var label = new Label {
                    Text = question.Description,
                    AutoSize = true,
                    Tag = $"lbl_{i}",
                    Location = new Point(10, i * 10)
                };
                Controls.Add(label);
            }
        }

        private void InitData() {
            _test = new Test {
                Theme = "Основы государственного управления экономикой",
                Questions = new List<Question>()
            };

            _test.Questions.Add(new Question {
                Description = "Основной целью государственного регулирования экономики является: ",
                Answers = new List<string> {
                    "контроль и ограничение деятельности коммерческих организаций на рынке",
                    "обеспечение правовых основ экономических решений, равных условий и стабильности правил хозяйствования",
                    "перераспределение ресурсов в пользу неэффективных, но общественно значимых производств"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Объектом государственного регулирования являются: ",
                Answers = new List<string> {
                    "все отрасли и подразделения материального производства; товарные, фондовый, валютный рынки, ценообразование, денежное обращение, а также предприятия независимо от формы собственности и хозяйствования",
                    "государственные предприятия и организации",
                    "неэффективные и финансово неблагополучные предприятия"
                },
                RightAnswers = new HashSet<int> { 0, 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Государственное регулирование основывается:",
                Answers = new List<string> {
                    "на административных методах властного управления",
                    "на правах, бюджетной, банковской системы, государственных заказах и др.",
                    "на мониторинге ситуации и вмешательстве в критических ситуациях"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Деятельность предприятий в рыночной среде регулируется:",
                Answers = new List<string> {
                    "объективными законами рынка",
                    "командно-административными методами управления",
                    "правовыми методами"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Description = "Объектами муниципального управления являются:",
                Answers = new List<string> {
                    "население муниципального образования",
                    "население, инфраструктура и территория",
                    "население, ресурсы и предприятия"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Муниципальное хозяйство – это совокупность:",
                Answers = new List<string> {
                    "предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность",
                    "предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность, направленную на удовлетворение коллективных (общественных) потребностей его населения",
                    "муниципальных предприятий и учреждений, осуществляющих на территории муниципального образования хозяйственную деятельность"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Социально-экономическое развитие субъекта хозяйственной деятельности подразумевает в первую очередь:",
                Answers = new List<string> {
                    "изменение территории муниципальных образований",
                    "дотации",
                    "самостоятельную деятельность в данном направлении"
                },
                RightAnswers = new HashSet<int> { 1 }
            });
            _test.Questions.Add(new Question {
                Description = "Под комплексным социально-экономическим развитием муниципального образования понимается процесс изменений в различных сферах жизни муниципального образования, направленных на достижение определенного уровня развития социальной (в том числе духовной) и экономической сферна данной территории, осуществляемых с наименьшим ущербом для природных ресурсов и предлагающих максимальное удовлетворение потребностей населения и при соблюдении интересов государства, управляемый:",
                Answers = new List<string> {
                    "государством",
                    "органами местного самоуправления",
                    "населением"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Description = "Эффективность государственного управления – это:",
                Answers = new List<string> {
                    "соотношение достигнутых общественных целей и использованных государственных ресурсов",
                    "обеспечение роста национального дохода",
                    "характеристика качества применяемом государством решений и их реализации"
                },
                RightAnswers = new HashSet<int> { 2 }
            });
            _test.Questions.Add(new Question {
                Description = "Базовые ценности государства – это:",
                Answers = new List<string> {
                    "обобщенные цели, составляющие основу общегосударственных интересов и политической стратегии, а также инструментальные ценности, выражающие одобряемые обществом средства достижения целей",
                    "основополагающие ценности, обеспечивающие устойчивость функционирования государства",
                    "основные разделяемые обществом устои, ценности, а также национальные традиции"
                },
                RightAnswers = new HashSet<int> { 0 }
            });
        }
    }
}