﻿using CMS.DataEngine;

namespace Repeater.Repositories
{
    public interface IDocumentTypeHelperRepository
    {
        /// <summary>
        /// GetPageTypeClasses
        /// </summary>
        /// <returns></returns>
        public ObjectQuery<DataClassInfo> GetPageTypeClasses();
    }
}
