using ReactiveUI;
using System.Collections.Generic;
using System.Diagnostics;

namespace Avalonia4431.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private object _selectedItem;

        public object SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value is DGViewModel model)
                {
                    Debug.WriteLine("ListBox Item Changed: DG ViewModel's Selected Item: " + model.SelectedItem?.Name);
                }

                this.RaiseAndSetIfChanged(ref _selectedItem, value);
            }
        }

        public IEnumerable<object> Items { get; } = new object[]
        {
            new TestViewModel(),
            new DGViewModel(),
        };
    }
}
