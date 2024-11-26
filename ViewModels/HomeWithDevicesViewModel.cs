namespace EffiSenseRe.ViewModels {
    public class HomeWithDevicesViewModel {
        public string Address { get; set; }
        public int Size { get; set; }
        public int RoomsCount { get; set; }
        public string HeatingType { get; set; }
        public List<DeviceViewModel> Devices { get; set; }
    }
}
