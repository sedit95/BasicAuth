using BasicAuth.Models.ItemsModels;
using System.Collections.Generic;
using System.Linq;

namespace BasicAuth.Services
{
    public class ItemService : IItemService
    {
        private List<ItemModel> _items = new List<ItemModel>
        {
            new ItemModel {Id = 1, Code = "0001", Name = "Notebook", Amount = 22, Price = 6300},
            new ItemModel {Id = 2, Code = "0002", Name = "Keyboard", Amount = 15, Price = 230},
            new ItemModel {Id = 3, Code = "0003", Name = "Mouse", Amount = 9, Price = 150},
        };

        public List<ItemModel> GetAll()
        {
            return _items.ToList();
        }

    }
}
