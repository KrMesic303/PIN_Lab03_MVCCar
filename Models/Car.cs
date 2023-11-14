namespace MVCCar.Models
{
    public class Car
    {
        /// <summary>
        /// Car Model
        /// </summary>
        public int Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int ProductionYear { get; set; }
        public decimal Price { get; set; }

    }
}
