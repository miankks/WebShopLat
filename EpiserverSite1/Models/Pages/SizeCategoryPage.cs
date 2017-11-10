using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "SizeCategoryPage", GUID = "0d0655ad-9325-4571-880d-694c91749e89", Description = "")]
    public class SizeCategoryPage : ISelectionFactory
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