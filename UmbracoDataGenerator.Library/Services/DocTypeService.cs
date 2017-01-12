using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Services;
using UmbracoDataGenerator.Library.Services.Interfaces;

namespace UmbracoDataGenerator.Library.Services
{
    public class DocTypeService : IDocTypeService
    {
        private readonly IContentTypeService _contentTypeService;
        public DocTypeService(IContentTypeService contentTypeService)
        {
            _contentTypeService = contentTypeService;
        }

        public void CreateDocType(string docType)
        {
            if (DocTypeExists(docType)) return;
            
            //_contentTypeService.Save()
        }

        public void DeleteDocType(string docType)
        {
            throw new NotImplementedException();
        }

        public bool DocTypeExists(string docType)
        {
            return _contentTypeService.GetAllContentTypeAliases().Contains(docType);
        }
    }
}
