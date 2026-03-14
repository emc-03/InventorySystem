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

        public int ProductID { get { return productID; } set { productID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }

        public int InStock { get { return inStock; } set { inStock = value; } }
        public int Min { get { return min; } set { min = value; } }
        public int Max { get { return max; } set { max = value; } }



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

