using ReactiveUI;
using System.Collections.Generic;
using System.Diagnostics;

namespace Avalonia4431.ViewModels
{
    public class DGViewModel : ReactiveObject
    {
        private ItemModel _selectedItem;

        public string Name => "DataGrid ViewModel";

        public ItemModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                Debug.WriteLine("DG ViewModel Selected Item Changed: " + value?.Name);
                this.RaiseAndSetIfChanged(ref _selectedItem, value);
            }
        }

        public IEnumerable<ItemModel> Items { get; } = new ItemModel[]
        {
            new ItemModel(),
            new ItemModel(),
            new ItemModel(),
        };
    }
}
