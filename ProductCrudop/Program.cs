using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCrud crud = new ProductCrud();
            try
            {

                int choice = 1;
                do
                {


                    Console.WriteLine("1.Product List");
                    Console.WriteLine("2.Add product");
                    Console.WriteLine("3.Modify product");
                    Console.WriteLine("4.Delete Product");
                    Console.WriteLine("5.GetProductById");
                    Console.WriteLine("Select option from above");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            List<Product> product = crud.ProductLists();
                            Console.WriteLine("Id  Name  Price");
                            foreach(var item in product)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case 2:
                            Product p1 = new Product();
                            Console.WriteLine("Enter id:");
                            p1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            p1.Name = Console.ReadLine();
                            Console.WriteLine("Enter price:");
                            p1.Price = Convert.ToInt32(Console.ReadLine());
                            crud.AddProduct(p1);
                            break;

                        case 3:
                            Product p2 = new Product();
                            Console.WriteLine("Enter existing id:");
                            p2.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name:");
                            p2.Name = Console.ReadLine();
                            Console.WriteLine("enter New Price:");
                            p2.Price = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyProduct(p2);
                            Console.WriteLine("update Successfuly");
                            break;

                        case 4:
                            Console.WriteLine("Enter existing id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteProduct(id);
                            Console.WriteLine("Product Delete SuccessFuly");
                            break;

                        case 5:
                            Console.WriteLine("Enter Existing id:");
                            int id1 = Convert.ToInt32(Console.ReadLine());
                            Product prod = crud.GetProductById(id1);
                            Console.WriteLine(prod);
                            break;


                    }
                    Console.WriteLine("Press 1 for continue and 0 for exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice == 1);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
