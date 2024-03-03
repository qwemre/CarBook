namespace UdmyCarBook.Dto.CarPricingDtos
{
    public class ResulCarPricingWithCarDto
    {
        public int CarPricingID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
