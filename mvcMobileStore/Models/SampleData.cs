using System.Linq;

namespace mvcMobileStore.Models
{
    public static class SampleData
    {

        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 13",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Galaxy S22",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Pixel 6",
                        Company = "Google",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }





    }
}
