using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_EmilyCarter.model
{
    public static class Inventory
    {

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        private static int ProductID;

        
        public static void addDataProducts() {

                            
            Product product1 = new Product
            {
                ProductID = 1,
                Name = "One",
                Price = 3,
                InStock = 5,
                Max = 2,
                Min = 0,
            };

            Product product2 = new Product
            {
                ProductID = 2,
                Name = "Two",
                Price = 5,
                InStock = 6,
                Max = 4,
                Min = 0,
            };

            Product product3 = new Product
            {
                ProductID = 3,
                Name = "Three",
                Price = 7,
                InStock = 8,
                Max = 6,
                Min = 0,

            }; Product product4 = new Product
            {
                ProductID = 4,
                Name = "Four",
                Price = 9,
                InStock = 10,
                Max = 8,
                Min = 0,
            };

            Product product5 = new Product
            {
                ProductID = 5,
                Name = "Five",
                Price = 11,
                InStock = 12,
                Max = 10,
                Min = 0,
            };

            Products.Add(product1);
            Products.Add(product2);
            Products.Add(product3);
            Products.Add(product3);
            Products.Add(product4);
            Products.Add(product5);
        }

        public static void addDataParts() {

            Part part1 = new Inhouse
            {
                PartID = 1,
                Name = "Part One", 
                MachineID = 22, 
                InStock = 5,
                Max = 20, 
                Min = 0, 
                Price = 2
            };
            Part part2 = new Inhouse
            {
                PartID = 2,
                Name = "Part Two",
                MachineID = 33,
                InStock = 10,
                Max = 50,
                Min = 0,
                Price = 4
            };

            Part part3 = new Inhouse { 
            
                 PartID = 3,
                 Name = "Part Three",
                 MachineID = 44,
                 InStock = 15,
                 Max = 55,
                 Min = 0,
                 Price = 6

            };

            Part part4 = new Inhouse
            {
                PartID = 4,
                Name = "Part Four",
                MachineID = 55,
                InStock = 20,
                Max = 66,
                Min = 0,
                Price = 8

            };

            Part part5 = new Inhouse
            {
                PartID = 5,
                Name = "Part Five",
                MachineID = 66,
                InStock = 20,
                Max = 77,
                Min = 0,
                Price = 10

            };

            Part outSourced1 = new Outsourced
            {
                PartID = 1,
                Name = "One",
                CompanyName = "Tuple",
                InStock = 1,
                Max = 20,
                Min = 0,
                Price = 9
            };
            Part outSourced2 = new Outsourced
            {
                PartID = 2,
                Name = "Two",
                CompanyName = "Aspire",
                InStock = 2,
                Max = 30,
                Min = 0,
                Price = 10
            };

            Part outSourced3 = new Outsourced
            {
                PartID = 3,
                Name = "Three",
                CompanyName = "Shell",
                InStock = 3,
                Max = 40,
                Min = 0,
                Price = 11
            };

            Part outSourced4 = new Outsourced
            {
                PartID = 4,
                Name = "Four",
                CompanyName = "Switch",
                InStock = 4,
                Max = 50,
                Min = 0,
                Price = 12
            };

            Part outSourced5 = new Outsourced
            {
                PartID = 5,
                Name = "Five",
                CompanyName = "Clever",
                InStock = 5,
                Max = 60,
                Min = 0,
                Price = 13
            };

      
            Inventory.AllParts.Add(part1);
            Inventory.AllParts.Add(part2);
            Inventory.AllParts.Add(part3);
            Inventory.AllParts.Add(part4);
            Inventory.AllParts.Add(part5);

            Inventory.AllParts.Add(outSourced1);
            Inventory.AllParts.Add(outSourced2);
            Inventory.AllParts.Add(outSourced3);
            Inventory.AllParts.Add(outSourced4);
            Inventory.AllParts.Add(outSourced5);






        }

        public static void addProduct(Product addProduct) 
        {
            Products.Add(addProduct);
        }

        public static bool RemoveProduct(int index)
        {
            Products.RemoveAt(index);
            return true;
            
        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }

            return null;
        }

      public static void UpdateProduct(int productID, Product productName)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = productName;
                }
            }
        }

        // Part Methods 
      public static void AddPart(Part part)
        { 
            Inventory.AllParts.Add(part);
        }

        public static bool DeletePart(Part deletePart)
        {
            AllParts.Remove(deletePart);
            return true;
        }

       public static Part LookupPart(int lookPart)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == lookPart)
                {
                    return part;
                }
            }

            return null;
        }
     public static void updatePart(int partID, Part partName)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = partName;
                }
            }
        }

    }
}
