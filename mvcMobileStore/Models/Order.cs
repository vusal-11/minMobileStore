namespace mvcMobileStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string User { get; set; }
        public string ContactPhone { get; set; }

        public int PhoneId { get; set; }

        public Phone Phone { get; set; }
    }
}
