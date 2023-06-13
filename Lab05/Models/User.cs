using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public abstract class User
    {
        // username
        public string Username { get; set; }
        public string Password { get; set; }
        public int ID { get; private set; } = UserDict.Instance.Users.Count;
        public string FullName { get; set; } = "Unnamed User";

        public User()
        {
            
        }

        public string GetInfo()
        {
            return $"ID: {ID}\nUsername: {Username}\nFull Name: {FullName}";
        }

        public void Edit(){
            Console.WriteLine("Enter new username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            Password = Console.ReadLine();
            Console.WriteLine("Enter new full name: ");
            FullName = Console.ReadLine();
        }
        // public void CreateOrder(){
        //     // Create order detail, add to order, ask the user if they want to add more product
        //     // If yes, repeat the process
        //     // If no, calculate total price, set status to "Confirmed"
        //     while(true){
        //         Console.WriteLine("Enter product ID: ");
        //         int productID = int.Parse(Console.ReadLine());
        //         Console.WriteLine("Enter quantity: ");
        //         int quantity = int.Parse(Console.ReadLine());
        //         if (ProductDict.Instance.Products.ContainsKey(productID)){
        //             OrderDetail orderDetail = new OrderDetail();
        //             orderDetail.ProductID = productID;
        //             orderDetail.Quantity = quantity;
        //             // OrderDict.Instance.Orders[ID].OrderDetails.Add(orderDetail);
        //         }
        //         else{
        //             Console.WriteLine("Product not found!");
        //         }
        //         // Add order detail to order
        //         Console.WriteLine("Do you want to add more product? (Y/N)");
        //         string choice = Console.ReadLine();
        //         if(choice == "N"){
        //             break;
        //         }
        //     }
        // }
        // // Search product
        // public void SearchProduct(){
        //     Console.WriteLine("Enter product name: ");
        //     string name = Console.ReadLine();
        //     List<Product> products = ProductDict.Instance.GetAll();
        //     foreach(Product product in products){
        //         if(product.Name == name){
        //             Console.WriteLine(product.GetInfo());
        //         }
        //     }
        // }
    }
}