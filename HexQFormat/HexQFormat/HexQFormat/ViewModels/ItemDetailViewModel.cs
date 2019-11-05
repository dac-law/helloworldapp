using System;

using HexQFormat.Models;

namespace HexQFormat.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Converter Item { get; set; }
        public ItemDetailViewModel(Converter item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
