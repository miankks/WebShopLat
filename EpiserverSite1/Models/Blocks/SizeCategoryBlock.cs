using System;
using System.ComponentModel.DataAnnotations;
using EpiserverSite1.Models.ViewModels;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "SizeCategoryBlock", GUID = "6b0874e1-5591-4ffa-b224-4f844ee7b566", Description = "", AvailableInEditMode = false)]
    public class SizeCategoryBlock : BlockData
    {
        [SelectOne(SelectionFactoryType = typeof(SizeSelectionFactory))]
        public virtual string Size { get; set; }
    }
}