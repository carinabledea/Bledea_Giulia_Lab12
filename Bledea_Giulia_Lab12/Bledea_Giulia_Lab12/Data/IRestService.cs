using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bila_Radu_Lab12Xamarin.Models;

namespace Bila_Radu_Lab12Xamarin.Data
{
    interface IRestService
    {
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    }
}
