using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpiserverSite1.Models.Pages;

namespace EpiserverSite1.Models.ViewModels
{
    public interface IShoeViewModel<out T> where T : ShoesPage
    {
        T CurrentPage { get; }
    }
}
