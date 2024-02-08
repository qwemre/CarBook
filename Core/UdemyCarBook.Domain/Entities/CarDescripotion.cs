namespace UdemyCarBook.Domain.Entities
{
    public class CarDescripotion
    {
        public int CarDescripotionID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
    }
}
