namespace DataAdministrator.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productId { get; set; }

        [StringLength(50)]
        public string productName { get; set; }

        public int? unitPrice { get; set; }

        public int? categoryId { get; set; }

        public int? quantityAvailable { get; set; }

        public int? primeCost { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }

    public class ProductMockData
    {
        List<Product> products;

        object[,] MockData = new object[,]{
            {1, "Samsung 65 4K Ultra HD HDR Curved LED", 1699, ProductCategory.TV, 5, 600},
            {2, "LG 65 4K UHD HDR LED webOS3.0 Smart TV", 1299, ProductCategory.TV, 10, 400},
            {3, "Sony XBR X700D 55 4K UHD LED HDR Android Smart TV", 1199, ProductCategory.TV, 2, 350},
            {4, "Insignia 43 4K UHD LED Roku Smart TV", 499, ProductCategory.TV, 15, 155},
            {5, "Toshiba 49 4K UHD LED Chromecast", 849, ProductCategory.TV, 1, 355},
            {6, "Vizio E70u-D3 70 SmartCast 4K Ultra HD Home", 1699, ProductCategory.TV, 3, 550},
            {7, "Sharp LC-50N6000U 50 Smart 4K Ultra HD LED TV", 649, ProductCategory.TV, 25, 255},
            {8, "Hisense 55H7C 55 4K Ultra HD Smart LED TV", 599, ProductCategory.TV, 5, 223},
            {9, "LG 55UH615A 55 HDR 4K UHD ", 769, ProductCategory.TV, 0, 240},
            {10, "Samsung 75 4K UHD HDR LED Tizen Smart TV", 3799, ProductCategory.TV, 1, 1200},

            {11, "Frigidaire 33 22.1 Cu.", 1349, ProductCategory.Fridge, 10, 430},
            {12, "GE Cafe 36 21.9 Cu. Ft. Counter Depth", 1999, ProductCategory.Fridge, 5, 730},
            {13, "Samsung 35.7 21.5 Cu. Ft. Side By Side", 2599, ProductCategory.Fridge, 1, 890},
            {14, "Whirlpool 33 21.6 Cu. Ft. Stainless Steel", 1279, ProductCategory.Fridge, 8, 550},
            {15, "KitchenAid 49 29.5 Cu. Ft.Ice & Water Dispenser", 10099, ProductCategory.Fridge, 1, 3600},
            {16, "GE 36 25.4 Cu. Ft. Side-by-Side", 1699, ProductCategory.Fridge, 1, 400},
            {17, "Amana 33 21.2 Cu. with Water & Ice Dispenser ", 1329, ProductCategory.Fridge, 1, 449},
            {18, "Whirlpool 33 21.2 Cu. Ft. Side-by-Side", 1699, ProductCategory.Fridge, 1, 699},
            {19, "Frigidaire 33 22.6 Cu. Ft. Bottom Freezer", 1299, ProductCategory.Fridge, 1, 455},
            {20, "GE Profile 36 25.4 Cu. Ft. French Door", 2499, ProductCategory.Fridge, 1, 899},

            {21, "LG 5.2 Cu. Ft. High Efficiency Front Load", 799, ProductCategory.Washer, 15, 330},
            {22, "Samsung 4.8 Cu. Ft. High Efficiency Front Load", 699, ProductCategory.Washer, 3, 230},
            {23, "Insignia 1.6 Cu. Ft. Portable Washer", 349, ProductCategory.Washer, 4, 129},
            {24, "GE 4.9 Cu. Ft. Top Load Washer", 599, ProductCategory.Washer, 10, 210},
            {25, "LG 5.2 Cu. Ft. TurboWash Front Load Steam", 999, ProductCategory.Washer, 15, 329},
            {26, "Whirlpool 5.2 Cu. Front Load Steam Washer", 1149, ProductCategory.Washer, 2, 430},
            {27, "GE 4.8 Cu. Ft. Front Load Washer", 999, ProductCategory.Washer, 1, 430},
            {28, "Bosch 2.2 Cu. Ft. High Efficiency Front Load", 1399, ProductCategory.Washer, 22, 499},
            {29, "Samsung 5.8 Cu. Ft. High Efficiency Top Load", 1149, ProductCategory.Washer, 12, 330},
            {30, "LG 27 1.1 Cu. Ft. Sidekick Pedestal Washer", 899, ProductCategory.Washer, 5, 239},

            {31, "Bose SoundLink Color II Splashproof Portable", 149, ProductCategory.Audio, 25, 59},
            {32, "JBL Charge 3 Waterproof Wireless", 219, ProductCategory.Audio, 3, 79},
            {33, "Bose SoundLink Mini II Bluetooth", 249, ProductCategory.Audio, 14, 99},
            {34, "Sony SRS-XB2 Splashproof Wireless", 89, ProductCategory.Audio, 20, 35},
            {35, "Bang & Olufsen Beoplay S3 Bluetooth", 199, ProductCategory.Audio, 22, 89},
            {36, "Sennheiser Audiophile Headphones", 109, ProductCategory.Audio, 6, 33},
            {37, "Beats by Dr.Dre Powerbeats 3", 249, ProductCategory.Audio, 1, 99},
            {38, "JBL Duet BT On-Ear Bluetooth Wireless", 134, ProductCategory.Audio, 22, 52},
            {39, "Pioneer 5.2 Channel 3D 4K Ultra HD AV Receiver", 349, ProductCategory.Audio, 2, 129},
            {40, "Polk Audio RTIA7 300-Watt Tower Speaker", 399, ProductCategory.Audio, 5, 139},

            {41, "iPhone 7 32G", 899, ProductCategory.Phone, 45, 239},
            {42, "iPhone 7 Plus 32G", 1049, ProductCategory.Phone, 13, 333},
            {43, "Samsung Galaxy S7", 799, ProductCategory.Phone, 55, 229},
            {44, "Samsung Galaxy S7 Edge", 899, ProductCategory.Phone, 20, 245},
            {45, "LG V20", 999, ProductCategory.Phone, 25, 299},
            {46, "iPhone 6s 32G", 779, ProductCategory.Phone, 6, 219},
            {47, "Samsung Galaxy A5", 500, ProductCategory.Phone, 1, 199},
            {48, "Huawei GR5", 375, ProductCategory.Phone, 5, 129},
            {49, "Pixel XL, Phone by Google", 1049, ProductCategory.Phone, 1, 399},
            {50, "LG G5", 800, ProductCategory.Phone, 5, 299},
        };

        public List<Product> getMockData()
        {
            products = new List<Product>();

            for (int i = 0; i < MockData.GetLength(0); i++)
            {
                products.Add(new Product
                {
                    productId = (int)MockData[i, 0],
                    productName = (string)MockData[i, 1],
                    unitPrice = (int)MockData[i, 2],
                    categoryId = (int)MockData[i, 3],
                    quantityAvailable = (int)MockData[i, 4],
                    primeCost = (int)MockData[i, 5]
                });
            }
            return products;
        }
    }
}
