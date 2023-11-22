using CMS;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Repeater.Components.Widgets.Repeater;
using Repeater.Models.FormComponents;

[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget(RepeaterViewComponent.IDENTIFIER, typeof(RepeaterViewComponent), "Repeater Component", typeof(RepeaterProperties),
    Description = "The Repeater Widget is a flexible tool for automatically organizing lots of content as repeated items in accordions or columns and rows.", IconClass = "icon-arrows-crooked")]

[assembly: RegisterFormComponent(RepeaterPageTypeSelectorComponent.IDENTIFIER, typeof(RepeaterPageTypeSelectorComponent), "Drop-down for Page Type Selector ", IconClass = "icon-menu")]