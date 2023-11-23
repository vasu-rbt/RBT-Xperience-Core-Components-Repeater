using CMS.DocumentEngine;
using Microsoft.AspNetCore.Mvc.Rendering;

using Repeater.Models;

namespace Repeater.Repositories
{
    public interface IRepeaterRepository
    {        
        /// <summary>
        /// GetParticularPageTypeData
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public List<TreeNode> GetParticularPageTypeData(RepeaterDto dto);
    }
}
