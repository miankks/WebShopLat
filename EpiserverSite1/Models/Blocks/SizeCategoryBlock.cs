using System;
using System.ComponentModel.DataAnnotations;
using EpiserverSite1.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "SizeCategoryBlock", GUID = "e9313243-4919-473b-8b46-3a9fbca068d5", Description = "")]
    public class SizeCategoryBlock : BlockData
    {
        [SelectOne(SelectionFactoryType = typeof(SizeCategories))]
        public virtual string SelectSize { get; set; }
    }
}