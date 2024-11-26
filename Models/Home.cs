using EffiSenseRe.Models;

namespace EffiSenseRe.Models {
    public class Home {
        public int Id { get; set; } 
        public string Address { get; set; } 
        public int Size { get; set; } 
        public int RoomsCount { get; set; } 
        public string HeatingType { get; set; } 
        public string UserId { get; set; } 
        public ApplicationUser User { get; set; } 
        public ICollection<Device> Devices { get; set; }
    }

}
