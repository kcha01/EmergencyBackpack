using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmergencyBackpack.Models;
using System.Collections.ObjectModel;

namespace EmergencyBackpack.ViewModel
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        private string? newItem;


        [ObservableProperty]
        private string? selectedCategory;

        public ObservableCollection<string> Categories { get; } = new()
        {
            "Żywność",
            "Ubranie",
            "Narzędzie",
            "Komunikacja / Lokalizacja",
            "Inne"
        };


        [ObservableProperty] 
        private string? selectedPriority;

        public ObservableCollection<string> Priority { get; } = new()
        {
            "Niezbędne",
            "Ważne",
            "Mało ważne"
        };

        [ObservableProperty]
        private int count;

        [ObservableProperty]
        private float pricePerItemas;

        public ObservableCollection<BackpackItem> Items { get; } = new();

        [RelayCommand]
        private void AddItem()
        {
            if (string.IsNullOrWhiteSpace(NewItem))
                return;

            if (string.IsNullOrWhiteSpace(SelectedCategory))
                return;

            Items.Add(new BackpackItem
            {
                Title = NewItem,
                Category = SelectedCategory,
                Priority = SelectedPriority,
                HowMany = Count,
                PricePerItem = PricePerItemas,
                IsPrepared = false
            });

            NewItem = string.Empty;
            SelectedCategory = null;
            SelectedPriority = null;
        }

        [RelayCommand]
        private void RemoveItem(BackpackItem item)
        {
            if (item == null)
                return;

            Items.Remove(item);
        }

        [RelayCommand]
        private void TogglePrepared(BackpackItem item)
        {
            if (item == null)
                return;

            item.IsPrepared = !item.IsPrepared;
        }

 
    }
}
