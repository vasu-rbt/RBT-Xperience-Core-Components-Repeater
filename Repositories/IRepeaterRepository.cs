using CMS.DocumentEngine;
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
