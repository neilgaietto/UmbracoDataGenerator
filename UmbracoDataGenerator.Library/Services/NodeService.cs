using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Services;
using UmbracoDataGenerator.Library.Services.Interfaces;

namespace UmbracoDataGenerator.Library.Services
{
    public class NodeService : INodeService
    {
        private readonly IContentService _contentService;
        public NodeService(IContentService contentService)
        {
            _contentService = contentService;
        }

        public IEnumerable<int> CreateNodes(int parentId, string docType, int count)
        {
            throw new NotImplementedException();
        }

    }
}
