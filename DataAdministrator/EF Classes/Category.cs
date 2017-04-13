namespace DataAdministrator.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryId { get; set; }

        [StringLength(50)]
        public string categoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }

    // Product Category Definition
    public enum ProductCategory
    {
        ALL = 0,
        TV,
        Fridge,
        Washer,
        Audio,
        Phone      
    }

    // Product Category mock data create
    public class CategoryMockData
    {
        List<Category> categories;

        object[,] MockData = new object[,]{
            {ProductCategory.ALL, ProductCategory.ALL.ToString()},
            {ProductCategory.TV, ProductCategory.TV.ToString()},
            {ProductCategory.Fridge, ProductCategory.Fridge.ToString()},
            {ProductCategory.Washer, ProductCategory.Washer.ToString()},
            {ProductCategory.Audio, ProductCategory.Audio.ToString()},
            {ProductCategory.Phone, ProductCategory.Phone.ToString()},
        };

        // Return Categories data list to insert database
        public List<Category> getMockData()
        {
            categories = new List<Category>();

            for (int i = 0; i < MockData.GetLength(0); i++)
            {
                categories.Add(new Category
                {
                    categoryId = (int)MockData[i, 0],
                    categoryName = (string)MockData[i, 1],
                });
            }
            return categories;
        }
    }
}
