using CMS.Core;
using CMS.DocumentEngine;
using CMS.Helpers;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Repeater.Components.Widgets.Repeater;
using Repeater.Models;
using Repeater.Repositories;

[assembly: RegisterWidget(RepeaterViewComponent.IDENTIFIER, typeof(RepeaterViewComponent), "Repeater Component", typeof(RepeaterProperties),
    Description = "The Repeater Widget is a flexible tool for automatically organizing lots of content as repeated items in accordions or columns and rows.", IconClass = "icon-arrows-crooked")]

namespace Repeater.Components.Widgets.Repeater
{
    public class RepeaterViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "DancingGoat.HomePage.Repeater";
        private readonly IRepeaterRepository _repeaterRepository;
        private readonly IEventLogService _eventLogService;
        /// <summary>
        /// Create an instance of RepeaterViewComponent
        /// </summary>
        /// <param name="repeaterRepository"></param>
        /// <param name="eventLogService"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public RepeaterViewComponent(IRepeaterRepository repeaterRepository, IEventLogService eventLogService)
        {
            _repeaterRepository = repeaterRepository ?? throw new ArgumentNullException(nameof(repeaterRepository));
            _eventLogService = eventLogService ?? throw new ArgumentNullException(nameof(eventLogService));
        }
        /// <summary>
        /// Create an Instance for InvokeAsync
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<IViewComponentResult> InvokeAsync(RepeaterProperties properties)
        {
            try
            {
                if (properties.PageType != null)
                {
                    int topN = ValidationHelper.GetInteger(properties?.TopN, 10);
                    string? selectedPath = properties?.Path == null ? "" : properties?.Path?.FirstOrDefault()?.NodeAliasPath;
                    RepeaterDto repeater = new()
                    {
                        PageTypeClassName = properties?.PageType,
                        SelectedPath = selectedPath,
                        TopN = topN,
                        OrderBy = properties?.OrderBy,
                        Where = properties?.Where,
                    };
                    List<TreeNode> pagetypesData = await Task.Run(() => _repeaterRepository.GetParticularPageTypeData(repeater));

                    if (properties?.TopN > 0)
                    {
                        return View("~/Views/Shared/Repeater/" + properties.ViewName + ".cshtml", new RepeaterViewModel
                        {
                            ViewName = properties.ViewName,
                            PageTypeClassName = properties.PageType,
                            PageTypeData = pagetypesData,
                            Visible = properties.Visible,
                            Where = properties?.Where,
                            HtmlAfter = properties?.ContentAfter,
                            HtmlBefore = properties?.ContentBefore,
                        });
                    }
                    else
                    {
                        return View("~/Views/Shared/Repeater/_NoDataFound.cshtml", new RepeaterViewModel { PageTypeClassName = properties?.PageType, PageTypeData = pagetypesData, Visible = properties!.Visible });
                    }
                }
            }

            catch (Exception ex)
            {
                _eventLogService.LogException(nameof(RepeaterViewComponent), "InvokeAysnc", ex);
                return await Task.FromResult<IViewComponentResult>(Content(string.Empty));
            }
            return await Task.FromResult<IViewComponentResult>(Content(string.Empty));
        }
    }
}
