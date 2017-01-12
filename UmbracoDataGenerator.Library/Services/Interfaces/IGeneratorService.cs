using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoDataGenerator.Library.Services.Interfaces
{
    public interface IGeneratorService
    {
        /// <summary>
        /// Returns generated node Ids
        /// </summary>
        /// <param name="docType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<int> Create(string docType, int count);
    }
}
