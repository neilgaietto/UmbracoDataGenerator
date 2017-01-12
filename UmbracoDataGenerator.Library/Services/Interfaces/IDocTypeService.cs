using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoDataGenerator.Library.Services.Interfaces
{
    public interface IDocTypeService
    {
        bool DocTypeExists(string docType);
        void CreateDocType(string docType);
        void DeleteDocType(string docType);
    }
}
