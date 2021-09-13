using System;
using System.ComponentModel;

namespace Lab1 {
    public static class Utils {
        public static T Convert<T>(this string input) {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter == null) {
                throw new Exception();
            }

            return (T)converter.ConvertFromString(input);
        }

        public static T GetValueFromUser<T>(string msg) {
            while (true) {
                Console.Write(msg);
                var userAnswer = Console.ReadLine();
                try {
                    return Utils.Convert<T>(userAnswer);
                } catch (Exception) {
                    Console.WriteLine("Неправильный тип ответа. Попробуйте еще раз...");
                }
            }
        }
    }
}