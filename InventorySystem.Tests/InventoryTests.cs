using InventorySystem_EmilyCarter.helper;
using InventorySystem_EmilyCarter.model;
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
}
  
}