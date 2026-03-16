using InventorySystem_EmilyCarter.helper;
using Xunit;

namespace InventorySystem.Tests
{
    public class ValidatorTests
    {
        private readonly Validator _validator = new Validator();

        // Test 1 - valid inputs should return true
        [Fact]
        public void ValidateMinMaxValues_ValidInputs_ReturnsTrue()
        {
            // Arrange
            int min = 5;
            int max = 20;

            // Act
            bool result = _validator.ValidateMinMaxValues(min, max, out string errorMessage);

            // Assert
            Assert.True(result);
            Assert.Equal(string.Empty, errorMessage);
        }

        // Test 2 - Min equal to Max should be allowed (boundary/edge case)
        [Fact]
        public void ValidateMinMaxValues_MinEqualsMax_ReturnsTrue()
        {
            // Arrange
            int min = 10;
            int max = 10;

            // Act
            bool result = _validator.ValidateMinMaxValues(min, max, out string errorMessage);

            // Assert
            Assert.True(result);
            Assert.Equal(string.Empty, errorMessage);
        }

        // Test 3 - Min greater than Max should fail
        [Fact]
        public void ValidateMinMaxValues_MinGreaterThanMax_ReturnsFalse()
        {
            // Arrange
            int min = 50;
            int max = 10;

            // Act
            bool result = _validator.ValidateMinMaxValues(min, max, out string errorMessage);

            // Assert
            Assert.False(result);
            Assert.Contains("Min should be less than or equal to Max", errorMessage);
        }

        // Test 4 - Negative Max should fail
        [Fact]
        public void ValidateMinMaxValues_NegativeMax_ReturnsFalse()
        {
            // Arrange
            int min = 0;
            int max = -5;

            // Act
            bool result = _validator.ValidateMinMaxValues(min, max, out string errorMessage);

            // Assert
            Assert.False(result);
            Assert.Contains("Max should not be less than zero", errorMessage);
        }

        // Test 5 - Negative Min should fail
        [Fact]
        public void ValidateMinMaxValues_NegativeMin_ReturnsFalse()
        {
            // Arrange
            int min = -1;
            int max = 10;

            // Act
            bool result = _validator.ValidateMinMaxValues(min, max, out string errorMessage);

            // Assert
            Assert.False(result);
            Assert.Contains("Min should not be less than zero", errorMessage);
        }
        //Test Machine ID 1 - Valid Machine ID should return True 
        [Fact]
        public void ValidateMachineID_ValidInput_ReturnsTrue()
        {
            // Arrange
            string machineIDText = "123";
            // Act
            bool result = _validator.ValidateMachineID(machineIDText, out int? machineID, out string errorMessage);
            // Assert
            Assert.True(result);
            Assert.Equal(123, machineID);
            Assert.Equal(string.Empty, errorMessage);
        }

        // Test Machine ID 2 - Non-integer input should return False
        [Fact]

        public void ValidateMachineID_EmptyInput_ReturnsFalse()
        {
            // Arrange
            string machineIDText = "";
            // Act
            bool result = _validator.ValidateMachineID(machineIDText, out int? machineID, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(machineID);
            Assert.Contains("Machine ID cannot be empty", errorMessage);
        }

        // Test Machine ID 3 - Non-integer input should return False
        [Fact]

        public void ValidateMachineID_NonInteger_ReturnsFalse()
        {
            // Arrange
            string machineIDText = "abc";
            // Act
            bool result = _validator.ValidateMachineID(machineIDText, out int? machineID, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(machineID);
            Assert.Contains("Machine ID must be a valid integer", errorMessage);
        }

        // Test Machine ID 4 - Whitespace input should return False
        [Theory]
        [InlineData(" 123")] //leading whitespace
        [InlineData("123 ")] //trailing whitespace
        [InlineData("12 3")] //internal whitespace
        public void ValidateMachineID_WhitespaceInput_ReturnsFalse(string machineIDText)
        {
            // Act
            bool result = _validator.ValidateMachineID(machineIDText, out int? machineID, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(machineID);
            Assert.Contains("Machine ID should not contain spaces", errorMessage);
        }

        // Test Company Name 1 - Valid Company Name should return True
        [Fact]

        public void ValidateCompanyName_ValidInput_ReturnsTrue()
        {
            // Arrange
            string companyNameInput = "Tech Solutions";
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.True(result);
            Assert.Equal("Tech Solutions", validatedName);
            Assert.Equal(string.Empty, errorMessage);
        }

        // Test Company Name 2 - Null input should return False

        [Fact]

        public void ValidateCompanyName_NullInput_ReturnsFalse()
        {
            // Arrange
            string companyNameInput = null;
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(validatedName);
            Assert.Contains("Company Name cannot be empty", errorMessage);
        }

        // Test Company Name 3 - Does not contain numbers should return True
        [Fact]

        public void ValidateCompanyName_ContainsNumbers_ReturnsFalse()
        {
            // Arrange
            string companyNameInput = "Tech Solutions 123";
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(validatedName);
            Assert.Contains("Company Name should not contain numbers", errorMessage);
        }
        // Test Company Name 4 - Exceeding maximum length should return False
        [Fact]
        public void ValidateCompanyName_ExceedsMaxLength_ReturnsFalse()
        {
            // Arrange
            string companyNameInput = new string('A', 101); // Assuming max length is 100 characters
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(validatedName);
            Assert.Contains("Company Name should not exceed 100 characters", errorMessage);
        }
        // Test Company Name 5 - Minimum length 5 characters should return True
        [Fact]

        public void ValidateCompanyName_BelowMinLength_ReturnsFalse()
        {
            // Arrange
            string companyNameInput = "Tech"; // Assuming minimum length is 5 characters
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.False(result);
            Assert.Null(validatedName);
            Assert.Contains("Company Name should be at least 5 characters long", errorMessage);
        }


        // Test Company Name 6 - Happy path with leading/trailing whitespace should return True and trim the whitespace
        [Fact]

        public void ValidateCompanyName_ValidInputWithWhitespace_ReturnsTrueAndTrims()
        {
            // Arrange
            string companyNameInput = "  Tech Solutions  ";
            // Act
            bool result = _validator.ValidateCompanyName(companyNameInput, out string? validatedName, out string errorMessage);
            // Assert
            Assert.True(result);
            Assert.Equal("Tech Solutions", validatedName); // Expecting trimmed result
            Assert.Equal(string.Empty, errorMessage);
        }
    }
}