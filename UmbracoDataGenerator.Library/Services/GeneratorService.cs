using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoDataGenerator.Library.Services.Interfaces;

namespace UmbracoDataGenerator.Library.Services
{
    public class GeneratorService : IGeneratorService
    {
        private readonly IDocTypeService _docTypeService;
        private readonly INodeService _nodeService;

        public GeneratorService(IDocTypeService docTypeService, INodeService nodeService)
        {
            _docTypeService = docTypeService;
            _nodeService = nodeService;
        }

        public IEnumerable<int> Create(string docType, int count)
        {
            _docTypeService.CreateDocType(docType);

            var targetNode = Constants.UmbracoConstants.RootNodeId;

            var newNodes = _nodeService.CreateNodes(targetNode, docType, count);

            return newNodes;
        }
    }
}
