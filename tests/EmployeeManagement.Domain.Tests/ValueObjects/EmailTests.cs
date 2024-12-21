using EmployeeManagement.Domain.ValueObjects;

namespace EmployeeManagement.Domain.Tests.ValueObjects
{
    public class EmailTests
    {
        [Fact]
        public void Email_Constructor_ShouldCreateValidEmail()
        {
            // Arrange
            var validEmail = "test@example.com";

            // Act
            var email = new Email(validEmail);

            // Assert
            Assert.Equal(validEmail, email.Value);
        }

        [Fact]
        public void Email_Constructor_ShouldThrowArgumentException_WhenEmailIsEmpty()
        {
            // Arrange
            var invalidEmail = "";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Email(invalidEmail));
            Assert.Equal("Email address cannot be empty or whitespace. (Parameter 'value')", exception.Message);
        }

        [Fact]
        #pragma warning disable CS8604 // Possible null argument reference.
        public void Email_Constructor_ShouldThrowArgumentException_WhenEmailIsNull()
        {
            // Arrange
            string? invalidEmail = null;

            // Act & Assert

            var exception = Assert.Throws<ArgumentException>(() => new Email(invalidEmail));
            Assert.Equal("Email address cannot be empty or whitespace. (Parameter 'value')", exception.Message);
        }
        #pragma warning restore CS8604 // Possible null argument reference.

        [Fact]
        public void Email_Constructor_ShouldThrowArgumentException_WhenEmailIsInvalidFormat()
        {
            // Arrange
            var invalidEmail = "invalid-email";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Email(invalidEmail));
            Assert.Equal("Invalid email address format. (Parameter 'value')", exception.Message);
        }

        [Fact]
        public void Email_Equality_ShouldReturnTrue_WhenEmailsAreEqual()
        {
            // Arrange
            var email1 = new Email("test@example.com");
            var email2 = new Email("test@example.com");

            // Act & Assert
            Assert.True(email1.Equals(email2));
        }

        [Fact]
        public void Email_Equality_ShouldReturnFalse_WhenEmailsAreDifferent()
        {
            // Arrange
            var email1 = new Email("test@example.com");
            var email2 = new Email("another@example.com");

            // Act & Assert
            Assert.False(email1.Equals(email2));
        }

        [Fact]
        public void Email_ToString_ShouldReturnCorrectEmailString()
        {
            // Arrange
            var email = new Email("test@example.com");

            // Act
            var emailString = email.ToString();

            // Assert
            Assert.Equal("test@example.com", emailString);
        }
    }
}
