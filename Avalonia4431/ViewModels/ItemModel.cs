using System;

namespace Avalonia4431.ViewModels
{
    public class ItemModel
    {
        private readonly Guid ID = Guid.NewGuid();
        public string Name => ID.ToString();
    }
}
