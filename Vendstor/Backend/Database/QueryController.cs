
//Vendstor
namespace Vendstor.Backend.Database.Queries
{
    public static class QueryController
    {
        public static Store Store = new Store();
        public static User User = new User();

        public static PaymentType PaymentType = new PaymentType();

        public static Tax Tax = new Tax();
        public static Blob Blob = new Blob();
        public static Sale Sale = new Sale();

        public static class Products
        {
            // Controllers
            public static Product Product = new Product();
            public static ProductBrand Brand = new ProductBrand();
            public static ProductType Type = new ProductType();
            public static ProductSupplier Supplier = new ProductSupplier();
            public static Discount Discount = new Discount();
        }

        public static class Customers
        {
            public static Customer Customer = new Customer();
            public static CustomerGroup Group = new CustomerGroup();
        }
    }

}
