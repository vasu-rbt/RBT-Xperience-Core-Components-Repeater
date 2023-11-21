using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
