using CMS.DocumentEngine;
using Microsoft.AspNetCore.Mvc.Rendering;

using Repeater.Models;

namespace Repeater.Repositories
{
    public interface IRepeaterRepository
    {
        /// <summary>
        /// GetTreeData
        /// </summary>
        /// <param name="selectedPage"></param>
        /// <returns></returns>
        public List<SelectListItem> GetTreeData(string? selectedPage);
        /// <summary>
        /// GetParticularPageTypeData
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public List<TreeNode> GetParticularPageTypeData(RepeaterDto dto);
    }
}
