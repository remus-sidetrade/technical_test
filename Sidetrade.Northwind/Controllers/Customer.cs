using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sidetrade.Northwind.Controllers
{
    [Table("Customers", Schema = "dbo")]
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
    }
}
