using CommunityToolkit.Mvvm.ComponentModel;


namespace EmergencyBackpack.Models
{
    public partial class BackpackItem:ObservableObject
    {
        [ObservableProperty]
        public string? title;

        [ObservableProperty]
        public string? category;

        [ObservableProperty]
        public int howMany;

        [ObservableProperty]
        public float pricePerItem;

        [ObservableProperty]
        public bool isPrepared;

        [ObservableProperty]
        public string? priority;
    }
}
