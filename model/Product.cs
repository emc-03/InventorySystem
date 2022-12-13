using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_EmilyCarter.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set;}

        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

 
        //public Product(int pID, string name, decimal price, int inStock, int min, int max)
        //{
        //    ProductID = pID;
        //    Name = name;
        //    Price = price.ToString();
        //    InStock = inStock;
        //    Min = min;
        //    Max = max;


        //}

        public void Add(Product product)
        {
        
        }

        public void AddAssociatedPart(Part parts)
        {
            AssociatedParts.Add(parts);
        }

        public bool RemovedAssociatedPart(int partID)
        {
           
            Part part = LookupAssociatedPart(partID);

            if (part == null)
            {
                return false;
            }
            else
            {
                AssociatedParts.Remove(part);
                return true;
            }
           
         
        }

       public Part LookupAssociatedPart(int partID) {

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
           
            return null;
       }



    }
     
    }

