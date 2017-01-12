using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoDataGenerator.Library.Services.Interfaces
{
    public interface INodeService
    {
        /// <summary>
        /// Returns generated Node Ids
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="docType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<int> CreateNodes(int parentId, string docType, int count);
    }
}
