using CMS.DocumentEngine;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Repeater.Components.Widgets.Repeater
{
    public class RepeaterViewModel
    {
        /// <summary>
        /// Title
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Page Types purpose
        /// </summary>
        public List<SelectListItem>? AvailablePageTypes { get; set; }

        /// <summary>
        /// Page type
        /// </summary>
        public string? PageTypeClassName { get; set; }

        /// <summary>
        /// Contains all data related to a particular page type
        /// </summary>
        public List<TreeNode>? PageTypeData { get; set; }

        /// <summary>
        /// Widget is visible or not
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// DataId
        /// </summary>
        public string? DataId { get; set; }

        /// <summary>
        /// NoDataText
        /// </summary>
        public string? NoDataText { get; set; } = "";

        /// <summary>
        /// View Name
        /// </summary>
        public string? ViewName { get; set; }

        /// <summary>
        /// NumLarge
        /// </summary>
        public int NumLarge { get; set; }

        /// <summary>
        /// NumSmall
        /// </summary>
        public int NumSmall { get; set; }

        /// <summary>
        /// NumMedium
        /// </summary>
        public int NumMedium { get; set; }

        public string? Where { get; set; }

        public string? HtmlBefore { get; set; }

        public string? HtmlAfter { get; set; }
    }
}
