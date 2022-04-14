class Sample
{
    static void Main()
    {
        //local constant
        const string developerName = "Amara Finbarrs";

        //create objects
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 3

        //initialize fields
        //product1
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);

        //product 2
        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);

        //product3
        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(8000);

        //call methods
        product1.CalculateTax(10000, 3.4);
        product2.CalculateTax(percentage:7.4);
        product3.CalculateTax(15.2);


        //get values from fields
        //Developer name
        System.Console.WriteLine("Name of Developer: " + developerName);

        //product 1
        System.Console.WriteLine("\nProduct 1: ");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Cost: " + product1.GetCost());
        System.Console.WriteLine("Quantity  in Stock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product1.GetTax());

        //product 2
        System.Console.WriteLine("\nProduct 2: ");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Cost: " + product2.GetCost());
        System.Console.WriteLine("Quantity  in Stock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product2.GetTax());

        //product 3
        System.Console.WriteLine("\nProduct 3: ");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Cost: " + product3.GetCost());
        System.Console.WriteLine("Quantity  in Stock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product3.GetTax());

        //total Quantity
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

        System.Console.WriteLine("\nTotal Quantity: " + totalQuantity);
        System.Console.WriteLine("\nTotal no. of Products: " + Product.GetTotalNoOfProducts()); //Output: 3
        System.Console.WriteLine("\nCategory of Products: " + Product.CategoryName); //Output: Electronics

        double p1 = product1.GetCost();
        double p2 = product2.GetCost();
        double p3 = product3.GetCost();

        //to find the highest cost of the three products
        if (p1 > p2 && p1 > p3)
        {
            System.Console.WriteLine("\nProduct 1 cost more");
        }
        else if (p2 > p1 && p2 > p3)
        {
            System.Console.WriteLine("\nProduct 2 cost more");
        }
        else
        {
            System.Console.WriteLine("\nProduct 3 cost more");
        }

        System.Console.ReadKey();

    }


}
