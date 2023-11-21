using CMS.DataEngine;
using CMS.DocumentEngine;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeater.Repositories
{
    public class DocumentTypeHelperRepository : IDocumentTypeHelperRepository
    {
        /// <summary>
        /// GetPageTypeClasses
        /// </summary>
        /// <returns></returns>
        public ObjectQuery<DataClassInfo> GetPageTypeClasses()
        {
            return DocumentTypeHelper.GetDocumentTypeClasses();
        }
    }
}
