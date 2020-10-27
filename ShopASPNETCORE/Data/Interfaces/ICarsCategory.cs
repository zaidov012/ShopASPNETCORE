using ShopASPNETCORE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.Data.Interfaces
{
    public interface ICarsCategory
    {
        IList<Category> AllCategories { get; }
    }
}
