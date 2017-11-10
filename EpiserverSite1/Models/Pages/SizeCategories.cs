using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace EpiserverSite1.Models.Pages
{
    public class SizeCategories : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] {

                new SelectItem()
                {
                    Value = null
                },
                new SelectItem()
                {
                    Text = "Small",
                    Value = "S"
                },

                new SelectItem()
                {
                    Text = "Medium",
                    Value = "M"
                },

                new SelectItem()
                {
                    Text = "Large",
                    Value = "L"
                }
            };
        }
    }
}