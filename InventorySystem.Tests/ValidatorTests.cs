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
    }
}