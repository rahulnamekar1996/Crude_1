using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crude_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  ProductCrude crude = new ProductCrude();

            int option = 0;
            do
            {
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.update product");
                Console.WriteLine("3.Delete product");
                Console.WriteLine("4. Display all products");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        Product p1 = new Product();
                        Console.WriteLine("Enter product id");
                        p1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p1.name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p1.price = Convert.ToDouble(Console.ReadLine());
                        crude.AddProduct(p1);
                        break;

                    case 2:
                        Product p2 = new Product();
                        Console.WriteLine("Enter id to modify");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter product name");
                        p2.name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p2.price = Convert.ToDouble(Console.ReadLine());
                        crude.UpdateProduct(p2);
                        break;

                    case 3:

                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crude.DeleteProduct(id);
                        break;

                    case 4:
                        List<Product> list = crude.GetProducts();
                        foreach (Product p in list)
                        {
                            Console.WriteLine($"{p.id} {p.name} {p.price}");
                        }
                        break;


                }

                Console.WriteLine("presss 1 for continue");
                option = Convert.ToInt32(Console.ReadLine());



            }

            while (option == 1);*/

        
        
               EmployeeCrude crude = new EmployeeCrude();

            int option = 0;
            do
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Update employee");
                Console.WriteLine("3.Delete employee");
                Console.WriteLine("4.Display all employee");
                int op=Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        Employee e1= new Employee();
                        Console.WriteLine("Enter employee id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter eplyee name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter employee sallary");
                        e1.sallary=Convert.ToDouble(Console.ReadLine());
                        crude.AddEmployee(e1);
                        break;
                        

                    
                    case 2:
                        Employee e2= new Employee();
                        Console.WriteLine("Enter id to modify");
                        e2.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employye name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine(" Enter employye price");
                        e2.sallary=Convert.ToDouble(Console.ReadLine());
                        crude.AddEmployee(e2);
                        break;
                       
                    
                    case 3:

                        Console.WriteLine("Enter id delete");
                        int id=Convert.ToInt32(Console.ReadLine());
                        crude.DeleteEmolyee(id);
                        break;

                    case 4:
                        List<Employee> list=crude.GetEmployees();
                        foreach(Employee e in list)
                        {
                            Console.WriteLine($"{e.Id}  {e.Name} {e.sallary}");
                        }
                        break;


                }
                Console.WriteLine("Enter1 option for continue");
                option=Convert.ToInt32(Console.ReadLine());





            }
            while(option==1);
        }  


       
   
    
    
    
    


    }
}
