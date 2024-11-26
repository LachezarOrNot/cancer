namespace EffiSenseRe.Models {
    public class Device
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double AnnualEnergyConsumption { get; set; } 
        public string Category { get; set; } 
        public int HomeId { get; set; } 
        public Home Home { get; set; } 
    }


}
