using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;

namespace EpiserverSite1.Models.ViewModels
{
    public class SizeCategoryViewModel : ISelectItem
    {
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }


        public object Value => $"{Medium}-{Large}"; // instead of normal getters and setters

        //public string Text
        //{
        //    get { return Small; } 
        //}

        public string Text => Small;
    }

    public class SizeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new SizeCategoryViewModel[]
            {
                new SizeCategoryViewModel() { Small = "Small"},
                new SizeCategoryViewModel() { Medium = "Medium" },
                new SizeCategoryViewModel() { Large = "Large" },
            };
        }
    }
}