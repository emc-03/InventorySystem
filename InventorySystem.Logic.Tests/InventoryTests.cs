using InventorySystem.Logic.helper;
using InventorySystem.Logic.model;
using Xunit;

namespace InventorySystem.Tests
{
    public class InventoryTests
    {
        public InventoryTests()
        {

            // Clean the inventory before each test
            Inventory.AllParts.Clear();
            Inventory.Products.Clear();

        }
        // Test for adding a part to the inventory, should increase the count of parts in the inventory
        [Fact]
        public void AddPart_ValidPart_IncreasesPartCount()
        {
            // Arrange
            Part part = new Inhouse
            {
                PartID = 1,
                Name = "Test Part",
                Price = 10.99m,
                InStock = 5,
                Min = 1,
                Max = 10,
                MachineID = 123
            };
            // Act
            Inventory.AddPart(part);
            // Assert
            Assert.Single(Inventory.AllParts);
            Assert.Equal("Test Part", Inventory.AllParts[0].Name);
        }

        //Happy path: Looking up an existing part by its ID should return the correct part from the inventory
        [Fact]

        public void LookupPart_ExistingPartID_ReturnsCorrectPart()
        {
            // Arrange
            Part part = new Inhouse
            {
                PartID = 1,
                Name = "Test Part",
                Price = 10.99m,
                InStock = 5,
                Min = 1,
                Max = 10,
                MachineID = 123
            };
            Inventory.AddPart(part);
            // Act
            Part result = Inventory.LookupPart(1);
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Part", result.Name);


        }
        // Lookup an existing part by its ID should return null if the
        // //part does not exist in the inventory
        [Fact]

        public void LookupPart_NonExistingPartID_ReturnsNull()
        {
            // Arrange
            Part part = new Inhouse
            {
                PartID = 1,
                Name = "Test Part",
                Price = 10.99m,
                InStock = 5,
                Min = 1,
                Max = 10,
                MachineID = 123
            };
            Inventory.AddPart(part);
            // Act
            Part result = Inventory.LookupPart(999); // Using a non-existing ID
            // Assert
            Assert.Null(result);
        }
        // Deleting an existing part by its ID should remove the part from the inventory and return true
        [Fact]

        public void DeletePart_ExistingPart_ReturnsTrueAndRemovesPart()
        {
            // Arrange
            Part part = new Inhouse
            {
                PartID = 1,
                Name = "Test Part",
                Price = 10.99m,
                InStock = 5,
                Min = 1,
                Max = 10,
                MachineID = 123
            };
            Inventory.AddPart(part);
            // Act
            bool result = Inventory.DeletePart(part);
            // Assert
            Assert.True(result);
            Assert.Empty(Inventory.AllParts);


        }
    }

}