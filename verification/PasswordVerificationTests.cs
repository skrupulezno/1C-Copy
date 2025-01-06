using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1C_copy; 

namespace verification
{
    [TestClass]
    public class PasswordVerificationTests
    {
        [TestMethod]
        public void VerifyPassword_LengthLessThan5_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "abc1";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Длина пароля должна быть от 5 до 20 символов.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_LengthGreaterThan20_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "abcdefghijklmnopqrstuvwxyz1234567890";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Длина пароля должна быть от 5 до 20 символов.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_ContainsForbiddenCharacters_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "abc@123";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Пароль не должен содержать символы: @#$%^&", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_NoUpperCase_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "abc123";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Пароль должен содержать как минимум одну заглавную и одну строчную букву.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_NoLowerCase_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "ABC123";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Пароль должен содержать как минимум одну заглавную и одну строчную букву.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_NoDigits_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "Abcdef";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Пароль должен содержать как минимум одну цифру.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_ContainsNonLatinCharacters_ReturnsFalseWithErrorMessage()
        {
            // Arrange
            string password = "Abc123привет";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Пароль должен состоять только из латинских букв и цифр.", result.ErrorMessage);
        }

        [TestMethod]
        public void VerifyPassword_ValidPassword_ReturnsTrueWithSuccessMessage()
        {
            // Arrange
            string password = "Abc123";

            // Act
            var result = Validation.VerifyPassword(password);

            // Assert
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Пароль валиден.", result.ErrorMessage);
        }
    }
}