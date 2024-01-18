using BasicAuth.Models.ItemsModels;
using System.Collections.Generic;

namespace BasicAuth.Services
{
    public interface IItemService
    {
        List<ItemModel> GetAll();
    }
}
