namespace Homework01.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Sample
            List<Product> products = new List<Product>()
            {
            new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
            new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
            new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
            new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
            new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
            new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
            new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
            new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
            new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
            new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
            new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
            new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
            new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
            new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
            new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
            new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
            new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
            new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
            new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
            new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
            new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
            new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
            new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
            };

            // 1. Get all products in Smartphones category
            List<Product> smartphones = products.Where(p => p.Category == ProductCategory.Smartphones).ToList();
            

            // 2. Select titles of all products
            List<string> titles = products.Select(p => p.Title).ToList();

            // 3. Get all products with price > 1000
            List<Product> expensiveProducts = products.Where(p => p.Price > 1000).ToList();

            // 4. Get brands of all skincare products
            List<string> skincareBrands = products
                .Where(p => p.Category == ProductCategory.Skincare)
                .Select(p => p.Brand)
                .ToList();

            // 5. Get first product with rating > 4.8
            Product topRatedProduct = products.FirstOrDefault(p => p.Rating > 4.8);

            // 6. Get all products that are out of stock
            List<Product> outOfStockProducts = products.Where(p => p.Stock == 0).ToList();

            // 7. Get prices of fragrance products
            List<double> fragrancePrices = products
                .Where(p => p.Category == ProductCategory.Fragrances)
                .Select(p => p.Price)
                .ToList();

            // 8. Get description of first product with rating == 4.43
            Product productWithSpecificRating = products.FirstOrDefault(p => p.Rating == 4.43);
            if (productWithSpecificRating != null)
            {
                string description = productWithSpecificRating.Description;
            }

            // 9. Get title of last skincare product with price < 50
            Product lastCheapSkincare = products
                .Where(p => p.Category == ProductCategory.Skincare && p.Price < 50)
                .LastOrDefault();
            if (lastCheapSkincare != null)
            {
                string title = lastCheapSkincare.Title;
            }

            // 10. Get title of first fragrance product with price > 100
            Product firstExpensiveFragrance = products
                .Where(p => p.Category == ProductCategory.Fragrances && p.Price > 100)
                .FirstOrDefault();
            if (firstExpensiveFragrance != null)
            {
                string fragranceTitle = firstExpensiveFragrance.Title;
            }

            // 11. Get brand of last product with stock < 40
            Product lastLowStock = products
                .Where(p => p.Stock < 40)
                .LastOrDefault();
            if (lastLowStock != null)
            {
                string brand = lastLowStock.Brand;
            }

            // 12. Get title of first Laptop with stock > 80
            Product firstLaptopHighStock = products
                .Where(p => p.Category == ProductCategory.Laptops && p.Stock > 80)
                .FirstOrDefault();
            if (firstLaptopHighStock != null)
            {
                string laptopTitle = firstLaptopHighStock.Title;
            }

            // 13. Get title of first product with price > 1200
            Product firstOver1200 = products.FirstOrDefault(p => p.Price > 1200);
            if (firstOver1200 != null)
            {
                string expensiveTitle = firstOver1200.Title;
            }

            // 14. Get stock count of last Smartphone
            Product lastSmartphone = products
                .Where(p => p.Category == ProductCategory.Smartphones)
                .LastOrDefault();
            if (lastSmartphone != null)
            {
                int stock = lastSmartphone.Stock;
            }

            // 15. Map products to ProductDetails
            List<ProductDetails> productDetailsList = products
                .Select(p => new ProductDetails
                {
                    Id = p.Id,
                    Title = p.Title,
                    Price = p.Price
                })
                .ToList();
        }
    }
}
