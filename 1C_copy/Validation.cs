using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1C_copy
{
    public class Validation
    {
        public static (bool IsValid, string ErrorMessage) VerifyPassword(string password)
        {
            // Проверка длины пароля
            if (password.Length < 5 || password.Length > 20)
                return (false, "Длина пароля должна быть от 5 до 20 символов.");

            // Проверка на наличие запрещенных символов
            if (Regex.IsMatch(password, @"[@#$%^&]"))
                return (false, "Пароль не должен содержать символы: @#$%^&");

            // Проверка на наличие как минимум одной заглавной и одной строчной буквы
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
                return (false, "Пароль должен содержать как минимум одну заглавную и одну строчную букву.");

            // Проверка на наличие цифр
            if (!password.Any(char.IsDigit))
                return (false, "Пароль должен содержать как минимум одну цифру.");

            // Проверка на использование только латиницы
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
                return (false, "Пароль должен состоять только из латинских букв и цифр.");

            // Если все проверки пройдены
            return (true, "");
        }
    }
}