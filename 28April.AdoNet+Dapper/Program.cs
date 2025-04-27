using _28April.AdoNet_Dapper.Models;
using _28April.AdoNet_Dapper.Repositories.Implementations;

namespace _28April.AdoNet_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            //productRepository.Add(new Product
            //{
            //    Name = "Salvar",
            //    Price = 60,
            //    CategoryId = 1,
            //});

            //List<Product> prods = productRepository.GetAll();
            //foreach (Product prod in prods)
            //{
            //    Console.WriteLine(prod.Id + " " + prod.Name + " " + prod.Price);
            //}

            //productRepository.Delete(1);

            //var product = productRepository.GetById(4);
            //Console.WriteLine(product.Id + " " + product.Name + " " + product.Price);

            //productRepository.Update(1, new Product
            //{
            //    Name = "Etek",
            //    Price = 40,
            //    CategoryId = 1,
            //});
            start:
            Console.WriteLine("Seciminizi daxil edin:\n1. Product elave et\n2. Product update et\n3. Product sil\n4. Butun Product-ları goster (GetAll  *yanında categoryside gorunmelidir)\n5. Product-u Id-e gore tap (GetById)\n6. Category elave et\n7. Category update et\n8. Category sil\n9. Bütün Category-leri goster (GetAll)\n10. Category-ni Id-e gore tap (GetById)\n0. Cixish");
            string choice=Console.ReadLine();
            
            
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ardicilliqla mehsulun adini,qiiymetini ve categoryId daxil edin:");
                        productRepository.Add(new Product
                        {
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine()),
                            CategoryId = Convert.ToInt32(Console.ReadLine()),
                        });
                        break;
                    case "2":
                        Console.WriteLine("Deyishmek istediyiniz mehsulun id-nint daxil edin");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ardicilliqla yeni mehsulun adini,qiiymetini ve categoryId daxil edin:");
                        productRepository.Update(id, new Product
                        {
                            Name = Console.ReadLine(),
                            Price = Convert.ToInt32(Console.ReadLine()),
                            CategoryId = Convert.ToInt32(Console.ReadLine()),
                        });
                        break;
                    case "3":
                        Console.WriteLine("Silmek istediyiniz mehsulun id-ni qeyd edin:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        productRepository.Delete(id2);
                        break;
                    case "4":
                        List<Product> prods = productRepository.GetAll();
                        foreach (Product prod in prods)
                        {
                            Console.WriteLine(prod.Id + " " + prod.Name + " " + prod.Price);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Melumat almaq istediyiniz mehsulun id-ni daxil edin:");
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        var product = productRepository.GetById(id3);
                        Console.WriteLine(product.Id + " " + product.Name + " " + product.Price);
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "0":
                        break;
                }
            goto start;
        }
    }
}
