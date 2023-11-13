using System;


namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            Product Apple = new Product();
            
            Apple.Id = 1;
            Apple.Name = "elma";
            Apple.Price = 15;
            Apple.Description = "Amasya Elması";
            Apple.Stock = 20;


            Product Watermelon = new Product();

            Watermelon.Name = "karpuz";
            Watermelon.Price = 80;
            Watermelon.Description = "Diyarbakır karpuzu";
            Watermelon.Stock = 25;



            Product[] products = new Product[]
            {
                Apple,Watermelon
            };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Id);

                Console.WriteLine("------------------------------");


            }

            Console.WriteLine("----------------Methods-----------");



            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(Apple);
            sepetManager.Add(Watermelon);

            


            sepetManager.Add2("armut", "yesil armut", 12);
            sepetManager.Add2("elma", "yesil elma", 15);

            Console.ReadLine();
        }
    }
}
