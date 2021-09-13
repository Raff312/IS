using System;
using System.Text;

namespace Lab1 {
    public class Program {
        public static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("* 1 - Да, 0 - Нет *");
            var userAnswer = Utils.GetValueFromUser<int>("\nПО из сферы развлечений? ");

            if (userAnswer == 1) {
                userAnswer = Utils.GetValueFromUser<int>("\nМультимедиа? ");

                if (userAnswer == 1) {
                    Console.WriteLine("Ваш выбор: Контентные ПО");
                } else {
                    Console.WriteLine("Ваш выбор: Игры");
                }
            } else {
                userAnswer = Utils.GetValueFromUser<int>("\nПО из сферы услуг? ");

                if (userAnswer == 1) {
                    Console.WriteLine("Ваш выбор: Промо-приложения");
                } else {
                    Console.WriteLine("Ваш выбор: Новостные ПО");
                }
            }
        }
    }
}
