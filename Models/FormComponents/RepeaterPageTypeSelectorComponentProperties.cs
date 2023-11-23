using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace Repeater.Models.FormComponents
{
    public class RepeaterPageTypeSelectorComponentProperties :FormComponentProperties<string>
    {
        public RepeaterPageTypeSelectorComponentProperties()
             : base(FieldDataType.Text)
        {
        }
        [DefaultValueEditingComponent("RepeaterPageTypeSelectorProperties", DefaultValue = "")]
        public override string DefaultValue { get; set; }
    }
}
