namespace DataAdministrator.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [Column(TypeName = "text")]
        public string address { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }

    //Customer Mock Data : Actually not used in application due to removing login feature 
    public class CutomerMockData
    {
        List<Customer> customers;

        object[,] MockData = new object[,]{
            {"alan@gmail.com", "Alan", "Lee", "1234 Tyndale Pl, Burnaby", "778-123-4567" },
            {"Sidharth@abc.com", "Sidharth", "Kaushal", "330 Guildford, Surrey", "604-777-7777"},
            {"mandeep@douglas.ca", "Mandeep", "Kaur", "700 Royal Ave, New Westminster", "778-333-1111"}
        };

        // Create Customer objects list with mock data and return it to save database
        public List<Customer> getMockData()
        {
            customers = new List<Customer>();

            for (int i = 0; i < MockData.GetLength(0); i++)
            {
                customers.Add(new Customer
                {
                    email = (string)MockData[i, 0],
                    firstName = (string)MockData[i, 1],
                    lastName = (string)MockData[i, 2],
                    address = (string)MockData[i, 3],
                    phone = (string)MockData[i, 4]
                });
            }
            return customers;
        }
    }
}
